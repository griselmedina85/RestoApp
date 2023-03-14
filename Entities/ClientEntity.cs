using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class ClientEntity
    {
        [Key]
        public int ClientId { get; set; }
        //Relación con personas 
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
        //Relacion con Reservas
        public ICollection<ReservationEntity> Reservations { get; set; }

    }
}
