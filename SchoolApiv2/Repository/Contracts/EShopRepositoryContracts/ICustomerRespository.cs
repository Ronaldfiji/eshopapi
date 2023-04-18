using DataModel.Entity.EntityEShop;
using SchoolApiv2.Extentions;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts.EShopRepositoryContracts
{
    public interface ICustomerRespository : IGenericRepository<Customer>
    {
        Task<Customer> Get(int id);
        Task<PagedList<Customer>> GetAllCustomers(PagingRequestDto pagingRequestDto);
        Task<VirtualizeResponse<Customer>> GetAllCustomers(CustomerRequestDto customerRequestDto);
        Task<Customer> CreateCustomer(CustoemrToEditDto custoemrToEditDto);
        Task<Customer> UpdateCustomer(CustoemrToEditDto custoemrToEditDto);
        Task<Customer> DeleteCustomer(int id);
        Task<Customer?> GetCustomerByEmail(string email);


    }
}
