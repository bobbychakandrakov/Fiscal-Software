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
    public partial class DialogWindow3 : Form
    {

        public int ServiznaFirma { get; set; }

        public string DanuchnaSlyjba { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DialogWindow3()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.ServiznaFirma = int.Parse(serviznaFirmaBox.SelectedValue.ToString());

            this.DanuchnaSlyjba = danachenBox.SelectedValue.ToString();

            this.FromDate = fromDate.Value;

            this.ToDate = toDate.Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogWindow3_Load(object sender, EventArgs e)
        {
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

            danachenBox.DisplayMember = "Text";
            danachenBox.ValueMember = "Value";
            list.Clear();
            HashSet<string> tdd = new HashSet<string>();
            var clients = ClientCtrl.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                tdd.Add(clients[i].TDD);
            }
            string[] tdds = tdd.ToArray();
            for (int i = 0; i < tdds.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = tdds[i];
                item.Value = tdds[i];
                list.Add(item);
            }
            danachenBox.DataSource = list.ToList();
        }
    }
}
