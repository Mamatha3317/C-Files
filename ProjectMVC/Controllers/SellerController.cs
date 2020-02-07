using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using System;
using System.Linq;

namespace ProjectMVC.Controllers
{
    public class SellerController : Controller
    {
       
            public readonly SellerContext _context;
            public SellerController(SellerContext context)
            {
                this._context = context;
            }
        [HttpGet]
            // GET: Seller
            public ActionResult SellerRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellerRegister(Seller se)
        {
            try
            {
                _context.Add(se);
                _context.SaveChanges();
                ViewBag.message = se.Sname + "has got successfully registered";

                return View();
            }
            catch
            {
                ViewBag.message = se.Sname + "registration Failed";
                return View();
            }
        }
        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SellerLogin()
        {
            return View();
        }
       [HttpPost]
        public ActionResult SellerLogin(Seller se)
        {
            var logUser = _context.Sellers.Where(e => e.Sname == se.Sname && e.Spassword == se.Spassword).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }

            else
            {
                return View();
            }
        }

        // POST: Seller/Create
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

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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