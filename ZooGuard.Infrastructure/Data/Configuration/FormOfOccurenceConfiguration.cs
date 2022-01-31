using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entites.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class FormOfOccurenceConfiguration : IEntityTypeConfiguration<FormOfOccurence>
    {
        public void Configure(EntityTypeBuilder<FormOfOccurence> builder)
        {
            
        }
    }
}
