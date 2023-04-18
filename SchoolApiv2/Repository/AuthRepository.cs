using DataModel.DB;
using DataModel.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SchoolApiv2.Extentions;
using SchoolApiv2.Repository.Contracts;
using SchoolApiv2.Util;
using SharedModel.Models;
using SharedModel.Models.Util;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SchoolApiv2.Repository
{
    public class AuthRepository : GenericRepository<User>, IAuthRepository
    {
        
        private readonly IUserRepository userRepository;
        private readonly AuthServices authService;
        private readonly IWebHostEnvironment env;
        private readonly AppSettings appSettings;

        public AuthRepository(SchoolDBContext context,IUserRepository _userRepository,
            ILogger<AuthRepository> logger, AuthServices _authService,
            IOptions<AppSettings> _appSettings,  IWebHostEnvironment _env) : base(context, logger)
        {
            userRepository = _userRepository;
            authService = _authService;
            appSettings = _appSettings.Value;
            env = _env;
        }

        public async Task<ServiceResponse<TokenDto>> Login(LoginDto loginDto)
        {
            var serviceRes = new ServiceResponse<TokenDto>();

            try
            {
                var user = await userRepository.GetUserByEmail(loginDto.Email);

                if(user == null || ! BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password) )
                {
                    serviceRes.StatusCode = 404;
                    return serviceRes;
                }
                var token = await authService.GenerateAccesssTokenService(user, loginDto.IpAddress);
               
                return new ServiceResponse<TokenDto>
                {
                    Data = token,
                    Message= "Login success !",
                     StatusCode= 200,                    
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Login() method error, failed to login user !!", typeof(AuthRepository));
                throw new Exception($"Failed to login user into the system. " + $": {ex.Message}");
            }
        }

        public async Task<TokenDto> RefreshToken(RefreshTokenRequestDto refreshTokenRequestDto)
        {
            try
            {
                var refreshedToken = await authService.RefreshedTokensService(refreshTokenRequestDto);
                return refreshedToken;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} RefreshToken() method error", typeof(AuthRepository));
                throw new Exception($"Failed to refresh jwt/refresh token " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteRefreshTokens(int userId)
        {
            try
            {
                bool IsSuccess = await authService.DeleteAllRefreshTokenService(userId);
                return IsSuccess;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteRefreshTokens method error, failed to delete tokens !!", typeof(AuthRepository));
                throw new Exception($"Failed to delete tokens in database for: {userId}. " + $": {ex.Message}");
            }
        }

    }
}


//var model = JsonSerializer.Serialize(newUser, new JsonSerializerOptions
//{
//    WriteIndented = true,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles
//});
//Console.WriteLine("New Roles are: " + model);