using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ValhallaApp.Domain.Entities;

namespace ValhallaApp.Infrastructure.Persistence
{
    public partial class ValhallaContext : DbContext
    {
        public ValhallaContext()
        {
        }

        public ValhallaContext(DbContextOptions<ValhallaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ConfiguratedProduct> ConfiguratedProducts { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<Option> Options { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguratedProduct>(entity =>
            {
                entity.HasKey(e => e.ConfiguratedId)
                    .HasName("PK__Configur__A46D7380B0DB1552");

                entity.Property(e => e.ConfiguratedId)
                    .ValueGeneratedNever()
                    .HasColumnName("ConfiguratedID");

                entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");

                entity.HasOne(d => d.Configuration)
                    .WithMany(p => p.ConfiguratedProducts)
                    .HasForeignKey(d => d.ConfigurationId)
                    .HasConstraintName("FK__Configura__Confi__300424B4");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.ConfigurationId)
                    .ValueGeneratedNever()
                    .HasColumnName("ConfigurationID");

                entity.Property(e => e.AperturaTraseraSmart)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AsientosElectricos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AsistenciaAutopista)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bordado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cinturones)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Frenos)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Llantas)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LLantas");

                entity.Property(e => e.Pintura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisionNocturna)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vista)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WashingPackage)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.Property(e => e.OptionId)
                    .ValueGeneratedNever()
                    .HasColumnName("OptionID");

                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.ConfiguratedId).HasColumnName("ConfiguratedID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipVia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Configurated)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ConfiguratedId)
                    .HasConstraintName("FK__Orders__Configur__34C8D9D1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Orders__ProductI__33D4B598");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserID__32E0915F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__2A4B4B5E");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OptionId)
                    .HasConstraintName("FK__Products__Option__2B3F6F97");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
