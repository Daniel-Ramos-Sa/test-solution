using API_Teste.API_Teste.Domain;
using Microsoft.EntityFrameworkCore;

namespace API_Teste.API_Teste.Infrastructure
{
    /// <summary>
    /// Entidades de DbContext e Conexão com o Banco
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<User> Users { get; set; }
        
       
    }
}
