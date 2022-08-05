using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BranchesApi.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchesRef> BranchesRefs { get; set; }
        public virtual DbSet<CitiesRef> CitiesRefs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CountriesRef> CountriesRefs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<DistrictsRef> DistrictsRefs { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RegionsRef> RegionsRefs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6IQN98I;Database=Test;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchNo)
                    .HasName("PK_Branchesn");

                entity.Property(e => e.VatReg).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CityNoNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CityNo)
                    .HasConstraintName("FK_Branches_Cities");

                entity.HasOne(d => d.CountryNoNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CountryNo)
                    .HasConstraintName("FK_Branches_Countries");

                entity.HasOne(d => d.DistrictNoNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.DistrictNo)
                    .HasConstraintName("FK_Branches_Districts");

                entity.HasOne(d => d.RegionNoNavigation)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.RegionNo)
                    .HasConstraintName("FK_Branches_Regions");
            });

            modelBuilder.Entity<BranchesRef>(entity =>
            {
                entity.HasKey(e => e.OpNo)
                    .HasName("PK_Branches_Ref_1");
            });

            modelBuilder.Entity<CitiesRef>(entity =>
            {
                entity.HasKey(e => e.OpNo)
                    .HasName("PK_Cities_Ref_1");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityNo).ValueGeneratedNever();

                entity.HasOne(d => d.RegionNoNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.RegionNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_Regions");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryNo)
                    .HasName("PK_Countries_1");

                entity.Property(e => e.CountryNo).ValueGeneratedNever();
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictNo).ValueGeneratedNever();

                entity.HasOne(d => d.CityNoNavigation)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Districts_Cities");
            });

            modelBuilder.Entity<DistrictsRef>(entity =>
            {
                entity.HasKey(e => e.OpNo)
                    .HasName("PK_Districts_REF_1");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionNo)
                    .HasName("PK_region");

                entity.Property(e => e.RegionNo).ValueGeneratedNever();

                entity.HasOne(d => d.CountryNoNavigation)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.CountryNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions_Countries");
            });

            modelBuilder.Entity<RegionsRef>(entity =>
            {
                entity.HasKey(e => e.OpNo)
                    .HasName("PK_Area_Ref");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
