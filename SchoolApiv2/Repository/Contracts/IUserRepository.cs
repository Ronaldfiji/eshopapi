using DataModel.Entity;
using SchoolApiv2.Extentions;
using SharedModel.Models;
using SharedModel.Models.Util;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> Get(int id);        
        Task<PagedList<User>> GetAllUsers(PagingRequestDto pagingRequestDto);
        Task<User?> GetUserCourse(int userId);
        Task<User> CreateUser(UserToAddDto userDto);
        Task<User> UpdateUser(int id, UserToEditDto userToEditDto);
        Task<User> UpdateUserAdmin(int id, UserToEditDto userToEditDto);
        Task<User> DeleteUser(int id);
        Task<User?> GetUserByEmail(string email);
        Task<ServiceResponse<User>> AssignRole(User user, List<RoleToAssignDto> rolesToAss);
    }
}
