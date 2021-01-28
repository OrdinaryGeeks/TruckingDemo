using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
namespace TruckingDemo.Models
{
    public class DBContext : DbContext
    {



        public DBContext()
        {


            this.Configuration.LazyLoadingEnabled = false;

        }


        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Parcel> Parcel { get; set; }

        public DbSet<Driver> Driver { get; set; }
      //  public DbSet<Destination> Destination {get;set;}
       public DbSet<Location> Location { get; set; }

        public System.Data.Entity.DbSet<TruckingDemo.Models.PickupLocation> PickupLocations { get; set; }
    }
}