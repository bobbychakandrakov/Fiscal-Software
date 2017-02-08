using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    class OtherSetingsCtrl
    {
        public static void AddOtherSetings(OtherSetings os)
        {

            using (var ctx = new FiscalSoftware())
            {
                ctx.Othersetings.Add(os);
                ctx.SaveChanges();
               
            }

        }
        public static void UpdateOtherSetings(int id, OtherSetings os)
        {
            using (var ctx = new FiscalSoftware())
            {
                var original = ctx.Othersetings.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (original != null)
                {
                    original.ProcentDDS = os.ProcentDDS;
                    original.MRZ = os.MRZ;
                    original.Path = os.Path;
                    original.AvtomatichnoNomerirane = os.AvtomatichnoNomerirane;
                   
                    ctx.SaveChanges();
                }
            }
        }

        public static OtherSetings GetOtherSetingsId(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var os = ctx.Othersetings.Where(b => b.ID == id)
                    .FirstOrDefault();
                return os;
            }
        }
        public static void DeleteOtherSetongsById(int id)
        {
            using (var ctx = new FiscalSoftware())
            {
                var os = ctx.Othersetings.Where(b => b.ID == id)
                    .FirstOrDefault();

                if (os != null)
                {
                    ctx.Othersetings.Remove(os);
                }


                ctx.SaveChanges();


            }
        }


    }
}
