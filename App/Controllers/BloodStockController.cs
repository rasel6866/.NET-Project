using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class BloodStockController : Controller
    {
        BloodStockService bloodStockService;

        public BloodStockController(BloodStockService bloodStockService)
        {
            this.bloodStockService = bloodStockService;
        }

        public IActionResult Index()
        {
            var data = bloodStockService.Get();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new BloodStockDTO());
        }

        [HttpPost]
        public IActionResult Create(BloodStockDTO b)
        {
            if (ModelState.IsValid)
            {
                var res = bloodStockService.Create(b);

                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(b);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = bloodStockService.Get(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(BloodStockDTO b)
        {
            if (ModelState.IsValid)
            {
                var res = bloodStockService.Update(b);

                if (res == true)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(b);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = bloodStockService.Get(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id, string Decision)
        {
            if (Decision.Equals("Yes"))
            {
                bloodStockService.Delete(id);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}