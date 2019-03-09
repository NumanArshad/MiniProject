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
            this.cmbBxGroups = new System.Windows.Forms.ComboBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxProjects = new System.Windows.Forms.ComboBox();
            this.projectAdvisorGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // cmbBxGroups
            // 
            this.cmbBxGroups.FormattingEnabled = true;
            this.cmbBxGroups.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxGroups.Location = new System.Drawing.Point(104, 128);
            this.cmbBxGroups.Name = "cmbBxGroups";
            this.cmbBxGroups.Size = new System.Drawing.Size(100, 21);
            this.cmbBxGroups.TabIndex = 43;
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
            // cmbBxProjects
            // 
            this.cmbBxProjects.FormattingEnabled = true;
            this.cmbBxProjects.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxProjects.Location = new System.Drawing.Point(102, 86);
            this.cmbBxProjects.Name = "cmbBxProjects";
            this.cmbBxProjects.Size = new System.Drawing.Size(100, 21);
            this.cmbBxProjects.TabIndex = 40;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(104, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // Manage_Project__Advisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxGroups);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBxProjects);
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
        private System.Windows.Forms.ComboBox cmbBxGroups;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxProjects;
        private System.Windows.Forms.DataGridView projectAdvisorGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}