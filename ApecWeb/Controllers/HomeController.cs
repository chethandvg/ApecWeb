using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApecWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About our company.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        public ActionResult Aerospace_Parts()
        {
            ViewBag.Message = "Aerospace Components.";

            return View();
        }

        public ActionResult Oil_n_Gas()
        {
            ViewBag.Message = "Oil & Gas.";

            return View();
        }

        public ActionResult Machine_Tools()
        {
            ViewBag.Message = "Machine Tools.";

            return View();
        }

        public ActionResult Semiconductor()
        {
            ViewBag.Message = "Semiconductor.";

            return View();
        }

        public ActionResult Locomotive()
        {
            ViewBag.Message = "Locomotive.";

            return View();
        }

        public ActionResult Medical_Components()
        {
            ViewBag.Message = "Medical Components.";

            return View();
        }

        public ActionResult Opthamology_Equipment_Parts()
        {
            ViewBag.Message = "Medical Components.";

            return View();
        }

        public ActionResult Respiratory_Equipment_Parts()
        {
            ViewBag.Message = "Medical Components.";

            return View();
        }

        public ActionResult Imaging_Machine_Parts()
        {
            ViewBag.Message = "Medical Components.";

            return View();
        }
    }
}