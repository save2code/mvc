using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TIMS.IMS.Web.UI.Controllers
{
    public class PhysicalController : Controller
    {
         

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        // GET: Physical/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }

        // GET: Physical/View


        // GET: Physical/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult AddNew()
        {
            return View();
        }
        // POST: Physical/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        // GET: Physical/Edit
        public ActionResult Edit()
        {
            return View();
        }

        // GET: Physical/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Physical/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Physical/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Physical/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
