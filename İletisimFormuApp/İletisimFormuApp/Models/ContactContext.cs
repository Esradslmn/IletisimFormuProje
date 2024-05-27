using Microsoft.EntityFrameworkCore;

namespace MyContacts.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Muhasebe" },
              new Category { CategoryId = 2, Name = "Teknik Destek" },
              new Category { CategoryId = 3, Name = "İnsan Kaynakları" }
            );

            modelBuilder.Entity<Contact>().HasData(
              new Contact
              {
                  ContactId = 1,
                  FirstName = "Ezgi",
                  LastName = "Güler",
                  PhoneNumber = "123-456-7890",
                  Email = "eguler@gmail.com",
                  Message= "Message1",
                  CategoryId = 1,
              },
              new Contact
              {
                  ContactId = 2,
                  FirstName = "Esra",
                  LastName = "Güler",
                  PhoneNumber = "123-456-7890",
                  Email = "gesra@gmail.com",
                  Message = "Message2",
                  CategoryId = 1,
              },
              new Contact
              {
                  ContactId = 3,
                  FirstName = "Hilal",
                  LastName = "Güler",
                  PhoneNumber = "123-456-7890",
                  Email = "ggulerr@gmail.com",
                  Message = "Message3",
                  CategoryId = 2,
              }
         );
        }
    }

}