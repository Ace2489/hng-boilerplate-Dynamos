namespace HNG_stage3.DTOs
{
    public class SetCookieConsentDto
    {
        public bool NecessaryCookies { get; set; }
        public bool FunctionalityCookies { get; set; }
        public bool AnalyticsCookies { get; set; }
        public bool AdvertisingCookies { get; set; }
    }

    public class CookieConsentDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool NecessaryCookies { get; set; }
        public bool FunctionalityCookies { get; set; }
        public bool AnalyticsCookies { get; set; }
        public bool AdvertisingCookies { get; set; }
        public DateTime ConsentedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}