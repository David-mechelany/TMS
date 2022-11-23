using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TransportManagementSystem.Models;

#nullable disable

namespace TransportManagementSystem.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Filling> Fillings { get; set; }
        public virtual DbSet<Garage> Garages { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<LocalTransport> LocalTransports { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MaintComp> MaintComps { get; set; }
        public virtual DbSet<MaintPayment> MaintPayments { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderByPartner> OrderByPartners { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerTransport> PartnerTransports { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<TruckBrand> TruckBrands { get; set; }
        public virtual DbSet<TruckType> TruckTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J1VV5MG\\SQLEXPRESS;Database=Trans_db;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Discriminator).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Employee_Nationality");
            });

            modelBuilder.Entity<Filling>(entity =>
            {
                entity.HasOne(d => d.Station)
                    .WithMany(p => p.Fillings)
                    .HasForeignKey(d => d.StationId)
                    .HasConstraintName("FK_Filling_Station");

                entity.HasOne(d => d.TruckNumberNavigation)
                    .WithMany(p => p.Fillings)
                    .HasForeignKey(d => d.TruckNumber)
                    .HasConstraintName("FK_Filling_Truck");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("FK_Invoice_Garage");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Invoice_Partner");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.StationId)
                    .HasConstraintName("FK_Invoice_Station");
            });

            modelBuilder.Entity<LocalTransport>(entity =>
            {
                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.LocalTransports)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Trans_Employee");

                entity.HasOne(d => d.OrderByPartner)
                    .WithMany(p => p.LocalTransports)
                    .HasForeignKey(d => d.OrderByPartnerId)
                    .HasConstraintName("FK_LocalTransport_OrderByPartner");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.LocalTransports)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Trans_Order");

                entity.HasOne(d => d.TruckNumberNavigation)
                    .WithMany(p => p.LocalTransports)
                    .HasForeignKey(d => d.TruckNumber)
                    .HasConstraintName("FK_Trans_Truck");
            });

            modelBuilder.Entity<MaintComp>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ComponentId });

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.MaintComps)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintComp_Component");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.MaintComps)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintComp_Maintenance");
            });

            modelBuilder.Entity<MaintPayment>(entity =>
            {
                entity.HasOne(d => d.MidNavigation)
                    .WithMany(p => p.MaintPayments)
                    .HasForeignKey(d => d.Mid)
                    .HasConstraintName("FK_MaintPayment_Maintenance");
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.Maintenances)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("FK_Maintenance_Garage");

                entity.HasOne(d => d.TruckNumberNavigation)
                    .WithMany(p => p.Maintenances)
                    .HasForeignKey(d => d.TruckNumber)
                    .HasConstraintName("FK_Maintenance_Truck");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.Property(e => e.NationalityCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Order_Client");

                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .HasConstraintName("FK_Order_Invoice");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Order_Location");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Order_Product");
            });

            modelBuilder.Entity<OrderByPartner>(entity =>
            {
                entity.HasOne(d => d.Location)
                    .WithMany(p => p.OrderByPartners)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_PartnerOrder_Location");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.OrderByPartners)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_PartnerOrder_Partner");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderByPartners)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PartnerOrder_Product");
            });

            modelBuilder.Entity<PartnerTransport>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PartnerTransports)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_PartnerTransport_Order");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerTransports)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_PartnerTransport_Partner");
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.HasKey(e => e.TruckNumber)
                    .HasName("PK_Trucks");

                entity.HasOne(d => d.TruckBrand)
                    .WithMany(p => p.Trucks)
                    .HasForeignKey(d => d.TruckBrandId)
                    .HasConstraintName("FK_Truck_TruckBrand");
            });

            modelBuilder.Entity<TruckBrand>(entity =>
            {
                entity.HasOne(d => d.TruckType)
                    .WithMany(p => p.TruckBrands)
                    .HasForeignKey(d => d.TruckTypeId)
                    .HasConstraintName("FK_TruckBrand_TruckType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
