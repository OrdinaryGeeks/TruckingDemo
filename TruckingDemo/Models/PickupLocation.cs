using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckingDemo.Models
{
    public class PickupLocation
    {


        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime ScheduledTime { get; set; }

        public bool isPickUp { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}