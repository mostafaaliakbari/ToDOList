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
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _userService.Login(username, password);
            if (user != null)
            {
                var routeValues = new { userId = user.Id };
                return RedirectToAction("Index", "Todo", routeValues);
            }
            ViewBag.Error = "نام کاربری یا رمز عبور اشتباه است";
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
