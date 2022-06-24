using Microsoft.EntityFrameworkCore;

namespace CRUD_WEB.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
