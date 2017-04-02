using Fiscal_Software.Controllers;
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
        DanniFiskalnoUstroistvo dfu;
        Client client;
        Objects obj;
        SvidetelstvoRegistraciq sr;
        public PrintUvedomleniecs()
        {
            InitializeComponent();
        }

        public PrintUvedomleniecs(DanniFiskalnoUstroistvo dfu, Objects obj, Client client, SvidetelstvoRegistraciq sr)
        {
            InitializeComponent();
            this.dfu = dfu;
            this.client = client;
            this.obj = obj;
            this.sr = sr;
        }

        private void PrintUvedomleniecs_Load(object sender, EventArgs e)
        {
            var fd = FiscalDeviceCtrl.GetFiscalDevice(this.dfu.ModelFY);
            var company = CompanyCtrl.GetCompanyById(this.dfu.Serviz);
            ReportParameter Ot = new ReportParameter("ot", this.client.Mol);
            ReportParameter Na = new ReportParameter("na", this.client.Name);
            ReportParameter Bulstat = new ReportParameter("Bulstat", this.client.Bulstat);
            ReportParameter NaselenoMqsto = new ReportParameter("naselenoMqsto", this.client.Town);
            ReportParameter AdresUpravlenie = new ReportParameter("AdresUpravlenie", this.client.Address);
            ReportParameter DanAdres = new ReportParameter("DanAdres", this.client.Address);
            ReportParameter Telefon1 = new ReportParameter("telefon1", this.client.Telephone);
            ReportParameter Email = new ReportParameter("email", this.client.Email);
            ReportParameter NapReg = new ReportParameter("napReg", this.client.TDD);
            ReportParameter Ofis = new ReportParameter("ofis", this.client.Address);
            ReportParameter Telefon2 = new ReportParameter("telefon2", this.client.MolTelephone);
            ReportParameter ModelFiskalno = new ReportParameter("ModelFiskalno", fd.Model);
            ReportParameter indNomerFiskalno = new ReportParameter("indNomerFiskalno", this.dfu.FYNomer);
            ReportParameter IndNomerFiskalPamet = new ReportParameter("IndNomerFiskPamet", this.dfu.FPNomer);
            ReportParameter VavedenaServzinaFirma = new ReportParameter("VavedenaServiznafirma", company.Name + ", " + company.Address + ", " + company.Telephone);
            ReportParameter ServizenTehnik = new ReportParameter("servizenTehnik", TechnicianCtrl.GetTechnicianById(this.sr.Technician).Name);
            ReportParameter ServzienDogovor = new ReportParameter("servizenDogovor", ContractFiscalDeviceCtrl.GetContractFiscalDevice(this.sr.Contract).ContractN.ToString());
            ReportParameter ValidenOt = new ReportParameter("validenOt", this.sr.PrietObs.ToShortDateString());
            ReportParameter ValidenDo = new ReportParameter("validenDo", this.sr.PrekratenoObs.Value.ToShortDateString());


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
