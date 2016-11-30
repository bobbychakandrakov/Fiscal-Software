namespace Fiscal_Software.Forms
{
    partial class TechniciansForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteTechnicianBtn = new System.Windows.Forms.Button();
            this.editTechnicianBtn = new System.Windows.Forms.Button();
            this.addTechnicianBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.techniciansList = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelTechnicianBtn = new System.Windows.Forms.Button();
            this.saveTechnicianBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.technicianCompanyBox = new System.Windows.Forms.ComboBox();
            this.fiscalSoftwareDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Fiscal_SoftwareDataSet = new Fiscal_Software._Fiscal_SoftwareDataSet();
            this.technicianTelephoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.technicianEGNBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.technicianNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyTableAdapter = new Fiscal_Software._Fiscal_SoftwareDataSetTableAdapters.CompanyTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalSoftwareDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Fiscal_SoftwareDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.96861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.03139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteTechnicianBtn);
            this.panel1.Controls.Add(this.editTechnicianBtn);
            this.panel1.Controls.Add(this.addTechnicianBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 33);
            this.panel1.TabIndex = 0;
            // 
            // deleteTechnicianBtn
            // 
            this.deleteTechnicianBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteTechnicianBtn.Location = new System.Drawing.Point(155, 0);
            this.deleteTechnicianBtn.Name = "deleteTechnicianBtn";
            this.deleteTechnicianBtn.Size = new System.Drawing.Size(75, 33);
            this.deleteTechnicianBtn.TabIndex = 2;
            this.deleteTechnicianBtn.Text = "Изтриване";
            this.deleteTechnicianBtn.UseVisualStyleBackColor = true;
            this.deleteTechnicianBtn.Click += new System.EventHandler(this.deleteTechnicianBtn_Click);
            // 
            // editTechnicianBtn
            // 
            this.editTechnicianBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editTechnicianBtn.Location = new System.Drawing.Point(69, 0);
            this.editTechnicianBtn.Name = "editTechnicianBtn";
            this.editTechnicianBtn.Size = new System.Drawing.Size(86, 33);
            this.editTechnicianBtn.TabIndex = 1;
            this.editTechnicianBtn.Text = "Редактиране";
            this.editTechnicianBtn.UseVisualStyleBackColor = true;
            this.editTechnicianBtn.Click += new System.EventHandler(this.editTechnicianBtn_Click);
            // 
            // addTechnicianBtn
            // 
            this.addTechnicianBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTechnicianBtn.Location = new System.Drawing.Point(0, 0);
            this.addTechnicianBtn.Name = "addTechnicianBtn";
            this.addTechnicianBtn.Size = new System.Drawing.Size(69, 33);
            this.addTechnicianBtn.TabIndex = 0;
            this.addTechnicianBtn.Text = "Добавяне";
            this.addTechnicianBtn.UseVisualStyleBackColor = true;
            this.addTechnicianBtn.Click += new System.EventHandler(this.addTechnicianBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.techniciansList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 401);
            this.panel2.TabIndex = 1;
            // 
            // techniciansList
            // 
            this.techniciansList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techniciansList.FullRowSelect = true;
            this.techniciansList.Location = new System.Drawing.Point(0, 0);
            this.techniciansList.MultiSelect = false;
            this.techniciansList.Name = "techniciansList";
            this.techniciansList.Size = new System.Drawing.Size(231, 401);
            this.techniciansList.TabIndex = 0;
            this.techniciansList.UseCompatibleStateImageBehavior = false;
            this.techniciansList.View = System.Windows.Forms.View.Details;
            this.techniciansList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.techniciansList_ItemSelectionChanged);
            this.techniciansList.SelectedIndexChanged += new System.EventHandler(this.techniciansList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelTechnicianBtn);
            this.panel3.Controls.Add(this.saveTechnicianBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(240, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 33);
            this.panel3.TabIndex = 2;
            // 
            // cancelTechnicianBtn
            // 
            this.cancelTechnicianBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelTechnicianBtn.Location = new System.Drawing.Point(270, 0);
            this.cancelTechnicianBtn.Name = "cancelTechnicianBtn";
            this.cancelTechnicianBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelTechnicianBtn.TabIndex = 1;
            this.cancelTechnicianBtn.Text = "Отказ";
            this.cancelTechnicianBtn.UseVisualStyleBackColor = true;
            this.cancelTechnicianBtn.Click += new System.EventHandler(this.cancelTechnicianBtn_Click);
            // 
            // saveTechnicianBtn
            // 
            this.saveTechnicianBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveTechnicianBtn.Location = new System.Drawing.Point(345, 0);
            this.saveTechnicianBtn.Name = "saveTechnicianBtn";
            this.saveTechnicianBtn.Size = new System.Drawing.Size(75, 33);
            this.saveTechnicianBtn.TabIndex = 0;
            this.saveTechnicianBtn.Text = "Запис";
            this.saveTechnicianBtn.UseVisualStyleBackColor = true;
            this.saveTechnicianBtn.Click += new System.EventHandler(this.saveTechnicianBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.technicianCompanyBox);
            this.panel4.Controls.Add(this.technicianTelephoneBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.technicianEGNBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.technicianNameBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(240, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 401);
            this.panel4.TabIndex = 3;
            // 
            // technicianCompanyBox
            // 
            this.technicianCompanyBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.technicianCompanyBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.technicianCompanyBox.FormattingEnabled = true;
            this.technicianCompanyBox.Location = new System.Drawing.Point(101, 39);
            this.technicianCompanyBox.Name = "technicianCompanyBox";
            this.technicianCompanyBox.Size = new System.Drawing.Size(244, 21);
            this.technicianCompanyBox.TabIndex = 7;
            this.technicianCompanyBox.SelectedIndexChanged += new System.EventHandler(this.technicianCompanyBox_SelectedIndexChanged);
            // 
            // fiscalSoftwareDataSetBindingSource
            // 
            this.fiscalSoftwareDataSetBindingSource.DataSource = this._Fiscal_SoftwareDataSet;
            this.fiscalSoftwareDataSetBindingSource.Position = 0;
            // 
            // _Fiscal_SoftwareDataSet
            // 
            this._Fiscal_SoftwareDataSet.DataSetName = "_Fiscal_SoftwareDataSet";
            this._Fiscal_SoftwareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicianTelephoneBox
            // 
            this.technicianTelephoneBox.Location = new System.Drawing.Point(255, 144);
            this.technicianTelephoneBox.Name = "technicianTelephoneBox";
            this.technicianTelephoneBox.Size = new System.Drawing.Size(131, 20);
            this.technicianTelephoneBox.TabIndex = 6;
            this.technicianTelephoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.technicianTelephoneBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон";
            // 
            // technicianEGNBox
            // 
            this.technicianEGNBox.Location = new System.Drawing.Point(81, 144);
            this.technicianEGNBox.Name = "technicianEGNBox";
            this.technicianEGNBox.Size = new System.Drawing.Size(110, 20);
            this.technicianEGNBox.TabIndex = 4;
            this.technicianEGNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.technicianEGNBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ЕГН";
            // 
            // technicianNameBox
            // 
            this.technicianNameBox.Location = new System.Drawing.Point(101, 88);
            this.technicianNameBox.Name = "technicianNameBox";
            this.technicianNameBox.Size = new System.Drawing.Size(244, 20);
            this.technicianNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фирма*";
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // TechniciansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TechniciansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техници";
            this.Load += new System.EventHandler(this.TechniciansForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalSoftwareDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Fiscal_SoftwareDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteTechnicianBtn;
        private System.Windows.Forms.Button editTechnicianBtn;
        private System.Windows.Forms.Button addTechnicianBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView techniciansList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cancelTechnicianBtn;
        private System.Windows.Forms.Button saveTechnicianBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox technicianCompanyBox;
        private System.Windows.Forms.TextBox technicianTelephoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox technicianEGNBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox technicianNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fiscalSoftwareDataSetBindingSource;
        private _Fiscal_SoftwareDataSet _Fiscal_SoftwareDataSet;
        private _Fiscal_SoftwareDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
    }
}