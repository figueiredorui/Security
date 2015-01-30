using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Security.Identity.Helpers
{
    public static class IdentityHelper
    {
        public static ClaimsIdentity User
        {
            get
            {
                return GetIdentity();
            }
        }

        public static string GetClaim(string claimType)
        {
            var claim = User.Claims.FirstOrDefault(q => q.Type == claimType);

            if (claim != null)
                return claim.Value;
            else
                return null;
        }

        private static ClaimsIdentity GetIdentity()
        {
            var prinicpal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var identity = (ClaimsIdentity)prinicpal.Identity;

            if (identity == null)
                throw new Exception("identity not found");

            if (!identity.IsAuthenticated)
                throw new Exception("identity not Authenticated");

            return identity;
        }
       
    }
}
