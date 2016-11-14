namespace Fiscal_Software
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FiscalSoftware : DbContext
    {
        public FiscalSoftware()
            : base("name=FiscalSoftware")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<FiscalDevice> FiscalDevices { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Technician> Technicians { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.DN)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Bulstat)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.FDTown)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.FDNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.TDD)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Town)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Mol)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MolTown)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MolAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MolTelephone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.MolEGN)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.DanNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Bulstat)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.FDTown)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.FDNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Town)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Mol)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Technicians)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FiscalDevice>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<FiscalDevice>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<FiscalDevice>()
                .Property(e => e.Manufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<FiscalDevice>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FiscalDevice>()
                .Property(e => e.BulstatManufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<Technician>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Technician>()
                .Property(e => e.EGN)
                .IsFixedLength();

            modelBuilder.Entity<Technician>()
                .Property(e => e.Telephone)
                .IsUnicode(false);
        }
    }
}
