using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options) { }
        public DbSet<Post> Posts { get; set; } = null;
    }
}