using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class RemontCtrl
    {
        public static void AddRemont(Remont remont)
        {

            using (var ctx = new FiscalSoftware())
            {
                ctx.Remont.Add(remont);
                ctx.SaveChanges();

            }

        }

        public static void UpdateRemont(int id, Remont remont)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Remont.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.PrietV = remont.PrietV;
                    original.ZaqvkaZadadena = remont.ZaqvkaZadadena;
                    original.Tehnik = remont.Tehnik;
                    original.OpisanieDefekt = remont.OpisanieDefekt;
                    original.VurnatNa = remont.VurnatNa;
                    original.ChastiPriRemont = remont.ChastiPriRemont;

                    ctx.SaveChanges();
                }
            }
        }
        public static Remont GetRemontById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var remont = ctx.Remont.Where(b => b.ID == id)
                    .FirstOrDefault();
                return remont;
            }
        }

        public static Remont[] GetRemontsById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var remont = ctx.Remont.Where(b => b.ID == id).ToArray();
                return remont;
            }
        }
        public static void DeleteRemontById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var remont = ctx.Remont.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (remont != null)
                {


                    ctx.Remont.Remove(remont);
                    ctx.SaveChanges();


                }
            }


        }
    }
}
