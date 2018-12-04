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
                var mobileDevice= db.MobileDevices.Find(id);
                mobileDevice.Price = GetDiscountPrice(mobileDevice.Price);
                return mobileDevice;
            }
        }

        //Discount is 10% on the price
        // And add 100 SEK as a standard fee
        public double GetDiscountPrice(double price)
        {
            return price * 0.9+100;
        }
    }
}