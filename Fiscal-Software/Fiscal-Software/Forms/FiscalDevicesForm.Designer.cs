namespace Fiscal_Software.Forms
{
    partial class FiscalDevicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiscalDevicesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteFiscalDeviceBtn = new System.Windows.Forms.Button();
            this.editFiscalDeviceBtn = new System.Windows.Forms.Button();
            this.addFiscalDeviceBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fiscalDevicesList = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelFiscalDeviceBtn = new System.Windows.Forms.Button();
            this.saveFiscalDeviceBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fiscalDeviceManufacturerBulstatBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fiscalDeviceWarrantyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fiscalDevicePriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fiscalDeviceStartDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.fiscalDeviceCerificateN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiscalDeviceManufacturerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fiscalDeviceModelBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fiscalDeviceTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.7027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.29729F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44776F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.55224F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteFiscalDeviceBtn);
            this.panel1.Controls.Add(this.editFiscalDeviceBtn);
            this.panel1.Controls.Add(this.addFiscalDeviceBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 28);
            this.panel1.TabIndex = 0;
            // 
            // deleteFiscalDeviceBtn
            // 
            this.deleteFiscalDeviceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteFiscalDeviceBtn.Location = new System.Drawing.Point(157, 0);
            this.deleteFiscalDeviceBtn.Name = "deleteFiscalDeviceBtn";
            this.deleteFiscalDeviceBtn.Size = new System.Drawing.Size(75, 28);
            this.deleteFiscalDeviceBtn.TabIndex = 2;
            this.deleteFiscalDeviceBtn.Text = "Изтриване";
            this.deleteFiscalDeviceBtn.UseVisualStyleBackColor = true;
            this.deleteFiscalDeviceBtn.Click += new System.EventHandler(this.deleteFiscalDeviceBtn_Click);
            // 
            // editFiscalDeviceBtn
            // 
            this.editFiscalDeviceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editFiscalDeviceBtn.Location = new System.Drawing.Point(75, 0);
            this.editFiscalDeviceBtn.Name = "editFiscalDeviceBtn";
            this.editFiscalDeviceBtn.Size = new System.Drawing.Size(82, 28);
            this.editFiscalDeviceBtn.TabIndex = 1;
            this.editFiscalDeviceBtn.Text = "Редактиране";
            this.editFiscalDeviceBtn.UseVisualStyleBackColor = true;
            this.editFiscalDeviceBtn.Click += new System.EventHandler(this.editFiscalDeviceBtn_Click);
            // 
            // addFiscalDeviceBtn
            // 
            this.addFiscalDeviceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addFiscalDeviceBtn.Location = new System.Drawing.Point(0, 0);
            this.addFiscalDeviceBtn.Name = "addFiscalDeviceBtn";
            this.addFiscalDeviceBtn.Size = new System.Drawing.Size(75, 28);
            this.addFiscalDeviceBtn.TabIndex = 0;
            this.addFiscalDeviceBtn.Text = "Добавяне";
            this.addFiscalDeviceBtn.UseVisualStyleBackColor = true;
            this.addFiscalDeviceBtn.Click += new System.EventHandler(this.addFiscalDeviceBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fiscalDevicesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 295);
            this.panel2.TabIndex = 1;
            // 
            // fiscalDevicesList
            // 
            this.fiscalDevicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiscalDevicesList.FullRowSelect = true;
            this.fiscalDevicesList.Location = new System.Drawing.Point(0, 0);
            this.fiscalDevicesList.MultiSelect = false;
            this.fiscalDevicesList.Name = "fiscalDevicesList";
            this.fiscalDevicesList.Size = new System.Drawing.Size(236, 295);
            this.fiscalDevicesList.TabIndex = 0;
            this.fiscalDevicesList.UseCompatibleStateImageBehavior = false;
            this.fiscalDevicesList.View = System.Windows.Forms.View.Details;
            this.fiscalDevicesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fiscalDevicesList_ItemSelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelFiscalDeviceBtn);
            this.panel3.Controls.Add(this.saveFiscalDeviceBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(245, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 28);
            this.panel3.TabIndex = 2;
            // 
            // cancelFiscalDeviceBtn
            // 
            this.cancelFiscalDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelFiscalDeviceBtn.Location = new System.Drawing.Point(342, 0);
            this.cancelFiscalDeviceBtn.Name = "cancelFiscalDeviceBtn";
            this.cancelFiscalDeviceBtn.Size = new System.Drawing.Size(75, 28);
            this.cancelFiscalDeviceBtn.TabIndex = 1;
            this.cancelFiscalDeviceBtn.Text = "Отказ";
            this.cancelFiscalDeviceBtn.UseVisualStyleBackColor = true;
            this.cancelFiscalDeviceBtn.Click += new System.EventHandler(this.cancelFiscalDeviceBtn_Click);
            // 
            // saveFiscalDeviceBtn
            // 
            this.saveFiscalDeviceBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveFiscalDeviceBtn.Location = new System.Drawing.Point(417, 0);
            this.saveFiscalDeviceBtn.Name = "saveFiscalDeviceBtn";
            this.saveFiscalDeviceBtn.Size = new System.Drawing.Size(75, 28);
            this.saveFiscalDeviceBtn.TabIndex = 0;
            this.saveFiscalDeviceBtn.Text = "Запис";
            this.saveFiscalDeviceBtn.UseVisualStyleBackColor = true;
            this.saveFiscalDeviceBtn.Click += new System.EventHandler(this.saveFiscalDeviceBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fiscalDeviceManufacturerBulstatBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.fiscalDeviceWarrantyBox);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.fiscalDevicePriceBox);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.fiscalDeviceStartDateBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.fiscalDeviceCerificateN);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.fiscalDeviceManufacturerBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.fiscalDeviceModelBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.fiscalDeviceTypeBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(245, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 295);
            this.panel4.TabIndex = 3;
            // 
            // fiscalDeviceManufacturerBulstatBox
            // 
            this.fiscalDeviceManufacturerBulstatBox.Location = new System.Drawing.Point(184, 247);
            this.fiscalDeviceManufacturerBulstatBox.Name = "fiscalDeviceManufacturerBulstatBox";
            this.fiscalDeviceManufacturerBulstatBox.Size = new System.Drawing.Size(199, 20);
            this.fiscalDeviceManufacturerBulstatBox.TabIndex = 15;
            this.fiscalDeviceManufacturerBulstatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiscalDeviceManufacturerBulstatBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Булстат на производителя";
            // 
            // fiscalDeviceWarrantyBox
            // 
            this.fiscalDeviceWarrantyBox.Location = new System.Drawing.Point(389, 200);
            this.fiscalDeviceWarrantyBox.Name = "fiscalDeviceWarrantyBox";
            this.fiscalDeviceWarrantyBox.Size = new System.Drawing.Size(84, 20);
            this.fiscalDeviceWarrantyBox.TabIndex = 13;
            this.fiscalDeviceWarrantyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fiscalDeviceWarrantyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiscalDeviceWarrantyBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Гаранция (в месеци)";
            // 
            // fiscalDevicePriceBox
            // 
            this.fiscalDevicePriceBox.Location = new System.Drawing.Point(85, 200);
            this.fiscalDevicePriceBox.Name = "fiscalDevicePriceBox";
            this.fiscalDevicePriceBox.Size = new System.Drawing.Size(157, 20);
            this.fiscalDevicePriceBox.TabIndex = 11;
            this.fiscalDevicePriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена";
            // 
            // fiscalDeviceStartDateBox
            // 
            this.fiscalDeviceStartDateBox.Location = new System.Drawing.Point(296, 156);
            this.fiscalDeviceStartDateBox.Name = "fiscalDeviceStartDateBox";
            this.fiscalDeviceStartDateBox.Size = new System.Drawing.Size(178, 20);
            this.fiscalDeviceStartDateBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 158);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "от";
            // 
            // fiscalDeviceCerificateN
            // 
            this.fiscalDeviceCerificateN.Location = new System.Drawing.Point(135, 156);
            this.fiscalDeviceCerificateN.Name = "fiscalDeviceCerificateN";
            this.fiscalDeviceCerificateN.Size = new System.Drawing.Size(107, 20);
            this.fiscalDeviceCerificateN.TabIndex = 7;
            this.fiscalDeviceCerificateN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fiscalDeviceCerificateN_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Свидетелство N*";
            // 
            // fiscalDeviceManufacturerBox
            // 
            this.fiscalDeviceManufacturerBox.FormattingEnabled = true;
            this.fiscalDeviceManufacturerBox.Location = new System.Drawing.Point(121, 115);
            this.fiscalDeviceManufacturerBox.Name = "fiscalDeviceManufacturerBox";
            this.fiscalDeviceManufacturerBox.Size = new System.Drawing.Size(273, 21);
            this.fiscalDeviceManufacturerBox.TabIndex = 5;
            this.fiscalDeviceManufacturerBox.SelectedIndexChanged += new System.EventHandler(this.fiscalDeviceManufacturerBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Производител";
            // 
            // fiscalDeviceModelBox
            // 
            this.fiscalDeviceModelBox.Location = new System.Drawing.Point(272, 60);
            this.fiscalDeviceModelBox.Name = "fiscalDeviceModelBox";
            this.fiscalDeviceModelBox.Size = new System.Drawing.Size(202, 20);
            this.fiscalDeviceModelBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(209, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модел*";
            // 
            // fiscalDeviceTypeBox
            // 
            this.fiscalDeviceTypeBox.FormattingEnabled = true;
            this.fiscalDeviceTypeBox.Location = new System.Drawing.Point(64, 60);
            this.fiscalDeviceTypeBox.Name = "fiscalDeviceTypeBox";
            this.fiscalDeviceTypeBox.Size = new System.Drawing.Size(121, 21);
            this.fiscalDeviceTypeBox.TabIndex = 1;
            this.fiscalDeviceTypeBox.SelectedIndexChanged += new System.EventHandler(this.fiscalDeviceTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип";
            // 
            // FiscalDevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiscalDevicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фискални устройства";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FiscalDevicesForm_FormClosing);
            this.Load += new System.EventHandler(this.FiscalDevicesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteFiscalDeviceBtn;
        private System.Windows.Forms.Button editFiscalDeviceBtn;
        private System.Windows.Forms.Button addFiscalDeviceBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView fiscalDevicesList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cancelFiscalDeviceBtn;
        private System.Windows.Forms.Button saveFiscalDeviceBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox fiscalDevicePriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fiscalDeviceStartDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiscalDeviceCerificateN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fiscalDeviceManufacturerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiscalDeviceModelBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fiscalDeviceTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiscalDeviceManufacturerBulstatBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fiscalDeviceWarrantyBox;
        private System.Windows.Forms.Label label7;
    }
}