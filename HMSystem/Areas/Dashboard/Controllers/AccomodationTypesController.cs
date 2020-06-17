using HMS.Services;
using HMSystem.Areas.Dashboard.ViewModels;
using HMSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMSystem.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {
        AccomodationTypesService accomodationTypesService = new AccomodationTypesService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            AccomodationTypesListingModel model = new AccomodationTypesListingModel();

            model.AccomodationTypes = accomodationTypesService.GetAllAccomodationTypes();

            return PartialView("_Listing", model);
        }

        [HttpGet]
        public ActionResult Action(int? ID)
        {
            AccomodationTypesAddOrEditModel model = new AccomodationTypesAddOrEditModel();

            if(ID.HasValue)
            {
                var accomodationType = accomodationTypesService.GetAccomodationTypeByID(ID.Value);

                model.ID = accomodationType.ID;
                model.Name = accomodationType.Name;
                model.Description = accomodationType.Description;
            }

            return PartialView("_AddOrEdit", model);
        }

        [HttpPost]
        public JsonResult Action(AccomodationTypesAddOrEditModel model)
        {
            JsonResult json = new JsonResult();

            var result = false;

            if(model.ID > 0)
            {
                var accomodationType = accomodationTypesService.GetAccomodationTypeByID(model.ID);

                accomodationType.Name = model.Name;
                accomodationType.Description = model.Name;

                result = accomodationTypesService.UpdateAccomodationType(accomodationType);
            }
            else
            {
                AccomodationType accomodationType = new AccomodationType();

                accomodationType.Name = model.Name;
                accomodationType.Description = model.Description;

                result = accomodationTypesService.SaveAccomodationType(accomodationType);
            }

            if (result)
            {
                json.Data = new { Success = true };
            }
            else
            {
                json.Data = new { Success = false, Message = "Unable to perform action on Accomodation Type." };
            }

            return json;
        }

        public ActionResult Delete(int ID)
        {
            AccomodationTypesAddOrEditModel model = new AccomodationTypesAddOrEditModel();

            var accomodationType = accomodationTypesService.GetAccomodationTypeByID(ID);

            model.ID = accomodationType.ID;

            return PartialView("_Delete", model);
        }

        [HttpPost]
        public JsonResult Delete(AccomodationTypesAddOrEditModel model)
        {
            JsonResult json = new JsonResult();

            var result = false;

            var accomodationType = accomodationTypesService.GetAccomodationTypeByID(model.ID);

            result = accomodationTypesService.DeleteAccomodationType(accomodationType);

            if (result)
            {
                json.Data = new { Success = true };
            }
            else
            {
                json.Data = new { Success = false, Message = "Unable to perform action on Accomodation Type." };
            }

            return json;
        }
    }
}