using AppointmentManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentManagement.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<CONTACT> Contact { get; set; }
        public DbSet<APPOINTMENT> Appointment { get; set; }
        public DbSet<REMINDER> Reminder { get; set; }

    }

}