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
            this.DisableControls();
        }

        private void ServizniFirmi_Load(object sender, EventArgs e)
        {
            
        }
        
        private void DisableControls()
        {
            companyNameBox.Enabled = false;
            companyDanNumberBox.Enabled = false;
            companyBulstatBox.Enabled = false;
            companyFDTownBox.Enabled = false;
            companyFDDateBox.Enabled = false;
            companyFDNumberBox.Enabled = false;
            companyCertificateNBox.Enabled = false;
            companyTownBox.Enabled = false;
            companyAddressBox.Enabled = false;
            companyTelephoneBox.Enabled = false;
            companyFaxBox.Enabled = false;
            companyEmailBox.Enabled = false;
            companyWebBox.Enabled = false;
            companyMolBox.Enabled = false;
            saveCompanyBtn.Enabled = false;
            cancelSaveBtn.Enabled = false;
        }

        private void EnableControls()
        {
            companyNameBox.Enabled = true;
            companyDanNumberBox.Enabled = true;
            companyBulstatBox.Enabled = true;
            companyFDTownBox.Enabled = true;
            companyFDDateBox.Enabled = true;
            companyFDNumberBox.Enabled = true;
            companyCertificateNBox.Enabled = true;
            companyTownBox.Enabled = true;
            companyAddressBox.Enabled = true;
            companyTelephoneBox.Enabled = true;
            companyFaxBox.Enabled = true;
            companyEmailBox.Enabled = true;
            companyWebBox.Enabled = true;
            companyMolBox.Enabled = true;
            saveCompanyBtn.Enabled = true;
            cancelSaveBtn.Enabled = true;
        }

        private void addCompanyBtn_Click(object sender, EventArgs e)
        {
            this.EnableControls();
            addCompanyBtn.Enabled = false;
            editCompanyBtn.Enabled = false;
            deleteCompanyBtn.Enabled = false;
        }

        private void cancelSaveBtn_Click(object sender, EventArgs e)
        {
            this.DisableControls();
            addCompanyBtn.Enabled = true;
            editCompanyBtn.Enabled = true;
            deleteCompanyBtn.Enabled = true;
        }
    }
}
