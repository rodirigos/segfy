using Microsoft.EntityFrameworkCore;
using Seg.API.Models;

namespace Seg.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Insurance> Insurances {get;set;}
    }
}