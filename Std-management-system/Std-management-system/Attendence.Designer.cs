namespace Std_management_system
{
    partial class Attendence
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
            this.stdCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coursecmb = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdCmb
            // 
            this.stdCmb.FormattingEnabled = true;
            this.stdCmb.Location = new System.Drawing.Point(70, 172);
            this.stdCmb.Name = "stdCmb";
            this.stdCmb.Size = new System.Drawing.Size(400, 28);
            this.stdCmb.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 37);
            this.label3.TabIndex = 34;
            this.label3.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "course";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 71);
            this.button1.TabIndex = 31;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Attendence";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(530, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(536, 595);
            this.dataGridView1.TabIndex = 37;
            // 
            // coursecmb
            // 
            this.coursecmb.FormattingEnabled = true;
            this.coursecmb.Location = new System.Drawing.Point(70, 300);
            this.coursecmb.Name = "coursecmb";
            this.coursecmb.Size = new System.Drawing.Size(400, 28);
            this.coursecmb.TabIndex = 38;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Past",
            "Present"});
            this.status.Location = new System.Drawing.Point(70, 414);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(400, 28);
            this.status.TabIndex = 39;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 595);
            this.Controls.Add(this.status);
            this.Controls.Add(this.coursecmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stdCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Attendence";
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stdCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox coursecmb;
        private System.Windows.Forms.ComboBox status;
    }
}