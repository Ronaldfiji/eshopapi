using DataModel.DB;
using DataModel.Entity.EntityEShop;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SharedModel.Models.eShopModels;
using SharedModel.Models;
using SchoolApiv2.Repository.RepoExt.EShopRepoExt;
using Microsoft.EntityFrameworkCore;

namespace SchoolApiv2.Repository.EShopRepository
{
    public class CategoryRepository :  GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SchoolDBContext context, ILogger<CategoryRepository> logger) : base(context, logger)
        { }

        public async Task<Category> CreateCategory(CategoryToAddDto categoryDto)
        {

            var category = new Category()
            {
                Code = categoryDto.Code,
                Name = categoryDto.Name,
                Description = categoryDto.Description,
                Icon = categoryDto.Icon,
                IPAddress = categoryDto.IPAddress,

            };

            var newCategory = await Add(category);
            return newCategory;
        }

        public async Task<Category?> GetCategory(int id)
        {
            var category = await Get(id);
            return category;
        }


        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var categories = await GetAllAsync();
            return categories;
        }
        public async Task<PagedList<Category>> GetCategories(PagingRequestDto pagedRequestDto)
        {
            var categories = await _context.Category
                .SearchCategory(pagedRequestDto)
                .ToListAsync();
            return PagedList<Category>
                .ToPagedList(categories, pagedRequestDto.PageNumber, pagedRequestDto.PageSize);

        }

        public async Task<Category> UpdateCategory(int id, CategoryToAddDto categoryAddDto)
        {
            var item = await Get(id);

            if (item != null)
            {
                item.Code = categoryAddDto.Code;
                item.Name = categoryAddDto.Name;
                item.Description = categoryAddDto.Description;
                item.Icon = categoryAddDto.Icon;
                item.ModifiedDate = DateTime.UtcNow.AddHours(12);
                return await UpdateAsync(item);
            }
            return null!;
        }

        public async Task<Category?> DeleteItem(int id)
        {
            var item = await Get(id);

            if (item != null)
            {
                var deletedItem = await DeleteAsync(item);
                return deletedItem;
            }
            return item;
        }

        public async Task<bool> DeleteCategories(IEnumerable<Category> category)
        {
            var categoryListDelete = _context.Category.Where(c => category.Contains(c)).ToList();
            if (categoryListDelete.Any())
            {
                bool deleteStatus = await DeleteRangeAsync(categoryListDelete);
                return deleteStatus;
            }
            return false;//await Task.FromResult( categoryExist.Any());  
        }

        public async Task<bool> ItemExist(string code)
        {
            var categoryExist = await Find(c => c.Code == code);

            if (categoryExist != null && categoryExist.Any())
                return true;
            return false;
        }

    }



}

