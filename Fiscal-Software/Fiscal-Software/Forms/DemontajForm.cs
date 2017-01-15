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
    public partial class DemontajForm : Form
    {
        int id , dId;
        bool isUpdate = false, touched = false;
        Form1 f1;
        public DemontajForm()
        {
            InitializeComponent();
        }

        public DemontajForm(int id , Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
        }

        public DemontajForm(int id, Form1 f1, int dId)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
            this.dId = dId;
            var dfu = DemontajFiskalnoUstroistvoCtrl.GetDemontajFiskalnoUstroistvoById(dId);
            LoadData(dfu);
            this.isUpdate = true;
        }

        private void LoadData(DemontajNaFiskalnoUstroistvo dfu)
        {
            if (dfu.DateDemontaj.HasValue)
            {
                dataDemontaj.Value = dfu.DateDemontaj.Value;
            }
            fpNomer.Text = dfu.FPNomer.ToString();
            technicianBox.SelectedValue = dfu.Technician;
            if (dfu.OborotOt.HasValue)
            {
                oborotOt.Value = dfu.OborotOt.Value;
            }
            if (dfu.OborotDo.HasValue)
            {
                oborotDo.Value =  dfu.OborotDo.Value;
            }
            oborotSum.Text = dfu.Suma.ToString();
            if (dfu.DDS1.HasValue)
            {
                sum1.Text = dfu.DDS1.ToString();
            }
            if (dfu.DDS2.HasValue)
            {
                sum2.Text = dfu.DDS2.ToString();
            }
            if (dfu.DDS3.HasValue)
            {
                sum3.Text = dfu.DDS3.ToString();
            }
            if (dfu.DDS4.HasValue)
            {
                sum4.Text = dfu.DDS4.ToString();
            }
            inspektorIme.Text = dfu.InspectorName;
            inspectorTel.Text = dfu.InspectorTel;
            prichiniBox.Text = dfu.Reasons;
            oborotPrezGodinite.Text = dfu.OborotPoGodini;
        }

        private void saveDemontaj_Click(object sender, EventArgs e)
        {
            // Save to db
            if (technicianBox.SelectedValue.ToString() != "")
            {
                DemontajNaFiskalnoUstroistvo dfu = new DemontajNaFiskalnoUstroistvo();
                dfu.DateDemontaj = dataDemontaj.Value;
                dfu.FiscalID = this.id;
                if (fpNomer.Text != "")
                {
                    dfu.FPNomer = int.Parse(fpNomer.Text);
                }
                dfu.Technician = int.Parse(technicianBox.SelectedValue.ToString());
                dfu.OborotOt = oborotOt.Value;
                dfu.OborotDo = oborotDo.Value;
                if (oborotSum.Text != "")
                {
                    dfu.Suma = double.Parse(oborotSum.Text);
                }
                if (sum1.Text != "")
                {
                    dfu.DDS1 = double.Parse(sum1.Text);
                }
                if (sum2.Text != "")
                {
                    dfu.DDS2 = double.Parse(sum2.Text);
                }
                if (sum3.Text != "")
                {
                    dfu.DDS3 = double.Parse(sum3.Text);
                }
                if (sum4.Text != "")
                {
                    dfu.DDS4 = double.Parse(sum4.Text);
                }
                dfu.InspectorName = inspektorIme.Text;
                dfu.InspectorTel = inspectorTel.Text;
                dfu.Reasons = prichiniBox.Text;
                dfu.OborotPoGodini = oborotPrezGodinite.Text;
                if (isUpdate)
                {
                    DemontajFiskalnoUstroistvoCtrl.UpdateDemontajFiskalno(dId, dfu);
                }
                else
                {
                    DemontajFiskalnoUstroistvoCtrl.AddDemontajFiskalno(dfu);
                }
                touched = false;
                f1.LoadDemontaji();
                Close();
            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!");
            }
        }

        private void cancelDemontaj_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
            Close();
        }

        private void DemontajForm_Load(object sender, EventArgs e)
        {
            LoadTech();
            DirtyChecker.Check(Controls, c_ControlChanged);
        }

        private void DemontajForm_FormClosing(object sender, FormClosingEventArgs e)
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

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }
        private void LoadTech()
        {
            technicianBox.DisplayMember = "Text";
            technicianBox.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> techHash = new HashSet<string>();
            var techincians = TechnicianCtrl.GetAllTechnicians();
            for (int i = 0; i < techincians.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = techincians[i].Name;
                item.Value = techincians[i].ID;
                list.Add(item);
            }
            technicianBox.DataSource = list.ToList();
        }

    }
}
