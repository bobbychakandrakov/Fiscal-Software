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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void enableAuthenticationBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckAuthentiocation();
        }

        private void CheckAuthentiocation()
        {
            if (enableAuthenticationBox.Checked)
            {
                usernameBox.Enabled = true;
                passwordBox.Enabled = true;
            }
            else
            {
                usernameBox.Enabled = false;
                passwordBox.Enabled = false;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            CheckAuthentiocation();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testConnectionBtn_Click(object sender, EventArgs e)
        {
            if (DatabaseSettings.TestConnection(serverNameBox.Text, catalogNameBox.Text, usernameBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Connection is ok");
            }
            else
            {
                MessageBox.Show("Connection is not ok.Try again");
            }
        }

        private void saveConnectionBtn_Click(object sender, EventArgs e)
        {
            if (enableAuthenticationBox.Checked)
            {
                DatabaseSettings.SetConnectionString(serverNameBox.Text, catalogNameBox.Text, usernameBox.Text, passwordBox.Text);
            }
            else
            {
                DatabaseSettings.SetConnectionString(serverNameBox.Text, catalogNameBox.Text);
            }
            
            Application.Restart();
        }
    }
}
