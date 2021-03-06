// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 9,
                            Name = "Amy",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 1,
                            Name = "Jim",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 5,
                            Name = "Pam",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 3,
                            Name = "Alice",
                            Sex = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 8,
                            Name = "Dee",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 9,
                            Name = "Jimmy",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 6,
                            Name = "Edward",
                            Sex = "Male",
                            Species = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
