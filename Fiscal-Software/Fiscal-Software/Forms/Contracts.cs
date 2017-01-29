using Fiscal_Software.Controllers;
using Fiscal_Software.Controlles;
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
    public partial class Contracts : Form
    {

        ListViewItem lvi;
        // Add -> true Edit -> false
        bool addContractFlag = true, isHover = false, touched = false;
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
            contractsListView.Columns.Add("Срок ");
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
            contractsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            contractsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            DirtyChecker.Check(Controls, c_ControlChanged);
        }

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
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
            isHover = true;
            addContractFlag = true;
            ToggleControls(true);
            ResetControls();
            contractMP3Box.Enabled = false;
            addContractBtn.Enabled = false;
            editContractBtn.Enabled = false;
            deleteContractBtn.Enabled = false;
            contractsListView.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetControls();
                ToggleControls(false);
                addContractBtn.Enabled = true;
                editContractBtn.Enabled = true;
                deleteContractBtn.Enabled = true;
                contractsListView.Enabled = true;
                this.Text = "Договори";
            touched = false;

           
            

           
        }

        private void editContractBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Редактиране на Договор";
            isHover = true;
            addContractFlag = false;
            ToggleControls(true);
            addContractBtn.Enabled = false;
            editContractBtn.Enabled = false;
            deleteContractBtn.Enabled = false;
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
                    lvi = new ListViewItem(contract.Name);
                    lvi.Tag = contract.ID;
                    lvi.SubItems.Add(contract.Duration.ToString());
                    contractsListView.Items.Add(lvi);
                }
                else
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
                    ContractCtrl.UpdateContract(selectedContract,contract);
                    contractsListView.SelectedItems[0].SubItems[0].Text = contract.Name;
                    contractsListView.SelectedItems[0].SubItems[1].Text =contract.Duration.ToString();
                    ToggleControls(false);
                    addContractBtn.Enabled = true;
                    editContractBtn.Enabled = true;
                    deleteContractBtn.Enabled = true;
                    contractsListView.Enabled = true;
                }
                ResetControls();
            }
            else
            {
                MessageBox.Show("Моля, въведете име на договора!");
            }
            
            
        }

        private void contractSumForMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (isHover)
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
                var contract = ContractCtrl.GetContractById(selectedContract);
                if (contract != null)
                {
                    this.ResetControls();
                    LoadPanelWithData(contract);

                }
            }
        }

        private void deleteContractBtn_Click(object sender, EventArgs e)
        {

        }

        private void Contracts_FormClosing(object sender, FormClosingEventArgs e)
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

        private void deleteContractBtn_Click_1(object sender, EventArgs e)
        {
            if (contractsListView.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този договор ?",
                                   "Изход",
                           MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(contractsListView.SelectedItems[0].Tag.ToString());
                    ContractCtrl.DeleteContractById(id);
                    contractsListView.SelectedItems[0].Remove();
                }
            }
        }

        private void LoadPanelWithData(Contract contract)
        {
            isHover = false;
            contractNameBox.Text = contract.Name;
            contractDurationBox.Value = decimal.Parse(contract.Duration.ToString());
            contractPayToBox.Text = contract.PaymentTo;
           // contractSumBox.Text = contract.Price.ToString();
           // contractMP3Box.Text = contract.MP3.ToString();
            //contractSumForMonth.Checked
            if (contract.Price == 0 && contract.MP3 == 0)
            {
                contractSumForMonth.Checked = false;
                contractSumBox.Text = string.Empty;
                contractMP3Box.Text = string.Empty;
            }
            else if(contract.Price > 0)
            {
                contractSumForMonth.Checked = false;
                contractSumBox.Text = contract.Price.ToString();
            }
            else
            {
                contractSumForMonth.Checked = true;
                contractMP3Box.Text = contract.MP3.ToString();
            }
            contractProgrammingBox.Checked = contract.Programming != null ? bool.Parse(contract.Programming.ToString()) : false;
            contractProgrammingArticulBox.Checked = contract.ProgrammingArticul != null ? bool.Parse(contract.ProgrammingArticul.ToString()) : false; ;
            contractWorkBox.Checked = contract.Rabota != null ? bool.Parse(contract.Rabota.ToString()) : false; ;
            contractSparePartsBox.Checked = contract.SpareParts != null ? bool.Parse(contract.SpareParts.ToString()) : false; ;
            contractProtectBox.Checked = contract.Protect != null ? bool.Parse(contract.Protect.ToString()) : false; ;
            contractSpareModulesBox.Checked = contract.SpareModuls != null ? bool.Parse(contract.SpareModuls.ToString()) : false; ;
        }

        private void ResetControls()
        {
            contractNameBox.Text = string.Empty;
            contractDurationBox.Value =0;
            contractSumBox.Text = string.Empty;
           // contractSumForMonth.Text = string.Empty;
            contractPayToBox.Text = string.Empty;
            contractMP3Box.Text = string.Empty;
            contractProgrammingBox.Checked = false;
            contractProgrammingArticulBox.Checked = false;
            contractWorkBox.Checked = false;
            contractSparePartsBox.Checked = false;
            contractProtectBox.Checked = false;
            contractSpareModulesBox.Checked = false;
        }
    }
}
