using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Vural\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true");
        }
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Staff> Staff { get; set; } = null!;
        public DbSet<Subscribe> Subscribes { get; set; } = null!;
        public DbSet<Testimonial> Testimonials { get; set; } = null!;
        public DbSet<About> Abouts { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<SendMessage> SendMessages { get; set; } = null!;
        public DbSet<MessageCategory> MessageCategories { get; set; } = null!;
        public DbSet<WorkLocation> WorkLocations { get; set; } = null!;
    }
}
