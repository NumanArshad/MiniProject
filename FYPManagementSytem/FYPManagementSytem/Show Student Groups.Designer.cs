namespace FYPManagementSytem
{
    partial class Manage_Student_Groups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showStudentGroupsGridView = new System.Windows.Forms.DataGridView();
            this.groupStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectADataSet1 = new FYPManagementSytem.ProjectADataSet1();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            this.projectADataSet = new FYPManagementSytem.ProjectADataSet();
            this.advisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advisorTableAdapter = new FYPManagementSytem.ProjectADataSetTableAdapters.AdvisorTableAdapter();
            this.groupStudentTableAdapter = new FYPManagementSytem.ProjectADataSet1TableAdapters.GroupStudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.showGroupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeGroupEvaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentGroupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showStudentGroupsGridView
            // 
            this.showStudentGroupsGridView.AllowUserToAddRows = false;
            this.showStudentGroupsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showStudentGroupsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.showStudentGroupsGridView.ColumnHeadersHeight = 25;
            this.showStudentGroupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showStudentGroupsGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.showStudentGroupsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showStudentGroupsGridView.Location = new System.Drawing.Point(0, 121);
            this.showStudentGroupsGridView.Name = "showStudentGroupsGridView";
            this.showStudentGroupsGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showStudentGroupsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.showStudentGroupsGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.showStudentGroupsGridView.Size = new System.Drawing.Size(972, 219);
            this.showStudentGroupsGridView.TabIndex = 25;
            this.showStudentGroupsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showStudentGroupsGridView_CellContentClick);
            // 
            // groupStudentBindingSource
            // 
            this.groupStudentBindingSource.DataMember = "GroupStudent";
            this.groupStudentBindingSource.DataSource = this.projectADataSet1;
            // 
            // projectADataSet1
            // 
            this.projectADataSet1.DataSetName = "ProjectADataSet1";
            this.projectADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picBxAddNew
            // 
            this.picBxAddNew.Image = global::FYPManagementSytem.Properties.Resources.if_plus_sign_173078__3_;
            this.picBxAddNew.Location = new System.Drawing.Point(165, 71);
            this.picBxAddNew.Name = "picBxAddNew";
            this.picBxAddNew.Size = new System.Drawing.Size(29, 27);
            this.picBxAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxAddNew.TabIndex = 26;
            this.picBxAddNew.TabStop = false;
            this.picBxAddNew.Click += new System.EventHandler(this.picBxAddNew_Click);
            // 
            // projectADataSet
            // 
            this.projectADataSet.DataSetName = "ProjectADataSet";
            this.projectADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advisorBindingSource
            // 
            this.advisorBindingSource.DataMember = "Advisor";
            this.advisorBindingSource.DataSource = this.projectADataSet;
            // 
            // advisorTableAdapter
            // 
            this.advisorTableAdapter.ClearBeforeFill = true;
            // 
            // groupStudentTableAdapter
            // 
            this.groupStudentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Add New";
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
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
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
            this.showGroupsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showGroupsToolStripMenuItem.Text = "Show Groups";
            this.showGroupsToolStripMenuItem.Click += new System.EventHandler(this.showGroupsToolStripMenuItem_Click);
            // 
            // createGroupToolStripMenuItem
            // 
            this.createGroupToolStripMenuItem.Name = "createGroupToolStripMenuItem";
            this.createGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.manageGroupEvaluationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGroupEvaluationToolStripMenuItem,
            this.takeGroupEvaluationToolStripMenuItem});
            this.manageGroupEvaluationToolStripMenuItem.Name = "manageGroupEvaluationToolStripMenuItem";
            this.manageGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.manageGroupEvaluationToolStripMenuItem.Text = "Manage Group Evaluation";
            // 
            // showGroupEvaluationToolStripMenuItem
            // 
            this.showGroupEvaluationToolStripMenuItem.Name = "showGroupEvaluationToolStripMenuItem";
            this.showGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.showGroupEvaluationToolStripMenuItem.Text = "Show Group Evaluations";
            // 
            // takeGroupEvaluationToolStripMenuItem
            // 
            this.takeGroupEvaluationToolStripMenuItem.Name = "takeGroupEvaluationToolStripMenuItem";
            this.takeGroupEvaluationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.takeGroupEvaluationToolStripMenuItem.Text = "Take Group Evaluation";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // Manage_Student_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 340);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBxAddNew);
            this.Controls.Add(this.showStudentGroupsGridView);
            this.Name = "Manage_Student_Groups";
            this.Text = "Show Student Groups";
            this.Load += new System.EventHandler(this.Manage_Student_Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showStudentGroupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView showStudentGroupsGridView;
        private System.Windows.Forms.PictureBox picBxAddNew;
        private ProjectADataSet projectADataSet;
        private System.Windows.Forms.BindingSource advisorBindingSource;
        private ProjectADataSetTableAdapters.AdvisorTableAdapter advisorTableAdapter;
        private ProjectADataSet1 projectADataSet1;
        private System.Windows.Forms.BindingSource groupStudentBindingSource;
        private ProjectADataSet1TableAdapters.GroupStudentTableAdapter groupStudentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripMenuItem showGroupEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeGroupEvaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}