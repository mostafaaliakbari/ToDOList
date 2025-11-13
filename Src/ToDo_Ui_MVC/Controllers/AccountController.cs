using Microsoft.AspNetCore.Mvc;

namespace ToDo_Ui_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService = new UserService();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            _userService.Register(user);
            return RedirectToAction("Login");
        }
    }
}
