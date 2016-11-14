namespace Fiscal_Software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.номенклатуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.techniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiscalDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номенклатуриToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.експортToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitApp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // номенклатуриToolStripMenuItem
            // 
            this.номенклатуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanyMenu,
            this.techniciansToolStripMenuItem,
            this.fiscalDevicesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.номенклатуриToolStripMenuItem.Name = "номенклатуриToolStripMenuItem";
            this.номенклатуриToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.номенклатуриToolStripMenuItem.Text = "Номенклатури";
            // 
            // addCompanyMenu
            // 
            this.addCompanyMenu.Name = "addCompanyMenu";
            this.addCompanyMenu.Size = new System.Drawing.Size(194, 22);
            this.addCompanyMenu.Text = "Сервизни фирми";
            this.addCompanyMenu.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // techniciansToolStripMenuItem
            // 
            this.techniciansToolStripMenuItem.Name = "techniciansToolStripMenuItem";
            this.techniciansToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.techniciansToolStripMenuItem.Text = "Техници";
            this.techniciansToolStripMenuItem.Click += new System.EventHandler(this.techniciansToolStripMenuItem_Click);
            // 
            // fiscalDevicesToolStripMenuItem
            // 
            this.fiscalDevicesToolStripMenuItem.Name = "fiscalDevicesToolStripMenuItem";
            this.fiscalDevicesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.fiscalDevicesToolStripMenuItem.Text = "Фискални Устройства";
            this.fiscalDevicesToolStripMenuItem.Click += new System.EventHandler(this.fiscalDevicesToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // експортToolStripMenuItem
            // 
            this.експортToolStripMenuItem.Name = "експортToolStripMenuItem";
            this.експортToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.експортToolStripMenuItem.Text = "Експорт";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(51, 20);
            this.exitApp.Text = "Изход";
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clientsToolStripMenuItem.Text = "Картон Клиенти";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 392);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal-Software";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem номенклатуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.ToolStripMenuItem addCompanyMenu;
        private System.Windows.Forms.ToolStripMenuItem techniciansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiscalDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    }
}

