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
using Fiscal_Software.Controllers;

namespace Fiscal_Software.Forms
{
    public partial class PrintZaqvlenie : Form
    {
        DanniFiskalnoUstroistvo dfu;
        SvidetelstvoRegistraciq svidetelstvo;
        public PrintZaqvlenie()
        {
            InitializeComponent();
        }

        public PrintZaqvlenie(DanniFiskalnoUstroistvo dfu, SvidetelstvoRegistraciq svidetelstvo)
        {
            InitializeComponent();
            this.svidetelstvo = svidetelstvo;
            this.dfu = dfu;
        }

        private void PrintZaqvlenie_Load(object sender, EventArgs e)
        {
            var company = CompanyCtrl.GetCompanyById(dfu.Serviz);
            var obektDanni = ObjectCtrl.GetObjectById(dfu.Obekt);
            var client = ClientCtrl.GetClient(obektDanni.ClientId.Value);
            ReportParameter naFirma = new ReportParameter("naFirma", client.Name);
            ReportParameter DOPK = new ReportParameter("DOPK", client.Bulstat);
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", client.Name + " " + client.Town + ", " + client.Address);
            ReportParameter obekt = new ReportParameter("obekt", obektDanni.Type);
            ReportParameter vidDeinost = new ReportParameter("vidDeinost", obektDanni.Activity);
            ReportParameter modelFY = new ReportParameter("modelFY", FiscalDeviceCtrl.GetFiscalDevice(dfu.ModelFY).Model);
            ReportParameter NomerFY = new ReportParameter("NomerFY", dfu.FYNomer);
            ReportParameter NomerFP = new ReportParameter("NomerFP", dfu.FPNomer);
            ReportParameter ServiznaFirma = new ReportParameter("ServiznaFirma", company.Bulstat + ", " 
                                                + company.Name + ", " 
                                                + company.Town + ", " 
                                                + company.Address + ", тел: " 
                                                + company.Telephone);
            ReportParameter ServizenDogovor = new ReportParameter("ServizenDogovor",ContractFiscalDeviceCtrl.GetContractFiscalDevice(svidetelstvo.Contract).ContractN.Value.ToString());
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter ServizenTexnik = new ReportParameter("ServizenTexnik", TechnicianCtrl.GetTechnicianById(svidetelstvo.Technician).Name);

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
