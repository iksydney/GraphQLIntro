using GraphQLIntro.Data.ContextConfigurations;
using GraphQLIntro.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLIntro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
            modelBuilder.ApplyConfiguration(new SuperheroContextConfiguration(ids));
            modelBuilder.ApplyConfiguration(new SuperpowerContextConfiguration(ids));
            modelBuilder.ApplyConfiguration(new MovieContextConfiguration(ids));
        }

        public DbSet<SuperHeroe> SuperHeroes { get; set; }
        public DbSet<Superpower> Superpowers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

