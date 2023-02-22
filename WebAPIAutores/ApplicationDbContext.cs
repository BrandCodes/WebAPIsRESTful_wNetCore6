using Microsoft.EntityFrameworkCore;
using WebAPIAutores.Controllers.Entidades;

namespace WebAPIAutores
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Autor>Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
