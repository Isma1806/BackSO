using InvestigacionSO.Api.models;
using Microsoft.EntityFrameworkCore;

namespace InvestigacionSO.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
