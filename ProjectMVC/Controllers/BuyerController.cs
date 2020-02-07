using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _context;
        public BuyerController(BuyerContext context)
        {
            this._context = context;

        }
        [HttpGet]
        // GET: Buyer
        public ActionResult BuyerRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuyerRegister(Buyer be)
        {
            return View();
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(Buyer be)
        {

            var loginUser = _context.Buyers.Where(e => e.Bname ==be.Bname && e.Bpassword == be.Bpassword).ToList();
            if (loginUser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }

            else
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}