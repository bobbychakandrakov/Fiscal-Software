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
        public ClientsForm()
        {
            InitializeComponent();
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
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
