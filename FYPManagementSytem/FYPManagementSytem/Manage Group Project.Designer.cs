namespace FYPManagementSytem
{
    partial class Manage_Group_Project
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBxProjects = new System.Windows.Forms.ComboBox();
            this.groupProjectGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxGroups = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(112, 170);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 33);
            this.cmdSave.TabIndex = 36;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Select Project";
            // 
            // cmbBxProjects
            // 
            this.cmbBxProjects.FormattingEnabled = true;
            this.cmbBxProjects.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxProjects.Location = new System.Drawing.Point(112, 88);
            this.cmbBxProjects.Name = "cmbBxProjects";
            this.cmbBxProjects.Size = new System.Drawing.Size(100, 21);
            this.cmbBxProjects.TabIndex = 34;
            // 
            // groupProjectGridView
            // 
            this.groupProjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupProjectGridView.Location = new System.Drawing.Point(256, 77);
            this.groupProjectGridView.Name = "groupProjectGridView";
            this.groupProjectGridView.Size = new System.Drawing.Size(415, 150);
            this.groupProjectGridView.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Select Group";
            // 
            // cmbBxGroups
            // 
            this.cmbBxGroups.FormattingEnabled = true;
            this.cmbBxGroups.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxGroups.Location = new System.Drawing.Point(112, 125);
            this.cmbBxGroups.Name = "cmbBxGroups";
            this.cmbBxGroups.Size = new System.Drawing.Size(100, 21);
            this.cmbBxGroups.TabIndex = 37;
            // 
            // Manage_Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxGroups);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbBxProjects);
            this.Controls.Add(this.groupProjectGridView);
            this.Name = "Manage_Group_Project";
            this.Text = "Manage Group Project";
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBxProjects;
        private System.Windows.Forms.DataGridView groupProjectGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxGroups;
    }
}