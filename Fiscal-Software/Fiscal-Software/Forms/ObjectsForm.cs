using Fiscal_Software.Controlles;
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
    public partial class ObjectsForm : Form
    {
        int id;
        public ObjectsForm()
        {
            InitializeComponent();
        }
        public ObjectsForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void saveObjectBtn_Click(object sender, EventArgs e)
        {
            if (objectTpeBox.Text != "" && objectTown.Text != "" && objectAddressBox.Text != "")
            {
                var objectToAdd = new Objects();
                objectToAdd.Type = objectTpeBox.Text;
                objectToAdd.Activity = objectActivityBox.Text;
                objectToAdd.Ekatte = objectEKATTEBox.Text;
                objectToAdd.Town = objectTown.Text;
                objectToAdd.Address = objectAddressBox.Text;
                objectToAdd.Telephone = objectTelefoneBox.Text;
                objectToAdd.TDD = objectTDDBox.Text;
                objectToAdd.Mol = objectMOLBox.Text;
                objectToAdd.MolTown = objectMolTownBox.Text;
                objectToAdd.MolAddress = objectMolAddressBox.Text;
                objectToAdd.MolTelephone = objectTelephoneBox.Text;
                objectToAdd.ClientId = this.id;
                ObjectCtrl.AddObject(objectToAdd);
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля, попълнете задължителните полета!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
