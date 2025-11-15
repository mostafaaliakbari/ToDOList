using Microsoft.AspNetCore.Mvc;

namespace ToDo_Ui_MVC.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;
      
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        public IActionResult Index(int userId)
        {
            var todos = _todoService.GetUserTodos(userId);
            ViewBag.UserId = userId;
            return View(todos);
        }

        [HttpPost]
        public IActionResult Delete(int id,int userId)
        {
            _todoService.DeleteTodo(id);
            return RedirectToAction("Index", new { userId = userId });
        }

        [HttpPost]
        public IActionResult ToggleComplete(int id, int userId)
        {
            _todoService.ToggleComplete(id);
            return RedirectToAction("Index", new { userId = userId });
        }

        [HttpGet]
        public IActionResult Create(int userId)
        {
            ViewBag.Categories = _todoService.GetCategories();
            ViewBag.UserId = userId; 
            return View();
        }
        [HttpPost]
        public IActionResult Create(TodoItem todo, int userId)
        {
            todo.UserId = userId;

            _todoService.CreateTodo(todo);
            return RedirectToAction("Index", new { userId = userId });
        }
      
    }
}
