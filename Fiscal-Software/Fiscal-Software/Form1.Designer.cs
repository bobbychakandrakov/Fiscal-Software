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
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаЕИКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаДДСNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clientsListView = new System.Windows.Forms.ListView();
            this.numberDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.contractType = new System.Windows.Forms.ToolStripMenuItem();
            this.otherSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.exitApp,
            this.справкаЕИКToolStripMenuItem,
            this.справкаДДСNoToolStripMenuItem});
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
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clientsToolStripMenuItem.Text = "Картон Клиенти";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
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
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberDocument,
            this.contractType,
            this.otherSettings,
            this.databaseSettings});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
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
            // справкаЕИКToolStripMenuItem
            // 
            this.справкаЕИКToolStripMenuItem.Name = "справкаЕИКToolStripMenuItem";
            this.справкаЕИКToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.справкаЕИКToolStripMenuItem.Text = "Справка ЕИК";
            this.справкаЕИКToolStripMenuItem.Click += new System.EventHandler(this.справкаЕИКToolStripMenuItem_Click);
            // 
            // справкаДДСNoToolStripMenuItem
            // 
            this.справкаДДСNoToolStripMenuItem.Name = "справкаДДСNoToolStripMenuItem";
            this.справкаДДСNoToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.справкаДДСNoToolStripMenuItem.Text = "справка ДДС No";
            this.справкаДДСNoToolStripMenuItem.Click += new System.EventHandler(this.справкаДДСNoToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clientsListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.30434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 368);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // clientsListView
            // 
            this.clientsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsListView.FullRowSelect = true;
            this.clientsListView.Location = new System.Drawing.Point(3, 35);
            this.clientsListView.MultiSelect = false;
            this.clientsListView.Name = "clientsListView";
            this.clientsListView.Size = new System.Drawing.Size(420, 330);
            this.clientsListView.TabIndex = 0;
            this.clientsListView.UseCompatibleStateImageBehavior = false;
            this.clientsListView.View = System.Windows.Forms.View.Details;
            // 
            // numberDocument
            // 
            this.numberDocument.Name = "numberDocument";
            this.numberDocument.Size = new System.Drawing.Size(180, 22);
            this.numberDocument.Text = "Номера документи";
            this.numberDocument.Click += new System.EventHandler(this.numberDocument_Click);
            // 
            // contractType
            // 
            this.contractType.Name = "contractType";
            this.contractType.Size = new System.Drawing.Size(180, 22);
            this.contractType.Text = "Видове договори";
            // 
            // otherSettings
            // 
            this.otherSettings.Name = "otherSettings";
            this.otherSettings.Size = new System.Drawing.Size(180, 22);
            this.otherSettings.Text = "Други";
            // 
            // databaseSettings
            // 
            this.databaseSettings.Name = "databaseSettings";
            this.databaseSettings.Size = new System.Drawing.Size(180, 22);
            this.databaseSettings.Text = "База данни";
            this.databaseSettings.Click += new System.EventHandler(this.databaseSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscal-Software";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView clientsListView;
        private System.Windows.Forms.ToolStripMenuItem справкаЕИКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаДДСNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberDocument;
        private System.Windows.Forms.ToolStripMenuItem contractType;
        private System.Windows.Forms.ToolStripMenuItem otherSettings;
        private System.Windows.Forms.ToolStripMenuItem databaseSettings;
    }
}

