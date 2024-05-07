using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using OOPlab3.Models;

namespace OOPlab3.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<DoctorsToPatients> DoctorToPatient { get; set; }
    }
}
