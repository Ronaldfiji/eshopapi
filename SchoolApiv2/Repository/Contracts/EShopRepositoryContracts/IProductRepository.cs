using DataModel.Entity.EntityEShop;
using SchoolApiv2.Extentions;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;

namespace SchoolApiv2.Repository.Contracts.EShopRepositoryContracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product?> GetProduct(int id);
        Task<PagedList<Product>> GetProductsOnly(PagingRequestDto pagingRequestDto);
        Task<PagedList<Product>> GetProducts(PagingRequestDto pagedRequestDto);
        Task<Product> CreateProduct(ProductToEditDto productAddDto);
        Task<Product> UpdateProduct(int id, ProductToEditDto ProductUpdateDto);
        Task<Product?> DeleteProduct(int id);
        Task<IEnumerable<Product>> GetProductByCode(string code);
        Task<bool> ItemExist(string code);
        Task<IEnumerable<Product>> ProductByCategory(int CategoryId);
        //Task<bool> ProductInventoryExist(PaymentRequestModel PRModel);
        Task<Dictionary<string, object>> ProductInventoryExist(List<CartItem> cartItems);
        Task<ServiceResponse<ProductImage>> DeleteProductImage(int id);
        Task<IEnumerable<Product>> GetProductByName(string? productName);
        Task<bool> DeleteProducts(List<ProductToEditDto> productToEditDtos);
    }
}
