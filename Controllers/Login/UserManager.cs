using BLL.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplicationOIFUS.Controllers.Login
{
    public class UserManager
    {
        private IUsuarioBLL usuarioBLL;
        public UserManager(IUsuarioBLL usuarioBLL)
        {
            this.usuarioBLL = usuarioBLL;
        }
        
        public async void SignIn(HttpContext httpContext, ENT.Ent.Usuario user, bool isPersistent = false)
        {

          
            ClaimsIdentity identity = new ClaimsIdentity(this.GetUserClaims(user), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        }

        public async void SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }

        private IEnumerable<Claim> GetUserClaims(ENT.Ent.Usuario user)
        {
            List<Claim> claims = new List<Claim>();

            //claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Usr().ToString()));
            claims.Add(new Claim(ClaimTypes.Name, user.Usr));
            claims.AddRange(this.GetUserRoleClaims(user));
            return claims;
        }

        private IEnumerable<Claim> GetUserRoleClaims(ENT.Ent.Usuario user)
        {
            List<Claim> claims = new List<Claim>();

            //claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id().ToString()));
            claims.Add(new Claim(ClaimTypes.Role, "admin"));
            return claims;
        }
    }
}
