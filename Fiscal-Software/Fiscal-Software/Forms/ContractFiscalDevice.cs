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
    public partial class ContractFiscalDevice : Form
    {
        public ContractFiscalDevice()
        {
            InitializeComponent();
        }

        int objectID;
        Form1 f1;
        bool isUpdate = false, touched = false;

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
            if (cfd.DateFrom.HasValue)
            {
                DateFrom.Checked = true;
                DateFrom.Value = cfd.DateFrom.Value;
            }
            else
            {
                DateFrom.Checked = false;
                DateFrom.Value = DateTime.Now;
            }

            if (cfd.DateTo.HasValue)
            {
                DateTo.Checked = true;
                DateTo.Value = cfd.DateTo.Value;
            }
            else
            {
                DateFrom.Checked = false;
                DateFrom.Value = DateTime.Now;
            }
             
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
            
            if (ContractType.Text != "" && ContractN.Text != "")
            {
                ContractFiscalDevices cfd = new ContractFiscalDevices();
                if (this.isUpdate)
                {
                    cfd.ContractType = ContractCtrl.GetContractByName(ContractType.Text);
                    cfd.ObjectId = objectID;
                    cfd.AutomaticNumbering = AutomaticNumbering.Checked;
                    cfd.ContractN = Int32.Parse(ContractN.Text);
                    if (DateFrom.Checked)
                    {
                        cfd.DateFrom = DateFrom.Value;
                    }
                    else
                    {
                        cfd.DateFrom = null;
                    }
                    if (DateTo.Checked)
                    {
                        cfd.DateTo = DateTo.Value;
                    }
                    else
                    {
                        cfd.DateTo = null;
                    }
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
                    if (DateFrom.Checked)
                    {
                        cfd.DateFrom = DateFrom.Value;
                    }
                    else
                    {
                        cfd.DateFrom = null;
                    }
                    if (DateTo.Checked)
                    {
                        cfd.DateTo = DateTo.Value;
                    }
                    else
                    {
                        cfd.DateTo = null;
                    }
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
            
            DirtyChecker.Check(Controls, c_ControlChanged);
        }

        void c_ControlChanged(object sender, EventArgs e)
        {
            touched = true;
        }

        private void ContractFiscalDevice_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
