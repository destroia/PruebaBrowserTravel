using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaBrowserTravel.Models
{
    public class Autor
    {
        [MaxLength(10)]
        public long Id { get; set; }
        [MaxLength(45)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(45)]
        [Required]
        public string Apellido { get; set; }

    }
}
