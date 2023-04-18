using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SharedModel.Models;
using SharedModel.Models.eShopModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolApiv2.Controllers.eShop
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository categoryRepository;
        private ILogger<CategoryController> logger;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository _categoryRepository, ILogger<CategoryController> _logger, IMapper _mapper)
        {
            categoryRepository = _categoryRepository;
            logger = _logger;
            mapper = _mapper;
        }

        // GET api/<CategoryController>GetCategory/5
        [HttpGet("GetProduct/{id:int}")]
        public async Task<ActionResult<CategoryDto>> GetItem(int id)
        {
            var httpResponse = new HttpResponseMessage();
            try
            {
                var category = await categoryRepository.GetCategory(id);

                if (category == null)
                {
                    return NotFound();
                }

                var categoryDto = category.ConvertToDto();

                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        // GET: api/<CategoryController/GetCategories>
        [HttpGet("GetCategories")]
        public async Task<ActionResult> Get([FromQuery] PagingRequestDto pagingRequestDto)
        {
            try
            {

                var pagedCategory = await this.categoryRepository.GetCategories(pagingRequestDto);

                if (pagedCategory == null)
                {
                    return NotFound();
                }
                var categoryDtos = pagedCategory.ConvertToDto();

                var pagedResponse = new PagingResponse<CategoryDto>
                {
                    Items = categoryDtos.ToList(),
                    MetaData = pagedCategory.MetaData,
                };
                return Ok(pagedResponse);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // GET: api/<CategoryController/GetAllCategories>
        [HttpGet("GetAllCategories")]
        public async Task<ActionResult> Get()
        {
            try
            {
                var categories = await this.categoryRepository.GetAllCategoriesAsync();
                
                var categoryDtos = categories.ConvertToDto();
               
                return Ok(categories);
            }
            catch (FormatException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);

            }
        }

        // POST: api/CategoryController/Create
        [HttpPost("Create")]
        public async Task<ActionResult<ProductDto>> PostItem([FromBody] CategoryToAddDto categoryToAddDto)
        {
            try
            {
                if (categoryToAddDto == null || !ModelState.IsValid)
                {
                    return BadRequest($"{nameof(ProductToEditDto)} cannot be null or empty !");
                }

                //Check if same item exist in db.
                var category = await categoryRepository.ItemExist(categoryToAddDto.Code);

                if (category)
                {
                    ModelState.AddModelError("Category", $"Category with code {categoryToAddDto.Code} exist in database !");
                    return BadRequest(ModelState);
                }

                if (Request.HttpContext.Connection.RemoteIpAddress?.ToString() != null)
                {
                    categoryToAddDto.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                }

                var newCategory = await categoryRepository.CreateCategory(categoryToAddDto);

                if (newCategory == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve category (categoryId:({newCategory?.ID})");
                }
                var newCategoryDto = newCategory.ConvertToDto();

                return CreatedAtAction(nameof(GetItem), new { id = newCategory.ID }, newCategoryDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
