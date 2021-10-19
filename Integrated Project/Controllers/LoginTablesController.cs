using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Integrated_Project.Models;
using System.Globalization;
using Integrated_Project.Data_Access;

namespace Integrated_Project.Controllers
{
    public class LoginTablesController : Controller
    {

        // GET: LoginTables
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Email)
        {
            bool bob = CRUD.User.Status(Email);
            if (bob)
            {
                
            }
            return View();
        }
    }
}
