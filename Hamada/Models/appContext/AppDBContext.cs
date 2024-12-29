using Hamada.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hamada.Models.appContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Catgories> catgories { get; set; }
        public DbSet<Habits> habits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x=>x.habits)
                .WithOne(x=>x.User).HasForeignKey(x=>x.userID);

            modelBuilder.Entity<Habits>().HasOne(x=>x.Categories)
                .WithMany(x=>x.Habit).HasForeignKey(x=>x.CatID);
        }
    }
  
}
