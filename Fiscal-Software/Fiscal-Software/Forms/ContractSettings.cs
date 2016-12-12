using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiscal_Software.Helpers;
using Fiscal_Software.Controlles;

namespace Fiscal_Software.Forms
{
    public partial class ContractSettings : Form
    {
        public ContractSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numericUpDown1.Value.ToString());
            int svidetelstvo = int.Parse(numericUpDown2.Value.ToString());
            NomeraDokumenti nd = new NomeraDokumenti();
            nd.ContractN = n;
            nd.Svidetelstvo = svidetelstvo;
            NomeraDokumentiCtrl.AddNomeraDocument(nd);
            //DocumentNumber.SetSettings(n,svidetelstvo);
            this.Close();
        }

        private void ContractSettings_Load(object sender, EventArgs e)
        {
            /*
            DocumentNumber.ReadSettings();
            numericUpDown1.Value = DocumentNumber.number;
            numericUpDown2.Value = DocumentNumber.svidetelstvo;
            */
            var dk = NomeraDokumentiCtrl.GetNomerDokument();
            if (dk != null)
            {
                numericUpDown1.Value = int.Parse(dk.ContractN.ToString());
                numericUpDown2.Value = int.Parse(dk.Svidetelstvo.ToString());
            }
        }
    }
}
