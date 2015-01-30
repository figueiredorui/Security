using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Security.Identity.Models;

namespace Security.Identity.Contexts
{
    class SecurityContext : IdentityDbContext<ApplicationUser>
    {
        public SecurityContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
    }
}