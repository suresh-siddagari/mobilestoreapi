using MobileStore.DAL;
using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.Services
{
    public class MobileDeviceService
    {

        public List<MobileDevice> GetAllMobileDevices()
        {
            using (var db = new MobileStoreDbContext())
            {
                return db.MobileDevices.ToList();
            }
        }

        public MobileDevice GetMobileDevice(int id)
        {
            using (var db = new MobileStoreDbContext())
            {
                return db.MobileDevices.Find(id);
            }
        }
    }
}