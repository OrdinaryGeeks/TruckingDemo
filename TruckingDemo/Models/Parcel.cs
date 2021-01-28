using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruckingDemo.Models
{
    public class Parcel
    {

        [Key]
        public int ParcelID { get; set; }
        public int TrackingNumber { get; set;}

        public virtual int CargoID { get; set; }

        public float DestinationLat { get; set; }

        public float DestinationLong { get; set; }
    }
}