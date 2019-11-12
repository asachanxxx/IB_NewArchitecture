using Interblocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterBlock.Api.Service.Controllers
{
    public class ConfigurationsController : Controller
    {
        //
        // GET: /Configurations/
        public ActionResult Index()
        {

            IEnumerable<Interblocks.CProperty> prop = new List<CProperty>();
            var config = SystemConfiguration.GetProperties();
            return View(config);
        }

        //
        // GET: /Configurations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Configurations/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Configurations/Create
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

        //
        // GET: /Configurations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Configurations/Edit/5
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

        //
        // GET: /Configurations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Configurations/Delete/5
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
