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
    public partial class FiscalDevicesForm : Form
    {
        public FiscalDevicesForm()
        {
            InitializeComponent();
        }

        private void FiscalDevicesForm_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
        }

        private void ToggleControls(bool isEnabled)
        {
            fiscalDeviceTypeBox.Enabled = isEnabled;
            fiscalDeviceModelBox.Enabled = isEnabled;
            fiscalDeviceManufacturerBox.Enabled = isEnabled;
            fiscalDeviceCerificateNBtn.Enabled = isEnabled;
            fiscalDeviceStartDateBox.Enabled = isEnabled;
            fiscalDevicePriceBox.Enabled = isEnabled;
            fiscalDeviceWarrantyBox.Enabled = isEnabled;
            fiscalDeviceManufacturerBulstatBox.Enabled = isEnabled;
            saveFiscalDeviceBtn.Enabled = isEnabled;
            cancelFiscalDeviceBtn.Enabled = isEnabled;
        }

        private void addFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(true);
            addFiscalDeviceBtn.Enabled = false;
            editFiscalDeviceBtn.Enabled = false;
            deleteFiscalDeviceBtn.Enabled = false;
        }

        private void cancelFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            addFiscalDeviceBtn.Enabled = true;
            editFiscalDeviceBtn.Enabled = true;
            deleteFiscalDeviceBtn.Enabled = true;
        }
    }
}
