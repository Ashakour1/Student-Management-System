namespace Std_management_system
{
    partial class Course
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCoursehours = new System.Windows.Forms.TextBox();
            this.txtcourseDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Course Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Course Hours";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 71);
            this.button1.TabIndex = 41;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Course Desc";
            // 
            // txtCourseName
            // 
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName.Location = new System.Drawing.Point(49, 90);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(397, 53);
            this.txtCourseName.TabIndex = 44;
            // 
            // txtCoursehours
            // 
            this.txtCoursehours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoursehours.Location = new System.Drawing.Point(49, 222);
            this.txtCoursehours.Multiline = true;
            this.txtCoursehours.Name = "txtCoursehours";
            this.txtCoursehours.Size = new System.Drawing.Size(397, 53);
            this.txtCoursehours.TabIndex = 45;
            // 
            // txtcourseDesc
            // 
            this.txtcourseDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcourseDesc.Location = new System.Drawing.Point(49, 344);
            this.txtcourseDesc.Multiline = true;
            this.txtcourseDesc.Name = "txtcourseDesc";
            this.txtcourseDesc.Size = new System.Drawing.Size(397, 53);
            this.txtcourseDesc.TabIndex = 46;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.txtcourseDesc);
            this.Controls.Add(this.txtCoursehours);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCoursehours;
        private System.Windows.Forms.TextBox txtcourseDesc;
    }
}