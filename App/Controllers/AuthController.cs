using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AuthController : Controller
    {
        UserService userService;

        public AuthController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            var user = userService.Get(Email, Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("Id", user.Id);
                HttpContext.Session.SetString("Name", user.Name);
                HttpContext.Session.SetString("Role", user.Role);

                return RedirectToAction("Dashboard");
            }

            TempData["Msg"] = "Email or Password Invalid";

            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("Name") != null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                ViewBag.Role = HttpContext.Session.GetString("Role");
                ViewBag.Id = HttpContext.Session.GetInt32("Id");

                return View();
            }

            return Unauthorized();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new UserDTO());
        }

        [HttpPost]
        public IActionResult Registration(UserDTO obj)
        {
            if (ModelState.IsValid)
            {
                var res = userService.Create(obj);

                if (res)
                {
                    return RedirectToAction("Login");
                }
            }

            return View(obj);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}