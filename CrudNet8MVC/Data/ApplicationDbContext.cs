using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options){ 

        }

        //A partir de aqui se agregan los modelos, Cada uno es una tabla en la BD
        public DbSet<Contacto> Contacto { get; set; }
    }
}
