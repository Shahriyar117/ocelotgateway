using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class DataContext : DbContext
    {
        //protected readonly IConfiguration Configuration;

        //public DataContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //}
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
