using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class UserController : Controller
    {
        UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var data = userService.Get();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new UserDTO());
        }
        [HttpPost]
        public IActionResult Create(UserDTO u)
        {
            if (ModelState.IsValid)
            {
                var res = userService.Create(u);
                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(u);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = userService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(UserDTO u)
        {
            if (ModelState.IsValid)
            {
                var res = userService.Update(u);

                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(u);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = userService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int id, string Decision)
        {
            if (Decision.Equals("Yes"))
            {
                userService.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}