using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class TechnicianCtrl
    {
        public static void AddTechnician(Technician technician)
        {

            technician.CompanyID = technician.CompanyID;
            technician.Name = technician.Name;
            technician.EGN = technician.EGN;
            technician.Telephone = technician.Telephone;
            using (var ctx = new FiscalSoftware())
            {
                ctx.Technicians.Add(technician);
                ctx.SaveChanges();
                Console.WriteLine("technician added");
            }
        }

        public static Technician[] GetAllTechnicianByCompany(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var technicians = ctx.Set<Technician>().Where(c => c.CompanyID == id).ToArray();
                return technicians;
            }
        }
        public static void UpdateTechnician(int id, Technician technician)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Technicians.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.CompanyID = technician.CompanyID;
                    original.Name = technician.Name;
                    original.EGN = technician.EGN;
                    original.Telephone = technician.Telephone;
                    ctx.SaveChanges();
                    Console.WriteLine("technician updated!");
                }
                else
                {
                    Console.WriteLine("cannot find technician");
                }
            }
        }
        public static Technician GetTechnicianById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var technician = ctx.Technicians.Where(b => b.ID == id)
                    .FirstOrDefault();
                var company = ctx.Companies.Where(c => c.ID == technician.CompanyID)
                    .FirstOrDefault();
                return technician;
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
        public static Technician[] GetAllTechnicians()
        {
            using (var ctx = new FiscalSoftware())
            {
                var technician = ctx.Set<Technician>().ToArray();
                return technician;
            }
        }
    }
}
