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
        Form1 f1;
        int id;
        bool isEditing = false , touched = false;
        public AddFiscalDevice()
        {
            InitializeComponent();
        }

        public AddFiscalDevice(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public AddFiscalDevice(Form1 f1, int id)
        {
            InitializeComponent();
            this.f1 = f1;
            this.id = id;
            isEditing = true;
        }
        private void LoadData(DanniFiskalnoUstroistvo dfu)
        {
            servizBox.SelectedValue = dfu.Serviz;
            obektBox.SelectedValue = dfu.Obekt;
            modelFUCRU.SelectedValue = dfu.ModelFY;
            fuNomer.Text = dfu.FYNomer.ToString();
            fpNomer.Text = dfu.FPNomer.ToString();
            fpAktivirana.Value = dfu.FPAktivirana.Value;
            fpDemontirana.Value = dfu.FPDeaktivirana.Value;
            garanciqDo.Value = dfu.GuaranteeUntil.Value;
            platenSimDo.Value = dfu.PayedSim.Value;

            regNapNomer.Text = dfu.RegNoNap.ToString();
            simID.Text = dfu.SimID.ToString();
            simTelN.Text= dfu.SimTelNomer.ToString();

            nivomer.Text = dfu.Nivomer;
            regFirma.Text = dfu.Company;
            regGrad.Text = dfu.Town;
            regTexnik.Text = dfu.Technician;
            regAdres.Text = dfu.Address;
            regTel.Text = dfu.Tel;
            regDate.Value = dfu.RegDate.Value;
            esfpType.Text = dfu.ESFPT;
            modelESFP.Text = dfu.ModelESFP;
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
                dfu.ESFPT = esfpType.Text;
                dfu.ModelESFP = modelESFP.Text;
                if (isEditing)
                {
                    DanniFiskalnoUstroistvoCtrl.UpdateDanniFiskalnoUstroistvo(this.id, dfu);
                }
                else
                {
                    DanniFiskalnoUstroistvoCtrl.AddDanniFiskalnoUstroistvo(dfu);
                }
                f1.LoadDanni();
                touched = false;
                this.Close();
            }
           
        }

        private void cancelFD_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
            if (touched)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да излезете без да запазите информацията ?",
                                    "Изход",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void AddFiscalDevice_Load(object sender, EventArgs e)
        {
            fpDemontirana.ShowCheckBox = true;
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
            if (isEditing)
            {
                LoadData(DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(id));
            }
            DirtyChecker.Check(this.Controls, c_ControlChanged);
        }

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
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

        private void AddFiscalDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void AddFiscalDevice_FormClosing(object sender, FormClosingEventArgs e)
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

        private void fpDemontirana_ValueChanged(object sender, EventArgs e)
        {
            fpDemontirana.Format = DateTimePickerFormat.Long;
        }

        private void fpDemontirana_DropDown(object sender, EventArgs e)
        {
            fpDemontirana.Format = DateTimePickerFormat.Long;
        }

        private void platenSimDo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fpNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
