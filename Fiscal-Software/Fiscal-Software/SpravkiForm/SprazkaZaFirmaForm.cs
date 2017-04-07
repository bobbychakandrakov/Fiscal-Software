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
    public partial class SprazkaZaFirmaForm : Form
    {
        int firma;
        public SprazkaZaFirmaForm()
        {
            InitializeComponent();
        }

        public SprazkaZaFirmaForm(int firma)
        {
            InitializeComponent();
            this.firma = firma;
        }

        private void SprazkaZaFirmaForm_Load(object sender, EventArgs e)
        {
            ReportParameter firma = new ReportParameter("firma", "");
            ReportParameter mol = new ReportParameter("mol", "");
            ReportParameter bulstat = new ReportParameter("bulstat", "");
            ReportParameter egn = new ReportParameter("egn", "");
            ReportParameter firmaAdres = new ReportParameter("firmaAdres", "");
            ReportParameter firmaTel = new ReportParameter("firmaTel", "");
            ReportParameter firmaFax = new ReportParameter("firmaFax", "");
            ReportParameter email = new ReportParameter("email", "");
            ReportParameter dogovorN = new ReportParameter("dogovorN", "");
            ReportParameter data = new ReportParameter("data", "");
            ReportParameter izticha = new ReportParameter("izticha", "");
            ReportParameter platenDo = new ReportParameter("platenDo", "");
            ReportParameter tipFY = new ReportParameter("tipFY", "");
            ReportParameter firmaSobstvenik = new ReportParameter("firmaSobstvenik", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
              {
                   firma,
                   mol,
                   bulstat,
                   egn,
                   firmaAdres,
                   firmaTel,
                   firmaFax,
                   email,
                   dogovorN,
                   data,
                   izticha,
                   platenDo,
                   tipFY,
                   firmaSobstvenik,
                   obektIme
              }
            );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
