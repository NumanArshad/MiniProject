namespace FYPManagementSytem
{
    partial class Manage_Project__Advisors
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
            this.cmbBxProjects = new System.Windows.Forms.ComboBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxAdvisors = new System.Windows.Forms.ComboBox();
            this.projectAdvisorGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBxAdvisorRoles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select Project";
            // 
            // cmbBxProjects
            // 
            this.cmbBxProjects.FormattingEnabled = true;
            this.cmbBxProjects.Location = new System.Drawing.Point(104, 128);
            this.cmbBxProjects.Name = "cmbBxProjects";
            this.cmbBxProjects.Size = new System.Drawing.Size(100, 21);
            this.cmbBxProjects.TabIndex = 43;
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(102, 207);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 33);
            this.cmdSave.TabIndex = 42;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Select Advisor";
            // 
            // cmbBxAdvisors
            // 
            this.cmbBxAdvisors.FormattingEnabled = true;
            this.cmbBxAdvisors.Location = new System.Drawing.Point(102, 86);
            this.cmbBxAdvisors.Name = "cmbBxAdvisors";
            this.cmbBxAdvisors.Size = new System.Drawing.Size(100, 21);
            this.cmbBxAdvisors.TabIndex = 40;
            // 
            // projectAdvisorGridView
            // 
            this.projectAdvisorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectAdvisorGridView.Location = new System.Drawing.Point(233, 86);
            this.projectAdvisorGridView.Name = "projectAdvisorGridView";
            this.projectAdvisorGridView.Size = new System.Drawing.Size(415, 154);
            this.projectAdvisorGridView.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Advisor Role";
            // 
            // cmbBxAdvisorRoles
            // 
            this.cmbBxAdvisorRoles.FormattingEnabled = true;
            this.cmbBxAdvisorRoles.Location = new System.Drawing.Point(104, 168);
            this.cmbBxAdvisorRoles.Name = "cmbBxAdvisorRoles";
            this.cmbBxAdvisorRoles.Size = new System.Drawing.Size(100, 21);
            this.cmbBxAdvisorRoles.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage_Project__Advisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBxAdvisorRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxProjects);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBxAdvisors);
            this.Controls.Add(this.projectAdvisorGridView);
            this.Name = "Manage_Project__Advisors";
            this.Text = "Manage Project Advisors";
            this.Load += new System.EventHandler(this.Manage_Project__Advisors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectAdvisorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxProjects;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxAdvisors;
        private System.Windows.Forms.DataGridView projectAdvisorGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBxAdvisorRoles;
        private System.Windows.Forms.Button button1;
    }
}