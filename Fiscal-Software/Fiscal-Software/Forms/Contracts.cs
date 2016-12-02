using Fiscal_Software.Controlles;
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
    public partial class Contracts : Form
    {

        ListViewItem lvi;
        // Add -> true Edit -> false
        bool addContractFlag = true;
        int selectedContract;
        public Contracts()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            contractsListView.Columns.Add("Име");
            contractsListView.Columns.Add("Срок");
            var contracts = ContractCtrl.GetAllContracts();
            for (int i = 0; i < contracts.Length; i++)
            {
                lvi = new ListViewItem(contracts[i].Name);
                lvi.Tag = contracts[i].ID;
                lvi.SubItems.Add(contracts[i].Duration.ToString());
                contractsListView.Items.Add(lvi);
            }

            // ListView Design
            contractsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            contractsListView.Columns[0].Width = 150;
            contractsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            contractsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            contractsListView.Columns[1].Width = 150;
            contractsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            contractsListView.Columns[1].TextAlign = HorizontalAlignment.Right;
        }

        private void ToggleControls(bool isEnabled)
        {
            contractNameBox.Enabled = isEnabled;
            contractDurationBox.Enabled = isEnabled;
            contractSumBox.Enabled = isEnabled;
            contractSumForMonth.Enabled = isEnabled;
            contractPayToBox.Enabled = isEnabled;
            contractMP3Box.Enabled = isEnabled;
            contractProgrammingBox.Enabled = isEnabled;
            contractProgrammingArticulBox.Enabled = isEnabled;
            contractWorkBox.Enabled = isEnabled;
            contractSparePartsBox.Enabled = isEnabled;
            contractProtectBox.Enabled = isEnabled;
            contractSpareModulesBox.Enabled = isEnabled;
            cancelBtn.Enabled = isEnabled;
            saveContractBtn.Enabled = isEnabled;
        }

        private void addContractBtn_Click(object sender, EventArgs e)
        {
            addContractFlag = true;
            ToggleControls(true);
            contractMP3Box.Enabled = false;
            addContractBtn.Enabled = false;
            editContractBtn.Enabled = false;
            deleteContractBtn.Enabled = false;
            contractsListView.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ToggleControls(false);
            addContractBtn.Enabled = true;
            editContractBtn.Enabled = true;
            deleteContractBtn.Enabled = true;
            contractsListView.Enabled = true;
        }

        private void editContractBtn_Click(object sender, EventArgs e)
        {
            addContractFlag = false;
        }

        private void saveContractBtn_Click(object sender, EventArgs e)
        {
            if (contractNameBox.Text != "")
            {
                if (addContractFlag)
                {
                    var contract = new Contract();
                    contract.Name = contractNameBox.Text;
                    contract.Duration = int.Parse(contractDurationBox.Value.ToString());
                    contract.MP3 = contractMP3Box.Text != "" ? double.Parse(contractMP3Box.Text) : 0;
                    contract.Price = contractSumBox.Text != "" ? decimal.Parse(contractSumBox.Text) : 0;
                    contract.PaymentTo = contractPayToBox.Text;
                    contract.Programming = contractProgrammingBox.Checked;
                    contract.ProgrammingArticul = contractProgrammingArticulBox.Checked;
                    contract.Rabota = contractWorkBox.Checked;
                    contract.SpareParts = contractSparePartsBox.Checked;
                    contract.Protect = contractProtectBox.Checked;
                    contract.SpareModuls = contractSpareModulesBox.Checked;
                    ContractCtrl.AddContract(contract);
                }
                else
                {
                    var contract = new Contract();
                    contract.Name = contractNameBox.Text;
                    contract.Duration = int.Parse(contractDurationBox.Value.ToString());
                    contract.MP3 = double.Parse(contractMP3Box.Text);
                    contract.Price = decimal.Parse(contractSumBox.Text);
                    contract.PaymentTo = contractPayToBox.Text;
                    contract.Programming = contractProgrammingBox.Checked;
                    contract.ProgrammingArticul = contractProgrammingArticulBox.Checked;
                    contract.Rabota = contractWorkBox.Checked;
                    contract.SpareParts = contractSparePartsBox.Checked;
                    contract.Protect = contractProtectBox.Checked;
                    contract.SpareModuls = contractSpareModulesBox.Checked;
                    ContractCtrl.UpdateContract(selectedContract,contract);
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете име на договора!");
            }
            
            
        }

        private void contractSumForMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (contractSumForMonth.Checked)
            {
                contractMP3Box.Enabled = true;
                contractSumBox.Enabled = false;
            }
            else
            {
                contractMP3Box.Enabled = false;
                contractSumBox.Enabled = true;
            }
        }

        private void contractSumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void contractsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedContract = int.Parse(contractsListView.SelectedItems[0].Tag.ToString());
            }
        }
    }
}
