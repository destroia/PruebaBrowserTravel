using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Models
{
    [Keyless]
    public class Autor_has_libro
    {
        [MaxLength(10)]
        [Required]
        [Key]
        public long AutorId { get; set; }
        [MaxLength(13)]
        [Required]
        [Key]
        public long LibroId { get; set; }
    }
}
