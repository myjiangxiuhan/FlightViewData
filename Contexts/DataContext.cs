using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }
    }
}