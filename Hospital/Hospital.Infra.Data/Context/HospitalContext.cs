using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Hospital.Domain.Entities;
using Hospital.Infra.Data.EntityConfig;

namespace Hospital.Infra.Data.Context
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("HospitalContex")
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HospitalCenter> HospitalCenters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("nvarchar"));

            modelBuilder.Configurations.Add(new DoctorConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new HospitalConfig());
        }
    }
}