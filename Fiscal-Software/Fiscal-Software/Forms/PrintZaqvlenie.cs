using System;
using Microsoft.Reporting.WinForms;
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
    public partial class PrintZaqvlenie : Form
    {
        public PrintZaqvlenie()
        {
            InitializeComponent();
        }

        private void PrintZaqvlenie_Load(object sender, EventArgs e)
        {
            ReportParameter naFirma = new ReportParameter("naFirma", "");
            ReportParameter DOPK = new ReportParameter("DOPK", "");
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", "");
            ReportParameter obekt = new ReportParameter("obekt", "");
            ReportParameter vidDeinost = new ReportParameter("vidDeinost", "");
            ReportParameter modelFY = new ReportParameter("modelFY", "");
            ReportParameter NomerFY = new ReportParameter("NomerFY", "");
            ReportParameter NomerFP = new ReportParameter("NomerFP", "");
            ReportParameter ServiznaFirma = new ReportParameter("ServiznaFirma", "");
            ReportParameter ServizenDogovor = new ReportParameter("ServizenDogovor", "");
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter ServizenTexnik = new ReportParameter("ServizenTexnik", "");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                   {
                       naFirma,
                       DOPK,
                       sobstvenostNa,
                       obekt,
                       vidDeinost,
                       modelFY,
                       NomerFY,
                       NomerFP,
                       ServiznaFirma,
                       ServizenDogovor,
                       TodayDate,
                       ServizenTexnik
                   }
            );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
