using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controller
{
    public class TestController : System.Web.Mvc.Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecondView()
        {
            return View();
        }

        public ActionResult Hotel()
        {
            return View();
        }
    }
}