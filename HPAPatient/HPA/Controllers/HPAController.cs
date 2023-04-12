using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPA.Models;
using System.Data.OleDb;
using System.Data;
using HPA.Utility;

namespace HPA.Controllers
{
    public class HPAController : Controller
    {
        // GET: HPAController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HPAController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HPAController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HPAController/Create
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

        // GET: HPAController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HPAController/Edit/5
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

        // GET: HPAController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HPAController/Delete/5
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

        public ActionResult HPACreate()
        {            
            TempData["check"] = "start";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HPACreate(EmpHP emphp)
        {
            
            if (ModelState.IsValid)
            {
                string checkid = emphp.emp_specialid;
                ADONET adonet = new ADONET();
                DataTable dt = new DataTable();
                DateTime dtnow = DateTime.Now;
                dt = adonet.Select(checkid);
                if(dt.Rows.Count == 1)
                {
                    string employeeno = dt.Rows[0][0].ToString();
                    string idno = dt.Rows[0][1].ToString();
                    string birthdate = dt.Rows[0][2].ToString();
                    string birthyear = birthdate.Substring(0, 3);
                    string thisyear = DateTime.Now.ToString("yyyy");
                    string systemtime = dtnow.ToString("yyyyMMddHHmmss");

                    int intbirthyear = Convert.ToInt32(birthyear);
                    int intyear = Convert.ToInt32(thisyear);
                    int intchineseyear = intyear - 1911;
                    int intage = intchineseyear - intbirthyear;
                    string stringage = Convert.ToString(intage);
                    TempData["check"] = "select";
                    TempData["idno"] = idno;
                    TempData["birthdate"] = birthdate;
                    TempData["intage"] = intage;
                    TempData["employeeno"] = employeeno;

                    adonet.Insert(idno, birthdate, stringage, employeeno, emphp, systemtime);

                    return RedirectToAction("Index", "Home");
                }
                if(dt.Rows.Count == 0)
                {
                    TempData["check"] = "null";
                    return View();
                }
            }
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
