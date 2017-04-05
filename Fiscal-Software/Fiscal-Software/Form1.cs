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
using System.Globalization;
using Fiscal_Software.SpravkiForm;
using Fiscal_Software.DialogWindows;
//using Fiscal_Software.Forms;

namespace Fiscal_Software
{
    
    public partial class Form1 : Form
    {
        ListViewItem lvi;
        ListViewItem lvi1;
        ListViewItem lvi2;
        ListViewItem lviCfd;
        int selectedClientId = -1, 
            selectedObjectID = -1, 
            selectedCfdID=-1, 
            selectedFUDanni = -1, 
            selectedSvidetelstvo = -1, 
            selectedDemontaj = -1, 
            selectedRemont = -1;
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
                LoadColums();
                if (clientsListView.Items.Count > 0)
                {
                    clientsListView.Items[0].Selected = true;
                    clientsListView.Select();
                }
                if (objectsListView.Items.Count > 0)
                {
                    objectsListView.Items[0].Selected = true;
                    objectsListView.Select();
                }
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
        private void LoadColums()
        {
            // Obekti
            objectsListView.Clear();
            objectsListView.Columns.Add("ТДД");
            objectsListView.Columns.Add("Тип на обекта");
            objectsListView.Columns.Add("Град");
            objectsListView.Columns.Add("Телефон");
            objectsListView.Columns.Add("МОЛ (име)");
            objectsListView.Columns.Add("МОЛ (град)");
            objectsListView.Columns.Add("МОЛ (телефон)");
            objectsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            objectsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // FiscalDevices
            fiscalDeviceListView.Clear();
            fiscalDeviceListView.Columns.Add("Модел ФУ");
            fiscalDeviceListView.Columns.Add("Инд N на ФУ");
            fiscalDeviceListView.Columns.Add("ФП номер");
            fiscalDeviceListView.Columns.Add("ФП активирана");
            fiscalDeviceListView.Columns.Add("ФП демонтирана");
            fiscalDeviceListView.Columns.Add("Сервиз");
            fiscalDeviceListView.Columns.Add("Гаранция до");
            fiscalDeviceListView.Columns.Add("Първа регистрация (фирма)");
            fiscalDeviceListView.Columns.Add("Първа регистрация");
            fiscalDeviceListView.Columns.Add("Рег.Nr Нап");
            fiscalDeviceListView.Columns.Add("Рег. НАП");
            fiscalDeviceListView.Columns.Add("СИМ платен до");
            fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // Dogovori
            cfdList.Clear();
            cfdList.Columns.Add("Валиден");
            cfdList.Columns.Add("Тип договор");
            cfdList.Columns.Add("Договор N");
            cfdList.Columns.Add("От Дата");
            cfdList.Columns.Add("До Дата");
            cfdList.Columns.Add("Сума");
            cfdList.Columns.Add("Бележки");
            cfdList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cfdList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // Svidetelstva
            svidetelstvaList.Clear();
            svidetelstvaList.Columns.Add("N");
            svidetelstvaList.Columns.Add("Дата");
            svidetelstvaList.Columns.Add("Договор");
            svidetelstvaList.Columns.Add("От дата");
            svidetelstvaList.Columns.Add("Техник");
            svidetelstvaList.Columns.Add("Бележки");
            svidetelstvaList.Columns.Add("Рег. НАП");
            svidetelstvaList.Columns.Add("Рег. номер НАП");
            svidetelstvaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            svidetelstvaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // Remonti
            remontiList.Clear();
            remontiList.Columns.Add("Заявка в");
            remontiList.Columns.Add("Приет в");
            remontiList.Columns.Add("Върнат в");
            remontiList.Columns.Add("Техник");
            remontiList.Columns.Add("Описание на дефекта");
            remontiList.Columns.Add("Вложени части");
            remontiList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            remontiList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // Demontaj
            demontajList.Clear();
            demontajList.Columns.Add("Номер ФП");
            demontajList.Columns.Add("Демонтирана на");
            demontajList.Columns.Add("От дата");
            demontajList.Columns.Add("До дата");
            demontajList.Columns.Add("Сума");
            demontajList.Columns.Add("Сума А");
            demontajList.Columns.Add("Сума Б");
            demontajList.Columns.Add("Сума В");
            demontajList.Columns.Add("Причини");
            demontajList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            demontajList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void LoadDataAfter()
        {
            if (DatabaseSettings.IsSet)
            {
                RefreshClients();
            }
        }

        public void LoadRemonti()
        {

            remontiList.Clear();
            remontiList.Columns.Add("Заявка в");
            remontiList.Columns.Add("Приет в");
            remontiList.Columns.Add("Върнат в");
            remontiList.Columns.Add("Техник");
            remontiList.Columns.Add("Описание на дефекта");
            remontiList.Columns.Add("Вложени части");

            var remonti = RemontCtrl.GetRemontsById(selectedFUDanni);
            for (int i = 0; i < remonti.Length; i++)
            {
                if (remonti[i].ZaqvkaZadadena.HasValue)
                {
                    lvi2 = new ListViewItem(remonti[i].ZaqvkaZadadena.Value.ToShortDateString());
                }
                else
                {
                    lvi2 = new ListViewItem("");
                }
                if (remonti[i].PrietV.HasValue)
                {
                    lvi2.SubItems.Add(remonti[i].PrietV.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (remonti[i].VurnatNa.HasValue)
                {
                    lvi2.SubItems.Add(remonti[i].VurnatNa.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                lvi2.SubItems.Add(TechnicianCtrl.GetTechnicianById(remonti[i].Tehnik.Value).Name);
                lvi2.SubItems.Add(remonti[i].OpisanieDefekt);
                lvi2.SubItems.Add(remonti[i].ChastiPriRemont);
                lvi2.Tag = remonti[i].ID;
                remontiList.Items.Add(lvi2);
            }
            remontiList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            remontiList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void LoadSvidetelstva()
        {

            svidetelstvaList.Clear();
            svidetelstvaList.Columns.Add("N");
            svidetelstvaList.Columns.Add("Дата");
            svidetelstvaList.Columns.Add("Договор");
            svidetelstvaList.Columns.Add("От дата");
            svidetelstvaList.Columns.Add("Техник");
            svidetelstvaList.Columns.Add("Бележки");
            svidetelstvaList.Columns.Add("Рег. НАП");
            svidetelstvaList.Columns.Add("Рег. номер НАП");
            var svidetelstva = SvidetelstvoRegistraciqCtrl.GetSvidetelstvaRegistraciqById(selectedFUDanni);
            for (int i = 0; i < svidetelstva.Length; i++)
            {
                lvi2 = new ListViewItem(svidetelstva[i].SvidetelstvoN.ToString());
                if (svidetelstva[i].RegDate.HasValue)
                {
                    lvi2.SubItems.Add(svidetelstva[i].RegDate.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                var cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(svidetelstva[i].Contract);
                if (cfd != null)
                {
                    if (cfd.ContractN.HasValue)
                    {
                        lvi2.SubItems.Add(cfd.ContractN.Value.ToString());
                    }
                    
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (svidetelstva[i].RegDate.HasValue)
                {
                    lvi2.SubItems.Add(svidetelstva[i].RegDate.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                lvi2.SubItems.Add(TechnicianCtrl.GetTechnicianById(svidetelstva[i].Technician).Name);
                lvi2.SubItems.Add(svidetelstva[i].Notes);
                if (svidetelstva[i].RegNoNapIzdaden.HasValue)
                {
                    lvi2.SubItems.Add(svidetelstva[i].RegNoNapIzdaden.ToString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                lvi2.SubItems.Add(svidetelstva[i].RegNoNap.ToString());
                lvi2.Tag = svidetelstva[i].id;
                svidetelstvaList.Items.Add(lvi2);
            }
            svidetelstvaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            svidetelstvaList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void LoadDemontaji()
        {

            demontajList.Clear();
            demontajList.Columns.Add("Номер ФП");
            demontajList.Columns.Add("Демонтирана на");
            demontajList.Columns.Add("От дата");
            demontajList.Columns.Add("До дата");
            demontajList.Columns.Add("Сума");
            demontajList.Columns.Add("Сума А");
            demontajList.Columns.Add("Сума Б");
            demontajList.Columns.Add("Сума В");
            demontajList.Columns.Add("Причини");
            var demontaji = DemontajFiskalnoUstroistvoCtrl.GetDemontajFiskalnoUstroistvaById(selectedFUDanni);
            for (int i = 0; i < demontaji.Length; i++)
            {
                if (demontaji[i].FPNomer.HasValue)
                {
                    lvi2 = new ListViewItem(demontaji[i].FPNomer.Value.ToString());
                }
                else
                {
                    lvi2 = new ListViewItem("");
                }
                if (demontaji[i].DateDemontaj.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].DateDemontaj.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].OborotOt.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].OborotOt.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].OborotDo.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].OborotDo.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].DDS1.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].DDS1.Value.ToString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].DDS2.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].DDS2.Value.ToString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].DDS3.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].DDS3.Value.ToString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (demontaji[i].DDS4.HasValue)
                {
                    lvi2.SubItems.Add(demontaji[i].DDS4.Value.ToString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                lvi2.SubItems.Add(demontaji[i].Reasons);
                lvi2.Tag = demontaji[i].ID;
                demontajList.Items.Add(lvi2);
            }
            demontajList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            demontajList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            var cfds1 = ContractFiscalDeviceCtrl.GetAllContractFiscalDevices(selectedFUDanni);
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
                if (cfds1[i].DateFrom.HasValue)
                {
                    lvi2.SubItems.Add(cfds1[i].DateFrom.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                if (cfds1[i].DateTo.HasValue)
                {
                    lvi2.SubItems.Add(cfds1[i].DateTo.Value.ToShortDateString());
                }
                else
                {
                    lvi2.SubItems.Add("");
                }
                lvi2.SubItems.Add(String.Format(CultureInfo.InvariantCulture, "{0:#.##}", cfds1[i].Sum));
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
           // fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
                    molLabel1.Text = "МОЛ: " + client.Mol + ", Град: " + client.MolTown + " " + client.MolAddress + ", тел.: " + client.MolTelephone;
                    companyNamePlaceholder.Text = client.Name;
                    dnPlaceholder.Text = client.DN;
                    bulstatPlaceholder.Text = client.Bulstat;
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
                var clientForObj = ClientCtrl.GetClient(selectedClientId);
                ObjectsForm of = new ObjectsForm(clientForObj, this);
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
                LoadDanni();
                //LoadCfds();
            }
           
        }

        public void LoadDanni()
        {
            fiscalDeviceListView.Clear();
            fiscalDeviceListView.Columns.Add("Модел ФУ");
            fiscalDeviceListView.Columns.Add("Инд N на ФУ");
            fiscalDeviceListView.Columns.Add("ФП номер");
            fiscalDeviceListView.Columns.Add("ФП активирана");
            fiscalDeviceListView.Columns.Add("ФП демонтирана");
            fiscalDeviceListView.Columns.Add("Сервиз");
            fiscalDeviceListView.Columns.Add("Гаранция до");
            fiscalDeviceListView.Columns.Add("Първа регистрация (фирма)");
            fiscalDeviceListView.Columns.Add("Първа регистрация");
            fiscalDeviceListView.Columns.Add("Рег.Nr Нап");
            fiscalDeviceListView.Columns.Add("Рег. НАП");
            fiscalDeviceListView.Columns.Add("СИМ платен до");
            var danni = DanniFiskalnoUstroistvoCtrl.GetDanniFromObject(selectedObjectID);
            if (danni == null)
            {
                return;
            }
            for (int i = 0; i < danni.Length; i++)
            {
                if (danni[i].ModelFY > 0)
                {
                    var m = FiscalDeviceCtrl.GetFiscalDevice(danni[i].ModelFY);
                    if (m != null)
                    {
                        lvi2 = new ListViewItem(FiscalDeviceCtrl.GetFiscalDevice(danni[i].ModelFY).Model);
                    }
                    
                }
                else
                {
                    lvi2 = new ListViewItem("");
                }
                lvi2.SubItems.Add(danni[i].FYNomer.ToString());
                lvi2.SubItems.Add(danni[i].FPNomer.ToString());
                lvi2.SubItems.Add(danni[i].FPAktivirana.ToString());
                lvi2.SubItems.Add(danni[i].FPDeaktivirana.ToString());
                lvi2.SubItems.Add(CompanyCtrl.GetCompanyById(danni[i].Serviz).Name);
                lvi2.SubItems.Add(danni[i].GuaranteeUntil.ToString());
                lvi2.SubItems.Add(danni[i].Company);
                lvi2.SubItems.Add("1va reg");
                lvi2.SubItems.Add(danni[i].RegNoNap.ToString());
                lvi2.SubItems.Add(danni[i].RegNapDate.ToString());
                lvi2.SubItems.Add(danni[i].PayedSim.ToString());
                lvi2.Tag = danni[i].ID;
                fiscalDeviceListView.Items.Add(lvi2);
            }
            fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            fiscalDeviceListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void objectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cfdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cfdList.SelectedItems.Count > 0)
            {
                selectedCfdID = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ContractFiscalDevice cfd = new ContractFiscalDevice(selectedObjectID,this);
            cfd.Show();
        }

        private void добавянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                ContractFiscalDevice cfd = new ContractFiscalDevice(selectedFUDanni, this);
                cfd.Show();
                cfd.Text = "Добавяне на договор за подръжка";
            }
            
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
            if (cfdList.SelectedItems.Count > 0)
            {
                selectedCfdID = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                ContractFiscalDevices cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(selectedCfdID);
                ContractFiscalDevice cf = new ContractFiscalDevice(this, cfd);
                cf.Show();
                cf.Text = "Редактиране на договор за подръжка";
            }
            /*
            cfdList.Columns.Add("Валиден");
            cfdList.Columns.Add("Тип договор");
            cfdList.Columns.Add("Договор N");
            cfdList.Columns.Add("От Дата");
            cfdList.Columns.Add("До Дата");
            cfdList.Columns.Add("Сума");
            cfdList.Columns.Add("Бележки");
            */

        }

        private void objectsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedClientId > 0)
            {
                var objects = ObjectCtrl.GetObjectById(selectedObjectID);
                ObjectsForm of = new ObjectsForm(objects, this);
                of.Show();
            }
        }

        private void cfdList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            selectedCfdID = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
            ContractFiscalDevices cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(selectedCfdID);
            ContractFiscalDevice cf = new ContractFiscalDevice(this, cfd);
            cf.loadDataForUpdate(cfd);
            //MessageBox.Show(selectedCfdID.ToString());
            cf.Show();
            cf.Text = "Редактиране на договор за подръжка";
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {

        }

        private void добавянеНаФУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Fiscal Device Form for adding data
            
            AddFiscalDevice afd = new AddFiscalDevice(this);
            afd.Show();
        }

        private void редактиранеНаФУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Fiscal Device Form for editing prefilled data
            if (fiscalDeviceListView.SelectedItems.Count > 0)
            {
                selectedFUDanni = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
                if (selectedFUDanni > 0)
                {
                    AddFiscalDevice afd = new AddFiscalDevice(this, selectedFUDanni);
                    afd.Show();
                }
            }
            
        }

        private void изтриванеНаФУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dialog Window to confirm deletion of the selected element
            if (fiscalDeviceListView.SelectedItems.Count > 0)
            {
                selectedFUDanni = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
                if (selectedFUDanni > 0)
                {
                    DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете това фускално у-во ?",
                                        "Изтриване на фискално у-во",
                                MessageBoxButtons.YesNo);
                    if (deleteResult == DialogResult.Yes)
                    {
                        int id = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
                        DanniFiskalnoUstroistvoCtrl.DeleteDanniFiskalnoUstroistvoById(selectedFUDanni);
                        fiscalDeviceListView.SelectedItems[0].Remove();
                    }
                }
            }
            
        }

