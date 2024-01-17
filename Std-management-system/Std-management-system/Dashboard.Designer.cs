namespace Std_management_system
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblstudents = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbfaculty = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargeMonthlyFeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFacultiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addmissionToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.examToolStripMenuItem,
            this.attendenceToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblstudents);
            this.panel1.Location = new System.Drawing.Point(45, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 126);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblstudents
            // 
            this.lblstudents.AutoSize = true;
            this.lblstudents.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudents.Location = new System.Drawing.Point(81, 33);
            this.lblstudents.Name = "lblstudents";
            this.lblstudents.Size = new System.Drawing.Size(0, 37);
            this.lblstudents.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbfaculty);
            this.panel2.Location = new System.Drawing.Point(306, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 126);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // lbfaculty
            // 
            this.lbfaculty.AutoSize = true;
            this.lbfaculty.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfaculty.Location = new System.Drawing.Point(81, 33);
            this.lbfaculty.Name = "lbfaculty";
            this.lbfaculty.Size = new System.Drawing.Size(0, 37);
            this.lbfaculty.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.course);
            this.panel3.Location = new System.Drawing.Point(565, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 126);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.Location = new System.Drawing.Point(81, 33);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(0, 37);
            this.course.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL STUDENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL FACULTIES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL COURSES";
            // 
            // addmissionToolStripMenuItem
            // 
            this.addmissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.manageStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem});
            this.addmissionToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.contract;
            this.addmissionToolStripMenuItem.Name = "addmissionToolStripMenuItem";
            this.addmissionToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.addmissionToolStripMenuItem.Text = "Addmission";
            this.addmissionToolStripMenuItem.Click += new System.EventHandler(this.addmissionToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.verify;
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.management;
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.manageStudentToolStripMenuItem.Text = "ManageStudent";
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.changes;
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargeMonthlyFeeToolStripMenuItem});
            this.financeToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.hand;
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.financeToolStripMenuItem.Text = "Finance";
            this.financeToolStripMenuItem.Click += new System.EventHandler(this.financeToolStripMenuItem_Click);
            // 
            // chargeMonthlyFeeToolStripMenuItem
            // 
            this.chargeMonthlyFeeToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.money;
            this.chargeMonthlyFeeToolStripMenuItem.Name = "chargeMonthlyFeeToolStripMenuItem";
            this.chargeMonthlyFeeToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.chargeMonthlyFeeToolStripMenuItem.Text = "Charge Monthly Fee";
            this.chargeMonthlyFeeToolStripMenuItem.Click += new System.EventHandler(this.chargeMonthlyFeeToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem});
            this.examToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.exam__2_;
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.examToolStripMenuItem.Text = "Exam";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.scoreboard;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendenceToolStripMenuItem});
            this.attendenceToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.attendance;
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.attendenceToolStripMenuItem.Text = "Attendence";
            this.attendenceToolStripMenuItem.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // addAttendenceToolStripMenuItem
            // 
            this.addAttendenceToolStripMenuItem.Name = "addAttendenceToolStripMenuItem";
            this.addAttendenceToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.addAttendenceToolStripMenuItem.Text = "Add Attendence";
            this.addAttendenceToolStripMenuItem.Click += new System.EventHandler(this.addAttendenceToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCoursesToolStripMenuItem});
            this.courseToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.homework__1_;
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // manageCoursesToolStripMenuItem
            // 
            this.manageCoursesToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.presentation__1_;
            this.manageCoursesToolStripMenuItem.Name = "manageCoursesToolStripMenuItem";
            this.manageCoursesToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.manageCoursesToolStripMenuItem.Text = "Manage Courses";
            this.manageCoursesToolStripMenuItem.Click += new System.EventHandler(this.manageCoursesToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFacultiesToolStripMenuItem});
            this.facultyToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.graduation;
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.facultyToolStripMenuItem.Text = "Faculty";
            // 
            // allFacultiesToolStripMenuItem
            // 
            this.allFacultiesToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.mortarboard;
            this.allFacultiesToolStripMenuItem.Name = "allFacultiesToolStripMenuItem";
            this.allFacultiesToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.allFacultiesToolStripMenuItem.Text = "All Faculties";
            this.allFacultiesToolStripMenuItem.Click += new System.EventHandler(this.allFacultiesToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::Std_management_system.Properties.Resources.logout;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargeMonthlyFeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFacultiesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbfaculty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label course;
        public System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addmissionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}