using Microsoft.EntityFrameworkCore;
using CadastroEstudanteApi.Models;

namespace CadastroEstudanteApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudante> Estudantes { get; set; } = null!;
    }
}