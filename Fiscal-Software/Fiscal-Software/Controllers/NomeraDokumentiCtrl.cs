using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Controlles
{
    class NomeraDokumentiCtrl
    {
        public static void AddNomeraDocument(NomeraDokumenti nomeraDokument)
        {


            using (var ctx = new FiscalSoftware())
            {
                ctx.NomeraDokumenti.Add(nomeraDokument);
                ctx.SaveChanges();
            }
        }
        public static NomeraDokumenti GetNomerDokument()
        {
            using (var ctx = new FiscalSoftware())
            {
                NomeraDokumenti[] nomerDokument = ctx.NomeraDokumenti.Where(b => b.ID > -1).ToArray();
                if (nomerDokument.Length == 0)
                {
                    var newDok = new NomeraDokumenti();
                    newDok.ContractN = 0;
                    newDok.Svidetelstvo = 0;
                    return newDok;
                }
                return nomerDokument[nomerDokument.Length - 1];
            }
        }
    }
}