        private void свидетелствоЗаРегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Svidetelstvo Form
            if (selectedFUDanni > 0)
            {
                SvidetelsvtoRegistraciqForm srf = new SvidetelsvtoRegistraciqForm(selectedFUDanni, this);
                srf.Show();
            }
            
        }

        private void договорЗаПоддръжкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open DogovorPoddrujka Form
            //selectedFUDanni = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
            if (selectedFUDanni > 0)
            {
                ContractFiscalDevice cfd = new ContractFiscalDevice(selectedFUDanni, this);
                cfd.Show();
                cfd.Text = "Добавяне на договор за подръжка";
            }
            
        }

        private void демонтажНаФПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Demontaj Form
            if (selectedFUDanni > 0)
            {
                DemontajForm df = new DemontajForm(selectedFUDanni, this);
                df.Show();
            }
            
        }

        private void ремонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Remont Form
            if (selectedFUDanni > 0)
            {
                RemontiForm rf = new RemontiForm(selectedFUDanni, this);
                rf.Show();
            }
            
        }

        private void печатДосиеНаФУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Print Dialog with document filled with data
            PrintDogovor ps = new PrintDogovor();
            ps.Show();
        }

        private void fiscalDeviceListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fiscalDeviceListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                selectedFUDanni = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
                LoadCfds();
                LoadDemontaji();
                LoadSvidetelstva();
                LoadRemonti();
            }
        }

        private void добавянеНаСвидетелствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                SvidetelsvtoRegistraciqForm srf = new SvidetelsvtoRegistraciqForm(selectedFUDanni, this);
                srf.Show();
            }
            
        }

        private void изтриванеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (svidetelstvaList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този договор ?",
                                    "Изтриване на договор",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(svidetelstvaList.SelectedItems[0].Tag.ToString());
                    SvidetelstvoRegistraciqCtrl.DeleteSvidetelstvoRegistraciqById(id);
                    svidetelstvaList.SelectedItems[0].Remove();
                }

            }
        }

        private void добавянеНаДемонтажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                DemontajForm df = new DemontajForm(selectedFUDanni, this);
                df.Show();
            }
            
        }

        private void изтриванеНаДемонтажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demontajList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този договор ?",
                                    "Изтриване на договор",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(demontajList.SelectedItems[0].Tag.ToString());
                    DemontajFiskalnoUstroistvoCtrl.DeleteDemontajFiskalnoUstroistvoById(id);
                    demontajList.SelectedItems[0].Remove();
                }

            }
        }

        private void добавянеНаРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                RemontiForm rf = new RemontiForm(selectedFUDanni, this);
                rf.Show();
            }
        }

        private void редактиранеНаРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remontiList.SelectedItems.Count > 0)
            {
                int id = int.Parse(remontiList.SelectedItems[0].Tag.ToString());
                RemontiForm rf = new RemontiForm(selectedFUDanni, this, id);
                rf.Show();
            }
            
        }

        private void изтриванеНаРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (remontiList.SelectedItems.Count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да изтриете този ремонт ?",
                                    "Изтриване на договор",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    int id = int.Parse(remontiList.SelectedItems[0].Tag.ToString());
                    RemontCtrl.DeleteRemontById(id);
                    remontiList.SelectedItems[0].Remove();
                }

            }
        }

        private void clientsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (client != null)
            {
                ClientsForm cf = new ClientsForm(this, client);
                cf.Show();
            }
        }

        private void fiscalDeviceListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fiscalDeviceListView.SelectedItems.Count > 0)
            {
                selectedFUDanni = int.Parse(fiscalDeviceListView.SelectedItems[0].Tag.ToString());
                if (selectedFUDanni > 0)
                {
                    AddFiscalDevice afd = new AddFiscalDevice(this, selectedFUDanni);
                    afd.Show();
                }
            }
        }

        private void demontajList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedDemontaj = int.Parse(demontajList.SelectedItems[0].Tag.ToString());
            DemontajForm df = new DemontajForm(selectedFUDanni, this, selectedDemontaj);
            df.Show();
        }

        private void svidetelstvaList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedSvidetelstvo = int.Parse(svidetelstvaList.SelectedItems[0].Tag.ToString());
            var svideletstvo = SvidetelstvoRegistraciqCtrl.GetSvidetelstvoRegistraciqById(selectedSvidetelstvo);
            SvidetelsvtoRegistraciqForm srf = new SvidetelsvtoRegistraciqForm(selectedFUDanni, svideletstvo, this);
            srf.Show();
        }

        private void remontiList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(remontiList.SelectedItems[0].Tag.ToString());
            RemontiForm rf = new RemontiForm(selectedFUDanni, this, id);
            rf.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                if (cfdList.SelectedItems.Count > 0)
                {
                    if (cfdList.SelectedItems[0].Tag != null)
                    {
                        int id = int.Parse(cfdList.SelectedItems[0].Tag.ToString());
                        var dfu = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(selectedFUDanni);
                        var cfd = ContractFiscalDeviceCtrl.GetContractFiscalDevice(id);
                        PrintDogovor pd = new PrintDogovor(dfu, cfd);
                        pd.Show();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var danni = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(selectedFUDanni);
            var demontaj = DemontajFiskalnoUstroistvoCtrl.GetDemontajFiskalnoUstroistvoById(selectedDemontaj);
            PrintDemontaj pd = new PrintDemontaj(danni, demontaj);
            pd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedFUDanni > 0)
            {
                if (remontiList.SelectedItems.Count > 0)
                {
                    if (remontiList.SelectedItems[0].Tag != null)
                    {
                        int id = int.Parse(remontiList.SelectedItems[0].Tag.ToString());
                        var remont = RemontCtrl.GetRemontById(id);
                        var dfu = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(selectedFUDanni);
                        PrintRemont pr = new PrintRemont(remont, dfu);
                        pr.Show();
                    }
                }                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var danni = DanniFiskalnoUstroistvoCtrl.GetDanniFiskalnoUstroistvoById(selectedFUDanni);
            var obj = ObjectCtrl.GetObjectById(selectedObjectID);
            var client = ClientCtrl.GetClient(selectedClientId);
            var sr = SvidetelstvoRegistraciqCtrl.GetSvidetelstvoRegistraciqById(selectedSvidetelstvo);
            PrintUvedomleniecs pu = new PrintUvedomleniecs(danni, obj, client, sr);
            pu.Show();
        }

        private void otherSettings_Click(object sender, EventArgs e)
        {
            OtherSettingsForm osf = new OtherSettingsForm();
            osf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //IztichashtaSIMForm isim = new IztichashtaSIMForm();
            //isim.Show();
            //VuvedeniEksploataciqForm vef = new VuvedeniEksploataciqForm();
            //vef.Show();
            //FUModelForm fum = new FUModelForm();
            //fum.Show();
            //DogovoriZaPeriodForm dzp = new DogovoriZaPeriodForm();
            //dzp.Show();
            //IztichashtiDogovoriForm izf = new IztichashtiDogovoriForm();
            //izf.Show();
            //DogovoriSpravkaForm dsf = new DogovoriSpravkaForm();
            //dsf.Show();
            //SprazkaZaFirmaForm sff = new SprazkaZaFirmaForm();
            //sff.Show();
            //PrintZaqvlenie pz = new PrintZaqvlenie();
            //pz.Show();
            //DogovorServizForm dsf = new DogovorServizForm();
            //dsf.Show();
            DialogWindow2 dw2 = new DialogWindow2();
            var result = dw2.ShowDialog();
        }

        private void устройствоПоМоделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow4 dw4 = new DialogWindow4();
            var result = dw4.ShowDialog();

            if (result == DialogResult.OK)
            {
                int model = dw4.Model;
            }
        }

        private void договориЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow1 dw1 = new DialogWindow1();
            var result = dw1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw1.ServiznaFirma;

                DateTime fromDate = dw1.FromDate;

                DateTime toDate = dw1.ToDate;
            }
        }

        private void изтичащиДоговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow1 dw1 = new DialogWindow1(true);
            var result = dw1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw1.ServiznaFirma;

                DateTime fromDate = dw1.FromDate;

                DateTime toDate = dw1.ToDate;

            }
        }

        private void неплатениДоговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow1 dw1 = new DialogWindow1();
            var result = dw1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw1.ServiznaFirma;

                DateTime fromDate = dw1.FromDate;

                DateTime toDate = dw1.ToDate;
            }
        }

        private void изтичащиСИМКартиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow1 dw1 = new DialogWindow1();
            var result = dw1.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw1.ServiznaFirma;

                DateTime fromDate = dw1.FromDate;

                DateTime toDate = dw1.ToDate;
            }
        }

        private void справкаЗаФирмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow2 dw2 = new DialogWindow2();
            var result = dw2.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw2.Firma;
            }
        }

        private void справкаЗаДанСлужбаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWindow3 dw3 = new DialogWindow3();
            var result = dw3.ShowDialog();

            if (result == DialogResult.OK)
            {
                int firma = dw3.ServiznaFirma;

                string danuchnaSlyjba = dw3.DanuchnaSlyjba;

                DateTime fromDate = dw3.FromDate;

                DateTime toDate = dw3.ToDate;
            }
        }

        private void remontiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (remontiList.SelectedItems.Count > 0)
            {
                selectedRemont = int.Parse(remontiList.SelectedItems[0].Tag.ToString());
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void редактиранеНаДемонтажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demontajList.SelectedItems.Count > 0)
            {
                selectedDemontaj = int.Parse(demontajList.SelectedItems[0].Tag.ToString());
                DemontajForm df = new DemontajForm(selectedFUDanni, this, selectedDemontaj);
                df.Show();
            }
            
        }

        private void редактиранеНаСвидетелствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (svidetelstvaList.SelectedItems.Count > 0)
            {
                selectedSvidetelstvo = int.Parse(svidetelstvaList.SelectedItems[0].Tag.ToString());
                var svideletstvo = SvidetelstvoRegistraciqCtrl.GetSvidetelstvoRegistraciqById(selectedSvidetelstvo);
                SvidetelsvtoRegistraciqForm srf = new SvidetelsvtoRegistraciqForm(selectedFUDanni, svideletstvo, this);
                srf.Show();
            }
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (selectedClientId > 0)
            {
                var objects = ObjectCtrl.GetObjectById(selectedObjectID);
                ObjectsForm of = new ObjectsForm(objects, this);
                of.Show();
                of.Text = "Редактиране на обект";
            }
        }
        
    }

}
