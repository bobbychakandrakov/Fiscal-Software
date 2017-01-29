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
    public partial class RemontiForm : Form
    {
        int id , rId;
        bool isUpdate = false, touched = false;
        Form1 f1;
        public RemontiForm()
        {
            InitializeComponent();
        }

        public RemontiForm(int id , Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
        }

        public RemontiForm(int id, Form1 f1, int rId)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
            this.rId = rId;
            isUpdate = true;
            var rm = RemontCtrl.GetRemontById(rId);
            LoadData(rm);
        }

        private void RemontiForm_Load(object sender, EventArgs e)
        {
            LoadTech();

            DirtyChecker.Check(Controls, c_ControlChanged);
        }


        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }

        private void LoadTech()
        {
            technicBox.DisplayMember = "Text";
            technicBox.ValueMember = "Value";
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
            technicBox.DataSource = list.ToList();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Remont remont = new Remont();
            remont.FiscalDeviceID = id;
            if (prietB.Checked)
            {
                remont.PrietV = prietB.Value;
            }
            else
            {
                remont.PrietV = null;
            }
            if (zaqvkaPodadena.Checked)
            {
                remont.ZaqvkaZadadena = zaqvkaPodadena.Value;
            }
            else
            {
                remont.ZaqvkaZadadena = null;
            }
            if (varnatNa.Checked)
            {
                remont.VurnatNa = varnatNa.Value;
            }
            else
            {
                remont.VurnatNa = null;
            }
            
            remont.Tehnik = int.Parse(technicBox.SelectedValue.ToString());
            remont.OpisanieDefekt = opisanieDefekt.Text;
            
            remont.ChastiPriRemont = chastiRemont.Text;
            if (isUpdate)
            {
                RemontCtrl.UpdateRemont(rId, remont);
            }
            else
            {
                RemontCtrl.AddRemont(remont);
            }
            f1.LoadRemonti();
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RemontiForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LoadData(Remont remont)
        {
            if (remont.PrietV.HasValue)
            {
                prietB.Checked = true;
                prietB.Value = remont.PrietV.Value;
            }
            if (remont.ZaqvkaZadadena.HasValue)
            {
                zaqvkaPodadena.Checked = true;
                zaqvkaPodadena.Value = remont.ZaqvkaZadadena.Value;
            }
            if (remont.Tehnik.HasValue)
            {
                technicBox.SelectedValue = remont.Tehnik;
            }
            if (remont.VurnatNa.HasValue)
            {
                varnatNa.Checked = true;
                varnatNa.Value = remont.VurnatNa.Value;
            }
            opisanieDefekt.Text = remont.OpisanieDefekt;
            chastiRemont.Text = remont.ChastiPriRemont;
        }
    }
}
