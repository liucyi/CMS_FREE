using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicSite.Wep.Controllers
{
    public class HomeController : App_Start.AppController
    {
        public ActionResult Index()
        {
            return View();
        }

   
    }
}