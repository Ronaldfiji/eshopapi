using DataModel.DB;
using DataModel.Entity;
using DataModel.Entity.EntityEShop;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.Contracts.EShopRepositoryContracts;
using SharedModel.Models;
using SharedModel.Models.eShopModels;
using SharedModel.Models.Util;

namespace SchoolApiv2.Repository.EShopRepository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRespository
    {
        public CustomerRepository(SchoolDBContext context, ILogger<CustomerRepository> logger) : base(context, logger)
        { }

        public override async Task<Customer> Get(int id)
        {
            try
            {
                var customer = await _context.Customer                                      
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(s => s.ID == id);

                return customer!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(CustomerRepository));
                throw new Exception($"Failed to find customer with {nameof(id)} in database " + $": {ex.Message}");
            }
        }



        public async Task<PagedList<Customer>> GetAllCustomers(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var customers = await _context.Customer                                   
                                    .AsNoTracking()
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .ToListAsync();


                int ItemCount = await _context.Customer.CountAsync();
                return PagedList<Customer>.ToPagedList(customers, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllCustomers() method error", typeof(CustomerRepository));
                throw new Exception($"GetAllCustomrs menthod() => Failed to fetch customers data  in database " + $": {ex.Message}");
            }
        }

        public async Task<VirtualizeResponse<Customer>> GetAllCustomers(CustomerRequestDto customerRequestDto)
        {
            var totalSize = await _context.Customer.CountAsync();

            var items = await _context.Customer
               //.OrderBy(p => p.ID)
               .Skip(customerRequestDto.StartIndex)
               .Take(customerRequestDto.PageSize)
               .ToListAsync();

            return new VirtualizeResponse<Customer> { Items = items, TotalSize = totalSize };
        }

        public async Task<Customer> CreateCustomer(CustoemrToEditDto custoemrToEditDto)
        {
            try
            {
                var customer = new Customer()
                {
                    FirstName = custoemrToEditDto.FirstName,
                    LastName = custoemrToEditDto.LastName,
                    Email = custoemrToEditDto.Email,
                    Phone = custoemrToEditDto.Phone,
                    AddressLine1 = custoemrToEditDto.AddressLine1,
                    AddressLine2 = custoemrToEditDto.AddressLine2,
                    State = custoemrToEditDto.State,
                    PostalCode = custoemrToEditDto.PostalCode,
                    City = custoemrToEditDto.City,
                    Country = custoemrToEditDto.Country,
                    PictureUrl = custoemrToEditDto.PictureUrl,
                    Password = BCrypt.Net.BCrypt.HashPassword(custoemrToEditDto.Password),
                    CreatedBy = custoemrToEditDto.CreatedBy,
                    IPAddress = custoemrToEditDto.IPAddress,

                };

                var newCustomer = await Add(customer);              
                return newCustomer;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateCustomer() method error", typeof(CustomerRepository));
                throw new Exception($"Failed to create customer {nameof(CustoemrToEditDto)} in database " + $": {ex}");
            }
        }


      


        public async Task<Customer> UpdateCustomer(CustoemrToEditDto custoemrToEditDto)
        {
            try
            {
                var item = await Get(custoemrToEditDto.Id);
                if (item == null)
                {
                    return null!;
                }

                item.FirstName = custoemrToEditDto.FirstName;
                item.LastName = custoemrToEditDto.LastName;
                //item.Email = customerDto.Email; 
                item.Phone = custoemrToEditDto.Phone;
                item.AddressLine1 = custoemrToEditDto.AddressLine1;
                item.AddressLine2 = custoemrToEditDto.AddressLine2;
                item.State = custoemrToEditDto.State;
                item.PostalCode = custoemrToEditDto.PostalCode;
                item.City = custoemrToEditDto.City;
                item.Country = custoemrToEditDto.Country;
                item.PictureUrl = custoemrToEditDto.PictureUrl;   
                item.UpdatedBy = custoemrToEditDto?.UpdatedBy;
                item.ModifiedDate= custoemrToEditDto?.ModifiedDate;

                return await UpdateAsync(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateCustomer() method error", typeof(CustomerRepository));
                throw new Exception($"Failed to update {nameof(CustoemrToEditDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<Customer> DeleteCustomer(int id)
        {
            try
            {
                var item = await Get(id);

                if (item != null)
                {
                    var deletedItem = await DeleteAsync(item);
                    return deletedItem;
                }
                return item!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteCustomer() method error", typeof(CustomerRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<Customer?> GetCustomerByEmail(string email)
        {
            // return await appDbContext.Employees
            //    .FirstOrDefaultAsync(e => e.Email == email);
            var customer = await _context.Customer.FirstOrDefaultAsync(c => c.Email == email);
            return customer;

        }

    }
}
