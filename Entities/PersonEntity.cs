using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text;

namespace Entities
{
    public class PersonEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonLastName { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
        public int IdentityNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Gender { get; set; }
        //Relación con clientes
        public ICollection<ClientEntity> Clients { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }



    }
}
