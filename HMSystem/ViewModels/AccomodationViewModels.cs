﻿using HMSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSystem.ViewModels
{
    public class AccomodationViewModel
    {
        public AccomodationType AccomodationType { get; set; }
        public IEnumerable<AccomodationPackage> AccomodationPackages { get; set; }
        public IEnumerable<Accomodation> Accomodations { get; set; }
        public int SelectedAccomodationPackageID { get; set; }
    }
}