using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BReservationLog
    {
        public List<ReservationLogEntity> ReservationLogList()
        {
            using (var db = new RestoAppContext())
            {
                return db.ReservationsLog.ToList();
            }
        }
        public void CreateReservationLog(ReservationLogEntity oReservationLog)
        {
            using (var db = new RestoAppContext())
            {
                db.ReservationsLog.Add(oReservationLog);
                db.SaveChanges();
            }
        }
        public void UpdateReservationLog(ReservationLogEntity oReservationLog)
        {
            using (var db = new RestoAppContext())
            {
                db.ReservationsLog.Update(oReservationLog);
                db.SaveChanges();
            }
        }
    }
}
