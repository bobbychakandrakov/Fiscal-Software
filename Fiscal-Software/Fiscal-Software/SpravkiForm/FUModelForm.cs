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
    public partial class FUModelForm : Form
    {
        public FUModelForm()
        {
            InitializeComponent();
        }

        private void FUModelForm_Load(object sender, EventArgs e)
        {
            ReportParameter modelFU = new ReportParameter("modelFU", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter obektAdres = new ReportParameter("obektAdres", "");
            ReportParameter SIMDataIztichane = new ReportParameter("SIMDataIztichane", "");
            ReportParameter ModelFUSIMTelNomer = new ReportParameter("ModelFUSIMTelNomer", "");
            ReportParameter FUSIMID = new ReportParameter("FUSIMID", "");
            ReportParameter FPNomer = new ReportParameter("FPNomer", "");
            ReportParameter molIme = new ReportParameter("molIme", "");
            ReportParameter molAdres = new ReportParameter("molAdres", "");
            ReportParameter molDanAdres = new ReportParameter("molDanAdres", "");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               modelFU,
               obektIme,
               obektAdres,
               SIMDataIztichane,
               ModelFUSIMTelNomer,
               FUSIMID,
               FPNomer,
               molIme,
               molAdres,
               molDanAdres
          }
          );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
