using Fiscal_Software;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class CompanyCtrl
    {
        public static void AddCompany(Company company)
        {
           
            using (var ctx = new FiscalSoftware())
            {
                ctx.Companies.Add(company);
                ctx.SaveChanges();
                Console.WriteLine("Company added");
            }

        }
        public static void UpdateCompany(int id, Company company)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Companies.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Name = company.Name;
                    original.Bulstat = company.Bulstat;
                    original.Town = company.Town;
                    original.Address = company.Address;
                    original.Mol = company.Mol;
                    original.CertificateN = company.CertificateN;
                    original.DanNumber = company.DanNumber;
                    original.Email = company.Email;
                    original.Fax = company.Fax;
                    original.FDDate = company.FDDate;
                    original.FDNumber = company.FDNumber;
                    original.FDTown = company.FDTown;
                    original.Telephone = company.Telephone;
                    original.Web = company.Web;
                    ctx.SaveChanges();
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

        public static Company[] GetAllCompanies()
        {
            using (var ctx = new FiscalSoftware())
            {
                var company = ctx.Set<Company>().ToArray();
                return company;
            }
        }
        public static int GetCompanyByName(string name)
        {
            using (var ctx = new FiscalSoftware())
            {
                var company = ctx.Companies.Where(b => b.Name == name)
                    .FirstOrDefault();
                return company.ID;
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
