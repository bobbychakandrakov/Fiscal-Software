using Fiscal_Software.Controllers;
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
    public partial class TechniciansForm : Form
    {
        ListViewItem lvi;
        // Add -> true Edit -> false
        bool addTechnicianFlag = true;
        int selectedTechnicianID;
        public TechniciansForm()
        {
            InitializeComponent();
        }

        private void TechniciansForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Fiscal_SoftwareDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this._Fiscal_SoftwareDataSet.Company);
            this.ToggleControls(false,true);
            techniciansList.Columns.Add("Фирма");
            techniciansList.Columns.Add("Име");
            var technicians = TechnicianCtrl.GetAllTechnicians();
           
            for (int i = 0; i < technicians.Length; i++)
            {
                lvi = new ListViewItem(CompanyCtrl.GetCompanyById(technicians[i].CompanyID).Name);
                lvi.Tag = technicians[i].ID;
                lvi.SubItems.Add(technicians[i].Name);
                techniciansList.Items.Add(lvi);
            }

            techniciansList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            techniciansList.Columns[0].Width = 150;
            techniciansList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            techniciansList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            techniciansList.Columns[1].Width = 150;
            techniciansList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ToggleControls(bool areEnabled, bool list)
        {
            technicianCompanyBox.Enabled = areEnabled;
            technicianNameBox.Enabled = areEnabled;
            technicianEGNBox.Enabled = areEnabled;
            technicianTelephoneBox.Enabled = areEnabled;
            saveTechnicianBtn.Enabled = areEnabled;
            cancelTechnicianBtn.Enabled = areEnabled;
            techniciansList.Enabled = list;
        }

        private void addTechnicianBtn_Click(object sender, EventArgs e)
        {
            ResetControls();
            this.ToggleControls(true, false);
            addTechnicianBtn.Enabled = false;
            editTechnicianBtn.Enabled = false;
            deleteTechnicianBtn.Enabled = false;
        }

        private void cancelTechnicianBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(false,true);
            addTechnicianBtn.Enabled = true;
            editTechnicianBtn.Enabled = true;
            deleteTechnicianBtn.Enabled = true;
        }

        private void saveTechnicianBtn_Click(object sender, EventArgs e)
        {
            if (technicianNameBox.Text != "" && technicianCompanyBox.Text != "")
            {
                Technician tech = new Technician();
                // Impliment tag
                tech.CompanyID = 12;
                tech.Name = technicianNameBox.Text;
                tech.Telephone = technicianTelephoneBox.Text;
                tech.EGN = technicianEGNBox.Text;
                if (addTechnicianFlag)
                {
                    TechnicianCtrl.AddTechnician(tech);
                    lvi = new ListViewItem(CompanyCtrl.GetCompanyById(tech.CompanyID).Name);
                    lvi.SubItems.Add(tech.Name);
                    techniciansList.Items.Add(lvi);
                }
                else
                {
                    TechnicianCtrl.UpdateTechnician(selectedTechnicianID, tech);
                    techniciansList.SelectedItems[0].SubItems[0].Text = CompanyCtrl.GetCompanyById(tech.CompanyID).Name;
                    techniciansList.SelectedItems[0].SubItems[1].Text = tech.Name;
                    ToggleControls(false, true);
                    addTechnicianBtn.Enabled = true;
                    editTechnicianBtn.Enabled = true;
                    deleteTechnicianBtn.Enabled = true;
                }
                
                ResetControls();
            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControls()
        {
            technicianCompanyBox.Text = string.Empty;
            technicianNameBox.Text = string.Empty;
            technicianEGNBox.Text = string.Empty;
            technicianTelephoneBox.Text = string.Empty;
        }

        private void deleteTechnicianBtn_Click(object sender, EventArgs e)
        {
            if (techniciansList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този техник ?",
                                   "Изтриване на техник",
                           MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(techniciansList.SelectedItems[0].Tag.ToString());
                    TechnicianCtrl.DeleteTechnicianById(id);
                    techniciansList.SelectedItems[0].Remove();
                }
            }
        }

        private void editTechnicianBtn_Click(object sender, EventArgs e)
        {
            addTechnicianFlag = false;
            var tech = TechnicianCtrl.GetTechnicianById(selectedTechnicianID);
            LoadPanelWithData(tech, true);
            addTechnicianBtn.Enabled = false;
            editTechnicianBtn.Enabled = false;
            deleteTechnicianBtn.Enabled = false;
            techniciansList.Enabled = false;
        }

        private void LoadPanelWithData(Technician tech, bool toggle)
        {
            //ToggleControls(true);
            ToggleControls(toggle,true);
            technicianCompanyBox.Text = tech.Company.Name;
            technicianNameBox.Text = tech.Name;
            technicianEGNBox.Text = tech.EGN;
            technicianTelephoneBox.Text = tech.Telephone;
        }

        private void techniciansList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedTechnicianID = int.Parse(techniciansList.SelectedItems[0].Tag.ToString());
                var tech = TechnicianCtrl.GetTechnicianById(selectedTechnicianID);
                if (tech != null)
                {
                    LoadPanelWithData(tech, false);
                }
            }
        }

        private void technicianEGNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void technicianTelephoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
