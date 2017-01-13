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
using Fiscal_Software.Helpers;

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
            if (fuNomer.Text.Length != 8)
            {
                MessageBox.Show("ФУ номер трябва да е 8 символа!");
            }
            else if(fpNomer.Text.Length != 8)
            {
                MessageBox.Show("ФП номер трябва да е 8 символа!");
            }
            else if (regFirma.Text == "" || regGrad.Text == "" || regTexnik.Text == "" || regAdres.Text == "")
            {
                MessageBox.Show("Моля, попълнете данните за регистрация!");
            }
            else
            {
                DanniFiskalnoUstroistvo dfu = new DanniFiskalnoUstroistvo();
                dfu.Serviz = int.Parse(servizBox.SelectedValue.ToString());
                dfu.Obekt = int.Parse(obektBox.SelectedValue.ToString());
                dfu.ModelFY = int.Parse(modelFUCRU.SelectedValue.ToString());
                dfu.FYNomer = int.Parse(fuNomer.Text);
                dfu.FPNomer = int.Parse(fpNomer.Text);
                dfu.FPAktivirana = fpAktivirana.Value;
                dfu.FPDeaktivirana = fpDemontirana.Value;
                dfu.GuaranteeUntil = garanciqDo.Value;
                dfu.PayedSim = platenSimDo.Value;
                if (regNapNomer.Text != "")
                {
                    dfu.RegNoNap = int.Parse(regNapNomer.Text);
                }
                dfu.RegNapDate = regNapDate.Value;
                if (simTelN.Text != "")
                {
                    dfu.SimTelNomer = int.Parse(simTelN.Text);
                }
                if (simID.Text != "")
                {
                    dfu.SimID = int.Parse(simID.Text);
                }
                dfu.Nivomer = nivomer.Text;
                dfu.Company = regFirma.Text;
                dfu.Town = regGrad.Text;
                dfu.Technician = regTexnik.Text;
                dfu.Address = regAdres.Text;
                dfu.Tel = regTel.Text;
                dfu.RegDate = regDate.Value;
                DanniFiskalnoUstroistvoCtrl.AddDanniFiskalnoUstroistvo(dfu);
            }
           
        }

        private void cancelFD_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
            this.Close();
        }

        private void AddFiscalDevice_Load(object sender, EventArgs e)
        {
            servizBox.DisplayMember = "Text";
            servizBox.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> companyHash = new HashSet<string>();
            var companies = CompanyCtrl.GetAllCompanies();
            for (int i = 0; i < companies.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = companies[i].Name;
                item.Value = companies[i].ID;
                list.Add(item);
                //companyHash.Add(companies[i].Name);
            }

            //servizBox.DataSource = companyHash.ToList();
            servizBox.DataSource = list.ToList();
            list.Clear();
            HashSet<string> obektiHash = new HashSet<string>();
            var obekti = ObjectCtrl.GetAllObjects();
            for (int i = 0; i < obekti.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = obekti[i].Type;
                item.Value = obekti[i].ID;
                list.Add(item);
                //obektiHash.Add(obekti[i].Type);
            }
            obektBox.DisplayMember = "Text";
            obektBox.ValueMember = "Value";
            //obektBox.DataSource = obektiHash.ToList();
            obektBox.DataSource = list.ToList();
            list.Clear();
            HashSet<string> fiscalDeviceHash = new HashSet<string>();
            var fiscalDevices = FiscalDeviceCtrl.GetAllFiscalDevices();
            for (int i = 0; i < fiscalDevices.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = fiscalDevices[i].Model;
                item.Value = fiscalDevices[i].ID;
                list.Add(item);
                //fiscalDeviceHash.Add(fiscalDevices[i].Model);
            }
            modelFUCRU.DisplayMember = "Text";
            modelFUCRU.ValueMember = "Value";
            //
            modelESFP.DisplayMember = "Text";
            modelESFP.ValueMember = "Value";
            //
            //modelFUCRU.DataSource = fiscalDeviceHash.ToList();
            //modelESFP.DataSource = fiscalDeviceHash.ToList();
            modelFUCRU.DataSource = list.ToList();
            modelESFP.DataSource = list.ToList();
        }

        private void servizBox_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void servizBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fuNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void fpNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
