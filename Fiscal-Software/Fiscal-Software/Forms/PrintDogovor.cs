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
    public partial class PrintDogovor : Form
    {
        DanniFiskalnoUstroistvo dfu;
        ContractFiscalDevices cfd;
        public PrintDogovor()
        {
            InitializeComponent();
        }
        public PrintDogovor(DanniFiskalnoUstroistvo dfu , ContractFiscalDevices cfd)
        {
            InitializeComponent();
            this.dfu = dfu;
            this.cfd = cfd;
        }
        private void PrintSvidetelstvo_Load(object sender, EventArgs e)
        {
            var company = CompanyCtrl.GetCompanyById(dfu.Serviz);
            var obekt = ObjectCtrl.GetObjectById(dfu.Obekt);
            var fd = FiscalDeviceCtrl.GetFiscalDevice(dfu.ModelFY);
            var client = ClientCtrl.GetClient(obekt.ClientId.Value);
            // Report dogovor
            ReportParameter RemontNomer = new ReportParameter("RemontNomer", "0000000" + cfd.ContractN.Value.ToString() + " / " + DateTime.Now.ToShortDateString());
            ReportParameter todayDate = new ReportParameter("todayDate", DateTime.Now.ToShortDateString());
            ReportParameter vGrad = new ReportParameter("vGrad", obekt.Town);
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", company.Name + " ЕИК: " + company.Bulstat);
            ReportParameter predstavenaOt = new ReportParameter("predstavenaOt", company.Mol);
            ReportParameter organizaciqVazlojitel = new ReportParameter("organizaciqVazlojitel", obekt.Type);
            ReportParameter identNomer = new ReportParameter("identNomer", obekt.Ekatte);
            ReportParameter addres1 = new ReportParameter("addres1", obekt.Address);
            ReportParameter predstavenaOt2 = new ReportParameter("predstavenaOt2", obekt.Mol);
            ReportParameter vidTehnika = new ReportParameter("vidTehnika", fd.Model);
            ReportParameter identNomer2 = new ReportParameter("identNomer2", dfu.FYNomer);
            ReportParameter NomerFp = new ReportParameter("NomerFp", dfu.FPNomer);
            ReportParameter taksa = new ReportParameter("taksa", cfd.Sum.Value.ToString());
            ReportParameter validenOt = new ReportParameter("validenOt", cfd.DateFrom.Value.ToShortDateString());
            ReportParameter validenDo = new ReportParameter("validenDo", cfd.DateTo.Value.ToShortDateString());
            ReportParameter BankovaSmetka = new ReportParameter("BankovaSmetka", " ");
            ReportParameter data2 = new ReportParameter("data2", DateTime.Now.ToShortDateString());
            ReportParameter EikBulstad = new ReportParameter("EikBulstad", client.Bulstat);
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", client.Name);
            ReportParameter address2 = new ReportParameter("address2", client.MolTown + " " + client.MolAddress);
            ReportParameter predstavlqvanaOt = new ReportParameter("predstavlqvanaOt", client.Mol);
        ReportParameter TargovskiObekt= new ReportParameter("TargovskiObekt", obekt.Type);
            ReportParameter Model = new ReportParameter("Model", fd.Model);
            ReportParameter BimNomer = new ReportParameter("BimNomer", " ");
            ReportParameter indNomerNafiskalnotoUstroistvo = new ReportParameter("indNomerNafiskalnotoUstroistvo", dfu.FYNomer);
            ReportParameter FiskalnaPamet = new ReportParameter("FiskalnaPamet", dfu.FPNomer);
            ReportParameter ValidenOt2 = new ReportParameter("ValidenOt2", cfd.DateFrom.Value.ToShortDateString());
            ReportParameter Eik = new ReportParameter("Eik", company.Bulstat);
            ReportParameter Adress3 = new ReportParameter("Adress3", company.Address);
            ReportParameter ServzienTehnik = new ReportParameter("ServzienTehnik", dfu.Technician);
            ReportParameter Data = new ReportParameter("Data", DateTime.Now.ToShortDateString());

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
           {
                RemontNomer,
                todayDate,
                vGrad,
                serviznaOrganizaciq,
                predstavenaOt,
                organizaciqVazlojitel,
                identNomer,
                addres1,
               predstavenaOt2,
               vidTehnika,
                identNomer2,
               NomerFp,
                taksa,
               validenOt,
                validenDo,
                BankovaSmetka,
               data2,
                EikBulstad,
                sobstvenostNa,
                address2,
                predstavenaOt,
                TargovskiObekt,
                Model,
                BimNomer,
                indNomerNafiskalnotoUstroistvo,
                FiskalnaPamet,
                ValidenOt2,
                Eik,
                Adress3,
                ServzienTehnik,
                Data,
                predstavlqvanaOt

           }
           );



            /* RemontProtokol 
             * 
            ReportParameter TodayDate = new ReportParameter("TodayDate", " ");
            ReportParameter CompnayName = new ReportParameter("CompnayName", " ");
            ReportParameter MOL = new ReportParameter("MOL", " ");
            ReportParameter SobstvenostNa = new ReportParameter("SobstvenostNa", " ");
            ReportParameter Name = new ReportParameter("Name", " ");
            ReportParameter KonstatiranePovreda = new ReportParameter("KonstatiranePovreda", " ");
            ReportParameter PodavaneZaqvka = new ReportParameter("PodavaneZaqvka", " ");
            ReportParameter VarnatNa = new ReportParameter("VarnatNa", " ");
            ReportParameter OpisaniePovreda = new ReportParameter("OpisaniePovreda", " ");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
          {
               TodayDate,
               CompnayName,
               MOL,
               SobstvenostNa,
               Name,
               KonstatiranePovreda,
               PodavaneZaqvka,
               VarnatNa,
               OpisaniePovreda

          }
          );
          */
          /*
            ReportParameter datetime = new ReportParameter("datetime", " ");
            ReportParameter identNomer = new ReportParameter("identNomer", " ");
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", " ");
            ReportParameter PredstavlqvanOt = new ReportParameter("PredstavlqvanOt", " ");
            ReportParameter TurgovskiObekt = new ReportParameter("TurgovskiObekt", " ");
            ReportParameter PlombiranOt = new ReportParameter("PlombiranOt", " ");
            ReportParameter BimNomer = new ReportParameter("BimNomer", " ");
            ReportParameter Dopk = new ReportParameter("Dopk", " ");
            ReportParameter Fu = new ReportParameter("Fu", " ");
            ReportParameter Fp = new ReportParameter("Fp", " ");
            ReportParameter Fdrid = new ReportParameter("Fdrid", " ");
            ReportParameter PrichinaDemontaj = new ReportParameter("PrichinaDemontaj", " ");
            ReportParameter ot = new ReportParameter("ot", " ");
            ReportParameter Do = new ReportParameter("do", " ");
            ReportParameter suma = new ReportParameter("suma", " ");
            ReportParameter DDsA = new ReportParameter("DDsA", " ");
            ReportParameter DDsB = new ReportParameter("DDsB", " ");
            ReportParameter DDsV = new ReportParameter("DDsV", " ");
            ReportParameter DDsG = new ReportParameter("DDsG", " ");
            ReportParameter serviznaFirma = new ReportParameter("serviznaFirma", " ");
            ReportParameter Dopk2 = new ReportParameter("Dopk2", " ");
            ReportParameter predstavitel = new ReportParameter("predstavitel", " ");
            ReportParameter grad = new ReportParameter("grad", " ");
            ReportParameter data = new ReportParameter("data", " ");
            ReportParameter sobstvenik = new ReportParameter("sobstvenik", " ");

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
       {
              datetime,
              identNomer,
              sobstvenostNa,
              PredstavlqvanOt,
              TurgovskiObekt,
              PlombiranOt,
              Dopk,
              Fu,
              Fp,
              Fdrid,
              PrichinaDemontaj,
              ot,
              Do,
              suma,
              DDsA,
              DDsB,
              DDsV,
              DDsG,
              serviznaFirma,
              Dopk2,
              predstavitel,
              grad,
              data,
              sobstvenik

       }
       );
       */

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
