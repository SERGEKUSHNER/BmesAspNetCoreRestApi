namespace BmesAspNetCoreRestApi.Infrastructure
{
    public class AuthSettings
    {
        public string Key { get; set; }
        public int ExpirationInMinutes { get; set; }
    }
}