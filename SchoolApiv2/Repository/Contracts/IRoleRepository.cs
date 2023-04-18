using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IRoleRepository
    {
        Task<Role> Get(int id);
        Task<PagedList<Role>> GetAllRoles(PagingRequestDto pagingRequestDto);
        Task<List<Role>> GetAll();
        Task<Role> CreateRole(RoleToAddEditDto roleToAdd);
        Task<Role> UpdateRole(int id, RoleToAddEditDto roleToAddEdit);
        Task<Role> DeleteRole(int id);
        Task<Role> GetRoleByName(string name);
    }
}
