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

namespace Fiscal_Software.DialogWindows
{
    public partial class DialogWindow1 : Form
    {

        private bool neplaten;
        
        public int ServiznaFirma { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public DialogWindow1()
        {
            InitializeComponent();
        }

        public DialogWindow1(bool neplaten)
        {
            InitializeComponent();
            this.neplaten = neplaten;
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            this.ServiznaFirma = int.Parse(serviznaFirmaBox.SelectedValue.ToString());

            this.FromDate = fromDate.Value;

            this.ToDate = toDate.Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogWindow1_Load(object sender, EventArgs e)
        {
            if (neplaten)
            {
                label4.Text = "Период на сключване на договора";
            }
            serviznaFirmaBox.DisplayMember = "Text";
            serviznaFirmaBox.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> techHash = new HashSet<string>();
            var companies = CompanyCtrl.GetAllCompanies();
            for (int i = 0; i < companies.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = companies[i].Name;
                item.Value = companies[i].ID;
                list.Add(item);
            }
            serviznaFirmaBox.DataSource = list.ToList();
        }
    }
}
