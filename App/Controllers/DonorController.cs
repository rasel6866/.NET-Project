using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class DonorController : Controller
    {
        DonorService donorService;
        public DonorController(DonorService donorService)
        {
            this.donorService = donorService;
        }
        public IActionResult Index()
        {
            var data = donorService.Get();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new DonorDTO());
        }
        [HttpPost]
        public IActionResult Create(DonorDTO d)
        {
            if (ModelState.IsValid)
            {
                var res = donorService.Create(d);
                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(d);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = donorService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(DonorDTO d)
        {
            if (ModelState.IsValid)
            {
                var res = donorService.Update(d);
                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(d);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = donorService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int id, string Decision)
        {
            if (Decision.Equals("Yes"))
            {
                donorService.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}