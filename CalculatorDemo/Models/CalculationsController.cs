using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorDemo.Models
{
    public class CalculationsController : Controller
    {
        // GET: CalculationsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
