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
        public PrintDogovor()
        {
            InitializeComponent();
        }

        private void PrintSvidetelstvo_Load(object sender, EventArgs e)
        {

            /*Uvedomlenie Report
            ReportParameter Ot = new ReportParameter("ot", " ");
            ReportParameter Na = new ReportParameter("na", " ");
            ReportParameter Bulstat = new ReportParameter("Bulstat", " ");
            ReportParameter NaselenoMqsto = new ReportParameter("naselenoMqsto", " ");
            ReportParameter AdresUpravlenie = new ReportParameter("AdresUpravlenie", " ");
            ReportParameter DanAdres = new ReportParameter("DanAdres", " ");
            ReportParameter Telefon1 = new ReportParameter("telefon1", " ");
            ReportParameter Email = new ReportParameter("email", " ");
            ReportParameter NapReg = new ReportParameter("napReg", " ");
            ReportParameter Ofis= new ReportParameter("ofis", " ");
            ReportParameter Telefon2 = new ReportParameter("telefon2", " ");
            ReportParameter ModelFiskalno = new ReportParameter("ModelFiskalno", " ");
            ReportParameter indNomerFiskalno = new ReportParameter("indNomerFiskalno", " ");
            ReportParameter IndNomerFiskalPamet = new ReportParameter("IndNomerFiskPamet", " ");
            ReportParameter VavedenaServzinaFirma = new ReportParameter("VavedenaServiznafirma", " ");
            ReportParameter ServizenTehnik = new ReportParameter("servizenTehnik", " ");
            ReportParameter ServzienDogovor = new ReportParameter("servizenDogovor", " ");
            ReportParameter ValidenOt = new ReportParameter("validenOt", " ");
            ReportParameter ValidenDo = new ReportParameter("validenDo", " ");


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
            */

            // Report dogovor
            ReportParameter RemontNomer = new ReportParameter("RemontNomer", " ");
            ReportParameter todayDate = new ReportParameter("todayDate", " ");
            ReportParameter vGrad = new ReportParameter("vGrad", " ");
            ReportParameter serviznaOrganizaciq = new ReportParameter("serviznaOrganizaciq", " ");
            ReportParameter predstavenaOt = new ReportParameter("predstavenaOt", " ");
            ReportParameter organizaciqVazlojitel = new ReportParameter("organizaciqVazlojitel", " ");
            ReportParameter identNomer = new ReportParameter("identNomer", " ");
            ReportParameter addres1 = new ReportParameter("addres1", " ");
            ReportParameter predstavenaOt2 = new ReportParameter("predstavenaOt2", " ");
            ReportParameter vidTehnika = new ReportParameter("vidTehnika", " ");
            ReportParameter identNomer2 = new ReportParameter("identNomer2", " ");
            ReportParameter NomerFp = new ReportParameter("NomerFp", " ");
            ReportParameter taksa = new ReportParameter("taksa", " ");
            ReportParameter validenOt = new ReportParameter("validenOt", " ");
            ReportParameter validenDo = new ReportParameter("validenDo", " ");
            ReportParameter BankovaSmetka = new ReportParameter("BankovaSmetka", " ");
            ReportParameter data2 = new ReportParameter("data2", " ");
            ReportParameter EikBulstad = new ReportParameter("EikBulstad", " ");
            ReportParameter sobstvenostNa = new ReportParameter("sobstvenostNa", " ");
            ReportParameter address2 = new ReportParameter("address2", " ");
            ReportParameter predstavlqvanaOt = new ReportParameter("predstavlqvanaOt", " ");
            ReportParameter TargovskiObekt= new ReportParameter("TargovskiObekt", " ");
            ReportParameter Model = new ReportParameter("Model", " ");
            ReportParameter BimNomer = new ReportParameter("BimNomer", " ");
            ReportParameter indNomerNafiskalnotoUstroistvo = new ReportParameter("indNomerNafiskalnotoUstroistvo", " ");
            ReportParameter FiskalnaPamet = new ReportParameter("FiskalnaPamet", " ");
            ReportParameter ValidenOt2 = new ReportParameter("ValidenOt2", " ");
            ReportParameter Eik = new ReportParameter("Eik", " ");
            ReportParameter Adress3 = new ReportParameter("Adress3", " ");
            ReportParameter ServzienTehnik = new ReportParameter("ServzienTehnik", " ");
            ReportParameter Data = new ReportParameter("Data", " ");

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
                Data


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
