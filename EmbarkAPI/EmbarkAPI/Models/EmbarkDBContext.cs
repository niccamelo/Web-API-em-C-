using Microsoft.EntityFrameworkCore;

namespace EmbarkAPI.Models
{
    public class EmbarkDBContext : DbContext
    {
            
            public EmbarkDBContext(DbContextOptions<EmbarkDBContext> options)
              : base(options)
            { }

            public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Pct_viagem> Pct_viagem { get; set; }
        public DbSet<Hospedagem> Hospedagem { get; set; }




    }
}
