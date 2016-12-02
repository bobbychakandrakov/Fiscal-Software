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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addContractBtn = new System.Windows.Forms.Button();
            this.editContractBtn = new System.Windows.Forms.Button();
            this.deleteContractBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveContractBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contractsListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.76923F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 325);
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
            this.panel1.Size = new System.Drawing.Size(232, 36);
            this.panel1.TabIndex = 0;
            // 
            // addContractBtn
            // 
            this.addContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addContractBtn.Location = new System.Drawing.Point(0, 0);
            this.addContractBtn.Name = "addContractBtn";
            this.addContractBtn.Size = new System.Drawing.Size(75, 36);
            this.addContractBtn.TabIndex = 0;
            this.addContractBtn.Text = "Добавяне";
            this.addContractBtn.UseVisualStyleBackColor = true;
            // 
            // editContractBtn
            // 
            this.editContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editContractBtn.Location = new System.Drawing.Point(75, 0);
            this.editContractBtn.Name = "editContractBtn";
            this.editContractBtn.Size = new System.Drawing.Size(83, 36);
            this.editContractBtn.TabIndex = 1;
            this.editContractBtn.Text = "Редактиране";
            this.editContractBtn.UseVisualStyleBackColor = true;
            // 
            // deleteContractBtn
            // 
            this.deleteContractBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteContractBtn.Location = new System.Drawing.Point(158, 0);
            this.deleteContractBtn.Name = "deleteContractBtn";
            this.deleteContractBtn.Size = new System.Drawing.Size(75, 36);
            this.deleteContractBtn.TabIndex = 2;
            this.deleteContractBtn.Text = "Изтриване";
            this.deleteContractBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.saveContractBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(241, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 36);
            this.panel2.TabIndex = 1;
            // 
            // saveContractBtn
            // 
            this.saveContractBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveContractBtn.Location = new System.Drawing.Point(419, 0);
            this.saveContractBtn.Name = "saveContractBtn";
            this.saveContractBtn.Size = new System.Drawing.Size(75, 36);
            this.saveContractBtn.TabIndex = 0;
            this.saveContractBtn.Text = "Запис";
            this.saveContractBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelBtn.Location = new System.Drawing.Point(344, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 36);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отказ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contractsListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 277);
            this.panel3.TabIndex = 2;
            // 
            // contractsListView
            // 
            this.contractsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractsListView.FullRowSelect = true;
            this.contractsListView.Location = new System.Drawing.Point(0, 0);
            this.contractsListView.Name = "contractsListView";
            this.contractsListView.Size = new System.Drawing.Size(232, 277);
            this.contractsListView.TabIndex = 0;
            this.contractsListView.UseCompatibleStateImageBehavior = false;
            this.contractsListView.View = System.Windows.Forms.View.Details;
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Contracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договори";
            this.Load += new System.EventHandler(this.Contracts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
    }
}