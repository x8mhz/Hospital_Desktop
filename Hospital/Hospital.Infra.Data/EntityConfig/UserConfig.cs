using System.Data.Entity.ModelConfiguration;
using Hospital.Domain.Entities;

namespace Hospital.Infra.Data.EntityConfig
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("Usuario");

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

            Property(p => p.ZipCode)
                .HasColumnName("CEP")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Street)
                .HasColumnName("Rua")
                .HasMaxLength(255)
                .IsRequired();

            Property(p => p.Number)
                .HasColumnName("Numero")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.State)
                .HasColumnName("Estado")
                .HasMaxLength(3)
                .IsRequired();

            Property(p => p.City)
                .HasColumnName("Cidade")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Country)
                .HasColumnName("Pais")
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}