using Microsoft.EntityFrameworkCore;
using Jose_vargas_Apl1_p1.Entidades;

namespace Jose_vargas_Apl1_p1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Productos");
        }
    }
}