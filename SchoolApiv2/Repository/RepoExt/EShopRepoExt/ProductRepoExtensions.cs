using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using SharedModel.Models;
using System;

namespace SchoolApiv2.Repository.RepoExt.EShopRepoExt
{
    public static class ProductRepoExtensions
    {
        public static IQueryable<Product> SearchProduct(this IQueryable<Product> products, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return products;
           
            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "code")
            {
                return products.Where(p => p.Code.ToLower().Contains(searchText));
                //products = products.FindAll(p => p.Code.Contains(pagedRequestDto.SearchTerm)).ToList();
            }
            if (columnName == "name")
            {
                return products.Where(p => p.Name.ToLower().Contains(searchText));
            }
            if (columnName == "userid")
            {
                try
                {
                    return products.Where(p => p.UserID == Int32.Parse(searchText));
                }catch(FormatException)
                {
                    throw;// new Exception("Number format exception, failed to pass int value" + ex.Message);
                }
            }
            return products;

        }

        public static IQueryable<Product> SearchByName(this IQueryable<Product> products, string? searchText)
        {
            if (products.Any() && !string.IsNullOrEmpty(searchText))
            {
                string pName = searchText.Trim().ToLower();

                return products.Where(p => p.Name.Contains(pName));
            }
            return products;
        }
    }
}
