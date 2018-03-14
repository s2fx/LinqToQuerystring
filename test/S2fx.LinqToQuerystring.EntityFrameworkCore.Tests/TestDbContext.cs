namespace LinqToQueryString.EntityFrameworkCore.Tests
{
    using LinqToQueryString.Tests;
    using Microsoft.EntityFrameworkCore;

    public class TestDbContext : DbContext
    {
        public DbSet<ConcreteClass> ConcreteCollection { get; set; }

        public DbSet<ComplexClass> ComplexCollection { get; set; }

        public DbSet<EdgeCaseClass> EdgeCaseCollection { get; set; }

        public DbSet<NullableClass> NullableCollection { get; set; }

        public DbSet<NullableContainer> NullableContainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TestDb.sqlite");
        }
    }
}
