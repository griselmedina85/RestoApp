using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class EmployeeEntity
    {
        [Key]
        public int EmployeeId { get; set; }
        //Relación con personas 
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
