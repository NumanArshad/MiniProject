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
            this.showStudentGroupsGridView = new System.Windows.Forms.DataGridView();
            this.groupStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectADataSet1 = new FYPManagementSytem.ProjectADataSet1();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            this.projectADataSet = new FYPManagementSytem.ProjectADataSet();
            this.advisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advisorTableAdapter = new FYPManagementSytem.ProjectADataSetTableAdapters.AdvisorTableAdapter();
            this.groupStudentTableAdapter = new FYPManagementSytem.ProjectADataSet1TableAdapters.GroupStudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showStudentGroupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showStudentGroupsGridView
            // 
            this.showStudentGroupsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showStudentGroupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStudentGroupsGridView.Location = new System.Drawing.Point(52, 115);
            this.showStudentGroupsGridView.Name = "showStudentGroupsGridView";
            this.showStudentGroupsGridView.Size = new System.Drawing.Size(575, 150);
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
            this.picBxAddNew.Location = new System.Drawing.Point(61, 62);
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
            this.button1.Location = new System.Drawing.Point(254, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage_Student_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 303);
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
            this.ResumeLayout(false);

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
    }
}