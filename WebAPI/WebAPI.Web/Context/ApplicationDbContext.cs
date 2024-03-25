using Microsoft.EntityFrameworkCore;
using WebAPI.Web.Models;
using WebAPI.Web.Models.PokemonModel;
using WebAPI.Web.Models.VillaModel;

namespace WebAPI.Web.Context
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        //public DbSet<Post> Posts { get; set; }  
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories  { get; set; }
        //public DbSet<Country> Countries { get; set; }   
        //public DbSet<Owner> Owners { get; set; }    
        //public DbSet<Pokemon> Pokemons { get; set; }    
        //public DbSet<PokemonCategory> PokemonCategories { get; set; }   
        //public DbSet<PokemonOwner> PokemonOwners { get; set;}
        //public DbSet<Review> Reviews { get; set; }  
        //public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<House> Houses { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PokemonCategory>()
            //        .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            //modelBuilder.Entity<PokemonCategory>()
            //        .HasOne(p => p.Pokemon)
            //        .WithMany(pc => pc.PokemonCategories)
            //        .HasForeignKey(p => p.PokemonId);
            //modelBuilder.Entity<PokemonCategory>()
            //        .HasOne(p => p.Category)
            //        .WithMany(pc => pc.PokemonCategories)
            //        .HasForeignKey(c => c.CategoryId);

            //modelBuilder.Entity<PokemonOwner>()
            //        .HasKey(po => new { po.PokemonId, po.OwnerId });
            //modelBuilder.Entity<PokemonOwner>()
            //        .HasOne(p => p.Pokemon)
            //        .WithMany(pc => pc.PokemonOwners)
            //        .HasForeignKey(p => p.PokemonId);
            //modelBuilder.Entity<PokemonOwner>()
            //        .HasOne(p => p.Owner)
            //        .WithMany(pc => pc.PokemonOwners)
            //        .HasForeignKey(c => c.OwnerId);



            modelBuilder.Entity<House>().HasData(
                    new House
                    {
                        Id = 1,
                        Name = "Royal Villa",
                        Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                        ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                        Occupancy = 4,
                        Rate = 200,
                        Sqrt = 550,
                        Amenity = "",
                        Createddate = DateTime.Now
                    },
                  new House
                  {
                      Id = 2,
                      Name = "Premium Pool Villa",
                      Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                      ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                      Occupancy = 4,
                      Rate = 300,
                      Sqrt = 550,
                      Amenity = "",
                      Createddate = DateTime.Now
                  },
                  new House
                  {
                      Id = 3,
                      Name = "Luxury Pool Villa",
                      Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                      ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                      Occupancy = 4,
                      Rate = 400,
                      Sqrt = 750,
                      Amenity = "",
                      Createddate = DateTime.Now
                  },
                  new House
                  {
                      Id = 4,
                      Name = "Diamond Villa",
                      Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                      ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                      Occupancy = 4,
                      Rate = 550,
                      Sqrt = 900,
                      Amenity = "",
                      Createddate = DateTime.Now
                  },
                  new House
                  {
                      Id = 5,
                      Name = "Diamond Pool Villa",
                      Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                      ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                      Occupancy = 4,
                      Rate = 600,
                      Sqrt = 1100,
                      Amenity = "",
                      Createddate = DateTime.Now
                  });
        }
    }
}
