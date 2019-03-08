using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService(); 

        // GET: User
        public ActionResult Index()
        {
            var list= userService.GetUserList();
            return View();
        }
    }
}