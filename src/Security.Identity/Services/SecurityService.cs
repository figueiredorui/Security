using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Security.Identity.Services
{

    public class SecurityService
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public SecurityService()
        {
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return System.Web.HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? (_signInManager = new ApplicationSignInManager(UserManager, AuthenticationManager));
            }
            private set 
            { 
                _signInManager = value; 
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? ( _userManager = new ApplicationUserManager());
            }
            private set
            {
                _userManager = value;
            }
        }


    }
}