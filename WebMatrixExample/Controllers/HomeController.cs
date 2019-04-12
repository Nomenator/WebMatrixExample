using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace WebMatrixExample.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (!WebSecurity.IsAuthenticated)
            {
                Response.Redirect("~/account/login");
            }
            return View();
        }
    }
}