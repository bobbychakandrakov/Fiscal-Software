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
    public partial class ServizniFirmi : Form
    {
        public ServizniFirmi()
        {
            InitializeComponent();
            
        }

        private void ServizniFirmi_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
        }
        
        private void ToggleControls(bool isEnabled)
        {
            companyNameBox.Enabled = isEnabled;
            companyDanNumberBox.Enabled = isEnabled;
            companyBulstatBox.Enabled = isEnabled;
            companyFDTownBox.Enabled = isEnabled;
            companyFDDateBox.Enabled = isEnabled;
            companyFDNumberBox.Enabled = isEnabled;
            companyCertificateNBox.Enabled = isEnabled;
            companyTownBox.Enabled = isEnabled;
            companyAddressBox.Enabled = isEnabled;
            companyTelephoneBox.Enabled = isEnabled;
            companyFaxBox.Enabled = isEnabled;
            companyEmailBox.Enabled = isEnabled;
            companyWebBox.Enabled = isEnabled;
            companyMolBox.Enabled = isEnabled;
            saveCompanyBtn.Enabled = isEnabled;
            cancelSaveBtn.Enabled = isEnabled;
        }


        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(true);
            addCompanyBtn.Enabled = false;
            editCompanyBtn.Enabled = false;
            deleteCompanyBtn.Enabled = false;
        }

        private void cancelSaveBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            addCompanyBtn.Enabled = true;
            editCompanyBtn.Enabled = true;
            deleteCompanyBtn.Enabled = true;
        }
    }
}
