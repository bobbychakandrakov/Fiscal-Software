using Fiscal_Software.Forms;
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
//using Fiscal_Software.Forms;

namespace Fiscal_Software
{
    public partial class Form1 : Form
    {

        ListViewItem lvi;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void RefreshClients()
        {

            //clientsListView.Clear();
            clientsListView.Columns.Add("Фирма");
            clientsListView.Columns.Add("Булстат");
            clientsListView.Columns.Add("Телефон");
            clientsListView.Columns.Add("МОЛ");
            var clients = ClientCtrl.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                lvi = new ListViewItem(clients[i].Name);
                lvi.SubItems.Add(clients[i].Bulstat);
                lvi.SubItems.Add(clients[i].Telephone);
                lvi.SubItems.Add(clients[i].Mol);
                lvi.Tag = clients[i].ID;
                clientsListView.Items.Add(lvi);
            }
            clientsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            clientsListView.Columns[0].Width = 150;
            clientsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            clientsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            clientsListView.Columns[1].Width = 150;
            clientsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            clientsListView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            clientsListView.Columns[2].Width = 150;
            clientsListView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            clientsListView.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.None);
            clientsListView.Columns[3].Width = 150;
            clientsListView.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ServizniFirmi sf = new ServizniFirmi();
            sf.Show();
        }

        private void techniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechniciansForm techForm = new TechniciansForm();
            techForm.Show();
        }

        private void fiscalDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiscalDevicesForm fiscalDeviceForm = new FiscalDevicesForm();
            fiscalDeviceForm.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshClients();
        }
    }
}
