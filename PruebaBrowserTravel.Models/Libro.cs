using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Models
{
    public class Libro
    {
        [MaxLength(13)]
        public long Id { get; set; }
        [MaxLength(10)]
        [Required]
        public long EditorialId { get; set; }
        [MaxLength(45)]
        [Required]
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        [Required]
        [MaxLength(45)]
        public string NumeroPaginas { get; set; }

      
    }
}
