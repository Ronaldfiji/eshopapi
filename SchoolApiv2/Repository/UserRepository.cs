using DataModel.DB;
using DataModel.Entity;
using Microsoft.EntityFrameworkCore;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Repository.RepoExt;
using SharedModel.Models;
using SharedModel.Models.Util;
using System.Data;


namespace SchoolApiv2.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IWebHostEnvironment env;
        public UserRepository(SchoolDBContext context, ILogger<UserRepository> logger, IWebHostEnvironment _env) : base(context, logger)
        {
           env = _env;
        }

        public override async Task<User> Get(int id)
        {
            try
            {
                var user = await _context.User
                    .Include(u => u.UserPictures)                   
                    .Include(u => u.UserType)
                    .Include(u => u.UserRoles)
                        .ThenInclude(u => u.Role)                        
                    .Where(u => u.ID == id)
                    .FirstOrDefaultAsync();

                return user!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get user method error", typeof(UserRepository));
                throw new Exception($"Failed to find user with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        
        public async Task<PagedList<User>> GetAllUsers(PagingRequestDto pagingRequestDto)
        {
            try
            {
                var users = await _context.User
                                .Include(u => u.UserPictures)                               
                                .Include(u => u.UserType)
                                .Include(u => u.UserRoles)
                                    .ThenInclude(u => u.Role)
                                 .SearchUser(pagingRequestDto)
                                .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                .Take(pagingRequestDto.PageSize)
                                .ToListAsync();

                int ItemCount = await _context.User.CountAsync();
                return PagedList<User>.ToPagedList(users, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetAllUsers() method error", typeof(UserRepository));
                throw new Exception($"Failed to find user  in database " + $": {ex.Message}");
            }

        }


        public async Task<User?> GetUserCourse(int userId)
        {
            try
            {
                var user = await _context.User
                                .Include(u => u.UserType)
                                .Include(u => u.Enrollments)
                                    .ThenInclude(u =>  u.Course )                                
                                        .ThenInclude(c => c.SchoolYear)
                                .Include(u => u.Enrollments)
                                        .ThenInclude(u => u.School)
                                .FirstOrDefaultAsync(u => u.ID == userId);
                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetUserCourse() method error", typeof(UserRepository));
                throw new Exception($"Failed to find user course data  in database " + $": {ex.Message}");
            }

        }


        public async Task<User> CreateUser(UserToAddDto userToAddDto)
        {
            var savedImages = await SaveImagesToLocalDirectory(userToAddDto.UserPicturesToAddEditDto,
                                  userToAddDto.Phone, "Profile");
            var user = new User()
            {
                FirstName = userToAddDto.FirstName,
                LastName = userToAddDto.LastName,
                DOB = userToAddDto.DOB,
                Email = userToAddDto.Email,
                Phone = userToAddDto.Phone,
                Gender = (DataModel.Entity.Genders)userToAddDto.Gender,
                AddressLine1 = userToAddDto.AddressLine1,
                AddressLine2 = userToAddDto.AddressLine2,
                State = userToAddDto.State,
                PostalCode = userToAddDto.PostalCode,
                City = userToAddDto.City,
                Country = userToAddDto.Country,
                Password = BCrypt.Net.BCrypt.HashPassword(userToAddDto.Password),                
                UserTypeID = userToAddDto.UserTypeId,
                IPAddress= userToAddDto.IPAddress,
                CreatedBy= userToAddDto.CreatedBy,
                
            };
            if (savedImages != null)
            {
                user.UserPictures = (from img in savedImages
                                     select new UserPictures
                                     {
                                         Name = img.Name,
                                         Description = img.Description,
                                         Path = img.Path
                                     }).ToList();
            }
             foreach ( var role in userToAddDto.Roles )
             {
                 user.UserRoles.Add(new UserRole { RoleId= role.Id, CreatedBy = userToAddDto.FirstName,
                     IPAddress=userToAddDto.IPAddress });
             }
            var newUser = await Add(user);
            return newUser;
        }

        public async Task<User> UpdateUser(int id, UserToEditDto userToEditDto)
        {
            try
            {
                var imgsToUpdate = (from ImgDto in userToEditDto.UserPicturesDto
                                    select new UserPicturesToAddEditDto
                                    {
                                        Base64data = ImgDto.Base64data,
                                        ContentType = ImgDto.ContentType,
                                        FileName = ImgDto.FileName,
                                    }).ToList();

                var savedImages = new List<UserPicturesDto>();

                var newPics = userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName?? string.Empty;

                if (!string.IsNullOrEmpty(newPics))
                {
                    savedImages = await SaveImagesToLocalDirectory(imgsToUpdate,userToEditDto.Phone, "Profile");
                }

                var user = await Get(userToEditDto.Id);
                if (user == null)
                {
                    return null!;
                }
                user.FirstName = userToEditDto.FirstName;
                user.LastName = userToEditDto.LastName;
                user.DOB = userToEditDto.DOB;
                user.Gender = (DataModel.Entity.Genders)userToEditDto.Gender;
                user.Phone = userToEditDto.Phone;
                user.AddressLine1= userToEditDto.AddressLine1;
                user.AddressLine2 = userToEditDto.AddressLine2;
                user.City= userToEditDto.City;
                user.State= userToEditDto.State;
                user.PostalCode= userToEditDto.PostalCode;
                user.Country = userToEditDto.Country;
                user.UpdatedBy= userToEditDto.UpdatedBy;
                user.ModifiedDate= userToEditDto.ModifiedDate;   
                user.IPAddress= userToEditDto.IPAddress;
                user.UserTypeID = userToEditDto.UserTypeId;               
               

                if (savedImages != null && savedImages.Count > 0)
                {
                    user.UserPictures.Clear();
                    user.UserPictures = (from img in savedImages select new UserPictures
                                                  {
                                                      Name = img.Name,
                                                      Description = img.Description,
                                                      Path = img.Path
                                                  }).ToList();
                }
                return await UpdateAsync(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserAsync method error",
                  typeof(UserRepository));
                throw new Exception($"Failed to update {nameof(UserToEditDto)} in database " +
                    $": {ex.Message}");
            }
        }

        public async Task<User> UpdateUserAdmin(int id, UserToEditDto userToEditDto)
        {
            try
            {
                var imgsToUpdate = (from ImgDto in userToEditDto.UserPicturesDto
                                    select new UserPicturesToAddEditDto
                                    {
                                        Base64data = ImgDto.Base64data,
                                        ContentType = ImgDto.ContentType,
                                        FileName = ImgDto.FileName,
                                    }).ToList();

                var savedImages = new List<UserPicturesDto>();

                var newPics = userToEditDto.UserPicturesDto?.FirstOrDefault()?.FileName ?? string.Empty;

                if (!string.IsNullOrEmpty(newPics))
                {
                    savedImages = await SaveImagesToLocalDirectory(imgsToUpdate, userToEditDto.Phone, "Profile");
                }

                var user = await Get(userToEditDto.Id);
                if (user == null)
                {
                    return null!;
                }
                user.FirstName = userToEditDto.FirstName;
                user.LastName = userToEditDto.LastName;
                user.DOB = userToEditDto.DOB;
                user.Gender = (DataModel.Entity.Genders)userToEditDto.Gender;
                user.Phone = userToEditDto.Phone;
                user.AddressLine1 = userToEditDto.AddressLine1;
                user.AddressLine2 = userToEditDto.AddressLine2;
                user.City = userToEditDto.City;
                user.State = userToEditDto.State;
                user.PostalCode = userToEditDto.PostalCode;
                user.Country = userToEditDto.Country;
                user.UpdatedBy = userToEditDto.UpdatedBy;
                user.ModifiedDate = userToEditDto.ModifiedDate;
                user.IPAddress = userToEditDto.IPAddress;
                user.UserTypeID = userToEditDto.UserTypeId;
                if (userToEditDto.Roles.Count > 0)
                {
                    user.UserRoles.Clear();
                    foreach (var role in userToEditDto.Roles)
                    {
                        if (role != null && role.Id > 0)
                            user.UserRoles.Add(new UserRole { RoleId = role.Id,
                                CreatedBy = role.CreatedBy,
                                UpdatedBy = role.UpdatedBy,
                                IPAddress = user.IPAddress,
                            });
                    }
                }          

                if (savedImages != null && savedImages.Count > 0)
                {
                    user.UserPictures.Clear();
                    user.UserPictures = (from img in savedImages
                                         select new UserPictures
                                         {
                                             Name = img.Name,
                                             Description = img.Description,
                                             Path = img.Path
                                         }).ToList();
                }
                return await UpdateAsync(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateUserAsync method error",
                  typeof(UserRepository));
                throw new Exception($"Failed to update {nameof(UserToEditDto)} in database " +
                    $": {ex.Message}");
            }
        }

        public async Task<User> DeleteUser(int id)
        {
            var item = await Get(id);
            if (item == null)
            {
                return default(User)!;
            }
            var deletedItem = await DeleteAsync(item);
            if (deletedItem != null)
            {
                var status = await DeleteImageFolder("Profile", deletedItem.Phone);
                return deletedItem;
            }
            else
            {
                return default(User)!;
            }

        }

        private async Task<bool> DeleteImageFolder(string primaryFolderName, string productCode)
        {
            try
            {
                var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", productCode);

                var fullPathToDelete = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory() 
                if (Directory.Exists(fullPathToDelete))
                {
                    DirectoryInfo directory = new DirectoryInfo(fullPathToDelete);
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        file.Delete();
                    }
                    Directory.Delete(fullPathToDelete);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
                _logger.LogError(ex, "{Repo} DeleteImageFolder() method error, failed to delete image folder!!", typeof(UserRepository));
                throw new Exception($"Failed to delete images folder on server. " + $": {ex.Message}");
            }
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            // return await appDbContext.Employees
            //    .FirstOrDefaultAsync(e => e.Email == email);
            try
            {
                var user = await _context.User
                                .Include(u => u.UserPictures)                               
                                .Include(u => u.UserType)
                                .Include(u => u.UserRoles)
                                    .ThenInclude(u => u.Role)
                                .FirstOrDefaultAsync(c => c.Email.ToLower() == email.ToLower());
                return user;
            }
            catch (Exception ex)
            {
               
                _logger.LogError(ex, "{Repo} GetUserByEmail() method error", typeof(UserRepository));
                throw new Exception($"Failed to get user by email address. Review error logs. " + $": {ex.Message}");
            }

        }

        public async Task<ServiceResponse<User>> AssignRole(User user, List<RoleToAssignDto> rolesToAss)
        {
            try
            {
                var res = new ServiceResponse<User>();                
               
                user.UserRoles.Clear();
                foreach (var role in rolesToAss)
                {
                    
                    if (role != null && role.RoleId > 0)
                        user.UserRoles.Add(new UserRole { RoleId = role.RoleId, 
                            CreatedBy= role.CreatedBy,
                            UpdatedBy = role.UpdatedBy,
                            IPAddress = role.IPAddress,
                        });
                }                
                var updated = await UpdateAsync(user);
                if (updated != null)
                {
                    res.Data = updated;
                    res.StatusCode = 200;
                    return res;
                }
                return res; 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} AssignRole() method error", typeof(UserRepository));
                throw new Exception($"Failed to assign role to user. Review error logs. " + $": {ex.Message}");
            }

        }

        public async Task<List<UserPicturesDto>> SaveImagesToLocalDirectory(List<UserPicturesToAddEditDto> appUserImageList,
       string userId, string primaryFolderName)
        {
            if (!appUserImageList.Any() || string.IsNullOrEmpty(appUserImageList?.FirstOrDefault()?.Base64data.ToString()))
            {
                return null!;
            }
            try
            {
                var prodImagesSaved = new List<UserPicturesDto>();
                foreach (var file in appUserImageList)
                {
                    var buf = Convert.FromBase64String(file.Base64data);
                    var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}", userId);
                    var pathToSave = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory()
                    System.IO.Directory.CreateDirectory(pathToSave);
                    await System.IO.File.WriteAllBytesAsync(pathToSave + Path.DirectorySeparatorChar
                        + $"{userId}" + file.FileName, buf);

                    prodImagesSaved.Add(new UserPicturesDto
                    {
                        Name = file.FileName,
                        Path = "Static/" + primaryFolderName + "/" + userId + "/" + $"{userId}" + file.FileName,
                        Description = "Full path of image: " + pathToSave
                    });
                }
                return prodImagesSaved;
            }
            catch (Exception)
            {
                throw;
            }
        }


       


    }
}
