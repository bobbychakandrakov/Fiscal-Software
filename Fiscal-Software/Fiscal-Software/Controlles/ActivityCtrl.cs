using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class ActivityCtrl
    {
        public static Activities[] GetAllActivities()
        {
            using (var ctx = new FiscalSoftware())
            {
                var activity = ctx.Set<Activities>().ToArray();
                return activity;
            }
        }
    }
}
