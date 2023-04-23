using AutoMapper;
using DataModel.DB;
using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SchoolApiv2.Repository.RepoExt.EShopRepoExt;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;

namespace SchoolApiv2.Repository.EShopRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly IWebHostEnvironment env;
        private readonly IMapper mapper;
        public ProductRepository(SchoolDBContext context, ILogger<ProductRepository> logger, 
            IWebHostEnvironment env, IMapper _mapper) : base(context, logger)
        {
            this.env = env;
            mapper = _mapper;
        }

        public async Task<Product?> GetProduct(int id)
        {
            try
            {
                var product = await _context.Product
                  .Include(p => p.Category)
                  .Include(p => p.Supplier)
                  .Include(p => p.ProductImages)
                  .FirstOrDefaultAsync(c => c.ID == id);
                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProduct() by id method error", typeof(ProductRepository));
                throw new Exception($"Failed to find subject with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                //var products = await GetAllAsync();
                var products = await _context.Product
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .Include(p => p.ProductImages)
                    .ToListAsync();
                return products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProducts() method error", typeof(ProductRepository));
                throw new Exception($"Failed to find Products  in database " + $": {ex.Message}");

            }
        }

        public async Task<PagedList<Product>> GetProducts(PagingRequestDto pagedRequestDto)
        {
            try
            {
                var products = await _context.Product
                    .SearchProduct(pagedRequestDto)
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .Include(p => p.ProductImages)
                    .ToListAsync();

                return PagedList<Product>
                .ToPagedList(products, pagedRequestDto.PageNumber, pagedRequestDto.PageSize);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProducts() paged method error", typeof(ProductRepository));
                throw new Exception($"GetProdcuts()  menthod() => Failed to fetch product data  in database " + $": {ex.Message}");
            }

        }

        public async Task<Product> CreateProduct(ProductToEditDto productAddDto)
        {
            try
            {
                var savedImages = await SaveImagesToLocalDirectory(productAddDto.ProductImagesToAddDto,
                productAddDto.Code, "Products");

                var product = new Product()
                {
                    Code = productAddDto.Code,
                    Name = productAddDto.Name,
                    Description = productAddDto.Description,
                    Quantity = productAddDto.Quantity,
                    UnitPrice = productAddDto.UnitPrice,
                    CategoryID = productAddDto.CategoryID,
                    SupplierID = productAddDto.SupplierID,
                    ProductUnitID = productAddDto.ProductUnitID,
                    IsOnPromotion = productAddDto.IsOnPromotion,
                    IPAddress = productAddDto.IPAddress,
                    CreatedBy = productAddDto.CreatedBy,
                    UserID= productAddDto.UserID,
                    Rating= productAddDto.Rating,

                };
                if (savedImages != null)
                {
                    product.ProductImages = (from img in savedImages
                                             select new ProductImage
                                             {
                                                 Name = img.Name,
                                                 Description = img.Description,
                                                 Path = img.Path
                                             }).ToList();
                }
                var newProduct = await Add(product);
                return newProduct;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to create product {nameof(ProductToEditDto)} in database " + $": {ex}");
            }
        }

       

        public async Task<Product> UpdateProduct(int id, ProductToEditDto ProductUpdateDto)
        {
            try
            {
                var item = await Get(id);
                if (item != null)
                {
                    var savedImages = await SaveImagesToLocalDirectory(ProductUpdateDto.ProductImagesToAddDto,
                                        item.Code, "Products");

                    //item.Code = ProductUpdateDto.Code;
                    item.Name = ProductUpdateDto.Name;
                    item.Description = ProductUpdateDto.Description;
                    item.Quantity = ProductUpdateDto.Quantity;
                    item.UnitPrice = ProductUpdateDto.UnitPrice;
                    item.CategoryID = ProductUpdateDto.CategoryID;
                    item.SupplierID = ProductUpdateDto.SupplierID;
                    item.ProductUnitID = ProductUpdateDto.ProductUnitID;
                    item.IsOnPromotion = ProductUpdateDto.IsOnPromotion;
                    item.IPAddress = ProductUpdateDto.IPAddress;
                    item.ModifiedDate = ProductUpdateDto.ModifiedDate;

                    item.ProductImages = (from img in savedImages
                                          select new ProductImage
                                          {
                                              Name = img.Name,
                                              Description = img.Description,
                                              Path = img.Path
                                          }).ToList();

                    return await UpdateAsync(item);
                }

                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to update {nameof(ProductToEditDto)} in database " + $": {ex.Message}");
            }
        }
        public async Task<Product?> DeleteProduct(int id)
        {
            try
            {
                var item = await Get(id);
                if (item == null)
                {
                    return default(Product);
                }
                var deletedItem = await DeleteAsync(item);
                if (deletedItem != null)
                {
                    var status = await DeleteImageFolder("Products", deletedItem.Code);
                    return deletedItem;
                }
                else
                {
                    return default(Product);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }

        }
        public async Task<bool> DeleteProducts(List<ProductToEditDto> productToEditDtos)
        {
            try
            {
                var products = mapper.Map<List<Product>>(productToEditDtos);
                var deletedItemsStatus = await DeleteRangeAsync(products);
                if (deletedItemsStatus)
                {
                    productToEditDtos.ForEach(async prod => await DeleteImageFolder("Products", prod.Code));                    
                }
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProducts() method error", typeof(ProductRepository));
                throw new Exception($"Failed to delete {nameof(ProductToEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<List<ProductImageDto>> SaveImagesToLocalDirectory(List<ProductImagesToAddDto> prodImgToAddDto,
           string productCode, string primaryFolderName)
        {
            try
            {
                var prodImagesSaved = new List<ProductImageDto>();
                foreach (var file in prodImgToAddDto)
                {
                    var buf = Convert.FromBase64String(file.base64data);
                    var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", productCode);
                    var pathToSave = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory()
                    System.IO.Directory.CreateDirectory(pathToSave);
                    await System.IO.File.WriteAllBytesAsync(pathToSave + Path.DirectorySeparatorChar
                        + $"{productCode}" + file.fileName, buf);

                    prodImagesSaved.Add(new ProductImageDto
                    {
                        Name = file.fileName,
                        Path = "Static/" + primaryFolderName + "/" + productCode + "/" + $"{productCode}" + file.fileName,
                        Description = "Full path of image" + pathToSave
                    });
                }
                return prodImagesSaved;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> DeleteImageFolder(string primaryFolderName, string productCode)
        {
            try
            {
                var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", productCode);

                var fullPathToDelete = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory() 
                if (Directory.Exists(fullPathToDelete))
                {
                    DirectoryInfo directory = new DirectoryInfo(fullPathToDelete);
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        file.Delete();
                    }
                    Directory.Delete(fullPathToDelete);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
                _logger.LogError(ex, "{Repo} DeleteImageFolder() method error, failed to delete image folder!!", typeof(ProductRepository));
                throw new Exception($"Failed to delete images folder on server. " + $": {ex.Message}");
            }


        }

        public async Task<ServiceResponse<ProductImage>> DeleteProductImage(int id)
        {
            try
            {
                var res = new ServiceResponse<ProductImage>();
                var productImg = await _context.ProductImage.FindAsync(id);
                if (productImg == null)
                {
                    res.StatusCode = 404;
                }
                else
                {
                    _context.ProductImage.Remove(productImg);
                    var delStatus = await _context.SaveChangesAsync();
                    if (delStatus > 0)
                    {
                        var result = await DeleteImageFileOnServer(productImg);
                        if (result == true)
                        {
                            res.StatusCode = 200;
                            res.Data = productImg;
                        }
                        else
                        {
                            res.StatusCode = 500;
                        }
                    }
                    else
                    {
                        res.StatusCode = 500;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProductImage() method error, failed to delete image !!", typeof(ProductRepository));
                throw new Exception($"Failed to delete images from DB. " + $": {ex.Message}");
            }

        }


        private async Task<bool> DeleteImageFileOnServer(ProductImage productImage)
        {
            try
            {
                /*Returns file info, fileName attribute has full path name */
                //FileInfo file = new FileInfo(Path.Combine( env.ContentRootPath ,productImage.Path));

                //This method returns full path of file /
                string baseFolder = "Resource";
                var basePath = Path.GetFullPath(Path.Combine(env.ContentRootPath, baseFolder));
                var absolutePath = Path.Combine(basePath, productImage.Path);

                if (File.Exists(absolutePath))
                {
                    File.Delete(absolutePath);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting file on server : " + ex);
                throw;
            }


        }

        public async Task<IEnumerable<Product>> GetProductByCode(string code)
        {           
            var products = await Find(s => s.Code == code);
            return products;
        }

        public async Task<bool> ItemExist(string code)
        {
            var productExist = _context.Product.FirstOrDefault(s => s.Code == code);
            if (productExist != null) return true;
            return await Task.FromResult(false);
        }

        public async Task<IEnumerable<Product>> ProductByCategory(int CategoryId)
        {
            var products = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Include(p => p.ProductImages)
                .Where(p => p.CategoryID == CategoryId).ToListAsync();

            return products;


        }

        public async Task<IEnumerable<Product>> GetProductByName(string? productName)
        {

            var products = await _context.Product
               .SearchByName(productName)
               .Include(p => p.Category)
               .Include(p => p.Supplier)
               .Include(p => p.ProductImages)
               .ToListAsync();

            return products;

        }


        public async Task<Dictionary<string, object>> ProductInventoryExist(List<CartItem> cartItems)
        {
            var ItemExistStatus = new Dictionary<string, object>();
            var ItemsToPurchase = new List<CartItem>();
            foreach (var item in cartItems)
            {
                //var ItemInventoryQty = await productRepository.GetProduct(item.ProductId);
                var InventoryItem = await GetProduct(item.ProductID);

                if (InventoryItem != null)
                {
                    if (InventoryItem.Quantity < item.Quantity)
                    {
                        ItemExistStatus["ItemExit"] = false;
                        return ItemExistStatus;

                    }
                    ItemsToPurchase.Add(new CartItem
                    {
                        Quantity = item.Quantity,// Qty from customer cart to process.
                        ProductID = InventoryItem.ID,
                        Price = InventoryItem.UnitPrice,
                        Name = InventoryItem.Name,
                        Code = InventoryItem.Code,
                        Description = InventoryItem.Description,
                    });
                }
            }

            ItemExistStatus["ItemExit"] = true;
            ItemExistStatus["Items"] = ItemsToPurchase;
            return ItemExistStatus;
        }
    }
}
