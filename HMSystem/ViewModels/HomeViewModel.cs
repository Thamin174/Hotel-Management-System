using HMSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMSystem.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AccomodationType> AccomodationTypes { get; set; }
    }
}