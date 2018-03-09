using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMDC.Domain.Entities;

namespace StoreMDC.Infra.Data.Mappings
{
    public class StoreMap : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Store");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(s => s.Categories)
                .WithOne(c => c.Store);            
            
        }
    }
}
