namespace FYPManagementSytem
{
    partial class Dashboard
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
            this.cmdManageStudents = new System.Windows.Forms.Button();
            this.cmdManageProjects = new System.Windows.Forms.Button();
            this.cmdManageAdvisors = new System.Windows.Forms.Button();
            this.cmdProjectAdvisors = new System.Windows.Forms.Button();
            this.cmdGroupProject = new System.Windows.Forms.Button();
            this.cmdStudentGroups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdManageStudents
            // 
            this.cmdManageStudents.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdManageStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdManageStudents.Location = new System.Drawing.Point(91, 155);
            this.cmdManageStudents.Name = "cmdManageStudents";
            this.cmdManageStudents.Size = new System.Drawing.Size(121, 59);
            this.cmdManageStudents.TabIndex = 0;
            this.cmdManageStudents.Text = "Manage Students";
            this.cmdManageStudents.UseVisualStyleBackColor = false;
            this.cmdManageStudents.Click += new System.EventHandler(this.cmdManageStudents_Click);
            // 
            // cmdManageProjects
            // 
            this.cmdManageProjects.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdManageProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdManageProjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdManageProjects.Location = new System.Drawing.Point(265, 155);
            this.cmdManageProjects.Name = "cmdManageProjects";
            this.cmdManageProjects.Size = new System.Drawing.Size(121, 59);
            this.cmdManageProjects.TabIndex = 1;
            this.cmdManageProjects.Text = "Manage Projects";
            this.cmdManageProjects.UseVisualStyleBackColor = false;
            this.cmdManageProjects.Click += new System.EventHandler(this.cmdManageProjects_Click);
            // 
            // cmdManageAdvisors
            // 
            this.cmdManageAdvisors.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdManageAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdManageAdvisors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdManageAdvisors.Location = new System.Drawing.Point(444, 155);
            this.cmdManageAdvisors.Name = "cmdManageAdvisors";
            this.cmdManageAdvisors.Size = new System.Drawing.Size(121, 59);
            this.cmdManageAdvisors.TabIndex = 2;
            this.cmdManageAdvisors.Text = "Manage Advisors";
            this.cmdManageAdvisors.UseVisualStyleBackColor = false;
            this.cmdManageAdvisors.Click += new System.EventHandler(this.cmdManageAdvisors_Click);
            // 
            // cmdProjectAdvisors
            // 
            this.cmdProjectAdvisors.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdProjectAdvisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProjectAdvisors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdProjectAdvisors.Location = new System.Drawing.Point(444, 241);
            this.cmdProjectAdvisors.Name = "cmdProjectAdvisors";
            this.cmdProjectAdvisors.Size = new System.Drawing.Size(121, 59);
            this.cmdProjectAdvisors.TabIndex = 5;
            this.cmdProjectAdvisors.Text = "Assign Advisors to Project";
            this.cmdProjectAdvisors.UseVisualStyleBackColor = false;
            this.cmdProjectAdvisors.Click += new System.EventHandler(this.cmdProjectAdvisors_Click);
            // 
            // cmdGroupProject
            // 
            this.cmdGroupProject.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdGroupProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGroupProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdGroupProject.Location = new System.Drawing.Point(265, 241);
            this.cmdGroupProject.Name = "cmdGroupProject";
            this.cmdGroupProject.Size = new System.Drawing.Size(121, 59);
            this.cmdGroupProject.TabIndex = 4;
            this.cmdGroupProject.Text = "Assign Project to Group";
            this.cmdGroupProject.UseVisualStyleBackColor = false;
            this.cmdGroupProject.Click += new System.EventHandler(this.cmdGroupProject_Click);
            // 
            // cmdStudentGroups
            // 
            this.cmdStudentGroups.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdStudentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStudentGroups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdStudentGroups.Location = new System.Drawing.Point(91, 241);
            this.cmdStudentGroups.Name = "cmdStudentGroups";
            this.cmdStudentGroups.Size = new System.Drawing.Size(121, 59);
            this.cmdStudentGroups.TabIndex = 3;
            this.cmdStudentGroups.Text = "Student Groups";
            this.cmdStudentGroups.UseVisualStyleBackColor = false;
            this.cmdStudentGroups.Click += new System.EventHandler(this.cmdStudentGroups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "FYP Management System";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdProjectAdvisors);
            this.Controls.Add(this.cmdGroupProject);
            this.Controls.Add(this.cmdStudentGroups);
            this.Controls.Add(this.cmdManageAdvisors);
            this.Controls.Add(this.cmdManageProjects);
            this.Controls.Add(this.cmdManageStudents);
            this.Name = "Dashboard";
            this.Text = "Manage Advisor";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdManageStudents;
        private System.Windows.Forms.Button cmdManageProjects;
        private System.Windows.Forms.Button cmdManageAdvisors;
        private System.Windows.Forms.Button cmdProjectAdvisors;
        private System.Windows.Forms.Button cmdGroupProject;
        private System.Windows.Forms.Button cmdStudentGroups;
        private System.Windows.Forms.Label label1;
    }
}

