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
            this.lblSalaryError = new System.Windows.Forms.Label();
            this.lblDesignationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salary";
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(273, 196);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Designation";
            // 
            // cmbBxDesignation
            // 
            this.cmbBxDesignation.FormattingEnabled = true;
            this.cmbBxDesignation.Location = new System.Drawing.Point(223, 94);
            this.cmbBxDesignation.Name = "cmbBxDesignation";
            this.cmbBxDesignation.Size = new System.Drawing.Size(150, 21);
            this.cmbBxDesignation.TabIndex = 26;
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSalary.Location = new System.Drawing.Point(223, 142);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(150, 22);
            this.txtBxSalary.TabIndex = 25;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(145, 196);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 33);
            this.cmdCancel.TabIndex = 30;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblSalaryError
            // 
            this.lblSalaryError.AutoSize = true;
            this.lblSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryError.Location = new System.Drawing.Point(399, 148);
            this.lblSalaryError.Name = "lblSalaryError";
            this.lblSalaryError.Size = new System.Drawing.Size(35, 13);
            this.lblSalaryError.TabIndex = 31;
            this.lblSalaryError.Text = "label5";
            // 
            // lblDesignationError
            // 
            this.lblDesignationError.AutoSize = true;
            this.lblDesignationError.ForeColor = System.Drawing.Color.Red;
            this.lblDesignationError.Location = new System.Drawing.Point(399, 97);
            this.lblDesignationError.Name = "lblDesignationError";
            this.lblDesignationError.Size = new System.Drawing.Size(35, 13);
            this.lblDesignationError.TabIndex = 32;
            this.lblDesignationError.Text = "label5";
            // 
            // Add_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 317);
            this.Controls.Add(this.lblSalaryError);
            this.Controls.Add(this.lblDesignationError);
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
        private System.Windows.Forms.Label lblSalaryError;
        private System.Windows.Forms.Label lblDesignationError;
    }
}