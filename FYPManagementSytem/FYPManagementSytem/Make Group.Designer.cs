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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddInGroup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxSearchStudent = new System.Windows.Forms.TextBox();
            this.cmdCreateGroup = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGroupGridView
            // 
            this.studentGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGroupGridView.Location = new System.Drawing.Point(65, 136);
            this.studentGroupGridView.Name = "studentGroupGridView";
            this.studentGroupGridView.Size = new System.Drawing.Size(488, 137);
            this.studentGroupGridView.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(286, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "InActive";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(203, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Active";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Status";
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Select Student";
            // 
            // txtBxSearchStudent
            // 
            this.txtBxSearchStudent.Location = new System.Drawing.Point(203, 32);
            this.txtBxSearchStudent.Name = "txtBxSearchStudent";
            this.txtBxSearchStudent.Size = new System.Drawing.Size(100, 20);
            this.txtBxSearchStudent.TabIndex = 39;
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
            // Make_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 388);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreateGroup);
            this.Controls.Add(this.txtBxSearchStudent);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAddInGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentGroupGridView);
            this.Name = "Make_Group";
            this.Text = "Make Group";
            ((System.ComponentModel.ISupportInitialize)(this.studentGroupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView studentGroupGridView;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddInGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxSearchStudent;
        private System.Windows.Forms.Button cmdCreateGroup;
        private System.Windows.Forms.Button cmdCancel;
    }
}