using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace JDKB.UI.Models.Helpers
{
    public static class HttpContextHelper
    {
        public static string GetAuthUserId(HttpContext context)
        {
            var clains = context.User.Claims;

            Claim claim = null;

            if (clains.Count() > 0)
            {
                claim = clains.Where(c => c.Type == "id").FirstOrDefault();
            }

            return claim != null ? claim.Value : "";
        }
    }
}
