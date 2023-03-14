﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class ReservationLogEntity
    {
        /*

		*/
        [Key]
        public int ReservationLogId { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
        [Required]
        public string DetailTable { get; set; }
        [Required]
        public int PartialCapacity { get; set; }
        [Required]
        public int PartialTotalCapacity { get; set; }



    }
}
