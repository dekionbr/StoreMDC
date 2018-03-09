using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMDC.Domain.Entities;

namespace StoreMDC.Infra.Data.Mappings
{
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}
