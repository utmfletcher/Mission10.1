using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Mission10._1._1.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) 
        {
        
        }

        public DbSet<Bowlers> Bowlers { get; set; }
    }
}
