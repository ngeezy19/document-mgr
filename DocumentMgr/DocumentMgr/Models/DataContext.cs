using Microsoft.EntityFrameworkCore;

namespace DocumentMgr.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
