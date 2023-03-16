using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class UserEntity
    {
        /*
id_person	int	Unchecked
*/

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }
        //Relación con perfil
        public int ProfileId { get; set; }
        public ProfileEntity Profile { get; set; }
        //Relación con Persona
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
