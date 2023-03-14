using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BTable
    {
        public List<TableEntity> TableList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Tables.ToList();
            }
        }

        public void CreateTables(TableEntity oTable)
        {
            using (var db = new RestoAppContext())
            {
                db.Tables.Add(oTable);
                db.SaveChanges();
            }
        }

        public void UpdateTable(TableEntity oTable)
        {
            using (var db = new RestoAppContext())
            {
                db.Tables.Update(oTable);
                db.SaveChanges();
            }
        }
    }
}
