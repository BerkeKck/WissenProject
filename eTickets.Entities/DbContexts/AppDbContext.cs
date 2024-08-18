using Microsoft.EntityFrameworkCore;
using eTickets.Entities.Model.Concrete;
using eTickets.Entities.EntityConfig.Concrete;
using System.Reflection;

namespace eTickets.Entities.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }

    
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        // Constructor for design-time use
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use the connection string from configuration if not already configured
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"server=localhost;user=root;password=Password.1;database=eticket;");
            }
        }
    }
}
