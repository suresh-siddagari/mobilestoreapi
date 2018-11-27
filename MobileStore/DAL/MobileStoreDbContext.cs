using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class MobileStoreDbContext : DbContext
    {
        public MobileStoreDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<MobileDevice> MobileDevices { get; set; }
    }
}