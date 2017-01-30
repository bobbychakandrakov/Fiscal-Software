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
    public partial class PrintUvedomleniecs : Form
    {
        public PrintUvedomleniecs()
        {
            InitializeComponent();
        }

        private void PrintUvedomleniecs_Load(object sender, EventArgs e)
        {
            ReportParameter Ot = new ReportParameter("ot", " ");
            ReportParameter Na = new ReportParameter("na", " ");
            ReportParameter Bulstat = new ReportParameter("Bulstat", " ");
            ReportParameter NaselenoMqsto = new ReportParameter("naselenoMqsto", " ");
            ReportParameter AdresUpravlenie = new ReportParameter("AdresUpravlenie", " ");
            ReportParameter DanAdres = new ReportParameter("DanAdres", " ");
            ReportParameter Telefon1 = new ReportParameter("telefon1", " ");
            ReportParameter Email = new ReportParameter("email", " ");
            ReportParameter NapReg = new ReportParameter("napReg", " ");
            ReportParameter Ofis = new ReportParameter("ofis", " ");
            ReportParameter Telefon2 = new ReportParameter("telefon2", " ");
            ReportParameter ModelFiskalno = new ReportParameter("ModelFiskalno", " ");
            ReportParameter indNomerFiskalno = new ReportParameter("indNomerFiskalno", " ");
            ReportParameter IndNomerFiskalPamet = new ReportParameter("IndNomerFiskPamet", " ");
            ReportParameter VavedenaServzinaFirma = new ReportParameter("VavedenaServiznafirma", " ");
            ReportParameter ServizenTehnik = new ReportParameter("servizenTehnik", " ");
            ReportParameter ServzienDogovor = new ReportParameter("servizenDogovor", " ");
            ReportParameter ValidenOt = new ReportParameter("validenOt", " ");
            ReportParameter ValidenDo = new ReportParameter("validenDo", " ");


            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                Ot,
                Na,
                Bulstat,
                NaselenoMqsto,
                AdresUpravlenie,
                DanAdres,
                Telefon1,
                Email,
                NapReg,
                Ofis,
                Telefon2,
                ModelFiskalno,
                indNomerFiskalno,
                IndNomerFiskalPamet,
                VavedenaServzinaFirma,
                ServizenTehnik,
                ServzienDogovor,
                ValidenOt,
                ValidenDo

            }
            );
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
