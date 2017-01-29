using Microsoft.Reporting.WinForms;
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
    public partial class PrintSvidetelstvo : Form
    {
        public PrintSvidetelstvo()
        {
            InitializeComponent();
        }

        private void PrintSvidetelstvo_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
        }
    }
}
