using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class DanniFiskalnoUstroistvoCtrl
    {
        public static void AddDanniFiskalnoUstroistvo(DanniFiskalnoUstroistvo danni)
        {

            using (var ctx = new FiscalSoftware())
            {
                ctx.DanniFiskalnoUstroistvo.Add(danni);
                ctx.SaveChanges();

            }

        }
        public static DanniFiskalnoUstroistvo[] GetDanniFromObject(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo.Where(b => b.Obekt == id).ToArray();
                return danni;
            }
        }
        public static void UpdateDanniFiskalnoUstroistvo(int id, DanniFiskalnoUstroistvo danni)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.DanniFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.Serviz = danni.Serviz;
                    original.Obekt = danni.Obekt;
                    original.ModelFY = danni.ModelFY;
                    original.FYNomer = danni.FYNomer;
                    original.FPNomer = danni.FPNomer;
                    original.FPAktivirana = danni.FPAktivirana;
                    original.FPDeaktivirana = danni.FPDeaktivirana;
                    original.GuaranteeUntil = danni.GuaranteeUntil;
                    original.PayedSim = danni.PayedSim;
                    original.RegNoNap = danni.RegNoNap;
                    original.RegNapDate = danni.RegNapDate;
                    original.SimID = danni.SimID;
                    original.SimTelNomer = danni.SimTelNomer;
                    original.Nivomer = danni.Nivomer;
                    original.ModelESFP = danni.ModelESFP;
                    original.ESFPT = danni.ESFPT;
                    original.Company = danni.Company;
                    original.Town = danni.Town;
                    original.Technician = danni.Technician;
                    original.Address = danni.Address;
                    original.Tel = danni.Tel;
                    original.RegDate = danni.RegDate;
                    original.FiscalID = danni.FiscalID;
                    ctx.SaveChanges();
                }
            }
        }
        public static DanniFiskalnoUstroistvo GetDanniFiskalnoUstroistvoById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();
                return danni;
            }
        }
        public static void DeleteDanniFiskalnoUstroistvoById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (danni != null)
                {


                    ctx.DanniFiskalnoUstroistvo.Remove(danni);
                    ctx.SaveChanges();


                }
            }


        }

        public static DanniFiskalnoUstroistvo[] GetIztichashtiSim(int firma, DateTime fromDate, DateTime toDate)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo
                    .Where(b => b.PayedSim.Value >= fromDate 
                        && b.PayedSim.Value <= toDate 
                        && b.Serviz == firma).ToArray();
                return danni;
            }
        }

        public static DanniFiskalnoUstroistvo[] GetByModel(int model)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo
                    .Where(b => b.ModelFY == model).ToArray();
                return danni;
            }
        }

        public static DanniFiskalnoUstroistvo[] GetByServiz(int serviz)
        {
            using (var ctx = new FiscalSoftware())
            {
                var danni = ctx.DanniFiskalnoUstroistvo
                    .Where(b => b.Serviz == serviz).ToArray();
                return danni;
            }
        }

    }
}
