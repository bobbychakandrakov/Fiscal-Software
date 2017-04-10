using Fiscal_Software.Controllers;
using Fiscal_Software.Helpers;
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
        int firma;
        string danSlyjba;
        DateTime fromDate, toDate;

        public VuvedeniEksploataciqForm()
        {
            InitializeComponent();
        }

        public VuvedeniEksploataciqForm(int firma , string danSlyjba, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.firma = firma;
            this.danSlyjba = danSlyjba;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        private void VuvedeniEksploataciqForm_Load(object sender, EventArgs e)
        {
            var company = CompanyCtrl.GetCompanyById(firma);
            var dfu = DanniFiskalnoUstroistvoCtrl.GetIztichashtiSim(this.firma, this.fromDate, this.toDate);
            IztichashtSIM[] isim = new IztichashtSIM[dfu.Length];
            for (int i = 0; i < dfu.Length; i++)
            {
                Objects obekt = ObjectCtrl.GetObjectById(dfu[i].Obekt);
                Client client = ClientCtrl.GetClient(dfu[i].Serviz);
                isim[i] = new IztichashtSIM();
                isim[i].Naimenovanie = obekt.Type;
                isim[i].Address = obekt.Town + ", " + obekt.Address;
                // Implement logic
                if (dfu[i].FPAktivirana.HasValue)
                {
                    isim[i].DataIztichane = dfu[i].FPAktivirana.Value.ToShortDateString();
                }
                else
                {
                    isim[i].DataIztichane = string.Empty;
                }
                isim[i].ModelFY = FiscalDeviceCtrl.GetFiscalDevice(dfu[i].ModelFY).Model + " " + dfu[i].SimTelNomer;
                isim[i].NomerFY = dfu[i].FYNomer + " " + dfu[i].SimID;
                isim[i].NomerFP = dfu[i].FPNomer;
                isim[i].FirmaIme = client.Name + ", \nТел:" + client.Telephone + "\nТелМол:" + client.MolTelephone;
                isim[i].FirmaAdress = client.Town + ", " + client.Address;
                isim[i].FirmaDan = client.Bulstat;
            }
            ReportParameter nap = new ReportParameter("nap", this.danSlyjba);
            ReportParameter otData = new ReportParameter("otData", this.fromDate.ToShortDateString());
            ReportParameter doData = new ReportParameter("doData", this.toDate.ToShortDateString());
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", company.Name);
            ReportParameter serviznaOrgAdres = new ReportParameter("serviznaOrgAdres", company.Town + ", " + company.Address);
            ReportParameter serviznaOrgBulstat = new ReportParameter("serviznaOrgBulstat", company.Bulstat);
            ReportParameter nomerEGN = new ReportParameter("nomerEGN", company.Bulstat);
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter obektAdres = new ReportParameter("obektAdres", "");
            ReportParameter dataVuvejdane = new ReportParameter("dataVuvejdane", "");
            ReportParameter modelFU = new ReportParameter("modelFU", "");
            ReportParameter nomerFU = new ReportParameter("nomerFU", "");
            ReportParameter nomerFP = new ReportParameter("nomerFP", "");
            ReportParameter molIme = new ReportParameter("molIme", "");
            ReportParameter molAdres = new ReportParameter("molAdres", "");
            ReportParameter molDanNomer = new ReportParameter("molDanNomer", "");
            ReportParameter Grad = new ReportParameter("Grad", company.Town);
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter Upravitel = new ReportParameter("Upravitel", company.Mol);

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
            ReportDataSource rds = new ReportDataSource("SpravkiSource", isim);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
