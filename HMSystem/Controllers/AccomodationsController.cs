using HMS.Services;
using HMSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMSystem.Controllers
{
    public class AccomodationsController : Controller
    {
        AccomodationsService accomodationsService = new AccomodationsService();
        AccomodationPackagesService accomodationPackagesService = new AccomodationPackagesService();
        AccomodationTypesService accomodationTypesService = new AccomodationTypesService();
        // GET: Accomodations
        public ActionResult Index(int accomodationTypeID, int? accomodationPackageID)
        {
            AccomodationViewModel models = new AccomodationViewModel();

            models.AccomodationType = accomodationTypesService.GetAccomodationTypeByID(accomodationTypeID);
            models.AccomodationPackages = accomodationPackagesService.GetAllAccomodationPackagesByAccomodationType(accomodationTypeID);
            models.SelectedAccomodationPackageID = accomodationPackageID.HasValue ? accomodationPackageID.Value : models.AccomodationPackages.First().ID;
            models.Accomodations = accomodationsService.GetAllAccomodationsByAccomodationPackage(models.SelectedAccomodationPackageID);
            return View(models);
        }
    }
}