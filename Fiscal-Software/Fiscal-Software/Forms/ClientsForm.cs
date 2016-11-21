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
        public ClientsForm(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
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
                ClientCtrl.AddClient(client);
                f1.AddClient(client);
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
