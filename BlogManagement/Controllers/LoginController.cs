using BlogManagement.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogManagement.Controllers
{
    [ApiController]
    [Route("api/authenticate")]
    public class LoginController : Controller
    {

        [HttpGet]
        [Route("userlogin")]
        public ActionResult UserLogin()
        {
          
            var user = new UserDetails().GetUsers().Where(u => u.UserName == "Testing2").SingleOrDefault();

            if (user != null)
            {
                var userClaims = new List<Claim>()
                {
                    new Claim("UserName", user.UserName),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.EmailAddress),
                    new Claim(ClaimTypes.Role, user.Role)
                 };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }

            return Unauthorized();
        }

    }
}
