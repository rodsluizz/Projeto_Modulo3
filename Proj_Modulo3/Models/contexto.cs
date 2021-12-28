using Microsoft.EntityFrameworkCore;

namespace Proj_Modulo3.Models
{
    public class contexto : DbContext
    {   
        public contexto(DbContextOptions<contexto> options) : base(options)
        {
        }

        public DbSet<destinos> destinos { get; set; } 
        public DbSet<promocoes> promocoes { get; set; }
    }
}
