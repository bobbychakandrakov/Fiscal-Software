using Fiscal_Software.Controllers;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal_Software.Forms
{
    public partial class PrintDemontaj : Form
    {
        DanniFiskalnoUstroistvo danni;
        DemontajNaFiskalnoUstroistvo demontaj;
        public PrintDemontaj()
        {
            InitializeComponent();
        }

        public PrintDemontaj(DanniFiskalnoUstroistvo danni, DemontajNaFiskalnoUstroistvo demontaj)
        {
            InitializeComponent();
            this.danni = danni;
            this.demontaj = demontaj;
        }

        private void PrintDemontaj_Load(object sender, EventArgs e)
        {
            var company = CompanyCtrl.GetCompanyById(danni.Serviz);
            ReportParameter datetime = new ReportParameter("datetime", DateTime.Now.ToShortDateString() + " в " + DateTime.Now.ToShortTimeString() + " ч.,");
            ReportParameter identNomer = new ReportParameter("identNomer", " ");
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", company.Name);
            ReportParameter PredstavlqvanOt = new ReportParameter("PredstavlqvanOt", company.Mol);
            ReportParameter TurgovskiObekt = new ReportParameter("TurgovskiObekt", ObjectCtrl.GetObjectById(danni.Obekt).Type);
            ReportParameter PlombiranOt = new ReportParameter("PlombiranOt", CompanyCtrl.GetCompanyById(danni.Serviz).Name);
            ReportParameter BimNomer = new ReportParameter("BimNomer", " ");
            ReportParameter Dopk = new ReportParameter("Dopk", " ");
            ReportParameter Fu = new ReportParameter("Fu", danni.FYNomer);
            ReportParameter Fp = new ReportParameter("Fp", danni.FPNomer);
            ReportParameter Fdrid = new ReportParameter("Fdrid", "");
            ReportParameter PrichinaDemontaj = new ReportParameter("PrichinaDemontaj", demontaj.Reasons);
            ReportParameter ot = new ReportParameter("ot", demontaj.OborotOt.ToString());
            ReportParameter Do = new ReportParameter("do", demontaj.OborotDo.ToString());
            ReportParameter suma = new ReportParameter("suma", demontaj.Suma.ToString());
            ReportParameter DDsA = new ReportParameter("DDsA", demontaj.DDS1.ToString());
            ReportParameter DDsB = new ReportParameter("DDsB", demontaj.DDS2.ToString());
            ReportParameter DDsV = new ReportParameter("DDsV", demontaj.DDS3.ToString());
            ReportParameter DDsG = new ReportParameter("DDsG", demontaj.DDS4.ToString());
            ReportParameter serviznaFirma = new ReportParameter("serviznaFirma", company.Name);
            ReportParameter Dopk2 = new ReportParameter("Dopk2", " ");
            ReportParameter predstavitel = new ReportParameter("predstavitel", demontaj.InspectorName);
            ReportParameter grad = new ReportParameter("grad", " ");
            ReportParameter data = new ReportParameter("data", " ");
            ReportParameter sobstvenik = new ReportParameter("sobstvenik", company.Mol);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
       {
              datetime,
              identNomer,
              sobstvenostNa,
              PredstavlqvanOt,
              TurgovskiObekt,
              PlombiranOt,
              Dopk,
              Fu,
              Fp,
              Fdrid,
              PrichinaDemontaj,
              ot,
              Do,
              suma,
              DDsA,
              DDsB,
              DDsV,
              DDsG,
              serviznaFirma,
              Dopk2,
              predstavitel,
              grad,
              data,
              sobstvenik

       }
       );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
