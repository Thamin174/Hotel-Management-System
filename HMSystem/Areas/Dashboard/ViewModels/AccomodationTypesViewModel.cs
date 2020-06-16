using HMSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSystem.Areas.Dashboard.ViewModels
{
    public class AccomodationTypesListingModel
    {
        public IEnumerable<AccomodationType> AccomodationTypes { get; set; }
    }

    public class AccomodationTypesAddOrEditModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}