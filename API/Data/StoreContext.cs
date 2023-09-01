using API.Entities;
using Microsoft.EntityFrameworkCore;


namespace API.data
{
    public class StoreContext : DbContext {
        public StoreContext(DbContextOptions options) : base(options) {

        }

        public DbSet<Products> Products { get; set;}
    }
}
