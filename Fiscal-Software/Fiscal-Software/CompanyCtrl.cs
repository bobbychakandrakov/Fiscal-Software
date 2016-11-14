using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class CompanyCtrl
    {
        public static void AddCompany(string Name, string Bulstat, string Town, string Address, string Mol, string Telephone, string Fax, string Email, string Web, string FDTown, DateTime FDDate, string FDNumber, int CertificateN, string DanNumber)
        {
            Company company = new Company();
            company.Name = Name;
            company.Bulstat = Bulstat;
            company.Town = Town;
            company.Address = Address;
            company.Mol = Mol;
            company.CertificateN = CertificateN;
            company.DanNumber = DanNumber;
            company.Email = Email;
            company.Fax = Fax;
            company.FDDate = FDDate;
            company.FDNumber = FDNumber;
            company.FDTown = FDTown;
            company.Telephone = Telephone;
            company.Web = Web;
            using (var ctx = new FiscalSoftware())
            {
                ctx.Companies.Add(company);
                ctx.SaveChanges();
                Console.WriteLine("Company added");
            }

        }
        public static void UpdateCompany(int id, string Name, string Bulstat, string Town, string Address, string Mol, string Telephone, string Fax, string Email, string Web, string FDTown, DateTime FDDate, string FDNumber, int CertificateN, string DanNumber)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Companies.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Name = Name;
                    original.Bulstat = Bulstat;
                    original.Town = Town;
                    original.Address = Address;
                    original.Mol = Mol;
                    original.CertificateN = CertificateN;
                    original.DanNumber = DanNumber;
                    original.Email = Email;
                    original.Fax = Fax;
                    original.FDDate = FDDate;
                    original.FDNumber = FDNumber;
                    original.FDTown = FDTown;
                    original.Telephone = Telephone;
                    original.Web = Web;
                    ctx.SaveChanges();
                    Console.WriteLine("company updated!");
                }
                else
                {
                    Console.WriteLine("cannot find company");
                }
            }
        }
        public static Company GetCompanyById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var company = ctx.Companies.Where(b => b.ID == id)
                    .FirstOrDefault();
                return company;
            }
        }

        public static void DeleteCompanyById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var company = ctx.Companies.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (company != null)
                {
                    ctx.Companies.Remove(company);
                    ctx.SaveChanges();
                    Console.WriteLine("company was deleted!");
                }
            }


        }
    }
}
