using Fiscal_Software.Helpers;
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
    public partial class SvidetelsvtoRegistraciqForm : Form
    {
        int id , oldId;
        bool isUpdate = false, touched = false;
        Form1 f1;
        public SvidetelsvtoRegistraciqForm()
        {
            InitializeComponent();
        }

        public SvidetelsvtoRegistraciqForm(int id, Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
        }

        public SvidetelsvtoRegistraciqForm(int id , SvidetelstvoRegistraciq sr, Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            LoadData(sr);
            oldId = sr.id;
            isUpdate = true;
            this.f1 = f1;
        }

        private void saveSvidetelsvto_Click(object sender, EventArgs e)
        {
            // Save to db
            if (technikBox.SelectedValue.ToString() == "" || dogovorBox.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Моля, попълнете задължителните полета!");
            }
            else
            {
                SvidetelstvoRegistraciq sr = new SvidetelstvoRegistraciq();
                sr.FiscalID = id;
                sr.RegDate = data.Value;
                if (svidetelstvoN.Text != "")
                {
                    sr.SvidetelstvoN = int.Parse(svidetelstvoN.Text);
                }
                sr.Technician = int.Parse(technikBox.SelectedValue.ToString());
                sr.Contract = int.Parse(dogovorBox.SelectedValue.ToString());
                if (regNapFDRID.Text != "")
                {
                    sr.RegNoNap = int.Parse(regNapFDRID.Text);
                }
                sr.AutoNumbering = avtomatichnoNomerirane.Checked;
                sr.Notes = notesBox.Text;
                sr.PrietObs = prietNa.Value;
                sr.PrekratenoObs = prekratenNa.Value;
                sr.Reason = prichini.Text;
                if (isUpdate)
                {
                    SvidetelstvoRegistraciqCtrl.UpdateSvidetelstvoRegistraciq(oldId , sr);
                }
                else
                {
                    SvidetelstvoRegistraciqCtrl.AddSvidetelstvoRegistraciq(sr);
                }
                touched = false;
                f1.LoadSvidetelstva();
                Close();
            }
        }

        private void LoadData(SvidetelstvoRegistraciq sr)
        {
            data.Value = sr.RegDate.Value;
            svidetelstvoN.Text  = sr.SvidetelstvoN.ToString();
            technikBox.SelectedValue = sr.Technician;
            dogovorBox.SelectedValue = sr.Contract;
            regNapFDRID.Text = sr.RegNoNap.ToString();
            if (sr.AutoNumbering.HasValue)
            {
                avtomatichnoNomerirane.Checked = sr.AutoNumbering.Value;
            }
            notesBox.Text = sr.Notes;
            prietNa.Value = sr.PrietObs;
            prekratenNa.Value = sr.PrekratenoObs.Value;
            prichini.Text = sr.Reason ;
            //SvidetelstvoRegistraciqCtrl.AddSvidetelstvoRegistraciq(sr);
        }

        private void cancelSvidetelsvto_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
            Close();
        }

        private void SvidetelsvtoRegistraciqForm_Load(object sender, EventArgs e)
        {
            LoadTech();
            LoadContracts();
            DirtyChecker.Check(Controls, c_ControlChanged);
        }
        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }

        private void SvidetelsvtoRegistraciqForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void prekratenNa_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void prekratenNa_ValueChanged(object sender, EventArgs e)
        {
            if (prekratenNa.Checked)
            {
                prichini.Enabled = true;
            }
            else
            {
                prichini.Enabled = false;
            }
        }

        private void LoadTech()
        {
            technikBox.DisplayMember = "Text";
            technikBox.ValueMember = "Value";
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
            technikBox.DataSource = list.ToList();
        }

        private void LoadContracts()
        {
            dogovorBox.DisplayMember = "Text";
            dogovorBox.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> contractHash = new HashSet<string>();
            var contracts = ContractCtrl.GetAllContracts();
            for (int i = 0; i < contracts.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = contracts[i].Name;
                item.Value = contracts[i].ID;
                list.Add(item);
            }
            dogovorBox.DataSource = list.ToList();
        }
    }
}
