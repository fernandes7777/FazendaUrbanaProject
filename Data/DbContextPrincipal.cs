using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FazendaUrbana.Forms.Model.Data
{
    public class DbContextPrincipal : IdentityDbContext<User>
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<SupplierInput> SupplierInputs { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductionProduct> ProductionProducts { get; set; }
        public DbSet<ProductionInput> ProductionInputs { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<SupplierCertificate> SupplierCertificates { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public override DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SupplierInput>()
            .HasKey(si => new { si.SupplierId, si.InputId });

            modelBuilder.Entity<SupplierInput>()
                .HasOne(si => si.Supplier)
                .WithMany(s => s.SupplierInputs)
                .HasForeignKey(si => si.SupplierId);

            modelBuilder.Entity<SupplierInput>()
                .HasOne(si => si.Input)
                .WithMany(i => i.SupplierInputs)
                .HasForeignKey(si => si.InputId);

            modelBuilder.Entity<ProductionProduct>()
                .HasKey(pp => new { pp.ProductionId, pp.ProductId });

            modelBuilder.Entity<ProductionProduct>()
                .HasOne(pp => pp.Production)
                .WithMany(p => p.ProductionProducts)
                .HasForeignKey(pp => pp.ProductionId);

            modelBuilder.Entity<ProductionProduct>()
                .HasOne(pp => pp.Product)
                .WithMany(p => p.ProductionProducts)
                .HasForeignKey(pp => pp.ProductId);

            modelBuilder.Entity<ProductionInput>()
                .HasKey(pi => new { pi.ProductionId, pi.InputId });

            modelBuilder.Entity<ProductionInput>()
                .HasOne(pi => pi.Production)
                .WithMany(p => p.ProductionInputs)
                .HasForeignKey(pi => pi.ProductionId);

            modelBuilder.Entity<ProductionInput>()
                .HasOne(pi => pi.Input)
                .WithMany(i => i.ProductionInputs)
                .HasForeignKey(pi => pi.InputId);

            modelBuilder.Entity<SupplierCertificate>()
                .HasKey(sc => new { sc.SupplierId, sc.CertificateId });

            modelBuilder.Entity<SupplierCertificate>()
                .HasOne(sc => sc.Supplier)
                .WithMany(s => s.SupplierCertificates)
                .HasForeignKey(sc => sc.SupplierId);

            modelBuilder.Entity<SupplierCertificate>()
                .HasOne(sc => sc.Certificate)
                .WithMany(c => c.SupplierCertificates)
                .HasForeignKey(sc => sc.CertificateId);

            modelBuilder.Entity<Supplier>()
                .HasOne(s => s.Address)
                .WithMany(a => a.Suppliers)
                .HasForeignKey(s => s.AddressId);

            modelBuilder.Entity<Supplier>()
                .HasOne(s => s.Contact)
                .WithMany(c => c.Suppliers)
                .HasForeignKey(s => s.ContactId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Product)
                .WithMany(s => s.Sales)
                .HasForeignKey(s => s.ProductId);

            modelBuilder.Entity<Product>()
                .Property(s => s.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .Property(s => s.TotalPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProductionProduct>()
                .Property(s => s.TotalPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SupplierInput>()
                .Property(s => s.PurchasePrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}
