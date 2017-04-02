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

namespace Fiscal_Software.SpravkiForm
{
    public partial class VuvedeniEksploataciqForm : Form
    {
        public VuvedeniEksploataciqForm()
        {
            InitializeComponent();
        }

        private void VuvedeniEksploataciqForm_Load(object sender, EventArgs e)
        {
            ReportParameter nap = new ReportParameter("nap", "");
            ReportParameter otData = new ReportParameter("otData", "");
            ReportParameter doData = new ReportParameter("doData", "");
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", "");
            ReportParameter serviznaOrgAdres = new ReportParameter("serviznaOrgAdres", "");
            ReportParameter serviznaOrgBulstat = new ReportParameter("nomerFP", "");
            ReportParameter nomerEGN = new ReportParameter("nomerEGN", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter obektAdres = new ReportParameter("obektAdres", "");
            ReportParameter dataVuvejdane = new ReportParameter("dataVuvejdane", "");
            ReportParameter modelFU = new ReportParameter("modelFU", "");
            ReportParameter nomerFU = new ReportParameter("nomerFU", "");
            ReportParameter nomerFP = new ReportParameter("nomerFP", "");
            ReportParameter molIme = new ReportParameter("molIme", "");
            ReportParameter molAdres = new ReportParameter("molAdres", "");
            ReportParameter molDanNomer = new ReportParameter("molDanNomer", "");
            ReportParameter Grad = new ReportParameter("Grad", "");
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter Upravitel = new ReportParameter("Upravitel", "");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               nap,
               otData,
               doData,
               serviznaOrganizaciq,
               serviznaOrgAdres,
               serviznaOrgBulstat,
               nomerEGN,
               obektIme,
               obektAdres,
               serviznaOrganizaciq,
               dataVuvejdane,
               modelFU,
               nomerFU,
               nomerFP,
               molIme,
               molAdres,
               molDanNomer,
               Grad,
               TodayDate,
               Upravitel
          }
          );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
