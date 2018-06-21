using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Poject2.Models;
using Poject2.Models.Persons;

namespace Poject2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Person{set;get;}
        public DbSet<Doctor> Doctor { set; get;}
        public DbSet<PersonType> PersonType { set; get; }
        public DbSet<Pacient> Pacient { set; get;}
        public DbSet<Student> Student { set; get; }
        public DbSet<Appointment> Appointment { set; get; }
        public DbSet<Subject> Subject { set; get; }
        public DbSet<City> City { set; get; }
        public DbSet<Notifaciton> Notifaction { set; get; }
        public DbSet<Post> Post { set; get; }
        public DbSet<Rating> Rating { set; get; }
        public DbSet<States> States { set; get; }
        public DbSet<survey> survey { set; get; }
        public DbSet<transforPacient> transforPacient { set; get; }
        public DbSet<Address> Address { set; get; }
        public DbSet<Account> Account { set; get; }
        public DbSet<BlockPerson> BlockPerson { set; get; }
        public DbSet<Friend> Friends { set; get; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}