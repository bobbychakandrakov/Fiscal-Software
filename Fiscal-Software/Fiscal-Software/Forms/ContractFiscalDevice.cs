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

        public ContractFiscalDevice(int objectID,Form1 f1)
        {
            InitializeComponent();
            this.objectID = objectID;
            this.f1 = f1;
        }

        List<string> contractNames = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContractType.Text != "" || ContractN.Text != "")
            {
                ContractFiscalDevices cfd = new ContractFiscalDevices();
                cfd.ContractType = ContractCtrl.GetContractByName(ContractType.Text);
                cfd.ObjectId = this.objectID;
                cfd.AutomaticNumbering = AutomaticNumbering.Checked;
                cfd.ContractN = Int32.Parse(ContractN.Text);
                cfd.DateFrom = DateFrom.Value;
                cfd.DateTo = DateTo.Value;
                cfd.Sum = float.Parse(Sum.Text);
                cfd.SumMonth = float.Parse(SumForMount.Text);
                cfd.Valid = Valid.Checked;
                cfd.Notes = Notes.Text;
                ContractFiscalDeviceCtrl.AddContractFiscalDevice(cfd);
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
    }
}
