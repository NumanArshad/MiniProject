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
            this.advisorsGridView = new System.Windows.Forms.DataGridView();
            this.advisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectADataSet = new FYPManagementSytem.ProjectADataSet();
            this.advisorTableAdapter = new FYPManagementSytem.ProjectADataSetTableAdapters.AdvisorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // advisorsGridView
            // 
            this.advisorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advisorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.advisorsGridView.Location = new System.Drawing.Point(0, 84);
            this.advisorsGridView.Name = "advisorsGridView";
            this.advisorsGridView.Size = new System.Drawing.Size(691, 217);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBxAddNew
            // 
            this.picBxAddNew.Image = global::FYPManagementSytem.Properties.Resources.if_plus_sign_173078__3_;
            this.picBxAddNew.Location = new System.Drawing.Point(106, 36);
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
            this.ClientSize = new System.Drawing.Size(691, 301);
            this.Controls.Add(this.picBxAddNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advisorsGridView);
            this.Name = "Manage_Advisors";
            this.Text = "Manage Advisors";
            this.Load += new System.EventHandler(this.Manage_Advisors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advisorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView advisorsGridView;
        private ProjectADataSet projectADataSet;
        private System.Windows.Forms.BindingSource advisorBindingSource;
        private ProjectADataSetTableAdapters.AdvisorTableAdapter advisorTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBxAddNew;
    }
}