using CITB517_WebApplication.Data.Models;
using CITB517_WebApplication.Models;
using CITB517_WebApplication.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CITB517_WebApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IUserService userService;

        public UserController(UserManager<User> userManager,
                                 SignInManager<User> signInManager, IUserService userService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("UserName,Email,Password")] Register model)
        {

            if (!ModelState.IsValid) {
                return RedirectToAction("Register", "Home");
            }

            var user = await this.userManager.FindByEmailAsync(model.Email);
            if (user != null) {
                return RedirectToAction("Register", "Home");
            }

            await this.userService.Create(model);

            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (!ModelState.IsValid) {
                return View();
            }

            var user = await this.userManager.FindByEmailAsync(model.Email);
            if (user == null) {
                return RedirectToAction("Login", "Home");
            }

            var logInResult = await this.signInManager.PasswordSignInAsync(user, model.Password, false, false);
            if (!logInResult.Succeeded) {
                return RedirectToAction("Login", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();

            return RedirectToAction("Login", "Home");
        }

    }
}
