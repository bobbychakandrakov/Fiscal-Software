using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiscal_Software.Helpers;
using Fiscal_Software.Controllers;

namespace Fiscal_Software.Forms
{
    public partial class ServizniFirmi : Form
    {
        ListViewItem lvi;
        // Add -> true Edit -> false
        bool addCompanyFlag = true;
        int selectedCompanyID;
        public ServizniFirmi()
        {
            InitializeComponent();

        }

        private void ServizniFirmi_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            this.LoadListData();
        }

        private void LoadListData()
        {

            companyListView.Columns.Add("Фирма");

            companyListView.View = View.Details;
            var companies = CompanyCtrl.GetAllCompanies();

            for (int i = 0; i < companies.Length; i++)
            {
                lvi = new ListViewItem(companies[i].Name);
                lvi.Tag = companies[i].ID;
                companyListView.Items.Add(lvi);
            }
            companyListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            companyListView.Columns[0].Width = 70;
            companyListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

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
            ResetControlsValue();
            companyListView.Enabled = false;
            this.ToggleControls(true);
            addCompanyBtn.Enabled = false;
            editCompanyBtn.Enabled = false;
            deleteCompanyBtn.Enabled = false;
            addCompanyFlag = true;
        }

        private void cancelSaveBtn_Click(object sender, EventArgs e)
        {
            companyListView.Enabled = true;
            this.ToggleControls(false);
            addCompanyBtn.Enabled = true;
            editCompanyBtn.Enabled = true;
            deleteCompanyBtn.Enabled = true;
        }

        private void ResetControlsValue()
        {
            companyNameBox.Text = string.Empty;
            companyDanNumberBox.Text = string.Empty;
            companyBulstatBox.Text = string.Empty;
            companyFDTownBox.Text = string.Empty;
            companyFDDateBox.Text = string.Empty;
            companyFDNumberBox.Text = string.Empty;
            companyCertificateNBox.Text = string.Empty;
            companyTownBox.Text = string.Empty;
            companyAddressBox.Text = string.Empty;
            companyTelephoneBox.Text = string.Empty;
            companyFaxBox.Text = string.Empty;
            companyEmailBox.Text = string.Empty;
            companyWebBox.Text = string.Empty;
            companyMolBox.Text = string.Empty;
        }

        private void saveCompanyBtn_Click(object sender, EventArgs e)
        {
            if (companyNameBox.Text != "" && companyTownBox.Text != ""
                && companyAddressBox.Text != "" && companyMolBox.Text != ""
                && companyBulstatBox.Text != "")
            {
                try
                {
                    if (!BulstatChecker.calculateChecksumForNineDigitsEIK(companyBulstatBox.Text))
                    {
                        MessageBox.Show("Невалиден булстат", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Company company = new Company();
                        company.Name = companyNameBox.Text;
                        company.Bulstat = companyBulstatBox.Text;
                        company.Town = companyTownBox.Text;
                        company.Address = companyAddressBox.Text;
                        company.Mol = companyMolBox.Text;
                        if (companyCertificateNBox.Text != "")
                        {
                            company.CertificateN = int.Parse(companyCertificateNBox.Text);
                        }
                        else
                        {
                            company.CertificateN = null;
                        }
                        company.DanNumber = companyDanNumberBox.Text;
                        company.Email = companyEmailBox.Text;
                        company.Fax = companyFaxBox.Text;
                        company.FDDate = companyFDDateBox.Value;
                        company.FDNumber = companyFDNumberBox.Text;
                        company.FDTown = companyFDTownBox.Text;
                        company.Telephone = companyTelephoneBox.Text;
                        company.Web = companyWebBox.Text;
                        if (addCompanyFlag)
                        {
                            CompanyCtrl.AddCompany(company);
                            lvi = new ListViewItem(company.Name);
                            lvi.Tag = company.ID;
                            companyListView.Items.Add(lvi);
                        }
                        else
                        {
                            CompanyCtrl.UpdateCompany(selectedCompanyID, company);
                            companyListView.SelectedItems[0].Text = company.Name;
                            ToggleControls(false);
                            addCompanyBtn.Enabled = true;
                            editCompanyBtn.Enabled = true;
                            deleteCompanyBtn.Enabled = true;
                            companyListView.Enabled = true;
                        }
                        ResetControlsValue();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невалиден булстат", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void companyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedCompanyID = int.Parse(companyListView.SelectedItems[0].Tag.ToString());
                var company = CompanyCtrl.GetCompanyById(selectedCompanyID);
                if (company != null)
                {
                    LoadPanelWithData(company,false);
                }
            }
        }

        private void deleteCompanyBtn_Click(object sender, EventArgs e)
        {

            if (companyListView.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете " + companyListView.SelectedItems[0].Text + " ?",
                                    "Изтриване на фирма",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(companyListView.SelectedItems[0].Tag.ToString());
                    CompanyCtrl.DeleteCompanyById(id);
                    companyListView.SelectedItems[0].Remove();
                }
                
            }
        }

        private void editCompanyBtn_Click(object sender, EventArgs e)
        {

            if (companyListView.SelectedItems.Count > 0)
            {
                companyListView.Enabled = false;
                addCompanyBtn.Enabled = false;
                editCompanyBtn.Enabled = false;
                deleteCompanyBtn.Enabled = false;
                addCompanyFlag = false;
                selectedCompanyID = int.Parse(companyListView.SelectedItems[0].Tag.ToString());
                var company = CompanyCtrl.GetCompanyById(selectedCompanyID);
                if (company != null)
                {
                    LoadPanelWithData(company,true);
                }
            }
        }

        private void LoadPanelWithData(Company company, bool toggle)
        {
            //ToggleControls(true);
            ToggleControls(toggle);
            companyNameBox.Text = company.Name;
            companyDanNumberBox.Text = company.DanNumber;
            companyBulstatBox.Text = company.Bulstat;
            companyFDTownBox.Text = company.FDTown;
            companyFDDateBox.Value = DateTime.Parse(company.FDDate.ToString());
            companyFDNumberBox.Text = company.FDNumber;
            companyCertificateNBox.Text = company.CertificateN.ToString();
            companyTownBox.Text = company.Town;
            companyAddressBox.Text = company.Address;
            companyTelephoneBox.Text = company.Telephone;
            companyFaxBox.Text = company.Fax;
            companyEmailBox.Text = company.Email;
            companyWebBox.Text = company.Web;
            companyMolBox.Text = company.Mol;
        }
    }
}
