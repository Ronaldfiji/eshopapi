using DataModel.Entity;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IUserTypesRepository
    {
        Task<UserType> Get(int id);
        Task<List<UserType>> GetUserTypes();
        Task<UserType> CreateUserType(UserTypeToEditDto userTypeToEdit);
        Task<UserType> UpdateUserType(int id, UserTypeToEditDto userTypeToEdit);
        Task<UserType> DeleteUserType(int id);
        Task<UserType> GetUserTypeByName(string name);


    }
}
