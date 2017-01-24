using Fiscal_Software.Controllers;
using Fiscal_Software.Controlles;
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

namespace Fiscal_Software.Forms
{
    public partial class ObjectsForm : Form
    {
        int id, id1;
        bool isSaving = true, touched = false, write = false;
        HashSet<string> types = new HashSet<string>();
        HashSet<string> activitiesHash = new HashSet<string>();
        Form1 f1;
        Objects objects;
        public ObjectsForm()
        {
            InitializeComponent();
        }
        public ObjectsForm(int id, Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
            write = true;
        }
        public ObjectsForm(Client client, Form1 f1)
        {
            InitializeComponent();
            this.id = client.ID;
            this.f1 = f1;
            FillData(client);
        }


        public ObjectsForm(Objects objects, Form1 f1)
        {
            InitializeComponent();
            this.isSaving = false;
            this.id1 = objects.ID;
            this.id = int.Parse(objects.ClientId.ToString());
            this.f1 = f1;
            this.objects = objects;
        }

        private void FillData(Client client)
        {
            objectTown.Text = client.Town;
            objectAddressBox.Text = client.Address;
            objectTelefoneBox.Text = client.Telephone;
            objectTDDBox.Text = client.TDD;
            objectMOLBox.Text = client.Mol;
            objectMolAddressBox.Text = client.MolAddress;
            objectMolTownBox.Text = client.MolTown;
            objectTelephoneBox.Text = client.MolTelephone;
        }

        private void LoadPanelData(Objects objects)
        {
            objectTpeBox.Text = objects.Type;
            objectActivityBox.Text = objects.Activity;
            objectEKATTEBox.Text = objects.Ekatte;
            objectTown.Text = objects.Town;
            objectAddressBox.Text = objects.Address;
            objectTelefoneBox.Text = objects.Telephone;
            objectTDDBox.Text = objects.TDD;
            objectMOLBox.Text = objects.Mol;
            objectMolTownBox.Text = objects.MolTown;
            objectMolAddressBox.Text = objects.MolAddress;
            objects.MolTelephone = objectTelephoneBox.Text;
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
                if (isSaving)
                {
                    ObjectCtrl.AddObject(objectToAdd);
                }
                else
                {
                    ObjectCtrl.UpdateObject(id1, objectToAdd);
                }
                f1.RefreshObjects();
                touched = false;
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

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            objectActivityBox.DropDownStyle = ComboBoxStyle.DropDown;
            var objects = ObjectCtrl.GetAllObjects();
            for (int i = 0; i < objects.Length; i++)
            {
                types.Add(objects[i].Type);
                activitiesHash.Add(objects[i].Activity);
            }
            objectTpeBox.DataSource = types.ToList();
            
            objectActivityBox.DataSource = activitiesHash.ToList();
            if (this.objects != null)
            {
                LoadPanelData(this.objects);
            }
            //LoadPanelData(this.objects);
            DirtyChecker.Check(Controls, c_ControlChanged);
        }

        private void ObjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (touched)
            {
                DialogResult deleteResult = MessageBox.Show("Сигурни ли сте, че иската да излезете без да запазите информацията ?",
                                    "Изход",
                            MessageBoxButtons.YesNo);
                if (deleteResult == DialogResult.Yes)
                {
                    touched = false;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }
    }
}
