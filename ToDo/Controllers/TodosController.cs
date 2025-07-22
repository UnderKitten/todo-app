using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TodosController : Controller
    {
        public IActionResult Overview()
        {
            Todo todo = new Todo() {Task = "Buy bread"};
            return View(todo);
        }

        // public IActionResult Edit(string id)
        // {
        //     return Content("task = " + id);
        // }
    }
}