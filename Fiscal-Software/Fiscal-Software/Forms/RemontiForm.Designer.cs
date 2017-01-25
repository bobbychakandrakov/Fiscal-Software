namespace Fiscal_Software.Forms
{
    partial class RemontiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemontiForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prietB = new System.Windows.Forms.DateTimePicker();
            this.technicBox = new System.Windows.Forms.ComboBox();
            this.opisanieDefekt = new System.Windows.Forms.RichTextBox();
            this.chastiRemont = new System.Windows.Forms.RichTextBox();
            this.varnatNa = new System.Windows.Forms.DateTimePicker();
            this.zaqvkaPodadena = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приет в";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заявка\r\nподадена в\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Техник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Описание на дефекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Върнат на";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вложени части при ремонта";
            // 
            // prietB
            // 
            this.prietB.Checked = false;
            this.prietB.Location = new System.Drawing.Point(127, 46);
            this.prietB.Name = "prietB";
            this.prietB.ShowCheckBox = true;
            this.prietB.Size = new System.Drawing.Size(200, 20);
            this.prietB.TabIndex = 6;
            // 
            // technicBox
            // 
            this.technicBox.FormattingEnabled = true;
            this.technicBox.Location = new System.Drawing.Point(127, 122);
            this.technicBox.Name = "technicBox";
            this.technicBox.Size = new System.Drawing.Size(200, 21);
            this.technicBox.TabIndex = 7;
            // 
            // opisanieDefekt
            // 
            this.opisanieDefekt.Location = new System.Drawing.Point(54, 189);
            this.opisanieDefekt.Name = "opisanieDefekt";
            this.opisanieDefekt.Size = new System.Drawing.Size(273, 61);
            this.opisanieDefekt.TabIndex = 8;
            this.opisanieDefekt.Text = "";
            // 
            // chastiRemont
            // 
            this.chastiRemont.Location = new System.Drawing.Point(51, 365);
            this.chastiRemont.Name = "chastiRemont";
            this.chastiRemont.Size = new System.Drawing.Size(273, 61);
            this.chastiRemont.TabIndex = 9;
            this.chastiRemont.Text = "";
            // 
            // varnatNa
            // 
            this.varnatNa.Checked = false;
            this.varnatNa.Location = new System.Drawing.Point(127, 275);
            this.varnatNa.Name = "varnatNa";
            this.varnatNa.ShowCheckBox = true;
            this.varnatNa.Size = new System.Drawing.Size(197, 20);
            this.varnatNa.TabIndex = 10;
            // 
            // zaqvkaPodadena
            // 
            this.zaqvkaPodadena.Checked = false;
            this.zaqvkaPodadena.Location = new System.Drawing.Point(127, 83);
            this.zaqvkaPodadena.Name = "zaqvkaPodadena";
            this.zaqvkaPodadena.ShowCheckBox = true;
            this.zaqvkaPodadena.Size = new System.Drawing.Size(200, 20);
            this.zaqvkaPodadena.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(51, 465);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Запис";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(249, 465);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Отказ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RemontiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 515);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.zaqvkaPodadena);
            this.Controls.Add(this.varnatNa);
            this.Controls.Add(this.chastiRemont);
            this.Controls.Add(this.opisanieDefekt);
            this.Controls.Add(this.technicBox);
            this.Controls.Add(this.prietB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemontiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на ремонт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemontiForm_FormClosing);
            this.Load += new System.EventHandler(this.RemontiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker prietB;
        private System.Windows.Forms.ComboBox technicBox;
        private System.Windows.Forms.RichTextBox opisanieDefekt;
        private System.Windows.Forms.RichTextBox chastiRemont;
        private System.Windows.Forms.DateTimePicker varnatNa;
        private System.Windows.Forms.DateTimePicker zaqvkaPodadena;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}