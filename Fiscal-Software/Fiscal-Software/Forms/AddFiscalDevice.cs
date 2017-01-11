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
    public partial class AddFiscalDevice : Form
    {
        public AddFiscalDevice()
        {
            InitializeComponent();
        }

        private void saveFD_Click(object sender, EventArgs e)
        {
            // Save to db
        }

        private void cancelFD_Click(object sender, EventArgs e)
        {
            // Exit form and show dialog if forms are touched
        }
    }
}
