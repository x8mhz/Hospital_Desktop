using System.Data.Entity.ModelConfiguration;
using Hospital.Domain.Entities;

namespace Hospital.Infra.Data.EntityConfig
{
    public class HospitalConfig : EntityTypeConfiguration<HospitalCenter>
    {
        public HospitalConfig()
        {
            ToTable("Hospital");

            HasKey(p => p.Id);

            Property(p => p.Localization)
                .HasColumnName("Localizacao")
                .HasMaxLength(255)
                .IsRequired();

            Property(p => p.Sector)
                .HasColumnName("Setor")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.QtdRoom)
                .HasColumnName("Quarto")
                .IsRequired();
        }
    }
}