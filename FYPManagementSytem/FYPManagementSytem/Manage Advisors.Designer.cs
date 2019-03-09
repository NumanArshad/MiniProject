namespace FYPManagementSytem
{
    partial class Manage_Advisors
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
            this.advisorsGridView = new System.Windows.Forms.DataGridView();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxDesignation = new System.Windows.Forms.ComboBox();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // advisorsGridView
            // 
            this.advisorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorsGridView.Location = new System.Drawing.Point(200, 67);
            this.advisorsGridView.Name = "advisorsGridView";
            this.advisorsGridView.Size = new System.Drawing.Size(444, 150);
            this.advisorsGridView.TabIndex = 1;
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(85, 170);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 33);
            this.cmdSave.TabIndex = 22;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Designation";
            // 
            // cmbBxDesignation
            // 
            this.cmbBxDesignation.FormattingEnabled = true;
            this.cmbBxDesignation.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxDesignation.Location = new System.Drawing.Point(85, 78);
            this.cmbBxDesignation.Name = "cmbBxDesignation";
            this.cmbBxDesignation.Size = new System.Drawing.Size(100, 21);
            this.cmbBxDesignation.TabIndex = 19;
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Location = new System.Drawing.Point(85, 126);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBxSalary.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Salary";
            // 
            // Manage_Advisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBxDesignation);
            this.Controls.Add(this.txtBxSalary);
            this.Controls.Add(this.advisorsGridView);
            this.Name = "Manage_Advisors";
            this.Text = "Manage Advisors";
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView advisorsGridView;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxDesignation;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.Label label1;
    }
}