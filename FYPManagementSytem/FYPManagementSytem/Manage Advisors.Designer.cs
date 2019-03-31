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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.advisorsGridView = new System.Windows.Forms.DataGridView();
            this.advisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectADataSet = new FYPManagementSytem.ProjectADataSet();
            this.advisorTableAdapter = new FYPManagementSytem.ProjectADataSetTableAdapters.AdvisorTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label1 = new System.Windows.Forms.Label();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // advisorsGridView
            // 
            this.advisorsGridView.AllowUserToAddRows = false;
            this.advisorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advisorsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.advisorsGridView.ColumnHeadersHeight = 25;
            this.advisorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advisorsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.advisorsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advisorsGridView.Location = new System.Drawing.Point(0, 113);
            this.advisorsGridView.Name = "advisorsGridView";
            this.advisorsGridView.ReadOnly = true;
            this.advisorsGridView.Size = new System.Drawing.Size(835, 258);
            this.advisorsGridView.TabIndex = 1;
            this.advisorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advisorsGridView_CellContentClick);
            // 
            // advisorBindingSource
            // 
            this.advisorBindingSource.DataMember = "Advisor";
            this.advisorBindingSource.DataSource = this.projectADataSet;
            // 
            // projectADataSet
            // 
            this.projectADataSet.DataSetName = "ProjectADataSet";
            this.projectADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advisorTableAdapter
            // 
            this.advisorTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageStudentsToolStripMenuItem,
            this.manageProjectsToolStripMenuItem,
            this.manageEvaluationsToolStripMenuItem,
            this.studentGroupsToolStripMenuItem,
            this.assignProjectToolStripMenuItem,
            this.manageGroupEvaluationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 50;
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
            this.showProjectGroupToolStripMenuItem.Click += new System.EventHandler(this.showProjectGroupToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Add New";
            // 
            // picBxAddNew
            // 
            this.picBxAddNew.Image = global::FYPManagementSytem.Properties.Resources.if_plus_sign_173078__3_;
            this.picBxAddNew.Location = new System.Drawing.Point(147, 57);
            this.picBxAddNew.Name = "picBxAddNew";
            this.picBxAddNew.Size = new System.Drawing.Size(29, 27);
            this.picBxAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxAddNew.TabIndex = 49;
            this.picBxAddNew.TabStop = false;
            this.picBxAddNew.Click += new System.EventHandler(this.picBxAddNew_Click);
            // 
            // Manage_Advisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBxAddNew);
            this.Controls.Add(this.advisorsGridView);
            this.Name = "Manage_Advisors";
            this.Text = "Manage Advisors";
            this.Load += new System.EventHandler(this.Manage_Advisors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView advisorsGridView;
        private ProjectADataSet projectADataSet;
        private System.Windows.Forms.BindingSource advisorBindingSource;
        private ProjectADataSetTableAdapters.AdvisorTableAdapter advisorTableAdapter;
        private System.Windows.Forms.PictureBox picBxAddNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem assignProjectsReportPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupEvaluationReportPreviewToolStripMenuItem;
    }
}