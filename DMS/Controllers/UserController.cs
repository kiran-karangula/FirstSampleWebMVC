using DMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserInfo()
        {
            User user = new User()
            {
                UserId = 1001,
                UserName = "Khaja Moiz",
                DepartmentName = "Manufacturing"
            };
            return View(user);
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}