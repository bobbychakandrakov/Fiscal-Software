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

namespace Fiscal_Software.SpravkiForm
{
    public partial class DogovoriZaPeriodForm : Form
    {
        int firma;
        DateTime fromDate, toDate;

        public DogovoriZaPeriodForm()
        {
            InitializeComponent();
        }

        public DogovoriZaPeriodForm(int firma, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.firma = firma;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        private void DogovoriZaPeriodForm_Load(object sender, EventArgs e)
        {
            var dfu = DanniFiskalnoUstroistvoCtrl.GetByServiz(firma);
            int[] ids = new int[dfu.Length];

            for (int i = 0; i < dfu.Length; i++)
            {
                ids[i] = dfu[i].ID;
            }

            List<ContractFiscalDevices> cfds = new List<ContractFiscalDevices>();
            var cfs = ContractFiscalDeviceCtrl.GetByDateAndDanni(ids, fromDate, toDate);

            // Implement iteration and creating array for datasource

            ReportParameter dogovorN = new ReportParameter("dogovorN", "");
            ReportParameter data = new ReportParameter("data", "");
            ReportParameter tipFU = new ReportParameter("tipFU", "");
            ReportParameter nomerFY = new ReportParameter("nomerFY", "");
            ReportParameter nomerFP = new ReportParameter("nomerFP", "");
            ReportParameter firmaSobstvenik = new ReportParameter("firmaSobstvenik", "");
            ReportParameter obektIme = new ReportParameter("obektIme", "");
            ReportParameter grad = new ReportParameter("grad", "");
            ReportParameter TodayDate = new ReportParameter("TodayDate", DateTime.Now.ToShortDateString());
            ReportParameter Ypravitel = new ReportParameter("Ypravitel", "");
            ReportParameter otData = new ReportParameter("otData", "");
            ReportParameter doData = new ReportParameter("doData", "");
            ReportParameter serviznaOrg = new ReportParameter("serviznaOrg", "");
            ReportParameter servizenAdres = new ReportParameter("servizenAdres", "");
            ReportParameter bulstat = new ReportParameter("bulstat", "");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               dogovorN,
               data,
               tipFU,
               nomerFY,
               nomerFP,
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
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
