using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobileStore.Models
{
    public class MobileDevice
    {

        [Key]
        public int Id { get; set; }
        public string ModelName { get; set; }
        public Double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

    }
}