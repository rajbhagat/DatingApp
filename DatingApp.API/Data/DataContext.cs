namespace DatingApp.API.Data
{
    using Microsoft.EntityFrameworkCore;
    using DatingApp.API.Models;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}