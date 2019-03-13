namespace FYPManagementSytem
{
    partial class Add_Advisor
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxDesignation = new System.Windows.Forms.ComboBox();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salary";
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(211, 186);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 33);
            this.cmdSave.TabIndex = 28;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Designation";
            // 
            // cmbBxDesignation
            // 
            this.cmbBxDesignation.FormattingEnabled = true;
            this.cmbBxDesignation.Location = new System.Drawing.Point(211, 94);
            this.cmbBxDesignation.Name = "cmbBxDesignation";
            this.cmbBxDesignation.Size = new System.Drawing.Size(100, 21);
            this.cmbBxDesignation.TabIndex = 26;
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Location = new System.Drawing.Point(211, 142);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBxSalary.TabIndex = 25;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(95, 186);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 33);
            this.cmdCancel.TabIndex = 30;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // Add_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 317);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBxDesignation);
            this.Controls.Add(this.txtBxSalary);
            this.Name = "Add_Advisor";
            this.Text = "Add Advisor";
            this.Load += new System.EventHandler(this.Add_Advisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxDesignation;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.Button cmdCancel;
    }
}