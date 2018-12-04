using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class MobileDeviceInitializer : System.Data.Entity.CreateDatabaseIfNotExists<MobileStoreDbContext>
    {
        protected override void Seed(MobileStoreDbContext context)
        {
            //Test data 
            var mobileDevices = new List<MobileDevice>() {
                new MobileDevice {ModelName="Samsung Galaxy S9",Price=4999,Description="Super Camera", Image="https://ncp-prod-we-magento.azureedge.net/media/catalog/product/cache/6e09910fea398f365d440ee006ef1bf6/s/9/s9_plus_blue_front_1.png" },
                new MobileDevice{ModelName="Huawei P20 Pro",Price=7999, Description="Charge with another phone !", Image="https://ncp-prod-we-magento.azureedge.net/media/catalog/product/cache/6e09910fea398f365d440ee006ef1bf6/h/u/huawei-p20-blue-front_1_1.png"},
                new MobileDevice {ModelName="Iphone 7", Price=4000, Description="Excited to try finger print !", Image= "https://ncp-prod-we-magento.azureedge.net/media/catalog/product/cache/6e09910fea398f365d440ee006ef1bf6/i/p/iphone_7_black_front.png"}
            };

            mobileDevices.ForEach(m => context.MobileDevices.Add(m));
            context.SaveChanges();
        }
    }
}