using Microsoft.EntityFrameworkCore;
using RedisCacheProjectWithNLayer.Models;

namespace RedisCacheProjectWithNLayer.DB
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<BookModel> Books { get; set; }
    }
}
