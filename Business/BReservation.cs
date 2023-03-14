using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BReservation
    {
        public List<ReservationEntity> ReservationList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Reservations.ToList();
            }
        }
        public void CreateReservation(ReservationEntity oReservation)
        {
            using (var db = new RestoAppContext())
            {
                db.Reservations.Add(oReservation);
                db.SaveChanges();
            }
        }
        public void UpdateLocation(ReservationEntity oReservation)
        {
            using (var db = new RestoAppContext())
            {
                db.Reservations.Update(oReservation);
                db.SaveChanges();
            }
        }
    }
}
