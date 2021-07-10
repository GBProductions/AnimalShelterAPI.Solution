using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasData(
                    new Animal { AnimalId = 1, Name = "Amy", Species = "Dog", Age = 9, Sex = "Female" },
                    new Animal { AnimalId = 2, Name = "Jim", Species = "Cat", Age = 1, Sex = "Male" },
                    new Animal { AnimalId = 3, Name = "Pam", Species = "Dog", Age = 5, Sex = "Female" },
                    new Animal { AnimalId = 4, Name = "Alice", Species = "Cat", Age = 3, Sex = "Female" },
                    new Animal { AnimalId = 5, Name = "Dee", Species = "Dog", Age = 8, Sex = "Female" },
                    new Animal { AnimalId = 6, Name = "Jimmy", Species = "Cat", Age = 9, Sex = "Male" },
                    new Animal { AnimalId = 7, Name = "Edward", Species = "Cat", Age = 6, Sex = "Male" }
                );
        }
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    }
}