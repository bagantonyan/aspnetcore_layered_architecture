﻿using EventManager.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManager.DAL.Configurations
{
    public class EventConfiguration : BaseEntityConfiguration<Event>
    {
        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(256)
                .IsRequired(true);

            builder.Property(p => p.Description)
                .HasMaxLength(10000)
                .IsRequired(true);

            builder.Property(p => p.StartDate)
                .IsRequired(true);

            builder.Property(p => p.EndDate)
                .IsRequired(true);

            builder.Property(p => p.TimeZone)
                .HasMaxLength(128)
                .IsRequired(true);

            builder.Property(p => p.Mode)
                .HasMaxLength(8)
                .IsRequired(true);

            builder.Property(p => p.Location)
                .HasMaxLength(128)
                .IsRequired(true);

            builder.Property(p => p.Hidden)
                .IsRequired(true);

            builder.HasOne(e => e.User)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.UserId);
        }
    }
}