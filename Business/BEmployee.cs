using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BEmployee
    {
        public List<EmployeeEntity> EmployeeList()
        {
            using (var db = new RestoAppContext())
            {
                return db.Employees.ToList();
            }
        }

        public void CreateEmployee(EmployeeEntity oEmployee)
        {
            using (var db = new RestoAppContext())
            {
                db.Employees.Add(oEmployee);
                db.SaveChanges();
            }
        }

        public void UpdateEmployee(EmployeeEntity oEmployee)
        {
            using (var db = new RestoAppContext())
            {
                db.Employees.Update(oEmployee);
                db.SaveChanges();
            }
        }
    }
}
