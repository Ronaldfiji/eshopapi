using DataModel.Entity.EntityEShop;
using SchoolApiv2.Extentions;
using SharedModel.Models;
using SharedModel.Models.eShopModels;

namespace SchoolApiv2.Repository.Contracts.EShopRepositoryContracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> CreateCategory(CategoryToAddDto categoryDto);
        Task<Category?> GetCategory(int id);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<PagedList<Category>> GetCategories(PagingRequestDto pagedRequestDto);
        Task<Category> UpdateCategory(int id, CategoryToAddDto categoryAddDto);
        Task<Category?> DeleteItem(int id);
        Task<bool> DeleteCategories(IEnumerable<Category> category);
        Task<bool> ItemExist(string code);
    }
}
