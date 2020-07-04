using HMSystem.Entities;
using HMSysytem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
    public class DashboardsService
    {
        public bool SavePicture(Picture picture)
        {
            var context = new HMSContext();

            context.Pictures.Add(picture);
            return context.SaveChanges() >0;


        }
    }
}
