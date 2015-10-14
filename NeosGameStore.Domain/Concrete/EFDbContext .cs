using NeosGameStore.Domain.Entities;
using System.Data.Entity;

namespace NeosGameStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
