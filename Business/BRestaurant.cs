using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BRestaurant
    {
        public List<RestaurantEntity> RestaurantList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Restaurants.ToList();
            }
        }

        public void CreateRestaurant(RestaurantEntity oRestaurant)
        {
            using (var db = new RestoAppContext())
            {
                db.Restaurants.Add(oRestaurant);
                db.SaveChanges();
            }
        }

        public void UpdateRestaurant(RestaurantEntity oRestaurant)
        {
            using (var db = new RestoAppContext())
            {
                db.Restaurants.Update(oRestaurant);
                db.SaveChanges();
            }
        }
    }
}
