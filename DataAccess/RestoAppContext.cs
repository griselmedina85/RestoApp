using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class RestoAppContext:DbContext
    {
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<PersonEntity> Persons { get; set; }        
        public DbSet<ProfileEntity> Profiles { get; set; }
        public DbSet<ReservationEntity> Reservations { get; set; }
        public DbSet<ReservationLogEntity> ReservationsLog { get; set; }
        public DbSet<RestaurantEntity> Restaurants { get; set;}
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-KCE88OI\\SQLEXPRESS; Database=RestoAppDb;User Id=sa; Password=evasarayada");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ClientEntity>().HasIndex(b => b.ClientId).IsUnique();
            //modelBuilder.Entity<EmployeeEntity>().HasIndex(b => b.EmployeeId).IsUnique();
            //modelBuilder.Entity<LocationEntity>().HasIndex(b => b.LocationId).IsUnique();
            modelBuilder.Entity<LocationEntity>().HasData(
                new LocationEntity { LocationId = 1, LocationDescription = "Salón" },
                new LocationEntity { LocationId = 2, LocationDescription = "Patio" },
                new LocationEntity { LocationId = 3, LocationDescription = "Terraza" }
                );
            //modelBuilder.Entity<PersonEntity>().HasIndex(b => b.PersonId).IsUnique();
            //modelBuilder.Entity<ProfileEntity>().HasIndex(b => b.ProfileId).IsUnique();
            //modelBuilder.Entity<ReservationEntity>().HasIndex(b => b.ReservationId).IsUnique();
            //modelBuilder.Entity<ReservationLogEntity>().HasIndex(b => b.ReservationLogId).IsUnique();
            //modelBuilder.Entity<RestaurantEntity>().HasIndex(b => b.RestaurantId).IsUnique();
            //modelBuilder.Entity<TableEntity>().HasIndex(b => b.TableId).IsUnique();
            //modelBuilder.Entity<UserEntity>().HasIndex(b => b.UserId).IsUnique();
            modelBuilder.Entity("Entities.ReservationEntity", b =>
            {
                b.HasOne("Entities.ClientEntity", "Cliente")
                    .WithMany("Reservations")
                    .HasForeignKey("ClienteClientId");

                b.HasOne("Entities.RestaurantEntity", "Restaurant")
                    .WithMany("Reservations")
                    .HasForeignKey("RestaurantId")
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .IsRequired();

                b.HasOne("Entities.TableEntity", "Table")
                    .WithMany("Reservations")
                    .HasForeignKey("TableId")
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .IsRequired();
            });

        }
    }

}
