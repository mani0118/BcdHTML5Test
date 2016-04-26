using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controller
{
    public class AccountController : System.Web.Mvc.Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Login()
        {
            int n = 12;


            Math.Sqrt(12);

            Math.Pow(n, 2);

            for (int i = (int)Math.Pow(n, 2); i > 1; i--)
            {

            }

            return View();
        }
    }
}