using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers.eShop
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private ILogger<ProductController> logger;
        private readonly IMapper mapper;

        public ProductController(IProductRepository _productRepository, ILogger<ProductController> _logger, IMapper _mapper)
        {
            productRepository = _productRepository;
            logger = _logger;
            mapper = _mapper;
        }

        // GET api/<ProductController>GetProduct/5
        [HttpGet("GetProduct/{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var product = await productRepository.GetProduct(id);

                if (product == null)
                {
                    return NotFound();
                }

                var productDto = product.ConvertToDto();

                return Ok(productDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


       
        // GET: api/ProductController/Details/XXXXX
        [HttpGet("GetByCode/{code}")]
        public async Task<ActionResult<ProductDto>> GetItem(string code)
        {
            if (string.IsNullOrEmpty(code) || code.Length > 10)
            {
                return BadRequest($"Invalid input data provided !");
            }
            try
            {
                var products = await this.productRepository.GetProductByCode(code);

                if (products == null)
                {
                    return NotFound();
                }
                var productDTOs = products.ConvertToDto();
                return Ok(productDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/<ProductController/GetProducts>
        [HttpGet("GetProductsAll")]
        public async Task<ActionResult> GetProductsAll()
        {
            try
            {
                var pagedProduct = await this.productRepository.GetProducts();

                if (pagedProduct == null)
                {
                    return NotFound();
                }
                var productsDtos = pagedProduct.ConvertToDto();
               
                return Ok(productsDtos);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("LINQ query parameter expression"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // GET: api/<ProductController/GetProducts>
        [HttpGet("GetProducts")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {
               
                var pagedProduct = await this.productRepository.GetProducts(pagingRequestDto);

                if (pagedProduct == null)
                {
                    return NotFound();
                }
                var productsDtos = pagedProduct.ConvertToDto();

                var pagedResponse = new PagingResponse<ProductDto>
                {
                    Items = productsDtos.ToList(),
                    MetaData = pagedProduct.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex.Message);
            }            
            catch (Exception ex)
            {
                if (ex.Message.Contains("LINQ query parameter expression"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }


        // POST: api/ProductController/Create

        [HttpPost("Create")]
        public async Task<ActionResult<ProductDto>> PostItem([FromBody] ProductToEditDto productAddDto)
        {
            try
            {
                if (productAddDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(ProductToEditDto)} cannot be null or empty !");
                }
               
                //Check if same item exist in db.
                var product = await productRepository.GetProductByCode(productAddDto.Code);             

                if (product != null && product.Any())
                {
                    ModelState.AddModelError("Product", $"Product with code {productAddDto.Code} exist in database !");
                    return BadRequest(ModelState);
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    productAddDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newProduct = await this.productRepository.CreateProduct(productAddDto);

                if (newProduct == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve product (productId:({newProduct?.ID})");
                }
                var newProductDto = newProduct.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newProduct.ID }, newProductDto);
            }
            catch (DbUpdateException ex)
            {
                return BadRequest(ex.Message);
            }            
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY constraint"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        
        //PATCH: api/ProductController/UpdateProduct{int id, ProductToEditDto}           
        [HttpPatch("Update/{id:int}")]
        public async Task<ActionResult<ProductDto>> UpdateProduct(int id, ProductToEditDto productUpdateDto)
        {
            try
            {
                if (productUpdateDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(AssessmentToEditDto)} cannot be null or empty !");
                }

                if (id != productUpdateDto.Id)
                {
                    return BadRequest();
                }
                bool itemsExist = await this.productRepository.ItemExist(productUpdateDto.Code);
                if (!itemsExist)
                {
                    return NotFound($"Item does not exist with id : {productUpdateDto.Code}");
                }              
                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    productUpdateDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }
                productUpdateDto.ModifiedDate = DateTime.UtcNow.AddHours(12);

                var updatedProduct = await this.productRepository.UpdateProduct(id, productUpdateDto);
                if (updatedProduct == null)
                {
                    return NotFound(updatedProduct);
                }
                try
                {
                    var product = await productRepository.GetProduct(updatedProduct.ID);
                    var productDto = product?.ConvertToDto();
                    return Ok(productDto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // Delete: api/ProductController/Delete/5
        [HttpDelete("Delete/{id:int}")]
        public async Task<ActionResult<ProductDto>> DeleteItem(int id)
        {
            try
            {
                var deletedItem = await productRepository.DeleteProduct(id);

                if (deletedItem == null)
                {
                    return NotFound();
                }
                //var deletedItemDto = deletedItem.ConvertToDto();
                var productDto = mapper.Map<ProductDto>(deletedItem);
                return Ok(productDto); // or ' return NoContent();'

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Post: api/ProductController/Delete/List<Product>
        [HttpPost("DeleteItems")]
        public async Task<ActionResult> DeleteProducts([FromBody] IEnumerable<ProductToEditDto> productToEditDtos)
        {
            try
            {

                if (productToEditDtos == null || !productToEditDtos.Any() || !ModelState.IsValid)
                {
                    return BadRequest($"Entity to delete {nameof(ProductToEditDto)} cannot be null or empty !");
                }

                var deleteProducts = await productRepository.DeleteProducts(productToEditDtos.ToList());

                if (deleteProducts == false)
                {
                    return NotFound();
                }

                return Ok(new { message = "Records deleted success", StatusCode = 200, Status = deleteProducts });
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("modified or deleted"))
                {
                    return BadRequest(ex.Message);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // Delete: api/ProductController/DeleteImage/1
        [HttpDelete("DeleteImage/{id:int}")]
        public async Task<ActionResult> DeleteImage(int id)
        {
            try
            {
                var deleteStatus = await productRepository.DeleteProductImage(id);
                if (deleteStatus.StatusCode == 404)
                {
                    return NotFound();
                }
                if (deleteStatus.StatusCode == 200)
                {
                    var deletedProductImg = mapper.Map<ProductImageDto>(deleteStatus.Data);
                    var dataObj = new ServiceResponse<ProductImageDto>
                    {
                        Data = deletedProductImg,
                        Message = "Deleted successfully !",
                        StatusCode = 200,
                    };
                    return Ok(dataObj);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to delete item. Review error logs");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/ProductController/ProductByCategory/5
        [HttpGet("ProductByCategory/{id:int}")]
        public async Task<ActionResult> GetProductByCategory(int id)
        {
            try
            {
                var productCategory = await this.productRepository.ProductByCategory(id);
                if (productCategory == null)
                {
                    return NotFound();
                }

                var productByCategoryDto = productCategory.ConvertToDto();

                return Ok(productByCategoryDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}


//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);