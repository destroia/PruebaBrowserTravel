using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.DTO
{
    public class Autor_has_libroDto
    {
        [Required]
        public long AutorId { get; set; }
        [Required]
        public long LibroId { get; set; }
    }
}
