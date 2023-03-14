using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class RestaurantEntity
    {
        [Key]
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(50)]
        public string RestaurantName { get; set; }
        public string Speciallity { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        public int Capacity { get; set; }
        //Relacion con mesas
        public ICollection<TableEntity> Tables { get; set; }
        //Relación con reservas
        public ICollection<ReservationEntity> Reservations { get; set; }
    }
}
