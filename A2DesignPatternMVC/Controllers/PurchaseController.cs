using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A2DesignPatternMVC.Controllers
{
    public class PurchaseController : Controller
    {
        // GET: Purchase
        public ActionResult Purchase()
        {
            return View();
        }

        public ActionResult GetInviceIn()
        {
            return PartialView("Invoces_In");
        }

        public ActionResult GetPartners()
        {
            return PartialView("Partners");
        }
    }
}