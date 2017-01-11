using System;
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
    public partial class AddFiscalDevice : Form
    {
        public AddFiscalDevice()
        {
            InitializeComponent();
        }

        private void saveFD_Click(object sender, EventArgs e)
        {
            // Save to db
            DanniFiskalnoUstroistvo dfu = new DanniFiskalnoUstroistvo();
            dfu.Serviz = 1;
            dfu.Obekt = 1;
            dfu.ModelFY = 1;
            dfu.FYNomer = 1;
            dfu.FPNomer = 1;
            dfu.Company = "company";
            dfu.Town = "Plovdiv";
            dfu.Technician = "Boyan";
            dfu.Address = "Trakia";
            DanniFiskalnoUstroistvoCtrl.AddDanniFiskalnoUstroistvo(dfu);
        }

        private void cancelFD_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
            this.Close();
        }

        private void AddFiscalDevice_Load(object sender, EventArgs e)
        {
            HashSet<string> companyHash = new HashSet<string>();
            var companies = CompanyCtrl.GetAllCompanies();
            for (int i = 0; i < companies.Length; i++)
            {
                companyHash.Add(companies[i].Name);
            }
            servizBox.DataSource = companyHash.ToList();
            HashSet<string> fiscalDeviceHash = new HashSet<string>();
            var fiscalDevices = FiscalDeviceCtrl.GetAllFiscalDevices();
            for (int i = 0; i < fiscalDevices.Length; i++)
            {
                fiscalDeviceHash.Add(fiscalDevices[i].Model);
            }
            modelFUCRU.DataSource = fiscalDeviceHash.ToList();
        }
    }
}
