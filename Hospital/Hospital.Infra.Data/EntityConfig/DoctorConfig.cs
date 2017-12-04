using Hospital.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Hospital.Infra.Data.EntityConfig
{
    public class DoctorConfig : EntityTypeConfiguration<Doctor>
    {
        public DoctorConfig()
        {
            ToTable("Doutor");

            HasKey(p => p.Id);

            Property(p => p.Name)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Genere)
                .HasColumnName("Genero")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.BirthDate)
                .HasColumnName("Nascimento")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Cpf)
                .HasColumnName("CPF")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Telephone)
                .HasColumnName("Telefone")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.PhNo)
                .HasColumnName("PhNo")
                .HasMaxLength(20)
                .IsRequired();

            Property(p => p.Specialization)
                .HasColumnName("Especializacao")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}