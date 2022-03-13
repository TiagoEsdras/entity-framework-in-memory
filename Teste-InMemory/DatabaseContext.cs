using Microsoft.EntityFrameworkCore;

namespace Teste_InMemory
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<EventoModel> Eventos { get; set; }
    }
}