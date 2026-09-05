using Microsoft.EntityFrameworkCore;
using React_CRUD_WebAPI.Model;

namespace React_CRUD_WebAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
