using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using User.api.model;



namespace User.api.Infraestrutura
{
    public class ConectionDatabase : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Estoque> Estoque { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(
             "Server=localhost;" +
             "Port=5432;Database=postgres;" +
             "User Id=postgres;" +
             "Password =8971matu;");
                   

    }
}

