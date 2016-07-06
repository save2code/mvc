using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TIMS.IMS.Web.UI.Controllers
{
    public class vLanController : Controller
    {
        // GET: vLan
        public ActionResult Search()
        {
            return View();
        }

        // GET: vLan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: vLan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vLan/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: vLan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: vLan/Edit/5
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

        // GET: vLan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: vLan/Delete/5
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
