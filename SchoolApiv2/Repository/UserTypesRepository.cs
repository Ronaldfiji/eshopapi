using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SharedModel.Models;

namespace SchoolApiv2.Repository
{
    public class UserTypesRepository : GenericRepository<UserType>, IUserTypesRepository
    {
        public UserTypesRepository(SchoolDBContext context, ILogger<UserTypesRepository> logger, IWebHostEnvironment _env) : 
            base(context, logger)
        {
          
        }
        public override async Task<UserType> Get(int id)
        {
            try
            {
                var userType = await _context.UserType               
                    .FirstOrDefaultAsync( ut => ut.ID == id);
                return userType!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get user type (id) method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to find user type with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<List<UserType>> GetUserTypes()
        {
            try
            {
                var userTypes = await _context.UserType                                
                                .ToListAsync();

                return userTypes;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetUserTypes() method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to find user types in database " + $": {ex.Message}");
            }
        }

        public async Task<UserType> CreateUserType(UserTypeToEditDto userTypeToEdit)
        {
            try
            {

                var userType = new UserType()
                {
                    Name = userTypeToEdit.Name,
                    Description = userTypeToEdit.Description,
                    IPAddress = userTypeToEdit.IPAddress,
                    CreatedBy = userTypeToEdit.CreatedBy,
                };

                var newUserType = await Add(userType);
                return newUserType;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateUserType() method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to create user types {nameof(UserTypeToEditDto)} in database " + $": {ex.Message}");
            }
        }


        public async Task<UserType> UpdateUserType(int id, UserTypeToEditDto userTypeToEdit)
        {
            try
            {
                var userType = await Get(userTypeToEdit.Id);
                if (userType == null)
                {
                    return null!;
                }
                userType.Name = userTypeToEdit.Name;
                userType.Description = userTypeToEdit.Description;
                userType.IPAddress = userTypeToEdit.IPAddress;
                userType.ModifiedDate = userTypeToEdit.ModifiedDate;
                userType.UpdatedBy = userTypeToEdit.UpdatedBy;
               
                return await UpdateAsync(userType);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserType() method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to update user types {nameof(UserTypeToEditDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<UserType> DeleteUserType(int id)
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
                _logger.LogError(ex, "{Repo} DeleteUserType() method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<UserType> GetUserTypeByName(string name)
        {
            try
            {
                var userType = await _context.UserType
                                .FirstOrDefaultAsync(r => r.Name.ToLower() == name.ToLower());
                return userType!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetUserTypeByName() method error", typeof(UserTypesRepository));
                throw new Exception($"Failed to get user type by name. Review error logs. " + $": {ex.Message}");
            }

        }


    }
}
