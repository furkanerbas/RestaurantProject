using System;

namespace RestaurantAutomation.Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
