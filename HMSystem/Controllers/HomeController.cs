using HMS.Services;
using HMSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();

            AccomodationTypesService service = new AccomodationTypesService();

            model.AccomodationTypes = service.GetAllAccomodationTypes();

            return View(model);
        }
    }
}