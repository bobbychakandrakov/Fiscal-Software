using System;
using Microsoft.Reporting.WinForms;
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
    public partial class PrintZaqvlenie : Form
    {
        public PrintZaqvlenie()
        {
            InitializeComponent();
        }

        private void PrintZaqvlenie_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
