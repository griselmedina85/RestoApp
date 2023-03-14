using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BProfile
    {
        public List<ProfileEntity> ProfileList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Profiles.ToList();
            }
        }
        public void CreateProfile(ProfileEntity oProfile)
        {
            using (var db = new RestoAppContext())
            {
                db.Profiles.Add(oProfile);
                db.SaveChanges();
            }
        }
        public void UpdateProfile(ProfileEntity oProfile)
        {
            using (var db = new RestoAppContext())
            {
                db.Profiles.Update(oProfile);
                db.SaveChanges();
            }
        }
    }
}
