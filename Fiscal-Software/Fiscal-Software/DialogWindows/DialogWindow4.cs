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
    public partial class DialogWindow4 : Form
    {

        public int Model { get; set; }
        public DialogWindow4()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Model = int.Parse(modelFYBox.SelectedValue.ToString());

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogWindow4_Load(object sender, EventArgs e)
        {
            modelFYBox.DisplayMember = "Text";
            modelFYBox.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> techHash = new HashSet<string>();
            var devices = FiscalDeviceCtrl.GetAllFiscalDevices();
            for (int i = 0; i < devices.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = devices[i].Model;
                item.Value = devices[i].ID;
                list.Add(item);
            }
            modelFYBox.DataSource = list.ToList();
        }
    }
}
