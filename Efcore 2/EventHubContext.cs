using Efcore_2.configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efcore_2
{
    public class EventHubContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
          "Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            // OrganizerProfile Configuration Class
            modelBuilder.ApplyConfiguration(
                new OrganizerProfileConfiguration());

            // Organizer - Event (1-M)
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(o => o.Events)
                .HasForeignKey(e => e.OrganizerId)
                .IsRequired();

            // Attendee - Badge (1-1)
            modelBuilder.Entity<Badge>()
                .HasOne(b => b.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId)
                .IsRequired();

            // Badge Number must be unique
            modelBuilder.Entity<Badge>()
                .HasIndex(b => b.BadgeNumber)
                .IsUnique();

        }
    }
}
