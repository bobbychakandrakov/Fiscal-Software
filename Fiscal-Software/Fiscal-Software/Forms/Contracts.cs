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
    public partial class Contracts : Form
    {

        ListViewItem lvi;
        public Contracts()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            contractsListView.Columns.Add("Име");
            contractsListView.Columns.Add("Срок");
            lvi = new ListViewItem("Namedwadawdawda");
            lvi.SubItems.Add("12");
            contractsListView.Items.Add(lvi);

            // ListView Design
            contractsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            contractsListView.Columns[0].Width = 150;
            contractsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            contractsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            contractsListView.Columns[1].Width = 150;
            contractsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            contractsListView.Columns[1].TextAlign = HorizontalAlignment.Right;
        }

        private void ToggleControls(bool isEnabled)
        {

        }
    }
}
