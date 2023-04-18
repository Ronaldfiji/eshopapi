using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedModel.Models
{
    public class AuthDto
    {
    }
    public class LoginDto
    {
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Password is required !"), DataType(DataType.Password), MaxLength(30)]
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; } = false;
        [JsonIgnore]
        public string IpAddress { get; set; } = string.Empty.ToString();

    }

    
    public class TokenDto
    {
        public string AccessToken { get; set; } = string.Empty;
        [JsonIgnore]
        public string RefreshToken { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime AccessTokenExpiry { get; set; }
        
    }
    public class RefreshTokenRequestDto
    {
        //public string AccessToken { get; set; } = string.Empty;
       // [Required(ErrorMessage = "Refresh token required !"),  MaxLength(130)]
        public string RefreshToken { get; set; } = string.Empty;
        [JsonIgnore]
        public string IpAddress { get; set; } = string.Empty.ToString();
    }

}
