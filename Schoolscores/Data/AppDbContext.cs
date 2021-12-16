using Microsoft.EntityFrameworkCore;
using Schoolscores.Models;

namespace Schoolscores.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
