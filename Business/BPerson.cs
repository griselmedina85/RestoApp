using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BPerson
    {
        public List<PersonEntity> PersonList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Persons.ToList();
            }
        }
        public void CreatePerson(PersonEntity oPerson)
        {
            using (var db = new RestoAppContext())
            {
                db.Persons.Add(oPerson);
                db.SaveChanges();
            }
        }
        public void UpdatePerson(PersonEntity oPerson)
        {
            using (var db = new RestoAppContext())
            {
                db.Persons.Update(oPerson);
                db.SaveChanges();
            }
        }
    }
}
