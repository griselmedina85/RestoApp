using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BClient
    {
        public List<ClientEntity> ClientList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Clients.ToList();
            }
        }

        public void CreateClient(ClientEntity oClient)
        {
            using (var db = new RestoAppContext())
            {
                db.Clients.Add(oClient);
                db.SaveChanges();
            }
        }

        public void UpdateClient(ClientEntity oClient)
        {
            using (var db = new RestoAppContext())
            {
                db.Clients.Update(oClient);
                db.SaveChanges();
            }
        }
    }
}
