using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class PlashtaniqCtrl
    {
        public static void AddPlashtaniq(Plashtaniq p)
        {


            using (var ctx = new FiscalSoftware())
            {
                ctx.Plashtaniq.Add(p);
                ctx.SaveChanges();
            }
        }

        public static Plashtaniq[] GetAll(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var p = ctx.Plashtaniq.Where(pa => pa.DogovorID == id).ToArray();
                return p;
            }
        }

        public static void UpdatePlashtaniq(int id, Plashtaniq p)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Plashtaniq.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {

                    original.DogovorID = p.DogovorID;
                    original.DataDo = p.DataDo;
                    original.DataNa = p.DataNa;
                    original.Suma = p.Suma;
                    original.Notes = p.Notes;


                    ctx.SaveChanges();

                }
                else
                {
                    Console.WriteLine("cannot find Plashtaniq");
                }
            }
        }
        public static Plashtaniq GetPlashtane(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var p = ctx.Plashtaniq.Where(b => b.ID == id)
                    .FirstOrDefault();


                return p;
            }
        }
        public static void DeletePlashtane(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var p = ctx.Plashtaniq.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (p != null)
                {
                    ctx.Plashtaniq.Remove(p);
                }


                ctx.SaveChanges();


            }
        }

    }
}
