using SharedModel.Models.Util;
using SharedModel.Models;

namespace SchoolApiv2.Repository.Contracts
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<TokenDto>> Login(LoginDto loginDto);
        Task<TokenDto> RefreshToken(RefreshTokenRequestDto refreshTokenRequestDto);
        Task<bool> DeleteRefreshTokens(int userId);
    }
}
