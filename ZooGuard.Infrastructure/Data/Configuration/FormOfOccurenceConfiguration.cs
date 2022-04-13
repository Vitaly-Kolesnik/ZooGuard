using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.VenderEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class FormOfOccurenceConfiguration : IEntityTypeConfiguration<FormOfOccurence>
    {
        public void Configure(EntityTypeBuilder<FormOfOccurence> builder)
        {
            builder
              .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
