using Fiscal_Software.Controllers;
using Fiscal_Software.Helpers;
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
        ListViewItem lvi;
        // Add -> true Edit -> false
        bool addFiscalDiviceFlag = true, touched = false;
        HashSet<string> hash = new HashSet<string>();
        HashSet<string> man = new HashSet<string>();
        int selectedFiscalDeviceID;

        public FiscalDevicesForm()
        {
            InitializeComponent();
        }

        private void FiscalDevicesForm_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            this.LoadListData();
            DirtyChecker.Check(Controls, c_ControlChanged);
        }

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }

        private void LoadListData()
        {
            fiscalDevicesList.Columns.Add("Тип ФУ");
            fiscalDevicesList.Columns.Add("Модел");
            var fiscalDevices = FiscalDeviceCtrl.GetAllFiscalDevices();
            for (int i = 0; i < fiscalDevices.Length; i++)
            {
                hash.Add(fiscalDevices[i].Type);
                if (fiscalDevices[i].Manufacturer != "")
                {
                    man.Add(fiscalDevices[i].Manufacturer);
                }
                
                lvi = new ListViewItem(fiscalDevices[i].Type);
                lvi.Tag = fiscalDevices[i].ID;
                lvi.SubItems.Add(fiscalDevices[i].Model);
                fiscalDevicesList.Items.Add(lvi);
            }
            FiscalTypeLoad();
            FiscalManufactureLoad();
            fiscalDevicesList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            fiscalDevicesList.Columns[0].Width = 150;
            fiscalDevicesList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            fiscalDevicesList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            fiscalDevicesList.Columns[1].Width = 150;
            fiscalDevicesList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
           fiscalDevicesList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            fiscalDevicesList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FiscalTypeLoad()
        {
            fiscalDeviceTypeBox.Items.Clear();
            foreach (var type in hash)
            {
                fiscalDeviceTypeBox.Items.Add(type);
            }
        }

        private void FiscalManufactureLoad()
        {
            fiscalDeviceManufacturerBox.DataSource = man.ToList();
        }

        private void ToggleControls(bool isEnabled)
        {
            fiscalDeviceTypeBox.Enabled = isEnabled;
            fiscalDeviceModelBox.Enabled = isEnabled;
            fiscalDeviceManufacturerBox.Enabled = isEnabled;
            fiscalDeviceCerificateN.Enabled = isEnabled;
            fiscalDeviceStartDateBox.Enabled = isEnabled;
            fiscalDevicePriceBox.Enabled = isEnabled;
            fiscalDeviceWarrantyBox.Enabled = isEnabled;
            fiscalDeviceManufacturerBulstatBox.Enabled = isEnabled;
            saveFiscalDeviceBtn.Enabled = isEnabled;
            cancelFiscalDeviceBtn.Enabled = isEnabled;
        }

        private void addFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Добавяне на фискално Устройство";
            ResetControlsValue();
            this.ToggleControls(true);
            addFiscalDeviceBtn.Enabled = false;
            editFiscalDeviceBtn.Enabled = false;
            deleteFiscalDeviceBtn.Enabled = false;
            addFiscalDiviceFlag = true;
            fiscalDevicesList.Enabled = false;
        }

        private void cancelFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            ResetControlsValue();
                fiscalDevicesList.Enabled = true;
                this.ToggleControls(false);
                addFiscalDeviceBtn.Enabled = true;
                editFiscalDeviceBtn.Enabled = true;
                deleteFiscalDeviceBtn.Enabled = true;
            touched = false;


            
        }

        private void saveFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            if (fiscalDeviceCerificateN.Text != "" && fiscalDeviceModelBox.Text != "")
            {
                FiscalDevice fiscalDevice = new FiscalDevice();
                fiscalDevice.Model = fiscalDeviceModelBox.Text;
                fiscalDevice.CertificateN = int.Parse(fiscalDeviceCerificateN.Text);
                fiscalDevice.Type = fiscalDeviceTypeBox.Text;
                fiscalDevice.Manufacturer = fiscalDeviceManufacturerBox.Text;
                if (fiscalDeviceStartDateBox.Checked)
                {
                    fiscalDevice.StartDate = fiscalDeviceStartDateBox.Value;
                }
                else
                {
                    fiscalDevice.StartDate = null;
                }
                
                if (fiscalDevicePriceBox.Text != "")
                {
                    fiscalDevice.Price = decimal.Parse(fiscalDevicePriceBox.Text);
                }
                else
                {
                    fiscalDevice.Price = null;
                }
                if (fiscalDeviceWarrantyBox.Text != "")
                {
                    fiscalDevice.Warranty = int.Parse(fiscalDeviceWarrantyBox.Text);
                }
                else
                {
                    fiscalDevice.Warranty = null;
                }
                fiscalDevice.BulstatManufacturer = fiscalDeviceManufacturerBulstatBox.Text;
                if (addFiscalDiviceFlag)
                {
                    FiscalDeviceCtrl.AddFiscalDevice(fiscalDevice);
                    lvi = new ListViewItem(fiscalDevice.Type);
                    lvi.Tag = fiscalDevice.ID;
                    lvi.SubItems.Add(fiscalDevice.Model);
                    fiscalDevicesList.Items.Add(lvi);
                    hash.Add(fiscalDevice.Type);
                    FiscalTypeLoad();
                    man.Add(fiscalDevice.Manufacturer);
                    FiscalManufactureLoad();
                }
                else
                {
                    FiscalDeviceCtrl.UpdateFiscalDevice(selectedFiscalDeviceID, fiscalDevice);
                    fiscalDevicesList.SelectedItems[0].SubItems[0].Text = fiscalDevice.Type;
                    fiscalDevicesList.SelectedItems[0].SubItems[1].Text = fiscalDevice.Model;
                    ToggleControls(false);
                    addFiscalDeviceBtn.Enabled = true;
                    editFiscalDeviceBtn.Enabled = true;
                    deleteFiscalDeviceBtn.Enabled = true;
                    fiscalDevicesList.Enabled = true;
                    hash.Add(fiscalDevice.Type);
                    FiscalTypeLoad();
                }
                ResetControlsValue();

            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Редактиране на фискално Устройство";
            if (fiscalDevicesList.SelectedItems.Count > 0)
            {
                fiscalDevicesList.Enabled = false;
                addFiscalDeviceBtn.Enabled = false;
                editFiscalDeviceBtn.Enabled = false;
                deleteFiscalDeviceBtn.Enabled = false;
                addFiscalDiviceFlag = false;
                selectedFiscalDeviceID = int.Parse(fiscalDevicesList.SelectedItems[0].Tag.ToString());
                var fiscalDevice = FiscalDeviceCtrl.GetFiscalDevice(selectedFiscalDeviceID);
                if (fiscalDevice != null)
                {
                    LoadPanelWithData(fiscalDevice, true);
                }
            }
        }

        private void LoadPanelWithData(FiscalDevice fiscalDevice, bool toggle)
        {
            //ToggleControls(true);
            ToggleControls(toggle);
            fiscalDeviceTypeBox.Text = fiscalDevice.Type;
            fiscalDeviceModelBox.Text = fiscalDevice.Model;
            fiscalDeviceManufacturerBox.Text = fiscalDevice.Manufacturer;
            fiscalDeviceCerificateN.Text = fiscalDevice.CertificateN.ToString();
            if (fiscalDevice.StartDate.HasValue)
            {
                fiscalDeviceStartDateBox.Value = DateTime.Parse(fiscalDevice.StartDate.ToString());
            }
            else
            {
                fiscalDeviceStartDateBox.Value = DateTime.Now;
                fiscalDeviceStartDateBox.Checked = false;
            }
            fiscalDevicePriceBox.Text = fiscalDevice.Price.ToString();
            fiscalDeviceWarrantyBox.Text = fiscalDevice.Warranty.ToString();
            fiscalDeviceManufacturerBulstatBox.Text = fiscalDevice.BulstatManufacturer;
        }

        private void ResetControlsValue()
        {
            fiscalDeviceTypeBox.Text = string.Empty;
            fiscalDeviceModelBox.Text = string.Empty;
            fiscalDeviceManufacturerBox.Text = string.Empty;
            fiscalDeviceCerificateN.Text = string.Empty;
            fiscalDevicePriceBox.Text = string.Empty;
            fiscalDeviceWarrantyBox.Text = string.Empty;
            fiscalDeviceManufacturerBulstatBox.Text = string.Empty;
        }

        private void deleteFiscalDeviceBtn_Click(object sender, EventArgs e)
        {
            if (fiscalDevicesList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете това у-во ?",
                                    "Изтриване на фискално у-во",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(fiscalDevicesList.SelectedItems[0].Tag.ToString());
                    FiscalDeviceCtrl.DeleteFiscalDevice(id);
                    fiscalDevicesList.SelectedItems[0].Remove();
                }

            }
        }

        private void fiscalDevicesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedFiscalDeviceID = int.Parse(fiscalDevicesList.SelectedItems[0].Tag.ToString());
                var fiscalDevice = FiscalDeviceCtrl.GetFiscalDevice(selectedFiscalDeviceID);
                if (fiscalDevice != null)
                {
                    LoadPanelWithData(fiscalDevice, false);
                }
            }
        }

        private void fiscalDeviceCerificateN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fiscalDeviceWarrantyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fiscalDeviceManufacturerBulstatBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fiscalDeviceManufacturerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fiscalDeviceTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FiscalDevicesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (touched)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да излезете без да запазите информацията ?",
                                    "Изход",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    touched = false;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
