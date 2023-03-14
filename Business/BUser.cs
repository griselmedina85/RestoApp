using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BUser
    {
        public List<UserEntity> UserList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Users.ToList();
            }
        }

        public void CreateUser(UserEntity oUser)
        {
            using (var db = new RestoAppContext())
            {
                db.Users.Add(oUser);
                db.SaveChanges();
            }
        }

        public void UpdateUser(UserEntity oUser)
        {
            using (var db = new RestoAppContext())
            {
                db.Users.Update(oUser);
                db.SaveChanges();
            }
        }
    }
}
