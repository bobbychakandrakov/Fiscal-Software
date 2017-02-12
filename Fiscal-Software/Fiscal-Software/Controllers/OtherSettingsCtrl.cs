using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controllers
{
    public static class OtherSettingsCtrl
    {
        public static void Add(OtherSetings os)
        {
            using (var ctx = new FiscalSoftware())
            {
                ctx.Othersetings.Add(os);
                ctx.SaveChanges();
            }
        }

        public static OtherSetings Get()
        {
            using (var ctx = new FiscalSoftware())
            {
                var os = ctx.Othersetings.OrderByDescending(p => p.ID).FirstOrDefault();
                return os;
            }
        }
    }
}
