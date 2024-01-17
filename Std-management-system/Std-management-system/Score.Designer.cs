namespace Std_management_system
{
    partial class Score
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
            this.txtScoreNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseCmb = new System.Windows.Forms.ComboBox();
            this.studentCmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScoreNumber
            // 
            this.txtScoreNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScoreNumber.Location = new System.Drawing.Point(48, 106);
            this.txtScoreNumber.Multiline = true;
            this.txtScoreNumber.Name = "txtScoreNumber";
            this.txtScoreNumber.Size = new System.Drawing.Size(397, 53);
            this.txtScoreNumber.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 50;
            this.label3.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 49;
            this.label2.Text = "course";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 71);
            this.button1.TabIndex = 48;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Student ";
            // 
            // courseCmb
            // 
            this.courseCmb.FormattingEnabled = true;
            this.courseCmb.Location = new System.Drawing.Point(48, 250);
            this.courseCmb.Name = "courseCmb";
            this.courseCmb.Size = new System.Drawing.Size(397, 28);
            this.courseCmb.TabIndex = 54;
            // 
            // studentCmb
            // 
            this.studentCmb.FormattingEnabled = true;
            this.studentCmb.Location = new System.Drawing.Point(48, 384);
            this.studentCmb.Name = "studentCmb";
            this.studentCmb.Size = new System.Drawing.Size(397, 28);
            this.studentCmb.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(511, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(434, 576);
            this.dataGridView1.TabIndex = 56;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentCmb);
            this.Controls.Add(this.courseCmb);
            this.Controls.Add(this.txtScoreNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtScoreNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseCmb;
        private System.Windows.Forms.ComboBox studentCmb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}