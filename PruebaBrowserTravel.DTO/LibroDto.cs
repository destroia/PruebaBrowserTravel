using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.DTO
{
    public class LibroDto
    {
        public long Id { get; set; }
        [Required]
        public long EditorialId { get; set; }

        [Required]
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        [Required]
        public string NumeroPaginas { get; set; }
    }
}
