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
        int id, id1;
        bool isSaving = true;
        HashSet<string> types = new HashSet<string>();
        HashSet<string> activitiesHash = new HashSet<string>();
        Form1 f1;
        public ObjectsForm()
        {
            InitializeComponent();
        }
        public ObjectsForm(int id, Form1 f1)
        {
            InitializeComponent();
            this.id = id;
            this.f1 = f1;
        }

        public ObjectsForm(Objects objects)
        {
            InitializeComponent();
            this.isSaving = false;
            this.id1 = objects.ID;
            this.id = int.Parse(objects.ClientId.ToString());
            LoadPanelData(objects);
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
                this.f1.RefreshObjects();
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
            objectActivityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var objects = ObjectCtrl.GetAllObjects();
            for (int i = 0; i < objects.Length; i++)
            {
                types.Add(objects[i].Type);
            }
            objectTpeBox.DataSource = types.ToList();
            var activities = ActivityCtrl.GetAllActivities();
            for (int i = 0; i < activities.Length; i++)
            {
                activitiesHash.Add(activities[i].Activity);
            }
            objectActivityBox.DataSource = activitiesHash.ToList();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;


            switch (MessageBox.Show(this, "Сигурни ли сте, че иската да излезете " + " ?", "Изход от обекти", MessageBoxButtons.YesNo))
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
