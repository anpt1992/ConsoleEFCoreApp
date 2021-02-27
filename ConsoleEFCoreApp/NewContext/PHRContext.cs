using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConsoleEFCoreApp.PHR_Models;

#nullable disable

namespace ConsoleEFCoreApp.NewContext
{
    public partial class PHRContext : DbContext
    {
        public PHRContext()
        {
        }

        public PHRContext(DbContextOptions<PHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Advertise> Advertises { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Districtwardstreet> Districtwardstreets { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Structure> Structures { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=phr;user=root;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("10.4.11-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Role)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Advertise>(entity =>
            {
                entity.ToTable("advertise");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.ToTable("direction");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("district");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Prefix)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Districtwardstreet>(entity =>
            {
                entity.ToTable("districtwardstreet");

                entity.HasIndex(e => e.DistrictId, "IX_DistrictWardStreet_DistrictId");

                entity.HasIndex(e => e.StreetId, "IX_DistrictWardStreet_StreetId");

                entity.HasIndex(e => e.WardId, "IX_DistrictWardStreet_WardId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DistrictId).HasColumnType("int(11)");

                entity.Property(e => e.StreetId).HasColumnType("int(11)");

                entity.Property(e => e.WardId).HasColumnType("int(11)");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Districtwardstreets)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_DistrictWardStreet_District_DistrictId");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Districtwardstreets)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_DistrictWardStreet_Street_StreetId");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.Districtwardstreets)
                    .HasForeignKey(d => d.WardId)
                    .HasConstraintName("FK_DistrictWardStreet_Ward_WardId");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("note");

                entity.HasIndex(e => e.CreatedBy, "IX_Note_CreatedBy");

                entity.HasIndex(e => e.ProductId, "IX_Note_ProductId");

                entity.HasIndex(e => e.TaskId, "IX_Note_TaskId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedAt)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("current_timestamp(6)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.Detail)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProductId).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskId).HasColumnType("int(11)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Note_Account_CreatedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Note_Product_ProductId");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Note_Task_TaskId");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("price");

                entity.HasIndex(e => e.ProductId, "IX_Price_ProductId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("current_timestamp(6)");

                entity.Property(e => e.ProductId).HasColumnType("bigint(20)");

                entity.Property(e => e.Value).HasColumnType("bigint(20)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Price_Product_ProductId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasIndex(e => e.AdvertiseId, "IX_Product_AdvertiseId");

                entity.HasIndex(e => e.CategoryId, "IX_Product_CategoryId");

                entity.HasIndex(e => e.CreatedBy, "IX_Product_CreatedBy");

                entity.HasIndex(e => e.DirectionId, "IX_Product_DirectionId");

                entity.HasIndex(e => e.DistrictId, "IX_Product_DistrictId");

                entity.HasIndex(e => e.StatusId, "IX_Product_StatusId");

                entity.HasIndex(e => e.StreetId, "IX_Product_StreetId");

                entity.HasIndex(e => e.StructureId, "IX_Product_StructureId");

                entity.HasIndex(e => e.WardId, "IX_Product_WardId");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.AdvertiseId).HasColumnType("int(11)");

                entity.Property(e => e.Area)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AreaCalc)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContactName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContactPhone)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreatedAt)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("current_timestamp(6)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.DirectionId).HasColumnType("int(11)");

                entity.Property(e => e.DistrictId).HasColumnType("int(11)");

                entity.Property(e => e.GoogleDriveUrl)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HouseNumber)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StatusId).HasColumnType("int(11)");

                entity.Property(e => e.StreetId).HasColumnType("int(11)");

                entity.Property(e => e.StructureId).HasColumnType("int(11)");

                entity.Property(e => e.WardId).HasColumnType("int(11)");

                entity.HasOne(d => d.Advertise)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.AdvertiseId)
                    .HasConstraintName("FK_Product_Advertise_AdvertiseId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category_CategoryId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Product_Account_CreatedBy");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_Product_Direction_DirectionId");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Product_District_DistrictId");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Product_Status_StatusId");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_Product_Street_StreetId");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StructureId)
                    .HasConstraintName("FK_Product_Structure_StructureId");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.WardId)
                    .HasConstraintName("FK_Product_Ward_WardId");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.ToTable("street");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Structure>(entity =>
            {
                entity.ToTable("structure");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("task");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("ward");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
