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
        public PrintDemontaj()
        {
            InitializeComponent();
        }

        private void PrintDemontaj_Load(object sender, EventArgs e)
        {
            ReportParameter datetime = new ReportParameter("datetime", " ");
            ReportParameter identNomer = new ReportParameter("identNomer", " ");
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", " ");
            ReportParameter PredstavlqvanOt = new ReportParameter("PredstavlqvanOt", " ");
            ReportParameter TurgovskiObekt = new ReportParameter("TurgovskiObekt", " ");
            ReportParameter PlombiranOt = new ReportParameter("PlombiranOt", " ");
            ReportParameter BimNomer = new ReportParameter("BimNomer", " ");
            ReportParameter Dopk = new ReportParameter("Dopk", " ");
            ReportParameter Fu = new ReportParameter("Fu", " ");
            ReportParameter Fp = new ReportParameter("Fp", " ");
            ReportParameter Fdrid = new ReportParameter("Fdrid", " ");
            ReportParameter PrichinaDemontaj = new ReportParameter("PrichinaDemontaj", " ");
            ReportParameter ot = new ReportParameter("ot", " ");
            ReportParameter Do = new ReportParameter("do", " ");
            ReportParameter suma = new ReportParameter("suma", " ");
            ReportParameter DDsA = new ReportParameter("DDsA", " ");
            ReportParameter DDsB = new ReportParameter("DDsB", " ");
            ReportParameter DDsV = new ReportParameter("DDsV", " ");
            ReportParameter DDsG = new ReportParameter("DDsG", " ");
            ReportParameter serviznaFirma = new ReportParameter("serviznaFirma", " ");
            ReportParameter Dopk2 = new ReportParameter("Dopk2", " ");
            ReportParameter predstavitel = new ReportParameter("predstavitel", " ");
            ReportParameter grad = new ReportParameter("grad", " ");
            ReportParameter data = new ReportParameter("data", " ");
            ReportParameter sobstvenik = new ReportParameter("sobstvenik", " ");

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
