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
        bool isUpdate = false;
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
            remont.PrietV = prietB.Value;
            remont.ZaqvkaZadadena = zaqvkaPodadena.Value;
            remont.Tehnik = int.Parse(technicBox.SelectedValue.ToString());
            remont.OpisanieDefekt = opisanieDefekt.Text;
            remont.VurnatNa = varnatNa.Value;
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

        private void LoadData(Remont remont)
        {
            if (remont.PrietV.HasValue)
            {
                prietB.Value = remont.PrietV.Value;
            }
            if (remont.ZaqvkaZadadena.HasValue)
            {
                zaqvkaPodadena.Value = remont.ZaqvkaZadadena.Value;
            }
            if (remont.Tehnik.HasValue)
            {
                technicBox.SelectedValue = remont.Tehnik;
            }
            if (remont.VurnatNa.HasValue)
            {
                varnatNa.Value = remont.VurnatNa.Value;
            }
            opisanieDefekt.Text = remont.OpisanieDefekt;
            chastiRemont.Text = remont.ChastiPriRemont;
        }
    }
}
