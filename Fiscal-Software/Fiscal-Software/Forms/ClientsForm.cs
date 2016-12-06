using Fiscal_Software.Controllers;
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
    public partial class ClientsForm : Form
    {
        Form1 f1;
        Client client;
        bool isUpdate = false;
        public ClientsForm(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public ClientsForm(Form1 f1,Client client)
        {
            InitializeComponent();
            this.f1 = f1;
            this.client = client;
            this.isUpdate = true;
            loadData(this.client);
        }

        private void loadData(Client client)
        {
              clientNameBox.Text= client.Name;
            clientTDDBox.Text=client.Name;
            clientMolBox.Text= client.Mol;
            clientMolTownBox.Text= client.MolTown;
             clientMolAddressBox.Text= client.MolAddress;
             clientDNBox.Text=client.DN;
            clientBulstatBox.Text=client.Bulstat;
            clientFDDateBox.Value = client.FDDate.Value;
           clientFDNumberBox.Text = client.FDNumber ;
             clientFDTownBox.Text= client.FDTown;
            clientTownBox.Text = client.Town ;
            clientAddressBox.Text= client.Address;
            clientTelephoneBox.Text = client.Telephone ;
           clientFaxBox.Text = client.Fax ;
           clientEmailBox.Text = client.Email;
             clientWebBox.Text= client.Web ;
            clientMolEGNBox.Text= client.MolEGN;
            clientMolTownBox.Text = client.MolTown;
            clientMolTelephoneBox.Text = client.MolTelephone;

        }
        private void cancelClientBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveClientBtn_Click(object sender, EventArgs e)
        {
            if (clientNameBox.Text != "" && clientTDDBox.Text != "" && clientMolBox.Text != "" && clientMolTownBox.Text != "" && clientMolAddressBox.Text != "")
            {
                Client client = new Client();
                client.Name = clientNameBox.Text;
                client.TDD = clientTDDBox.Text;
                client.Mol = clientMolBox.Text;
                client.MolTown = clientMolTownBox.Text;
                client.MolAddress = clientMolAddressBox.Text;
                client.DN = clientDNBox.Text;
                client.Bulstat = clientBulstatBox.Text;
                client.FDDate = clientFDDateBox.Value;
                client.FDNumber = clientFDNumberBox.Text;
                client.FDTown = clientFDTownBox.Text;
                client.Town = clientTownBox.Text;
                client.Address = clientAddressBox.Text;
                client.Telephone = clientTelephoneBox.Text;
                client.Fax = clientFaxBox.Text;
                client.Email = clientEmailBox.Text;
                client.Web = clientWebBox.Text;
                client.MolEGN = clientMolEGNBox.Text;
                client.MolTown = clientMolTownBox.Text;
                client.MolTelephone = clientMolTelephoneBox.Text;
                if (!isUpdate)
                {
                   
                    ClientCtrl.AddClient(client);
                    f1.AddClient(client);
                }
                else
                {
                    ClientCtrl.UpdateClient(this.client.ID, client);
                    this.f1.LoadDataAfter();
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientBulstatBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clientFDNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clientMolEGNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clientDNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
