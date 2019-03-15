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
            this.lblTotalWeightageError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblTotalMarksError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(268, 242);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(93, 33);
            this.cmdCancel.TabIndex = 27;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(379, 242);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(93, 33);
            this.cmdSave.TabIndex = 26;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(212, 76);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(260, 22);
            this.txtBxName.TabIndex = 23;
            // 
            // txtBxTotalMarks
            // 
            this.txtBxTotalMarks.AutoSize = true;
            this.txtBxTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotalMarks.Location = new System.Drawing.Point(81, 136);
            this.txtBxTotalMarks.Name = "txtBxTotalMarks";
            this.txtBxTotalMarks.Size = new System.Drawing.Size(90, 16);
            this.txtBxTotalMarks.TabIndex = 29;
            this.txtBxTotalMarks.Text = "Total Marks";
            // 
            // txtBxTotalMark
            // 
            this.txtBxTotalMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotalMark.Location = new System.Drawing.Point(212, 133);
            this.txtBxTotalMark.Name = "txtBxTotalMark";
            this.txtBxTotalMark.Size = new System.Drawing.Size(260, 22);
            this.txtBxTotalMark.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total Weightage";
            // 
            // txtBxTotalWeightage
            // 
            this.txtBxTotalWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTotalWeightage.Location = new System.Drawing.Point(212, 193);
            this.txtBxTotalWeightage.Name = "txtBxTotalWeightage";
            this.txtBxTotalWeightage.Size = new System.Drawing.Size(260, 22);
            this.txtBxTotalWeightage.TabIndex = 30;
            // 
            // lblTotalWeightageError
            // 
            this.lblTotalWeightageError.AutoSize = true;
            this.lblTotalWeightageError.ForeColor = System.Drawing.Color.Red;
            this.lblTotalWeightageError.Location = new System.Drawing.Point(503, 196);
            this.lblTotalWeightageError.Name = "lblTotalWeightageError";
            this.lblTotalWeightageError.Size = new System.Drawing.Size(0, 13);
            this.lblTotalWeightageError.TabIndex = 32;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(503, 79);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 13);
            this.lblNameError.TabIndex = 33;
            // 
            // lblTotalMarksError
            // 
            this.lblTotalMarksError.AutoSize = true;
            this.lblTotalMarksError.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMarksError.Location = new System.Drawing.Point(503, 140);
            this.lblTotalMarksError.Name = "lblTotalMarksError";
            this.lblTotalMarksError.Size = new System.Drawing.Size(0, 13);
            this.lblTotalMarksError.TabIndex = 34;
            // 
            // Add_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 361);
            this.Controls.Add(this.lblTotalMarksError);
            this.Controls.Add(this.lblTotalWeightageError);
            this.Controls.Add(this.lblNameError);
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
        private System.Windows.Forms.Label lblTotalWeightageError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblTotalMarksError;
    }
}