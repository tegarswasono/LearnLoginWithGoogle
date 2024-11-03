using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;

namespace LearnLoginWithGoogle.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            var redirectUri = Url.Action("Index", "Home");
            return Challenge(new AuthenticationProperties { RedirectUri = redirectUri }, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
