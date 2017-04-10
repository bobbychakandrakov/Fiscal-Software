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
            var company = CompanyCtrl.GetCompanyById(this.firma);

            var dfu = DanniFiskalnoUstroistvoCtrl.GetByServiz(this.firma);

            int[] ids = new int[dfu.Length];

            for (int i = 0; i < dfu.Length; i++)
            {
                ids[i] = dfu[i].ID;
            }

            List<ContractFiscalDevices> cfds = new List<ContractFiscalDevices>();
            var cfs = ContractFiscalDeviceCtrl.GetByDateAndDanni(ids);

            FirmaSpravkaHelp[] fsh = new FirmaSpravkaHelp[cfs.Length];

            for (int i = 0; i < cfs.Length; i++)
            {
                DanniFiskalnoUstroistvo d = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(cfs[i].ObjectId);
                Client client = ClientCtrl.GetClient(d.Serviz);
                Objects obekt = ObjectCtrl.GetObjectById(d.Obekt);
                fsh[i] = new FirmaSpravkaHelp();
                fsh[i].NomerDogovor = cfs[i].ContractN.Value;
                fsh[i].Data = cfs[i].DateFrom.Value.ToShortDateString();
                fsh[i].IztichaNa = cfs[i].DateTo.Value.ToShortDateString();

                var plashtaniq = PlashtaniqCtrl.GetbyID(cfs[i].ID);
                if (plashtaniq.Length > 0)
                {
                    fsh[i].PlatenDo = plashtaniq[0].DataDo.Value.ToShortDateString();
                }
                else
                {
                    fsh[i].PlatenDo = "0";
                }
                
                fsh[i].TipFY = FiscalDeviceCtrl.GetFiscalDevice(d.ModelFY).Model;
                fsh[i].Firma = client.Name;
                fsh[i].Obekt = obekt.Type;
            }

            ReportParameter firma = new ReportParameter("firma", company.Name);
            ReportParameter mol = new ReportParameter("mol", company.Mol);
            ReportParameter bulstat = new ReportParameter("bulstat", company.Bulstat);
            ReportParameter egn = new ReportParameter("egn", company.Bulstat);
            ReportParameter firmaAdres = new ReportParameter("firmaAdres", company.Town + ", " + company.Address);
            ReportParameter firmaTel = new ReportParameter("firmaTel", company.Telephone);
            ReportParameter firmaFax = new ReportParameter("firmaFax", company.Fax);
            ReportParameter email = new ReportParameter("email", company.Email);
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
            ReportDataSource rds = new ReportDataSource("FirmaSource", fsh);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
