using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Domain;

namespace ProductCatalogAPI.Data
{
    public class CatalogContext: DbContext
    {
        public CatalogContext(DbContextOptions options) : base(options)
        { }

        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogItem> Catalog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogType>(e =>
            {
                e.Property(t => t.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                e.Property(t => t.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatalogBrand>(e =>
            {
                e.Property(b => b.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                e.Property(b => b.Brand)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatalogItem>(e =>
            {
                e.Property(c => c.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                e.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                e.Property(c => c.Price)
                    .IsRequired();

                e.HasOne(t => t.CatalogType)
                    .WithMany()
                    .HasForeignKey(t => t.CatalogTypeId);

                e.HasOne(t => t.CatalogBrand)
                    .WithMany()
                    .HasForeignKey(t => t.CatalogBrandId);

            });
        }

    }
}
