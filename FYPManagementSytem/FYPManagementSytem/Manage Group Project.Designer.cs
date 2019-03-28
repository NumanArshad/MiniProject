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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmbBxProjects = new System.Windows.Forms.ComboBox();
            this.groupProjectGridView = new System.Windows.Forms.DataGridView();
            this.cmbBxGroups = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdvisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEvaluationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEvaluationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectAdvisorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGroupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProjectsReportPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupEvaluationReportPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(396, 148);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 33);
            this.cmdSave.TabIndex = 36;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmbBxProjects
            // 
            this.cmbBxProjects.FormattingEnabled = true;
            this.cmbBxProjects.Location = new System.Drawing.Point(396, 66);
            this.cmbBxProjects.Name = "cmbBxProjects";
            this.cmbBxProjects.Size = new System.Drawing.Size(100, 21);
            this.cmbBxProjects.TabIndex = 34;
            // 
            // groupProjectGridView
            // 
            this.groupProjectGridView.AllowUserToAddRows = false;
            this.groupProjectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupProjectGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.groupProjectGridView.ColumnHeadersHeight = 25;
            this.groupProjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupProjectGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.groupProjectGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupProjectGridView.Location = new System.Drawing.Point(0, 209);
            this.groupProjectGridView.Name = "groupProjectGridView";
            this.groupProjectGridView.ReadOnly = true;
            this.groupProjectGridView.Size = new System.Drawing.Size(948, 250);
            this.groupProjectGridView.TabIndex = 33;
            this.groupProjectGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupProjectGridView_CellContentClick);
            // 
            // cmbBxGroups
            // 
            this.cmbBxGroups.FormattingEnabled = true;
            this.cmbBxGroups.Location = new System.Drawing.Point(396, 103);
            this.cmbBxGroups.Name = "cmbBxGroups";
            this.cmbBxGroups.Size = new System.Drawing.Size(100, 21);
            this.cmbBxGroups.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageStudentsToolStripMenuItem,
            this.manageProjectsToolStripMenuItem,
            this.manageAdvisorToolStripMenuItem,
            this.manageEvaluationsToolStripMenuItem,
            this.studentGroupsToolStripMenuItem,
            this.assignProjectToolStripMenuItem,
            this.manageGroupEvaluationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // manageStudentsToolStripMenuItem
            // 
            this.manageStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStudentsToolStripMenuItem,
            this.addStudentToolStripMenuItem});
            this.manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            this.manageStudentsToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.manageStudentsToolStripMenuItem.Text = "Manage Students";
            // 
            // showStudentsToolStripMenuItem
            // 
            this.showStudentsToolStripMenuItem.Name = "showStudentsToolStripMenuItem";
            this.showStudentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showStudentsToolStripMenuItem.Text = "Show Students";
            this.showStudentsToolStripMenuItem.Click += new System.EventHandler(this.showStudentsToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // manageProjectsToolStripMenuItem
            // 
            this.manageProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProjectToolStripMenuItem,
            this.addProjectToolStripMenuItem});
            this.manageProjectsToolStripMenuItem.Name = "manageProjectsToolStripMenuItem";
            this.manageProjectsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.manageProjectsToolStripMenuItem.Text = "Manage Projects";
            // 
            // showProjectToolStripMenuItem
            // 
            this.showProjectToolStripMenuItem.Name = "showProjectToolStripMenuItem";
            this.showProjectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showProjectToolStripMenuItem.Text = "Show Projects";
            this.showProjectToolStripMenuItem.Click += new System.EventHandler(this.showProjectToolStripMenuItem_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // manageAdvisorToolStripMenuItem
            // 
            this.manageAdvisorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAdvisorToolStripMenuItem,
            this.addAdvisorToolStripMenuItem});
            this.manageAdvisorToolStripMenuItem.Name = "manageAdvisorToolStripMenuItem";
            this.manageAdvisorToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.manageAdvisorToolStripMenuItem.Text = "Manage Advisor";
            // 
            // showAdvisorToolStripMenuItem
            // 
            this.showAdvisorToolStripMenuItem.Name = "showAdvisorToolStripMenuItem";
            this.showAdvisorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showAdvisorToolStripMenuItem.Text = "Show Advisors";
            this.showAdvisorToolStripMenuItem.Click += new System.EventHandler(this.showAdvisorToolStripMenuItem_Click);
            // 
            // addAdvisorToolStripMenuItem
            // 
            this.addAdvisorToolStripMenuItem.Name = "addAdvisorToolStripMenuItem";
            this.addAdvisorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addAdvisorToolStripMenuItem.Text = "Add  Advisor";
            this.addAdvisorToolStripMenuItem.Click += new System.EventHandler(this.addAdvisorToolStripMenuItem_Click);
            // 
            // manageEvaluationsToolStripMenuItem
            // 
            this.manageEvaluationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEvaluationsToolStripMenuItem,
            this.addEvaluationToolStripMenuItem});
            this.manageEvaluationsToolStripMenuItem.Name = "manageEvaluationsToolStripMenuItem";
            this.manageEvaluationsToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.manageEvaluationsToolStripMenuItem.Text = "Manage Evaluations";
            // 
            // showEvaluationsToolStripMenuItem
            // 
            this.showEvaluationsToolStripMenuItem.Name = "showEvaluationsToolStripMenuItem";
            this.showEvaluationsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showEvaluationsToolStripMenuItem.Text = "Show Evaluations";
            this.showEvaluationsToolStripMenuItem.Click += new System.EventHandler(this.showEvaluationsToolStripMenuItem_Click);
            // 
            // addEvaluationToolStripMenuItem
            // 
            this.addEvaluationToolStripMenuItem.Name = "addEvaluationToolStripMenuItem";
            this.addEvaluationToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addEvaluationToolStripMenuItem.Text = "Add Evaluation";
            this.addEvaluationToolStripMenuItem.Click += new System.EventHandler(this.addEvaluationToolStripMenuItem_Click);
            // 
            // studentGroupsToolStripMenuItem
            // 
            this.studentGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGroupsToolStripMenuItem,
            this.createGroupToolStripMenuItem});
            this.studentGroupsToolStripMenuItem.Name = "studentGroupsToolStripMenuItem";
            this.studentGroupsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.studentGroupsToolStripMenuItem.Text = "Student Groups";
            // 
            // showGroupsToolStripMenuItem
            // 
            this.showGroupsToolStripMenuItem.Name = "showGroupsToolStripMenuItem";
            this.showGroupsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.showGroupsToolStripMenuItem.Text = "Show Groups";
            this.showGroupsToolStripMenuItem.Click += new System.EventHandler(this.showGroupsToolStripMenuItem_Click);
            // 
            // createGroupToolStripMenuItem
            // 
            this.createGroupToolStripMenuItem.Name = "createGroupToolStripMenuItem";
            this.createGroupToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.createGroupToolStripMenuItem.Text = "Create Group";
            this.createGroupToolStripMenuItem.Click += new System.EventHandler(this.createGroupToolStripMenuItem_Click);
            // 
            // assignProjectToolStripMenuItem
            // 
            this.assignProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProjectGroupToolStripMenuItem,
            this.manageProjectAdvisorsToolStripMenuItem});
            this.assignProjectToolStripMenuItem.Name = "assignProjectToolStripMenuItem";
            this.assignProjectToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.assignProjectToolStripMenuItem.Text = "Assign Project";
            // 
            // showProjectGroupToolStripMenuItem
            // 
            this.showProjectGroupToolStripMenuItem.Name = "showProjectGroupToolStripMenuItem";
            this.showProjectGroupToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showProjectGroupToolStripMenuItem.Text = " Manage Project Group";
            // 
            // manageProjectAdvisorsToolStripMenuItem
            // 
            this.manageProjectAdvisorsToolStripMenuItem.Name = "manageProjectAdvisorsToolStripMenuItem";
            this.manageProjectAdvisorsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.manageProjectAdvisorsToolStripMenuItem.Text = "Manage Project Advisors";
            this.manageProjectAdvisorsToolStripMenuItem.Click += new System.EventHandler(this.manageProjectAdvisorsToolStripMenuItem_Click);
            // 
            // manageGroupEvaluationToolStripMenuItem
            // 
            this.manageGroupEvaluationToolStripMenuItem.Name = "manageGroupEvaluationToolStripMenuItem";
            this.manageGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.manageGroupEvaluationToolStripMenuItem.Text = "Manage Group Evaluation";
            this.manageGroupEvaluationToolStripMenuItem.Click += new System.EventHandler(this.manageGroupEvaluationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignProjectsReportPreviewToolStripMenuItem,
            this.groupEvaluationReportPreviewToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // assignProjectsReportPreviewToolStripMenuItem
            // 
            this.assignProjectsReportPreviewToolStripMenuItem.Name = "assignProjectsReportPreviewToolStripMenuItem";
            this.assignProjectsReportPreviewToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.assignProjectsReportPreviewToolStripMenuItem.Text = "Assign Projects Report Preview";
            this.assignProjectsReportPreviewToolStripMenuItem.Click += new System.EventHandler(this.assignProjectsReportPreviewToolStripMenuItem_Click);
            // 
            // groupEvaluationReportPreviewToolStripMenuItem
            // 
            this.groupEvaluationReportPreviewToolStripMenuItem.Name = "groupEvaluationReportPreviewToolStripMenuItem";
            this.groupEvaluationReportPreviewToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.groupEvaluationReportPreviewToolStripMenuItem.Text = "Group Evaluation Report Preview";
            this.groupEvaluationReportPreviewToolStripMenuItem.Click += new System.EventHandler(this.groupEvaluationReportPreviewToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Select Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select Group";
            // 
            // Manage_Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbBxGroups);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmbBxProjects);
            this.Controls.Add(this.groupProjectGridView);
            this.Name = "Manage_Group_Project";
            this.Text = "Manage Group Project";
            this.Load += new System.EventHandler(this.Manage_Group_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cmbBxProjects;
        private System.Windows.Forms.DataGridView groupProjectGridView;
        private System.Windows.Forms.ComboBox cmbBxGroups;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdvisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEvaluationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEvaluationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProjectGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectAdvisorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGroupEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignProjectsReportPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupEvaluationReportPreviewToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}