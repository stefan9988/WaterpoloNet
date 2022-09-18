using Microsoft.EntityFrameworkCore;
using WaterpoloAppNet.Models;

namespace WaterpoloAppNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
