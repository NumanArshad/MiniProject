namespace FYPManagementSytem
{
    partial class Show_Evaluations
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
            this.button1 = new System.Windows.Forms.Button();
            this.evaluationsGridView = new System.Windows.Forms.DataGridView();
            this.picBxAddNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evaluationsGridView
            // 
            this.evaluationsGridView.AllowUserToAddRows = false;
            this.evaluationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evaluationsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.evaluationsGridView.ColumnHeadersHeight = 25;
            this.evaluationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.evaluationsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.evaluationsGridView.Location = new System.Drawing.Point(0, 127);
            this.evaluationsGridView.Name = "evaluationsGridView";
            this.evaluationsGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evaluationsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evaluationsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.evaluationsGridView.Size = new System.Drawing.Size(656, 235);
            this.evaluationsGridView.TabIndex = 5;
            this.evaluationsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evaluationsGridView_CellContentClick);
            // 
            // picBxAddNew
            // 
            this.picBxAddNew.Image = global::FYPManagementSytem.Properties.Resources.if_plus_sign_173078__3_;
            this.picBxAddNew.Location = new System.Drawing.Point(73, 28);
            this.picBxAddNew.Name = "picBxAddNew";
            this.picBxAddNew.Size = new System.Drawing.Size(29, 27);
            this.picBxAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxAddNew.TabIndex = 6;
            this.picBxAddNew.TabStop = false;
            this.picBxAddNew.Click += new System.EventHandler(this.picBxAddNew_Click);
            // 
            // Show_Evaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBxAddNew);
            this.Controls.Add(this.evaluationsGridView);
            this.Name = "Show_Evaluations";
            this.Text = "Show Evaluations";
            this.Load += new System.EventHandler(this.Show_Evaluations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBxAddNew;
        private System.Windows.Forms.DataGridView evaluationsGridView;
    }
}