﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.FullName)
                .HasMaxLength(100)
                .IsRequired();

            builder
               .Property(x => x.ShortName)
               .HasMaxLength(50)
               .IsRequired();

            builder
                .Property(x => x.Date)
                .HasMaxLength(15)
                .IsRequired();

            builder
                .Property(x => x.RegistrationDocument)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(x => x.AccountingNumber)
                .HasMaxLength(10)
                .IsRequired();

            builder
                .Property(x => x.Information)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
