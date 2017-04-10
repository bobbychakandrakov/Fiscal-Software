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
using Fiscal_Software.Helpers;
using Fiscal_Software.Controllers;

namespace Fiscal_Software.SpravkiForm
{
    public partial class DogovoriSpravkaForm : Form
    {
        int firma;
        DateTime fromDate, toDate;
        public DogovoriSpravkaForm()
        {
            InitializeComponent();
        }
        public DogovoriSpravkaForm(int firma, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.firma = firma;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }


        private void DogovoriSpravkaForm_Load(object sender, EventArgs e)
        {
            var dfu = DanniFiskalnoUstroistvoCtrl.GetByServiz(firma);
            int[] ids = new int[dfu.Length];

            for (int i = 0; i < dfu.Length; i++)
            {
                ids[i] = dfu[i].ID;
            }

            var company = CompanyCtrl.GetCompanyById(firma);

            List<ContractFiscalDevices> cfds = new List<ContractFiscalDevices>();
            var cfs = ContractFiscalDeviceCtrl.GetByDateAndDanni(ids, fromDate, toDate);

            // Implement iteration and creating array for datasource

            DogovoriHelp[] dogovori = new DogovoriHelp[cfs.Length];
            for (int i = 0; i < cfs.Length; i++)
            {
                DanniFiskalnoUstroistvo d = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(cfs[i].ObjectId);
                Client client = ClientCtrl.GetClient(d.Serviz);
                Objects obekt = ObjectCtrl.GetObjectById(d.Obekt);
                dogovori[i] = new DogovoriHelp();
                dogovori[i].NomerDogovor = cfs[i].ContractN.Value;
                dogovori[i].Data = cfs[i].DateFrom.Value.ToShortDateString();

                var plashtaniq = PlashtaniqCtrl.GetbyID(cfs[i].ID);
                if (plashtaniq.Length > 0)
                {
                    dogovori[i].PlatenDo = plashtaniq[0].DataDo.Value.ToShortDateString();
                }
                else
                {
                    dogovori[i].PlatenDo = "0";
                }

                dogovori[i].TipFY = FiscalDeviceCtrl.GetFiscalDevice(d.ModelFY).Model;
                dogovori[i].NomerFY = d.FYNomer;
                dogovori[i].Firma = client.Name;
                dogovori[i].Obekt = obekt.Type + ", " + client.MolTelephone;
            }

            ReportParameter dogovorN = new ReportParameter("dogovorN", "");
            ReportParameter data = new ReportParameter("data", "");
            ReportParameter tipFU = new ReportParameter("tipFU", "");
            ReportParameter nomerFY = new ReportParameter("nomerFY", "");
            ReportParameter platenDo = new ReportParameter("platenDo", "");
            ReportParameter firmaSobstvenik = new ReportParameter("firmaSobstvenik", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter grad = new ReportParameter("grad", company.Town);
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter Ypravitel = new ReportParameter("Ypravitel", company.Mol);
            ReportParameter otData = new ReportParameter("otData", fromDate.ToShortDateString());
            ReportParameter doData = new ReportParameter("doData", toDate.ToShortDateString());
            ReportParameter serviznaOrg = new ReportParameter("serviznaOrg", company.Name);
            ReportParameter servizenAdres = new ReportParameter("servizenAdres", company.Town + ", " + company.Address);
            ReportParameter bulstat = new ReportParameter("bulstat", company.Bulstat);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               dogovorN,
               data,
               tipFU,
               nomerFY,
               platenDo,
               firmaSobstvenik,
               obektIme,
               grad,
               TodayDate,
               Ypravitel,
               otData,
               doData,
               serviznaOrg,
               servizenAdres,
               bulstat
          }
          );
            ReportDataSource rds = new ReportDataSource("DogovoriSource", dogovori);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
