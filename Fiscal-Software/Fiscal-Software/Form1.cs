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
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using Fiscal_Software.Helpers;
using System.IO;
using Fiscal_Software.Controlles;
//using Fiscal_Software.Forms;

namespace Fiscal_Software
{
    
    public partial class Form1 : Form
    {
        ListViewItem lvi;
        ListViewItem lvi1;
        int selectedClientId;
        Client client;

        public Form1()
        {
            InitializeComponent();
            DatabaseSettings.SetupDatabase();
        }

        public void AddClient(Client client)
        {
            this.lvi = new ListViewItem(client.Name);
            this.lvi.SubItems.Add(client.Bulstat);
            this.lvi.SubItems.Add(client.Telephone);
            this.lvi.SubItems.Add(client.Mol);
            this.lvi.Tag = client.ID;
            this.clientsListView.Items.Add(lvi);
        }
        private void RefreshClients()
        {
            clientsListView.Clear();
            clientsListView.Columns.Add("Фирма");
            clientsListView.Columns.Add("Дан. N");
            clientsListView.Columns.Add("Булстат");
            //clientsListView.Columns.Add("Телефон");
           // clientsListView.Columns.Add("МОЛ");
            var clients = ClientCtrl.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                lvi = new ListViewItem(clients[i].Name);
                lvi.SubItems.Add(clients[i].FDNumber);
                lvi.SubItems.Add(clients[i].Bulstat);
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
            ClientsForm clientsForm = new ClientsForm(this);
            clientsForm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (DatabaseSettings.IsSet)
            {
                RefreshClients();
            }
            /*
            using (var ctx=new FiscalSoftware())
            {
                var contract = new Contract();
                contract.Name = "bachka";
                ctx.Contracts.Add(contract);
                ctx.SaveChanges();
            }
            */
            
            
        }

        public void LoadDataAfter()
        {
            if (DatabaseSettings.IsSet)
            {
                RefreshClients();
            }
        }

        public void LoadObjects(Objects[] objects)
        {
            objectsListView.Clear();
            objectsListView.Columns.Add("ТДД");
            objectsListView.Columns.Add("Тип на обекта");
            objectsListView.Columns.Add("Град");
            objectsListView.Columns.Add("Телефон");
            objectsListView.Columns.Add("МОЛ (име)");
            objectsListView.Columns.Add("МОЛ (град)");
            objectsListView.Columns.Add("МОЛ (телефон)");
            for (int i = 0; i < objects.Length; i++)
            {
                lvi1 = new ListViewItem(objects[i].TDD);
                lvi1.SubItems.Add(objects[i].Type);
                lvi1.SubItems.Add(objects[i].Town);
                lvi1.SubItems.Add(objects[i].Telephone);
                lvi1.SubItems.Add(objects[i].Mol);
                lvi1.SubItems.Add(objects[i].MolTown);
                lvi1.SubItems.Add(objects[i].MolTelephone);
                lvi1.Tag = objects[i].ID;
                objectsListView.Items.Add(lvi1);
            }
            objectsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            objectsListView.Columns[0].Width = 150;
            objectsListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            objectsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            objectsListView.Columns[1].Width = 150;
            objectsListView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            objectsListView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            objectsListView.Columns[2].Width = 150;
            objectsListView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void справкаЕИКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://public.brra.bg/CheckUps/Verifications/VerificationPersonOrg.ra");
        }

        private void справкаДДСNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://inetdec.nra.bg/pls/pub/home.html#/selectService:6,8,rep.Vatquery.home");
        }

        private void databaseSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void numberDocument_Click(object sender, EventArgs e)
        {
            ContractSettings cs = new ContractSettings();
            cs.Show();
        }

        private void contractType_Click(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts();
            contracts.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void номенклатуриToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
          

        }

        private void clientsListView_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
          
        }

        private void clientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            ClientsForm cl = new ClientsForm(this);
            cl.Show();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                ClientsForm cf = new ClientsForm(this, client);
                cf.Show();
            }
        }

        private void clientsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedClientId = int.Parse(clientsListView.SelectedItems[0].Tag.ToString());
                client = ClientCtrl.GetClient(selectedClientId);
                if (client != null)
                {
                    molLabel.Text = "МОЛ: " + client.Mol;
                }
                var objects = ObjectCtrl.GetObjectsForClient(client.ID);
                LoadObjects(objects);
            }
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            if (clientsListView.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този клиент ?",
                                    "Изтриване на клиент",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(clientsListView.SelectedItems[0].Tag.ToString());
                    ClientCtrl.DeleteClient(id);
                   clientsListView.SelectedItems[0].Remove();
                }

            }
        }

        private void dduhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm cl = new ClientsForm(this);
            cl.Show();
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientsListView.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този клиент ?",
                                    "Изтриване на клиент",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(clientsListView.SelectedItems[0].Tag.ToString());
                    ClientCtrl.DeleteClient(id);
                    clientsListView.SelectedItems[0].Remove();
                }

            }
        }

        private void редактиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                ClientsForm cf = new ClientsForm(this, client);
                cf.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

                ObjectsForm of = new ObjectsForm(selectedClientId);
                of.Show();
            
            
        }
    }
}
