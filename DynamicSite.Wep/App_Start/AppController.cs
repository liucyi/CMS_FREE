using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicSite.Wep.App_Start
{
    public class AppController : Controller
    {

        public static string SetMyTempalte()
        {
            return "~/Views/theme/default/_Layout.cshtml";            
        }

    }
}