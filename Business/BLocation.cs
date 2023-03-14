using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BLocation
    { 
        public List<LocationEntity> LocationList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Locations.ToList();
            }
        }

        public void CreateLocation(LocationEntity oLocation)
        {
            using (var db = new RestoAppContext())
            {
                db.Locations.Add(oLocation);
                db.SaveChanges();
            }
        }

        public void UpdateLocation(LocationEntity oLocation)
        {
            using (var db = new RestoAppContext())
            {
                db.Locations.Update(oLocation);
                db.SaveChanges();
            }
        }
    }
}
