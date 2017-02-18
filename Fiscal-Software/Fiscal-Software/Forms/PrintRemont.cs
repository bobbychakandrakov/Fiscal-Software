using Fiscal_Software.Controllers;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Fiscal_Software.Forms
{
    public partial class PrintRemont : Form
    {
        Remont remont;
        DanniFiskalnoUstroistvo dfu;
        public PrintRemont()
        {
            InitializeComponent();
        }

        public PrintRemont(Remont remont, DanniFiskalnoUstroistvo dfu)
        {
            InitializeComponent();
            this.remont = remont;
            this.dfu = dfu;
            MessageBox.Show("1Test");
        }

        private void PrintRemont_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToString());
            var serviz = CompanyCtrl.GetCompanyById(dfu.Serviz);
            ReportParameter CompnayName = new ReportParameter("CompnayName", serviz.Name);
            ReportParameter MOL = new ReportParameter("MOL", serviz.Mol);
            var klient = ClientCtrl.GetClient(ObjectCtrl.GetObjectById(dfu.Obekt).ID);
            ReportParameter SobstvenostNa = new ReportParameter("SobstvenostNa", klient.Name);
            ReportParameter Name = new ReportParameter("Name", klient.Mol);
            ReportParameter KonstatiranePovreda = new ReportParameter("KonstatiranePovreda", remont.ZaqvkaZadadena.ToString());
            ReportParameter PodavaneZaqvka = new ReportParameter("PodavaneZaqvka", remont.PrietV.ToString());
            ReportParameter VarnatNa = new ReportParameter("VarnatNa", remont.VurnatNa.ToString());
            ReportParameter OpisaniePovreda = new ReportParameter("OpisaniePovreda", remont.OpisanieDefekt);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               TodayDate,
               CompnayName,
               MOL,
               SobstvenostNa,
               Name,
               KonstatiranePovreda,
               PodavaneZaqvka,
               VarnatNa,
               OpisaniePovreda

          }
          );

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
