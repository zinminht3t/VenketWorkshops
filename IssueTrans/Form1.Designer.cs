namespace IssueTrans
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.btnCusFrm = new System.Windows.Forms.Button();
            this.txtRCusID = new System.Windows.Forms.TextBox();
            this.txtVideoCode = new System.Windows.Forms.TextBox();
            this.btnVideoFrm = new System.Windows.Forms.Button();
            this.txtRVideoCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video Code : ";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(333, 63);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(291, 31);
            this.txtCusID.TabIndex = 2;
            this.txtCusID.TextChanged += new System.EventHandler(this.txtCusID_TextChanged);
            // 
            // btnCusFrm
            // 
            this.btnCusFrm.Location = new System.Drawing.Point(648, 52);
            this.btnCusFrm.Name = "btnCusFrm";
            this.btnCusFrm.Size = new System.Drawing.Size(75, 53);
            this.btnCusFrm.TabIndex = 3;
            this.btnCusFrm.Text = "...";
            this.btnCusFrm.UseVisualStyleBackColor = true;
            this.btnCusFrm.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRCusID
            // 
            this.txtRCusID.Location = new System.Drawing.Point(333, 135);
            this.txtRCusID.Name = "txtRCusID";
            this.txtRCusID.ReadOnly = true;
            this.txtRCusID.Size = new System.Drawing.Size(390, 31);
            this.txtRCusID.TabIndex = 4;
            // 
            // txtVideoCode
            // 
            this.txtVideoCode.Location = new System.Drawing.Point(333, 223);
            this.txtVideoCode.Name = "txtVideoCode";
            this.txtVideoCode.Size = new System.Drawing.Size(291, 31);
            this.txtVideoCode.TabIndex = 5;
            this.txtVideoCode.TextChanged += new System.EventHandler(this.txtVideoCode_TextChanged);
            // 
            // btnVideoFrm
            // 
            this.btnVideoFrm.Location = new System.Drawing.Point(648, 212);
            this.btnVideoFrm.Name = "btnVideoFrm";
            this.btnVideoFrm.Size = new System.Drawing.Size(75, 53);
            this.btnVideoFrm.TabIndex = 6;
            this.btnVideoFrm.Text = "...";
            this.btnVideoFrm.UseVisualStyleBackColor = true;
            this.btnVideoFrm.Click += new System.EventHandler(this.btnVideoFrm_Click);
            // 
            // txtRVideoCode
            // 
            this.txtRVideoCode.Location = new System.Drawing.Point(333, 287);
            this.txtRVideoCode.Name = "txtRVideoCode";
            this.txtRVideoCode.ReadOnly = true;
            this.txtRVideoCode.Size = new System.Drawing.Size(390, 31);
            this.txtRVideoCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Issue Date : ";
            // 
            // dtpIssue
            // 
            this.dtpIssue.Location = new System.Drawing.Point(333, 378);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(390, 31);
            this.dtpIssue.TabIndex = 9;
            this.dtpIssue.ValueChanged += new System.EventHandler(this.dtpIssue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Due Date : ";
            // 
            // dtpDue
            // 
            this.dtpDue.Location = new System.Drawing.Point(333, 465);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(390, 31);
            this.dtpDue.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remark : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(258, 748);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(213, 65);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 576);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 120);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRVideoCode);
            this.Controls.Add(this.btnVideoFrm);
            this.Controls.Add(this.txtVideoCode);
            this.Controls.Add(this.txtRCusID);
            this.Controls.Add(this.btnCusFrm);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Rental";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCusFrm;
        private System.Windows.Forms.TextBox txtRCusID;
        private System.Windows.Forms.TextBox txtVideoCode;
        private System.Windows.Forms.Button btnVideoFrm;
        private System.Windows.Forms.TextBox txtRVideoCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtCusID;
    }
}

