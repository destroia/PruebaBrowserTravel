using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Models
{
    public class Editorial
    {
        [MaxLength(10)]
        public long Id { get; set; }
        [MaxLength(45)]
       // [Required]
        public string Nombre { get; set; }
        [MaxLength(45)]
       // [Required]
        public string Sede { get; set; }
        [ForeignKey("EditorialId")]
        public List<Libro> Libros { get; set; }
    }
}
