using Microsoft.EntityFrameworkCore;
using MyContacts.Domain.Entities;

namespace MyContacts.Repository.Common
{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Person> Persons { get; set; }
        public DbSet<NaturalPerson> NaturalPersons { get; set; }
        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Address>();
            //modelBuilder.Entity<NaturalPerson>();
            //modelBuilder.Entity<LegalPerson>();


            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
