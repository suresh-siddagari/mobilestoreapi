using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class MobileDeviceInitializer : System.Data.Entity.DropCreateDatabaseAlways<MobileStoreDbContext>
    {
        protected override void Seed(MobileStoreDbContext context)
        {
            var mobileDevices = new List<MobileDevice>() {
                new MobileDevice {ModelName="Honor 9",Price=4999 },
                new MobileDevice{ModelName="Iphone 8",Price=7999}
            };

            mobileDevices.ForEach(m => context.MobileDevices.Add(m));
            context.SaveChanges();
        }
    }
}