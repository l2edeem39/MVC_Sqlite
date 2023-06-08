using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TestDBSqLite.DataAccess
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DatabaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("DbContext"));
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
