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
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<NomeraDokumenti> NomeraDokumenti { get; set; }
        public virtual DbSet<ContractFiscalDevices> ContractFiscalDevices { get; set; }
        public virtual DbSet<DanniFiskalnoUstroistvo> DanniFiskalnoUstroistvo { get; set; }
        public virtual DbSet<SvidetelstvoRegistraciq> SvidetelstvoRegistraciq { get; set; }

        public virtual DbSet<DemontajNaFiskalnoUstroistvo> DemontajNaFiskalnoUstroistvo { get; set; }
        public virtual DbSet<Remont> Remont { get; set; }
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
            modelBuilder.Entity<Objects>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Ekatte)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Town)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.TDD)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.Mol)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.MolTown)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.MolAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Objects>()
                .Property(e => e.MolTelephone)
                .IsUnicode(false);
            modelBuilder.Entity<Contract>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .Property(e => e.PaymentTo)
                .IsUnicode(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.MP3);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Programming);

            modelBuilder.Entity<Contract>()
                .Property(e => e.ProgrammingArticul);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Rabota);

            modelBuilder.Entity<Contract>()
                .Property(e => e.SpareParts);

            modelBuilder.Entity<Contract>()
                .Property(e => e.SpareModuls);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Protect);
               
            modelBuilder.Entity<Contract>()
                .Property(e => e.Duration);

            modelBuilder.Entity<Activities>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<NomeraDokumenti>()
              .Property(e => e.ContractN);

            modelBuilder.Entity<NomeraDokumenti>()
            .Property(e => e.Svidetelstvo);

            modelBuilder.Entity<ContractFiscalDevices>()
          .Property(e => e.AutomaticNumbering);

              modelBuilder.Entity<ContractFiscalDevices>()
          .Property(e => e.ContractN);

            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.DateFrom);

            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.DateTo);

            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.SumMonth);

            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.Sum);


            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.Valid);

            modelBuilder.Entity<ContractFiscalDevices>()
        .Property(e => e.Notes);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
       .Property(e => e.RegDate);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.SvidetelstvoN);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.Technician);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.Contract);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.RegNoNap);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.RegNoNapIzdaden);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.AutoNumbering);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.Notes);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.PrietObs);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.PrekratenoObs);

            modelBuilder.Entity<SvidetelstvoRegistraciq>()
     .Property(e => e.Reason);
            modelBuilder.Entity<Remont>()
  .Property(e => e.ChastiPriRemont);
            modelBuilder.Entity<Remont>()
.Property(e => e.OpisanieDefekt);
            modelBuilder.Entity<Remont>()
.Property(e => e.PrietV);
            modelBuilder.Entity<Remont>()
.Property(e => e.Tehnik);
            modelBuilder.Entity<Remont>()
.Property(e => e.VurnatNa);
            modelBuilder.Entity<Remont>()
.Property(e => e.ZaqvkaZadadena);
            modelBuilder.Entity<Remont>()
.Property(e => e.FiscalDeviceID);




        }
    }
}
