namespace FYPManagementSytem
{
    partial class Make_Group
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
            this.studentGroupGridView = new System.Windows.Forms.DataGridView();
            this.cmdAddInGroup = new System.Windows.Forms.Button();
            this.txtBxSearchStudent = new System.Windows.Forms.TextBox();
            this.cmdCreateGroup = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGroupGridView
            // 
            this.studentGroupGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGroupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGroupGridView.Location = new System.Drawing.Point(65, 136);
            this.studentGroupGridView.Name = "studentGroupGridView";
            this.studentGroupGridView.Size = new System.Drawing.Size(488, 137);
            this.studentGroupGridView.TabIndex = 4;
            // 
            // cmdAddInGroup
            // 
            this.cmdAddInGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAddInGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdAddInGroup.Location = new System.Drawing.Point(65, 93);
            this.cmdAddInGroup.Name = "cmdAddInGroup";
            this.cmdAddInGroup.Size = new System.Drawing.Size(100, 33);
            this.cmdAddInGroup.TabIndex = 35;
            this.cmdAddInGroup.Text = "Add in Group";
            this.cmdAddInGroup.UseVisualStyleBackColor = false;
            this.cmdAddInGroup.Click += new System.EventHandler(this.cmdAddInGroup_Click);
            // 
            // txtBxSearchStudent
            // 
            this.txtBxSearchStudent.Location = new System.Drawing.Point(203, 32);
            this.txtBxSearchStudent.Name = "txtBxSearchStudent";
            this.txtBxSearchStudent.Size = new System.Drawing.Size(100, 20);
            this.txtBxSearchStudent.TabIndex = 39;
            this.txtBxSearchStudent.TextChanged += new System.EventHandler(this.txtBxSearchStudent_TextChanged);
            // 
            // cmdCreateGroup
            // 
            this.cmdCreateGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCreateGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCreateGroup.Location = new System.Drawing.Point(453, 309);
            this.cmdCreateGroup.Name = "cmdCreateGroup";
            this.cmdCreateGroup.Size = new System.Drawing.Size(100, 33);
            this.cmdCreateGroup.TabIndex = 40;
            this.cmdCreateGroup.Text = "Create Group";
            this.cmdCreateGroup.UseVisualStyleBackColor = false;
            this.cmdCreateGroup.Click += new System.EventHandler(this.cmdCreateGroup_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(286, 309);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 33);
            this.cmdCancel.TabIndex = 41;
            this.cmdCancel.Text = "Cancel ";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Search Student";
            // 
            // Make_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreateGroup);
            this.Controls.Add(this.txtBxSearchStudent);
            this.Controls.Add(this.cmdAddInGroup);
            this.Controls.Add(this.studentGroupGridView);
            this.Name = "Make_Group";
            this.Text = "Make Group";
            this.Load += new System.EventHandler(this.Make_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView studentGroupGridView;
        private System.Windows.Forms.Button cmdAddInGroup;
        private System.Windows.Forms.TextBox txtBxSearchStudent;
        private System.Windows.Forms.Button cmdCreateGroup;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label2;
    }
}