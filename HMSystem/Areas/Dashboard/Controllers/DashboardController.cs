﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMSystem.Areas.Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard/Dashboard
        //[Authorize(Roles ="Administrator")]
        public ActionResult Index()
        {
            return View();
        }
    }
}