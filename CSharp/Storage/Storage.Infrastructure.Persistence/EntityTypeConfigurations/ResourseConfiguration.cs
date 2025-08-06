using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Core.Domain;


namespace Storage.Infrastructure.Persistence.EntityTypeConfigurations
{
    public class ResourseConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(ent => ent.id);
            builder.HasIndex(ent => ent.id).IsUnique();

        }
    }
}