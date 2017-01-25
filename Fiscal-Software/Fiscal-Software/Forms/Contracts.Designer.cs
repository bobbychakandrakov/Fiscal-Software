namespace Fiscal_Software.Forms
{
    partial class Contracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contracts));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteContractBtn = new System.Windows.Forms.Button();
            this.editContractBtn = new System.Windows.Forms.Button();
            this.addContractBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveContractBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contractsListView = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contractSpareModulesBox = new System.Windows.Forms.CheckBox();
            this.contractProtectBox = new System.Windows.Forms.CheckBox();
            this.contractSparePartsBox = new System.Windows.Forms.CheckBox();
            this.contractWorkBox = new System.Windows.Forms.CheckBox();
            this.contractProgrammingArticulBox = new System.Windows.Forms.CheckBox();
            this.contractProgrammingBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contractPayToBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contractSumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contractMP3Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contractSumForMonth = new System.Windows.Forms.CheckBox();
            this.contractDurationBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.contractNameBox = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDurationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.38482F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.61517F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.290954F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.70905F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteContractBtn);
            this.panel1.Controls.Add(this.editContractBtn);
            this.panel1.Controls.Add(this.addContractBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 33);
            this.panel1.TabIndex = 0;
            // 
            // deleteContractBtn
            // 
            this.deleteContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteContractBtn.Location = new System.Drawing.Point(158, 0);
            this.deleteContractBtn.Name = "deleteContractBtn";
            this.deleteContractBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteContractBtn.TabIndex = 2;
            this.deleteContractBtn.Text = "Изтриване";
            this.deleteContractBtn.UseVisualStyleBackColor = true;
            this.deleteContractBtn.Click += new System.EventHandler(this.deleteContractBtn_Click_1);
            // 
            // editContractBtn
            // 
            this.editContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editContractBtn.Location = new System.Drawing.Point(75, 0);
            this.editContractBtn.Name = "editContractBtn";
            this.editContractBtn.Size = new System.Drawing.Size(83, 33);
            this.editContractBtn.TabIndex = 1;
            this.editContractBtn.Text = "Редактиране";
            this.editContractBtn.UseVisualStyleBackColor = true;
            this.editContractBtn.Click += new System.EventHandler(this.editContractBtn_Click);
            // 
            // addContractBtn
            // 
            this.addContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addContractBtn.Location = new System.Drawing.Point(0, 0);
            this.addContractBtn.Name = "addContractBtn";
            this.addContractBtn.Size = new System.Drawing.Size(75, 33);
            this.addContractBtn.TabIndex = 0;
            this.addContractBtn.Text = "Добавяне";
            this.addContractBtn.UseVisualStyleBackColor = true;
            this.addContractBtn.Click += new System.EventHandler(this.addContractBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.saveContractBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(241, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 33);
            this.panel2.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelBtn.Location = new System.Drawing.Point(344, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отказ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveContractBtn
            // 
            this.saveContractBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveContractBtn.Location = new System.Drawing.Point(419, 0);
            this.saveContractBtn.Name = "saveContractBtn";
            this.saveContractBtn.Size = new System.Drawing.Size(75, 33);
            this.saveContractBtn.TabIndex = 0;
            this.saveContractBtn.Text = "Запис";
            this.saveContractBtn.UseVisualStyleBackColor = true;
            this.saveContractBtn.Click += new System.EventHandler(this.saveContractBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contractsListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 375);
            this.panel3.TabIndex = 2;
            // 
            // contractsListView
            // 
            this.contractsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsListView.FullRowSelect = true;
            this.contractsListView.Location = new System.Drawing.Point(0, 0);
            this.contractsListView.Name = "contractsListView";
            this.contractsListView.Size = new System.Drawing.Size(232, 375);
            this.contractsListView.TabIndex = 0;
            this.contractsListView.UseCompatibleStateImageBehavior = false;
            this.contractsListView.View = System.Windows.Forms.View.Details;
            this.contractsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.contractsListView_ItemSelectionChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.contractSpareModulesBox);
            this.panel4.Controls.Add(this.contractProtectBox);
            this.panel4.Controls.Add(this.contractSparePartsBox);
            this.panel4.Controls.Add(this.contractWorkBox);
            this.panel4.Controls.Add(this.contractProgrammingArticulBox);
            this.panel4.Controls.Add(this.contractProgrammingBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.contractPayToBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.contractSumBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.contractMP3Box);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.contractSumForMonth);
            this.panel4.Controls.Add(this.contractDurationBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.contractNameBox);
            this.panel4.Controls.Add(this.label123);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(241, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 375);
            this.panel4.TabIndex = 3;
            // 
            // contractSpareModulesBox
            // 
            this.contractSpareModulesBox.AutoSize = true;
            this.contractSpareModulesBox.Location = new System.Drawing.Point(263, 349);
            this.contractSpareModulesBox.Name = "contractSpareModulesBox";
            this.contractSpareModulesBox.Size = new System.Drawing.Size(115, 17);
            this.contractSpareModulesBox.TabIndex = 17;
            this.contractSpareModulesBox.Text = "Резервни модули";
            this.contractSpareModulesBox.UseVisualStyleBackColor = true;
            // 
            // contractProtectBox
            // 
            this.contractProtectBox.AutoSize = true;
            this.contractProtectBox.Location = new System.Drawing.Point(263, 326);
            this.contractProtectBox.Name = "contractProtectBox";
            this.contractProtectBox.Size = new System.Drawing.Size(99, 17);
            this.contractProtectBox.TabIndex = 16;
            this.contractProtectBox.Text = "Предпазители";
            this.contractProtectBox.UseVisualStyleBackColor = true;
            // 
            // contractSparePartsBox
            // 
            this.contractSparePartsBox.AutoSize = true;
            this.contractSparePartsBox.Location = new System.Drawing.Point(263, 303);
            this.contractSparePartsBox.Name = "contractSparePartsBox";
            this.contractSparePartsBox.Size = new System.Drawing.Size(106, 17);
            this.contractSparePartsBox.TabIndex = 15;
            this.contractSparePartsBox.Text = "Резервни части";
            this.contractSparePartsBox.UseVisualStyleBackColor = true;
            // 
            // contractWorkBox
            // 
            this.contractWorkBox.AutoSize = true;
            this.contractWorkBox.Location = new System.Drawing.Point(29, 349);
            this.contractWorkBox.Name = "contractWorkBox";
            this.contractWorkBox.Size = new System.Drawing.Size(50, 17);
            this.contractWorkBox.TabIndex = 14;
            this.contractWorkBox.Text = "Труд";
            this.contractWorkBox.UseVisualStyleBackColor = true;
            // 
            // contractProgrammingArticulBox
            // 
            this.contractProgrammingArticulBox.AutoSize = true;
            this.contractProgrammingArticulBox.Location = new System.Drawing.Point(29, 326);
            this.contractProgrammingArticulBox.Name = "contractProgrammingArticulBox";
            this.contractProgrammingArticulBox.Size = new System.Drawing.Size(159, 17);
            this.contractProgrammingArticulBox.TabIndex = 13;
            this.contractProgrammingArticulBox.Text = "Програмиране на артикул";
            this.contractProgrammingArticulBox.UseVisualStyleBackColor = true;
            // 
            // contractProgrammingBox
            // 
            this.contractProgrammingBox.AutoSize = true;
            this.contractProgrammingBox.Location = new System.Drawing.Point(29, 303);
            this.contractProgrammingBox.Name = "contractProgrammingBox";
            this.contractProgrammingBox.Size = new System.Drawing.Size(101, 17);
            this.contractProgrammingBox.TabIndex = 12;
            this.contractProgrammingBox.Text = "Програмиране";
            this.contractProgrammingBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Плащане на услуги при сключен договор (услугите се плащат от клиента)";
            // 
            // contractPayToBox
            // 
            this.contractPayToBox.Location = new System.Drawing.Point(29, 198);
            this.contractPayToBox.Name = "contractPayToBox";
            this.contractPayToBox.Size = new System.Drawing.Size(422, 48);
            this.contractPayToBox.TabIndex = 10;
            this.contractPayToBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Плащане до";
            // 
            // contractSumBox
            // 
            this.contractSumBox.Location = new System.Drawing.Point(308, 139);
            this.contractSumBox.Name = "contractSumBox";
            this.contractSumBox.Size = new System.Drawing.Size(143, 20);
            this.contractSumBox.TabIndex = 8;
            this.contractSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractSumBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сума";
            // 
            // contractMP3Box
            // 
            this.contractMP3Box.Location = new System.Drawing.Point(124, 139);
            this.contractMP3Box.Name = "contractMP3Box";
            this.contractMP3Box.Size = new System.Drawing.Size(109, 20);
            this.contractMP3Box.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Процент от МР3";
            // 
            // contractSumForMonth
            // 
            this.contractSumForMonth.AutoSize = true;
            this.contractSumForMonth.Location = new System.Drawing.Point(29, 88);
            this.contractSumForMonth.Name = "contractSumForMonth";
            this.contractSumForMonth.Size = new System.Drawing.Size(182, 17);
            this.contractSumForMonth.TabIndex = 4;
            this.contractSumForMonth.Text = "Сума по договора (за 1 месец)";
            this.contractSumForMonth.UseVisualStyleBackColor = true;
            this.contractSumForMonth.CheckedChanged += new System.EventHandler(this.contractSumForMonth_CheckedChanged);
            // 
            // contractDurationBox
            // 
            this.contractDurationBox.Location = new System.Drawing.Point(206, 52);
            this.contractDurationBox.Name = "contractDurationBox";
            this.contractDurationBox.Size = new System.Drawing.Size(177, 20);
            this.contractDurationBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Срок на договора в месеци";
            // 
            // contractNameBox
            // 
            this.contractNameBox.Location = new System.Drawing.Point(73, 13);
            this.contractNameBox.Name = "contractNameBox";
            this.contractNameBox.Size = new System.Drawing.Size(378, 20);
            this.contractNameBox.TabIndex = 1;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ForeColor = System.Drawing.Color.Red;
            this.label123.Location = new System.Drawing.Point(26, 16);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(29, 13);
            this.label123.TabIndex = 0;
            this.label123.Text = "Име";
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договори";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contracts_FormClosing);
            this.Load += new System.EventHandler(this.Contracts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDurationBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteContractBtn;
        private System.Windows.Forms.Button editContractBtn;
        private System.Windows.Forms.Button addContractBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveContractBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView contractsListView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown contractDurationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractNameBox;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.CheckBox contractSumForMonth;
        private System.Windows.Forms.CheckBox contractSpareModulesBox;
        private System.Windows.Forms.CheckBox contractProtectBox;
        private System.Windows.Forms.CheckBox contractSparePartsBox;
        private System.Windows.Forms.CheckBox contractWorkBox;
        private System.Windows.Forms.CheckBox contractProgrammingArticulBox;
        private System.Windows.Forms.CheckBox contractProgrammingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox contractPayToBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contractSumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contractMP3Box;
        private System.Windows.Forms.Label label2;
    }
}