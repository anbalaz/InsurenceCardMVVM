namespace InsurenceCard
{
    partial class FrmCreateInsuranceCard
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
            this.bttnOK = new System.Windows.Forms.Button();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxPersonalID = new System.Windows.Forms.TextBox();
            this.txtBxValidationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxBirthDate = new System.Windows.Forms.TextBox();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(436, 410);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(75, 23);
            this.bttnOK.TabIndex = 1;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(139, 49);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 2;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(139, 85);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 3;
            // 
            // txtBxPersonalID
            // 
            this.txtBxPersonalID.Location = new System.Drawing.Point(139, 126);
            this.txtBxPersonalID.Name = "txtBxPersonalID";
            this.txtBxPersonalID.Size = new System.Drawing.Size(100, 20);
            this.txtBxPersonalID.TabIndex = 4;
            // 
            // txtBxValidationDate
            // 
            this.txtBxValidationDate.Location = new System.Drawing.Point(139, 198);
            this.txtBxValidationDate.Name = "txtBxValidationDate";
            this.txtBxValidationDate.ReadOnly = true;
            this.txtBxValidationDate.Size = new System.Drawing.Size(139, 20);
            this.txtBxValidationDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PersonalIDcard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Validation date";
            // 
            // txtBxBirthDate
            // 
            this.txtBxBirthDate.Location = new System.Drawing.Point(139, 160);
            this.txtBxBirthDate.Name = "txtBxBirthDate";
            this.txtBxBirthDate.ReadOnly = true;
            this.txtBxBirthDate.Size = new System.Drawing.Size(139, 20);
            this.txtBxBirthDate.TabIndex = 10;
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.Location = new System.Drawing.Point(293, 196);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(104, 23);
            this.bttnGenerate.TabIndex = 11;
            this.bttnGenerate.Text = "Generate date";
            this.bttnGenerate.UseVisualStyleBackColor = true;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // FrmCreateInsuranceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 485);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.txtBxBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxValidationDate);
            this.Controls.Add(this.txtBxPersonalID);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.bttnOK);
            this.Name = "FrmCreateInsuranceCard";
            this.Text = "FrmCreateInsuranceCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxPersonalID;
        private System.Windows.Forms.TextBox txtBxValidationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxBirthDate;
        private System.Windows.Forms.Button bttnGenerate;
    }
}