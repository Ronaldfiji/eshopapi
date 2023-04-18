namespace SchoolApiv2.Util
{
    public class AppSettings
    {
        public string Environment { get; set; } = string.Empty;
        public string MerchantId { get; set; } = string.Empty;
        public string PrivateKey { get; set; } = string.Empty;
        public string PublicKey { get; set; } = string.Empty;

        public string Secret { get; set; } = string.Empty;

        // refresh token time to live (in days), inactive tokens are
        // automatically deleted from the database after this time
        public int RefreshTokenTTL { get; set; }
        public string AccessTokenExpirationMinutes { get; set; } = string.Empty;
        public string RefreshTokenExpirationMinutes { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
    }
}
