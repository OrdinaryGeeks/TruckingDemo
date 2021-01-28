using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TruckingDemo.Models
{
    public class Driver
    {
        
        public int DriverID { get; set; }

        public virtual ICollection<Cargo> Cargos { get; set; }

        public string DriverName { get; set; }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}