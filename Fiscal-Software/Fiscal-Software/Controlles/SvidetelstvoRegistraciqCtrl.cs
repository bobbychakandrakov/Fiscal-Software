using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class SvidetelstvoRegistraciqCtrl
    {
        public static void AddSvidetelstvoRegistraciq(SvidetelstvoRegistraciq svidetelstvo)
        {

            using (var ctx = new FiscalSoftware())
            {
                ctx.SvidetelstvoRegistraciq.Add(svidetelstvo);
                ctx.SaveChanges();
              
            }

        }
        public static void UpdateSvidetelstvoRegistraciq(int id, SvidetelstvoRegistraciq svidetelstvo)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.SvidetelstvoRegistraciq.Where(b => b.id == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.RegDate = svidetelstvo.RegDate;
                    original.SvidetelstvoN = svidetelstvo.SvidetelstvoN;
                    original.Technician = svidetelstvo.Technician;
                    original.Contract = svidetelstvo.Contract;
                    original.RegNoNap = svidetelstvo.RegNoNap;
                    original.RegNoNapIzdaden = svidetelstvo.RegNoNapIzdaden;
                    original.AutoNumbering = svidetelstvo.AutoNumbering;
                    original.Notes = svidetelstvo.Notes;
                    original.PrietObs = svidetelstvo.PrietObs;
                    original.PrekratenoObs = svidetelstvo.PrekratenoObs;
                    original.Reason = svidetelstvo.Reason;
                    ctx.SaveChanges();
                }
            }
        }
        public static SvidetelstvoRegistraciq GetSvidetelstvoRegistraciqById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var svidetelstvo= ctx.SvidetelstvoRegistraciq.Where(b => b.id == id)
                    .FirstOrDefault();
                return svidetelstvo;
            }
        }
        public static void DeleteSvidetelstvoRegistraciqById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var svidetelstvo = ctx.SvidetelstvoRegistraciq.Where(b => b.id == id)
                    .FirstOrDefault();

                if (svidetelstvo != null)
                {
                   

                    ctx.SvidetelstvoRegistraciq.Remove(svidetelstvo);
                    ctx.SaveChanges();


                }
            }


        }
    }
}
