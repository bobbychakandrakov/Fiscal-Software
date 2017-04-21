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
    public partial class PrintDogovorServizEKAFP : Form
    {
        DanniFiskalnoUstroistvo dfu;
        ContractFiscalDevices cfd;

        public PrintDogovorServizEKAFP()
        {
            InitializeComponent();
        }

        public PrintDogovorServizEKAFP(DanniFiskalnoUstroistvo dfu, ContractFiscalDevices cfd)
        {
            InitializeComponent();
            this.dfu = dfu;
            this.cfd = cfd;
        }

        private void PrintDogovorServizEKAFP_Load(object sender, EventArgs e)
        {
            var obekt = ObjectCtrl.GetObjectById(dfu.Obekt);
            var client = ClientCtrl.GetClient(obekt.ClientId.Value);
            var serviz = CompanyCtrl.GetCompanyById(dfu.Serviz);
            ReportParameter NomerDogovor = new ReportParameter("NomerDogovor", cfd.ContractN.HasValue ? cfd.ContractN.Value.ToString() : string.Empty);
            ReportParameter KlientIme = new ReportParameter("KlientIme", client.Name);
            ReportParameter KlientGrad = new ReportParameter("KlientGrad", client.Town);
            ReportParameter KlientAdres = new ReportParameter("KlientAdres", client.Address);
            ReportParameter KlientMol = new ReportParameter("KlientMol", client.Mol);
            ReportParameter KlientBulstat = new ReportParameter("KlientBulstat", client.Bulstat);
            ReportParameter KlientDanNomer = new ReportParameter("KlientDanNomer", client.DN);
            ReportParameter KlientTel = new ReportParameter("KlientTel", client.Telephone);
            ReportParameter ServizName = new ReportParameter("ServizName", serviz.Name);
            ReportParameter ServizGrad = new ReportParameter("ServizGrad", serviz.Town);
            ReportParameter ServizAdres = new ReportParameter("ServizAdres", serviz.Address);
            ReportParameter ServizMol = new ReportParameter("ServizMol", serviz.Mol);
            ReportParameter ServizBulstat = new ReportParameter("ServizBulstat", serviz.Bulstat);
            ReportParameter ServizDanNomer = new ReportParameter("ServizDanNomer", serviz.DanNumber);
            ReportParameter ServizTel = new ReportParameter("ServizTel", serviz.Telephone);
            ReportParameter otData = new ReportParameter("otData", cfd.DateFrom.Value.ToShortDateString());
            ReportParameter doData = new ReportParameter("doData", cfd.DateTo.Value.ToShortDateString());
            ReportParameter Data = new ReportParameter("Data", cfd.DateFrom.Value.ToShortDateString());


            // Empty Box 2610 ; Box with cross 2612
            var contract = ContractCtrl.GetContractById(cfd.ContractType);

            ReportParameter Programirane = new ReportParameter("Programirane", contract.Programming.Value == true ? "\u2612" : "\u2610");
            ReportParameter Artikuli = new ReportParameter("Artikuli", contract.ProgrammingArticul.Value == true ? "\u2612" : "\u2610");
            ReportParameter trud = new ReportParameter("trud", contract.Rabota.Value == true ? "\u2612" : "\u2610");
            ReportParameter RezervniChasti = new ReportParameter("RezervniChasti", contract.SpareParts.Value == true ? "\u2612" : "\u2610");
            ReportParameter Predpaziteli = new ReportParameter("Predpaziteli", contract.Protect.Value == true ? "\u2612" : "\u2610");
            ReportParameter RezervniModuli = new ReportParameter("RezervniModuli", contract.SpareModuls.Value == true ? "\u2612" : "\u2610");


            ReportParameter model = new ReportParameter("model",FiscalDeviceCtrl.GetFiscalDevice(dfu.ModelFY).Model);
            ReportParameter nEKAFP = new ReportParameter("nEKAFP", dfu.FYNomer);
            ReportParameter nFP = new ReportParameter("nFP", dfu.FPNomer);
            ReportParameter AdresTip = new ReportParameter("AdresTip", obekt.Type + " " + obekt.Address);
            ReportParameter garanciq = new ReportParameter("garanciq", dfu.GuaranteeUntil.HasValue ? dfu.GuaranteeUntil.Value.ToShortDateString() : "");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                NomerDogovor,
                KlientIme,
                KlientGrad,
                KlientAdres,
                KlientMol,
                KlientBulstat,
                KlientDanNomer,
                KlientTel,
                ServizName,
                ServizGrad,
                ServizAdres,
                ServizMol,
                ServizBulstat,
                ServizDanNomer,
                ServizTel,
                otData,
                doData,
                Data,
                Programirane,
                Artikuli,
                trud,
                RezervniChasti,
                Predpaziteli,
                RezervniModuli,
                model,
                nEKAFP,
                nFP,
                AdresTip,
                garanciq
            });

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
