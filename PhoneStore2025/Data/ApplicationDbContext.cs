using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneStore2025.Models;

namespace PhoneStore2025.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var phones = new Phone[3];
            phones[0] = new Phone();
            phones[0].Id = 1;
            phones[0].Manufacturer = "Apple";
            phones[0].PhoneModel = "iPhone 12 Pro Max";
            phones[0].Price = 305;
            phones[1] = new Phone();
            phones[1].Id = 2;
            phones[1].Manufacturer = "Samsung";
            phones[1].PhoneModel = "A35";
            phones[1].Price = 288;
            phones[2] = new Phone();
            phones[2].Id = 3;
            phones[2].Manufacturer = "Apple";
            phones[2].PhoneModel = "iPhone 15 Pro Max";
            phones[2].Price = 605;

            builder.Entity<Phone>().HasData(phones);
        }
    }
}
