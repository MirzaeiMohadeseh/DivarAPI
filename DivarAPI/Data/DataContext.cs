using DivarAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DivarAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
        public DbSet<Divar> Divars { get; set; }

    }
}
