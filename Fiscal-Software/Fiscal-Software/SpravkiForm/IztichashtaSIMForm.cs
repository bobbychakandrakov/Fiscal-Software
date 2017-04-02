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
    public partial class IztichashtaSIMForm : Form
    {
        public IztichashtaSIMForm()
        {
            InitializeComponent();
        }

        private void IztichashtaSIMForm_Load(object sender, EventArgs e)
        {
            ReportParameter naimenovanie = new ReportParameter("naimenovanie", "");
            ReportParameter obektAdres = new ReportParameter("obektAdres", "");
            ReportParameter dataNaIztichane = new ReportParameter("dataNaIztichane", "");
            ReportParameter modelFUSIMTelNumber = new ReportParameter("modelFUSIMTelNumber", "");
            ReportParameter nomerFUSIMID = new ReportParameter("nomerFUSIMID", "");
            ReportParameter nomerFP = new ReportParameter("nomerFP", "");
            ReportParameter firmaIme = new ReportParameter("firmaIme", "");
            ReportParameter firmaAdres = new ReportParameter("firmaAdres", "");
            ReportParameter firmaDanNomer = new ReportParameter("firmaDanNomer", "");
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", "");
            ReportParameter ot = new ReportParameter("ot", "");
            ReportParameter doData = new ReportParameter("doData", "");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               naimenovanie,
               obektAdres,
               dataNaIztichane,
               modelFUSIMTelNumber,
               nomerFUSIMID,
               nomerFP,
               firmaIme,
               firmaAdres,
               firmaDanNomer,
               serviznaOrganizaciq,
               ot,
               doData
          }
          );
            reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
