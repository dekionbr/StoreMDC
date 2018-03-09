using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreMDC.Domain.Entities;

namespace StoreMDC.Infra.Data.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(s => s.Country)
                .WithMany(c => c.States);

            builder.HasMany(s => s.Cities)
                .WithOne(c => c.State);
        }
    }
}
