using Microsoft.EntityFrameworkCore;
using RestfulWebAPI.Models;

namespace RestfulWebAPI.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Posts> Posts { get; set; }

    }
}
