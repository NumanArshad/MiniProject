namespace FYPManagementSytem
{
    partial class Add_Evaluation
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxTotalMarks = new System.Windows.Forms.Label();
            this.txtBxTotalMark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxTotalWeightage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(264, 242);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 33);
            this.cmdCancel.TabIndex = 27;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(379, 242);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(84, 33);
            this.cmdSave.TabIndex = 26;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(212, 76);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(260, 20);
            this.txtBxName.TabIndex = 23;
            // 
            // txtBxTotalMarks
            // 
            this.txtBxTotalMarks.AutoSize = true;
            this.txtBxTotalMarks.Location = new System.Drawing.Point(100, 140);
            this.txtBxTotalMarks.Name = "txtBxTotalMarks";
            this.txtBxTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.txtBxTotalMarks.TabIndex = 29;
            this.txtBxTotalMarks.Text = "Total Marks";
            // 
            // txtBxTotalMark
            // 
            this.txtBxTotalMark.Location = new System.Drawing.Point(212, 133);
            this.txtBxTotalMark.Name = "txtBxTotalMark";
            this.txtBxTotalMark.Size = new System.Drawing.Size(260, 20);
            this.txtBxTotalMark.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total Weightage";
            // 
            // txtBxTotalWeightage
            // 
            this.txtBxTotalWeightage.Location = new System.Drawing.Point(212, 193);
            this.txtBxTotalWeightage.Name = "txtBxTotalWeightage";
            this.txtBxTotalWeightage.Size = new System.Drawing.Size(260, 20);
            this.txtBxTotalWeightage.TabIndex = 30;
            // 
            // Add_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxTotalWeightage);
            this.Controls.Add(this.txtBxTotalMarks);
            this.Controls.Add(this.txtBxTotalMark);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxName);
            this.Name = "Add_Evaluation";
            this.Text = "Add Evaluation";
            this.Load += new System.EventHandler(this.Add_Evaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label txtBxTotalMarks;
        private System.Windows.Forms.TextBox txtBxTotalMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxTotalWeightage;
    }
}