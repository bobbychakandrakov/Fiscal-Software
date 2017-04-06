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
using Fiscal_Software.Helpers;

namespace Fiscal_Software.SpravkiForm
{
    public partial class FUModelForm : Form
    {
        int model;

        public FUModelForm()
        {
            InitializeComponent();
        }

        public FUModelForm(int model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void FUModelForm_Load(object sender, EventArgs e)
        {
            FiscalDevice fd = FiscalDeviceCtrl.GetFiscalDevice(model);
            DanniFiskalnoUstroistvo[] dfu = DanniFiskalnoUstroistvoCtrl.GetByModel(model);

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

            ReportParameter modelFU = new ReportParameter("modelFU", fd.Model);
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

            ReportDataSource rds = new ReportDataSource("TestSource", isim);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
