using AppNetRazor.Cursos;
using Microsoft.EntityFrameworkCore; //esta version de BD usamos

namespace AppNetRazor.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


    //PONER MODELOS AQUI
    public DbSet<Curso> Curso { get; set; } //instancio
    }
}
