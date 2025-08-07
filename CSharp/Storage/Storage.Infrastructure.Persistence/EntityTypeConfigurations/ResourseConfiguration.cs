using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Core.Domain;


namespace Storage.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ResourseConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(ent => ent.resId);
            builder.HasIndex(ent => ent.resId).IsUnique();
            builder.Property(ent => ent.resId).UseIdentityColumn();

            builder.Property(ent => ent.name).IsRequired(); 
            builder.HasIndex(ent => ent.name).IsUnique(); 
        }
    }
}