using Microsoft.EntityFrameworkCore;

namespace ASApi.Models
{
  public class ASApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public ASApiContext(DbContextOptions<ASApiContext> options) : base(options)  { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Buddy", Species = "Dog", Breed = "Golden Retriever", Age = 5 },
                new Animal { AnimalId = 2, Name = "Molly", Species = "Dog", Breed = "Labrador Retriever", Age = 3 },
                new Animal { AnimalId = 3, Name = "Coco", Species = "Dog", Breed = "Poodle", Age = 2 },
                new Animal { AnimalId = 4, Name = "Charlie", Species = "Dog", Breed = "Labrador Retriever", Age = 1 },
                new Animal { AnimalId = 5, Name = "Lucy", Species = "Dog", Breed = "Labrador Retriever", Age = 4 },
                new Animal { AnimalId = 6, Name = "Bailey", Species = "Dog", Breed = "Golden Retriever", Age = 6 },
                new Animal { AnimalId = 7, Name = "Daisy", Species = "Dog", Breed = "Golden Retriever", Age = 7 },
                new Animal { AnimalId = 8, Name = "Maggie", Species = "Dog", Breed = "Pug", Age = 8 },
                new Animal { AnimalId = 9, Name = "Sophie", Species = "Dog", Breed = "Pug", Age = 9 },
                new Animal { AnimalId = 10, Name = "Chloe", Species = "Cat", Breed = "Ocicat", Age = 10 },
                new Animal { AnimalId = 11, Name = "Sadie", Species = "Cat", Breed = "Ocicat", Age = 11 },
                new Animal { AnimalId = 12, Name = "Lola", Species = "Cat", Breed = "Persian", Age = 12 },
                new Animal { AnimalId = 13, Name = "Zoe", Species = "Cat", Breed = "Persian", Age = 13 },
                new Animal { AnimalId = 14, Name = "Duke", Species = "Cat", Breed = "Ragdoll", Age = 14 },
                new Animal { AnimalId = 15, Name = "Lily", Species = "Cat", Breed = "Ragdoll", Age = 15 },
                new Animal { AnimalId = 16, Name = "Rocky", Species = "Cat", Breed = "Siamese", Age = 16 },
                new Animal { AnimalId = 17, Name = "Luna", Species = "Cat", Breed = "Siamese", Age = 17 },
                new Animal { AnimalId = 18, Name = "Harley", Species = "Cat", Breed = "Sphynx", Age = 18 },
                new Animal { AnimalId = 19, Name = "Mia", Species = "Cat", Breed = "Sphynx", Age = 19 },
                new Animal { AnimalId = 20, Name = "Max", Species = "Cat", Breed = "Sphynx", Age = 20 }

            );
        }
    }
}