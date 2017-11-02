using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskWebApp.Controllers
{
    public class ErrorController : System.Web.Mvc.Controller
    {
        // GET: Error
        public System.Web.Mvc.ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View("Error");
        }
    }
}