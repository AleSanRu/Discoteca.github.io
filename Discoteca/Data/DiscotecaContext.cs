
using Discoteca.Models;
using Microsoft.EntityFrameworkCore;
namespace Discoteca.Data
{
    public class DiscotecaContext : DbContext
    {
        public DiscotecaContext(DbContextOptions<DiscotecaContext> options)
            : base(options)
        {
        }
        public DbSet<DiscotecaDatos> Discotecas { get; set; }
    }
}
