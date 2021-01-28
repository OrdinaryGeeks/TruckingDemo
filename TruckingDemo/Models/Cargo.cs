using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruckingDemo.Models
{
    public class Cargo
    {
        
        public int CargoID { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public int CargoTrackingNumber { get; set; }

        public virtual int DriverID { get; set; }

        public virtual ICollection<Parcel> Parcels{ get;  set;}
        public virtual int LocationID { get; set; }
    }
}