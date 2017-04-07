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

namespace Fiscal_Software.SpravkiForm
{
    public partial class DogovoriSpravkaForm : Form
    {
        int firma;
        DateTime fromDate, toDate;
        public DogovoriSpravkaForm()
        {
            InitializeComponent();
        }
        public DogovoriSpravkaForm(int firma, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.firma = firma;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }


        private void DogovoriSpravkaForm_Load(object sender, EventArgs e)
        {
            ReportParameter dogovorN = new ReportParameter("dogovorN", "");
            ReportParameter data = new ReportParameter("data", "");
            ReportParameter tipFU = new ReportParameter("tipFU", "");
            ReportParameter nomerFY = new ReportParameter("nomerFY", "");
            ReportParameter platenDo = new ReportParameter("platenDo", "");
            ReportParameter firmaSobstvenik = new ReportParameter("firmaSobstvenik", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter grad = new ReportParameter("grad", "");
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter Ypravitel = new ReportParameter("Ypravitel", "");
            ReportParameter otData = new ReportParameter("otData", "");
            ReportParameter doData = new ReportParameter("doData", "");
            ReportParameter serviznaOrg = new ReportParameter("serviznaOrg", "");
            ReportParameter servizenAdres = new ReportParameter("servizenAdres", "");
            ReportParameter bulstat = new ReportParameter("bulstat", "");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               dogovorN,
               data,
               tipFU,
               nomerFY,
               platenDo,
               firmaSobstvenik,
               obektIme,
               grad,
               TodayDate,
               Ypravitel,
               otData,
               doData,
               serviznaOrg,
               servizenAdres,
               bulstat
          }
          );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
