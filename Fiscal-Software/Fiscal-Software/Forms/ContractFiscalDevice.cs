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

        private void button1_Click(object sender, EventArgs e)
        {
            ContractFiscalDevices cfd = new ContractFiscalDevices();
            cfd.ContractType = 20;
            cfd.ObjectId = 2;
            cfd.AutomaticNumbering = AutomaticNumbering.Checked;
            cfd.ContractN = Int32.Parse(ContractN.Text);
            cfd.DateFrom = DateFrom.Value;
            cfd.DateTo = DateTo.Value;
            cfd.Sum = float.Parse(Sum.Text);
            cfd.SumMonth = float.Parse(SumMonth.Text);
            cfd.Valid = Valid.Checked;
            cfd.Notes = Notes.Text;
            ContractFiscalDeviceCtrl.AddContractFiscalDevice(cfd);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeCfd_Click(object sender, EventArgs e)
        {
           
        }

        private void ContractFiscalDevice_Load(object sender, EventArgs e)
        {

        }
    }
}
