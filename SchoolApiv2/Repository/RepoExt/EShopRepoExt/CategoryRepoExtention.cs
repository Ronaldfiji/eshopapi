using DataModel.Entity.EntityEShop;
using SharedModel.Models;

namespace SchoolApiv2.Repository.RepoExt.EShopRepoExt
{
    public static class CategoryRepoExtention    {


        public static IQueryable<Category> SearchCategory(this IQueryable<Category> categories, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return categories;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            switch (columnName)
            {
                case "id":
                    return categories.Where(p => p.ID.ToString().Contains(searchText));
                // break;
                case "code":
                    return categories.Where(p => p.Code.Contains(searchText));
                //  break;
                case "name":
                    return categories.Where(p => p.Name.Contains(searchText));
                //  break;
                case "description":
                    return categories.Where(p => p.Description.Contains(searchText));
                //  break;
                default:
                    Console.WriteLine("Default case");
                    return categories;
                    //break;
            }
        }

    }
}
