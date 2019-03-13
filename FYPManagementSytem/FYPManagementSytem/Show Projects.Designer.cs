namespace FYPManagementSytem
{
    partial class Show_Projects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projectsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsGridView
            // 
            this.projectsGridView.AllowUserToAddRows = false;
            this.projectsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectsGridView.ColumnHeadersHeight = 25;
            this.projectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.projectsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectsGridView.Location = new System.Drawing.Point(0, 119);
            this.projectsGridView.Name = "projectsGridView";
            this.projectsGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.projectsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.projectsGridView.Size = new System.Drawing.Size(880, 235);
            this.projectsGridView.TabIndex = 2;
            this.projectsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBxAddNew
            // 
            this.picBxAddNew.Image = global::FYPManagementSytem.Properties.Resources.if_plus_sign_173078__3_;
            this.picBxAddNew.Location = new System.Drawing.Point(73, 56);
            this.picBxAddNew.Name = "picBxAddNew";
            this.picBxAddNew.Size = new System.Drawing.Size(29, 27);
            this.picBxAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxAddNew.TabIndex = 3;
            this.picBxAddNew.TabStop = false;
            this.picBxAddNew.Click += new System.EventHandler(this.picBxAddNew_Click);
            // 
            // Show_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBxAddNew);
            this.Controls.Add(this.projectsGridView);
            this.Name = "Show_Projects";
            this.Text = "Show Projects";
            this.Load += new System.EventHandler(this.Show_Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView projectsGridView;
        private System.Windows.Forms.PictureBox picBxAddNew;
        private System.Windows.Forms.Button button1;
    }
}