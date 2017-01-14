using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class DemontajFiskalnoUstroistvoCtrl
    {
        public static void AddDemontajFiskalno(DemontajNaFiskalnoUstroistvo demontaj)
        {

            using (var ctx = new FiscalSoftware())
            {
                
                ctx.DemontajNaFiskalnoUstroistvo.Add(demontaj);
                ctx.SaveChanges();

            }

        }
        public static void UpdateDemontajFiskalno(int id, DemontajNaFiskalnoUstroistvo demontaj)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.DemontajNaFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.DateDemontaj = demontaj.DateDemontaj;
                    original.FPNomer = demontaj.FPNomer;
                    original.Technician = demontaj.Technician;
                    original.OborotDo = demontaj.OborotDo;
                    original.OborotOt = demontaj.OborotOt;
                    original.Suma = demontaj.Suma;
                    original.DDS1 = demontaj.DDS1;
                    original.DDS2 = demontaj.DDS2;
                    original.DDS3 = demontaj.DDS3;
                    original.DDS4 = demontaj.DDS4;
                    original.InspectorName = demontaj.InspectorName;
                    original.InspectorTel = demontaj.InspectorTel;
                    original.Reasons = demontaj.Reasons;
                    original.OborotPoGodini = demontaj.OborotPoGodini;
                    original.FiscalID = demontaj.FiscalID;

                    ctx.SaveChanges();
                }
            }
        }
        public static DemontajNaFiskalnoUstroistvo GetDemontajFiskalnoUstroistvoById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var demontaj = ctx.DemontajNaFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();
                return demontaj;
            }
        }

        public static DemontajNaFiskalnoUstroistvo[] GetDemontajFiskalnoUstroistvaById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var demontaj = ctx.DemontajNaFiskalnoUstroistvo.Where(b => b.ID == id).ToArray();
                return demontaj;
            }
        }
        public static void DeleteDemontajFiskalnoUstroistvoById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var demontaj = ctx.DemontajNaFiskalnoUstroistvo.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (demontaj != null)
                {


                    ctx.DemontajNaFiskalnoUstroistvo.Remove(demontaj);
                    ctx.SaveChanges();


                }
            }

        }

    }
}
