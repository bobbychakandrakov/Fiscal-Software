using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software
{
    class TechnicianCtrl
    {
        public static void AddTechnician(int CompanyId, string Name, string EGN, string Telephone)
        {
            Technician technician = new Technician();
            technician.CompanyID = CompanyId;
            technician.Name = Name;
            technician.EGN = EGN;
            technician.Telephone = Telephone;
            using (var ctx = new FiscalSoftware())
            {
                ctx.Technicians.Add(technician);
                ctx.SaveChanges();
                Console.WriteLine("technician added");
            }
        }
        public static void UpdateTechnician(int id, int CompanyId, string Name, string EGN, string Telephone)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Technicians.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.CompanyID = CompanyId;
                    original.Name = Name;
                    original.EGN = EGN;
                    original.Telephone = Telephone;
                    ctx.SaveChanges();
                    Console.WriteLine("technician updated!");
                }
                else
                {
                    Console.WriteLine("cannot find technician");
                }
            }
        }
        public static void GetTechnicianById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var technician = ctx.Technicians.Where(b => b.ID == id)
                    .FirstOrDefault();
                var company = ctx.Companies.Where(c => c.ID == technician.CompanyID)
                    .FirstOrDefault();

                Console.WriteLine(
                    technician.Name + " " +
                    technician.Telephone + " " +
                    technician.EGN + " " +
                    company.ID + " " +
                    company.Name + " " +
                    company.Town + " " +
                    company.Bulstat + " " +
                    company.Address + " " +
                    company.Mol
                   );
            }
        }
        public static void DeleteTechnicianById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var technician = ctx.Technicians.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (technician != null)
                {
                    ctx.Technicians.Remove(technician);
                    ctx.SaveChanges();
                    Console.WriteLine("technician was deleted!");
                }
            }
        }
    }
}
