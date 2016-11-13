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
    public partial class TechniciansForm : Form
    {
        public TechniciansForm()
        {
            InitializeComponent();
        }

        private void TechniciansForm_Load(object sender, EventArgs e)
        {
            this.ToggleControls(false);
        }

        private void ToggleControls(bool areEnabled)
        {
            technicianCompanyBox.Enabled = areEnabled;
            technicianNameBox.Enabled = areEnabled;
            technicianEGNBox.Enabled = areEnabled;
            technicianTelephoneBox.Enabled = areEnabled;
            saveTechnicianBtn.Enabled = areEnabled;
            cancelTechnicianBtn.Enabled = areEnabled;
        }

        private void addTechnicianBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(true);
            addTechnicianBtn.Enabled = false;
            editTechnicianBtn.Enabled = false;
            deleteTechnicianBtn.Enabled = false;
        }

        private void cancelTechnicianBtn_Click(object sender, EventArgs e)
        {
            this.ToggleControls(false);
            addTechnicianBtn.Enabled = true;
            editTechnicianBtn.Enabled = true;
            deleteTechnicianBtn.Enabled = true;
        }
    }
}
