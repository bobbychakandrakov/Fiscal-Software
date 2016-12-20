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
        ListViewItem lvi2;
        ListViewItem lviCfd;
        int selectedClientId = -1, selectedObjectID = -1, selectedCfdID=-1;
        Client client;
        ContractFiscalDevices cfd;

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
        public void AddCfd(ContractFiscalDevices cfd)
        {
            this.lviCfd = new ListViewItem(cfd.Notes);
            this.lviCfd.SubItems.Add(cfd.Sum.ToString());
            this.lviCfd.SubItems.Add(cfd.Valid.ToString());
            this.lviCfd.SubItems.Add(cfd.SumMonth.ToString());
            this.lviCfd.SubItems.Add(cfd.ContractType.ToString());
            this.lviCfd.SubItems.Add(cfd.ContractN.ToString());
            this.lviCfd.SubItems.Add(cfd.DateFrom.ToString());
            this.lviCfd.SubItems.Add(cfd.DateTo.ToString());
            this.lviCfd.SubItems.Add(cfd.AutomaticNumbering.ToString());
            this.lviCfd.SubItems.Add(cfd.ObjectId.ToString());
            this.lviCfd.Tag = cfd.ID;
            this.cfdList.Items.Add(lviCfd);
        }
        private void RefreshClients()
        {
            clientsListView.Clear();
            clientsListView.Columns.Add("Фирма");
            clientsListView.Columns.Add("ДДС Номер");
            clientsListView.Columns.Add("Булстат");
            //clientsListView.Columns.Add("Телефон");
           // clientsListView.Columns.Add("МОЛ");
            var clients = ClientCtrl.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                lvi = new ListViewItem(clients[i].Name);
                lvi.SubItems.Add(clients[i].DN);
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

            clientsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            clientsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        public void LoadCfds()
        {
            cfdList.Clear();
            cfdList.Columns.Add("Валиден");
            cfdList.Columns.Add("Тип договор");
            cfdList.Columns.Add("Договор N");
            cfdList.Columns.Add("От Дата");
            cfdList.Columns.Add("До Дата");
            cfdList.Columns.Add("Сума");
            cfdList.Columns.Add("Бележки");
            var cfds1 = ContractFiscalDeviceCtrl.GetAllContractFiscalDevices(selectedObjectID);
            for (int i = 0; i < cfds1.Length; i++)
            {
                if (cfds1[i].Valid.Value)
                {
                    lvi2 = new ListViewItem("Да");
                }
                else
                {
                    lvi2 = new ListViewItem("Не");
                }
                
                lvi2.SubItems.Add(ContractCtrl.GetContractById(cfds1[i].ContractType).Name);
                lvi2.SubItems.Add(cfds1[i].ContractN.ToString());
                lvi2.SubItems.Add(cfds1[i].DateFrom.Value.ToShortDateString());
                lvi2.SubItems.Add(cfds1[i].DateTo.Value.ToShortDateString());
                lvi2.SubItems.Add(cfds1[i].Sum.ToString());
                lvi2.SubItems.Add(cfds1[i].Notes);
                lvi2.Tag = cfds1[i].ID;
                cfdList.Items.Add(lvi2);
            }
            cfdList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            cfdList.Columns[0].Width = 150;
            cfdList.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            cfdList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            cfdList.Columns[1].Width = 150;
            cfdList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            cfdList.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            cfdList.Columns[2].Width = 150;
            cfdList.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            cfdList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cfdList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            objectsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            objectsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
                    molLabel1.Text = "МОЛ: " + client.Mol;
                }
                var objects = ObjectCtrl.GetObjectsForClient(client.ID);
                LoadObjects(objects);
            }
        }

        public void RefreshObjects()
        {
            client = ClientCtrl.GetClient(selectedClientId);
            var objects = ObjectCtrl.GetObjectsForClient(client.ID);
            LoadObjects(objects);
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
            if (selectedClientId > 0)
            {
                ObjectsForm of = new ObjectsForm(selectedClientId,this);
                of.Show();
            }
            
        }
    
        private void label1_Click(object sender, EventArgs e)
        {
            

            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (client != null)
            {
                panel1.Text = client.Mol;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (client != null)
            {
             molLabel1.Text = "МОЛ: "+client.Mol;
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                molLabel1.Text = "МОЛ: " + client.Mol;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (objectsListView.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този обект ?",
                                    "Изтриване на обект",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(objectsListView.SelectedItems[0].Tag.ToString());
                    ObjectCtrl.DeleteObjectById(id);
                    objectsListView.SelectedItems[0].Remove();
                }

            }
        }

        private void objectsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedObjectID = int.Parse(objectsListView.SelectedItems[0].Tag.ToString());
                LoadCfds();
            }
           
        }

        private void objectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cfdList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContractFiscalDevice cfd = new ContractFiscalDevice(selectedObjectID,this);
            cfd.Show();
        }

        private void добавянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractFiscalDevice cfd = new ContractFiscalDevice(selectedObjectID,this);
            cfd.Show();
        }

        private void изтриванеНаДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cfdList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този договор ?",
                                    "Изтриване на договор",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                    ContractFiscalDeviceCtrl.DeleteContractFiscalDevice(id);
                    cfdList.SelectedItems[0].Remove();
                }

            }
        }

        private void редактиранеНаДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                selectedCfdID = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                ContractFiscalDevices cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(selectedCfdID);
                ContractFiscalDevice cf = new ContractFiscalDevice(this, cfd);
            cf.loadDataForUpdate(cfd);
            //MessageBox.Show(selectedCfdID.ToString());
                cf.Show();
            
            
          
              
              /*  if (cfd != null)
                {
                   = "duhai";
                }*/
               /* var objects = ObjectCtrl.GetObjectsForClient(client.ID);
                LoadObjects(objects);
            }



        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cfdList_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /* if (e.IsSelected)
             {
                 selectedCfdID = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                 cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(selectedCfdID);
                /* if (cfd != null)
                 {
                     molLabel1.Text = "МОЛ: " + cfd.va;
                 }*/
            /*  var contractFD= ContractFiscalDeviceCtrl.GetAllContractFiscalDevices(cfd.ID);
              LoadCfds(contractFD);*/

            //}
            cfdList.Columns.Add("Валиден");
            cfdList.Columns.Add("Тип договор");
            cfdList.Columns.Add("Договор N");
            cfdList.Columns.Add("От Дата");
            cfdList.Columns.Add("До Дата");
            cfdList.Columns.Add("Сума");
            cfdList.Columns.Add("Бележки");


        }

        private void objectsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedClientId > 0)
            {
                var objects = ObjectCtrl.GetObjectById(selectedObjectID);
                ObjectsForm of = new ObjectsForm(objects);
                of.Show();
            }
        }

        private void cfdList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (selectedClientId > 0)
            {
                var objects = ObjectCtrl.GetObjectById(selectedObjectID);
                ObjectsForm of = new ObjectsForm(objects);
                of.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (selectedClientId > 0)
            {
                var objects = ObjectCtrl.GetObjectById(selectedObjectID);
                ObjectsForm of = new ObjectsForm(objects);
                of.Show();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;


            switch (MessageBox.Show(this, "Сигурни ли сте, че иската да излезете  " + " ?", "Изход от Fiscal-Software", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }

}
