using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class BloodRequestController : Controller
    {
        BloodRequestService bloodRequestService;

        public BloodRequestController(BloodRequestService bloodRequestService)
        {
            this.bloodRequestService = bloodRequestService;
        }
        public IActionResult Index()
        {
            var data = bloodRequestService.Get();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new BloodRequestDTO());
        }
        [HttpPost]
        public IActionResult Create(BloodRequestDTO b)
        {
            if (ModelState.IsValid)
            {
                var res = bloodRequestService.Create(b);

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
            var data = bloodRequestService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(BloodRequestDTO b)
        {
            if (ModelState.IsValid)
            {
                var res = bloodRequestService.Update(b);

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
            var data = bloodRequestService.Get(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(int id, string Decision)
        {
            if (Decision.Equals("Yes"))
            {
                bloodRequestService.Delete(id);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}