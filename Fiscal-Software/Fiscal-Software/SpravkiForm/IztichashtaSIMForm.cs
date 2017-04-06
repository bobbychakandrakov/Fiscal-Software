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
    public partial class IztichashtaSIMForm : Form
    {
        int firma;
        DateTime fromDate, toDate;

        public IztichashtaSIMForm()
        {
            InitializeComponent();
        }

        public IztichashtaSIMForm(int firma, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            this.firma = firma;
            this.fromDate = fromDate;
            this.toDate = toDate;

        }

        private void IztichashtaSIMForm_Load(object sender, EventArgs e)
        {
            var company = CompanyCtrl.GetCompanyById(firma);
            var dfu = DanniFiskalnoUstroistvoCtrl.GetIztichashtiSim(this.firma,this.fromDate, this.toDate);
            string naimenovaniq = "",
                   adresi = "",
                   datiIztichane = "";
            IztichashtSIM[] isim = new IztichashtSIM[dfu.Length];
            for (int i = 0; i < dfu.Length; i++)
            {
                Objects obekt = ObjectCtrl.GetObjectById(dfu[i].Obekt);
                Client client = ClientCtrl.GetClient(dfu[i].Serviz);
                isim[i] = new IztichashtSIM();
                isim[i].Naimenovanie = obekt.Type;
                isim[i].Address = obekt.Town + ", " + obekt.Address;
                if (dfu[i].PayedSim.HasValue)
                {
                    isim[i].DataIztichane = dfu[i].PayedSim.Value.ToShortDateString();
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
            
            ReportParameter naimenovanie = new ReportParameter("naimenovanie", naimenovaniq);
            ReportParameter obektAdres = new ReportParameter("obektAdres", adresi);
            ReportParameter dataNaIztichane = new ReportParameter("dataNaIztichane", datiIztichane);
            ReportParameter modelFUSIMTelNumber = new ReportParameter("modelFUSIMTelNumber", "");
            ReportParameter nomerFUSIMID = new ReportParameter("nomerFUSIMID", "");
            ReportParameter nomerFP = new ReportParameter("nomerFP", "");
            ReportParameter firmaIme = new ReportParameter("firmaIme", "");
            ReportParameter firmaAdres = new ReportParameter("firmaAdres", "");
            ReportParameter firmaDanNomer = new ReportParameter("firmaDanNomer", "");
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", company.Name);
            ReportParameter ot = new ReportParameter("ot", this.fromDate.ToShortDateString());
            ReportParameter doData = new ReportParameter("doData", this.toDate.ToShortDateString());

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
            ReportDataSource rds = new ReportDataSource("SIMSource", isim);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();

        }
    }
}
