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
    public partial class DialogWindow2 : Form
    {

        public int Firma { get; set; }

        public DialogWindow2()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Firma = int.Parse(firmaBox.SelectedValue.ToString());

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogWindow2_Load(object sender, EventArgs e)
        {
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            firmaBox.DisplayMember = "Text";
            firmaBox.ValueMember = "Value";
            var clients = ClientCtrl.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = clients[i].Name;
                item.Value = clients[i].ID;
                list.Add(item);
            }
            firmaBox.DataSource = list.ToList();
        }
    }
}
