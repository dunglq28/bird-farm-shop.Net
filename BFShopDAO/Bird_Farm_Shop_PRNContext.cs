using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BFShopBussinessObjects.Entities
{
    public partial class Bird_Farm_Shop_PRNContext : DbContext
    {
        public Bird_Farm_Shop_PRNContext()
        {
        }

        public Bird_Farm_Shop_PRNContext(DbContextOptions<Bird_Farm_Shop_PRNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionStrings());
            }
        }

        private string GetConnectionStrings()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config["ConnectionStrings:connStr"];
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__Account__AB6E616515D330FB");

                entity.ToTable("Account");

                entity.Property(e => e.Email)
                    .HasMaxLength(155)
                    .HasColumnName("email");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.Password)
                    .HasMaxLength(155)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .HasColumnName("street");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Account_RoleId");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .HasColumnName("order_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.StaffName)
                    .HasMaxLength(155)
                    .HasColumnName("StaffName");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(155)
                    .HasColumnName("customerName");

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .HasColumnName("customerPhone");

                entity.Property(e => e.Email)
                    .HasMaxLength(155)
                    .HasColumnName("email");

                entity.Property(e => e.TotalItem).HasColumnName("total_item");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Email");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK__OrderDet__8D19AE47420F8175");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(100)
                    .HasColumnName("order_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_OrderId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_ProductId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Characteristics).HasMaxLength(125);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("Date_created");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(150);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.QuantityAvailable).HasColumnName("Quantity_Available");

                entity.Property(e => e.QuantitySold).HasColumnName("Quantity_Sold");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Products__Catego__412EB0B6");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(50)
                    .HasColumnName("role_desc");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
