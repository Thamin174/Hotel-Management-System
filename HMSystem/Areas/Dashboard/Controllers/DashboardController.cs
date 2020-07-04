using HMS.Services;
using HMSystem.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpPost]
        public JsonResult UploadPictures()
        {
            JsonResult result = new JsonResult();

            var dashboardService = new DashboardsService();
            var picList = new List<Picture>();

            var files = Request.Files;

            for (int i = 0; i < files.Count; i++)
            {
                var picture = files[i];

                var fileName = Guid.NewGuid() + picture.FileName + Path.GetExtension(picture.FileName);
                var filePath = Server.MapPath("~/images/site/") + fileName;

                picture.SaveAs(filePath);

                var dbPicture = new Picture();
                dbPicture.URL = fileName;

                if(dashboardService.SavePicture(dbPicture))
                {
                    picList.Add(dbPicture);
                }
            }
            result.Data = picList;

            return result;
        }
    }
}