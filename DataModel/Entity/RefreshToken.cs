using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{
    [Table("RefreshToken", Schema = "SchoolApi")]
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public string JwtId { get; set; } = string.Empty;
        public bool IsUsed { get; set; }
        public bool IsRevorked { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CreatedByIp { get; set; } = string.Empty.ToString();
        //[ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
