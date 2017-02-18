using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Fiscal_Software.Forms
{
    public partial class PrintRemont : Form
    {
        public PrintRemont()
        {
            InitializeComponent();
        }

        private void PrintRemont_Load(object sender, EventArgs e)
        {
            ReportParameter TodayDate = new ReportParameter("TodayDate", " ");
            ReportParameter CompnayName = new ReportParameter("CompnayName", " ");
            ReportParameter MOL = new ReportParameter("MOL", " ");
            ReportParameter SobstvenostNa = new ReportParameter("SobstvenostNa", " ");
            ReportParameter Name = new ReportParameter("Name", " ");
            ReportParameter KonstatiranePovreda = new ReportParameter("KonstatiranePovreda", " ");
            ReportParameter PodavaneZaqvka = new ReportParameter("PodavaneZaqvka", " ");
            ReportParameter VarnatNa = new ReportParameter("VarnatNa", " ");
            ReportParameter OpisaniePovreda = new ReportParameter("OpisaniePovreda", " ");

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
            this.reportViewer1.ProcessingMode =
    Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "Reports/RemontProtokol.rdlc";
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
