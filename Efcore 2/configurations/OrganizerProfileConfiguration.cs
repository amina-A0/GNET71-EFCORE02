
using global::Efcore_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efcore_2.configurations
{
        public class OrganizerProfileConfiguration
            : IEntityTypeConfiguration<OrganizerProfile>
        {
            public void Configure(
                EntityTypeBuilder<OrganizerProfile> builder)
            {
                builder.HasKey(p => p.OrganizerProfileId);
                builder.Property(p => p.Biography)
                       .IsRequired();
                builder.Property(p => p.Website)
                       .IsRequired();
                builder.Property(p => p.Logo)
                       .IsRequired();
                builder.HasOne(p => p.Organizer)
                       .WithOne(o => o.OrganizerProfile)
                       .HasForeignKey<OrganizerProfile>(
                           p => p.OrganizerId)
                       .IsRequired();
            }
        }
    
}
