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

        int objectID, sumaMnojitel = 0;
        decimal sum = 0;
        Form1 f1;
        bool isUpdate = false, touched = false;
        ListViewItem lvi;


        public ContractFiscalDevice(int objectID,Form1 f1)
        {
            InitializeComponent();
            this.objectID = objectID;
            this.f1 = f1;
            panel3.Enabled = false;
            paymentsList.Enabled = false;
        }
       


        public ContractFiscalDevice(Form1 form1, ContractFiscalDevices cfd)
        {
        
            InitializeComponent();
            this.f1 = form1;
            this.cfd = cfd;
            this.isUpdate = true;
            
        
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
            Sum.Text = string.Format("{0:#.00}", Convert.ToDecimal(cfd.Sum.ToString()));
            //Sum.Text = cfd.Sum.ToString();
            SumForMount.Text = string.Format("{0:#.00}", Convert.ToDecimal(cfd.SumMonth.ToString()));
            //SumForMount.Text = cfd.SumMonth.ToString();
              Valid.Checked= cfd.Valid.Value;
              Notes.Text = cfd.Notes;
           

        }

        List<string> contractNames = new List<string>();
        private Form1 form1;
        private ContractFiscalDevices cfd;
        private void LoadColums()
        {
            paymentsList.Clear();
            paymentsList.Columns.Add("Дата на плащане");
            paymentsList.Columns.Add("До дата");
            paymentsList.Columns.Add("Сума");
            paymentsList.Columns.Add("Бележки");
            paymentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            paymentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
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
                touched = false;
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
            
            int? contractNumber = NomeraDokumentiCtrl.GetNomerDokument().ContractN.Value;
            if (contractNumber.HasValue)
            {
                ContractN.Text = contractNumber.Value.ToString();
            }
            ContractType.DisplayMember = "Text";
            ContractType.ValueMember = "Value";
            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item;
            HashSet<string> techHash = new HashSet<string>();
            var contracts = ContractCtrl.GetAllContracts();
            for (int i = 0; i < contracts.Length; i++)
            {
                item = new ComboboxItem();
                item.Text = contracts[i].Name;
                item.Value = contracts[i].ID;
                list.Add(item);
                //ContractType.Items.Add(contracts[i].Name);
            }
            ContractType.DataSource = list.ToList();
            LoadColums();
            LoadPayments();
            if (this.cfd != null)
            {
                loadDataForUpdate(this.cfd);
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

        private void cancelPayment_Click(object sender, EventArgs e)
        {
            touched = false;
            this.Close();
        }

        private void savePayment_Click(object sender, EventArgs e)
        {
            if (dataDoPayment.Checked == false || dataNaPayment.Checked == false || sumPayment.Text == "")
            {
                MessageBox.Show("Моля, попълнете задължителните полета!");
            }
            else
            {
                Plashtaniq p = new Plashtaniq();
                p.DogovorID = this.cfd.ID;
                p.DataDo = dataDoPayment.Value;
                p.DataNa = dataNaPayment.Value;
                p.Suma = decimal.Parse(sumPayment.Text);
                p.Notes = notesPayment.Text;
                PlashtaniqCtrl.AddPlashtaniq(p);
                touched = false;
                Close();
            }
            
        }

        private void LoadPayments()
        {
            if (isUpdate)
            {
                var payments = PlashtaniqCtrl.GetAll(this.cfd.ID);
                    paymentsList.Items.Clear();
                sum = 0;
                totalSum.Text = "0.00";
                    for (int i = 0; i < payments.Length; i++)
                    {
                        lvi = new ListViewItem(payments[i].DataNa.ToString());
                        lvi.SubItems.Add(payments[i].DataDo.ToString());
                        lvi.SubItems.Add(string.Format("{0:#.00}", Convert.ToDecimal(payments[i].Suma.ToString())));
                        lvi.SubItems.Add(payments[i].Notes);
                        lvi.Tag = payments[i].ID;
                        paymentsList.Items.Add(lvi);
                        if (payments[i].Suma.HasValue)
                        {
                            sum += payments[i].Suma.Value;
                        }

                    totalSum.Text = string.Format("{0:#.00}", Convert.ToDecimal(sum.ToString()));
                    paymentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    paymentsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            
            
        }

        private void deletePayments_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < paymentsList.CheckedItems.Count; i++)
            {
                PlashtaniqCtrl.DeletePlashtane(int.Parse(paymentsList.CheckedItems[i].Tag.ToString()));
            }
            sum = 0;
            LoadPayments();
        }

        private void SumForMount_Leave(object sender, EventArgs e)
        {
            Sum.Text = sumaMnojitel * float.Parse(SumForMount.Text) + "";
        }

        private void SumForMount_TextChanged(object sender, EventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SumForMount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = false;
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AutomaticNumbering_CheckedChanged(object sender, EventArgs e)
        {
            if (AutomaticNumbering.Checked)
            {
                ContractN.Enabled = false;
            }
            else
            {
                ContractN.Enabled = true;
            }
        }

        private void ContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? symaZamesec = ContractCtrl.GetContractById(int.Parse(ContractType.SelectedValue.ToString())).Duration;
            if (symaZamesec.HasValue)
            {
                sumaMnojitel = symaZamesec.Value;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        

    }
}
