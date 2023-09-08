using Microsoft.EntityFrameworkCore;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.AccesData
{
    public class ContextDBTravel : DbContext
    {
        public ContextDBTravel(DbContextOptions<ContextDBTravel> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Data Source=.;Initial Catalog=BrowserTravel;Integrated Security=true"

             );
            base.OnConfiguring(optionsBuilder);
            //Primer Migracion   Add-Migration InitialCreate
            //Despues de la primera migracion se utiliza  Update-Database


        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Autor_has_libro> Autor_Has_Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor_has_libro>()
                 .HasKey(t => new {
                     t.AutorId,
                     t.LibroId
                 });
        }
    }
}
