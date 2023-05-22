using API_BlogPlatform.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API_BlogPlatform.Persistence.Context
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        // protected override void OnConfiguring
        //(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseInMemoryDatabase(databaseName: "BlogPlatformDb");
        // }

        public DbSet<BlogPost> BlogPost { get; set; }

    }
}
