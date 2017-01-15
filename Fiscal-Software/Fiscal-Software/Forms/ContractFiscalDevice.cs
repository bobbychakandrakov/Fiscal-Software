using Fiscal_Software.Controllers;
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
    public partial class ContractFiscalDevice : Form
    {
        public ContractFiscalDevice()
        {
            InitializeComponent();
        }

        int objectID;
        Form1 f1;
        bool isUpdate = false;

        public ContractFiscalDevice(int objectID,Form1 f1)
        {
            InitializeComponent();
            this.objectID = objectID;
            this.f1 = f1;
        }
       


        public ContractFiscalDevice(Form1 form1, ContractFiscalDevices cfd)
        {
        
            InitializeComponent();
            this.f1 = form1;
            this.cfd = cfd;
            this.isUpdate = true;
            //loadData(this.cfd);
        
    }
       public void loadDataForUpdate(ContractFiscalDevices cfd)
        {
             ContractType.Text = ContractCtrl.GetContractById(this.cfd.ContractType).Name;
             AutomaticNumbering.Checked = cfd.AutomaticNumbering.Value;
             ContractN.Text = cfd.ContractN.ToString();
             DateFrom.Value = cfd.DateFrom.Value;
             DateTo.Value = cfd.DateTo.Value;
             Sum.Text = cfd.Sum.ToString();
            SumForMount.Text = cfd.SumMonth.ToString();
              Valid.Checked= cfd.Valid.Value;
              Notes.Text = cfd.Notes;
          

        }

        List<string> contractNames = new List<string>();
        private Form1 form1;
        private ContractFiscalDevices cfd;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ContractType.Text != "" || ContractN.Text != "")
            {
                ContractFiscalDevices cfd = new ContractFiscalDevices();
                if (this.isUpdate)
                {
                    cfd.ContractType = ContractCtrl.GetContractByName(ContractType.Text);
                    cfd.ObjectId = objectID;
                    cfd.AutomaticNumbering = AutomaticNumbering.Checked;
                    cfd.ContractN = Int32.Parse(ContractN.Text);
                    cfd.DateFrom = DateFrom.Value;
                    cfd.DateTo = DateTo.Value;
                    cfd.Sum = float.Parse(Sum.Text);
                    cfd.SumMonth = float.Parse(SumForMount.Text);
                    cfd.Valid = Valid.Checked;
                    cfd.Notes = Notes.Text;
                    ContractFiscalDeviceCtrl.UpdateControlFiscalDevice(this.cfd.ID,cfd);
                }
                else
                {
                    //ContractFiscalDevices cfd = new ContractFiscalDevices();
                    cfd.ContractType = ContractCtrl.GetContractByName(ContractType.Text);
                    cfd.ObjectId = this.objectID;
                    cfd.AutomaticNumbering = AutomaticNumbering.Checked;
                    if (ContractN.Text != "")
                    {
                        cfd.ContractN = int.Parse(ContractN.Text);
                    }
                   else
                    {
                        cfd.ContractN = null;
                    }
                    cfd.DateFrom = DateFrom.Value;
                    cfd.DateTo = DateTo.Value;
                    if (Sum.Text != "")
                    {
                        cfd.Sum = float.Parse(Sum.Text);
                    }
                    else
                    {
                        cfd.Sum = null;
                    }
                    if (SumForMount.Text != "")
                    {
                        cfd.SumMonth = float.Parse(SumForMount.Text);
                    }
                    else
                    {
                        cfd.SumMonth = null;
                    }
                    
                    cfd.Valid = Valid.Checked;
                    cfd.Notes = Notes.Text;
                    ContractFiscalDeviceCtrl.AddContractFiscalDevice(cfd);
                    
                }
                f1.LoadCfds();
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля, попълнете полетата!");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeCfd_Click(object sender, EventArgs e)
        {
           
        }

        private void ContractFiscalDevice_Load(object sender, EventArgs e)
        {
            var contracts = ContractCtrl.GetAllContracts();
            for (int i = 0; i < contracts.Length; i++)
            {
                ContractType.Items.Add(contracts[i].Name);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;


            switch (MessageBox.Show(this, "Сигурни ли сте, че иската да излезете " + " ?", "Договор за фискално устроийство", MessageBoxButtons.YesNo))
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
