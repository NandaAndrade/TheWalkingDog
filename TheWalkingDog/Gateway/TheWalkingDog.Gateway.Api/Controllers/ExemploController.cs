using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWalkingDog.Gateway.Api.Controllers
{
    public class ExemploController : Controller
    {
        // GET: ExemploController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExemploController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExemploController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExemploController/Create
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

        // GET: ExemploController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExemploController/Edit/5
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

        // GET: ExemploController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExemploController/Delete/5
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
