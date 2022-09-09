using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> dbContextOptions): base(dbContextOptions)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
