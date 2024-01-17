namespace Std_management_system
{
    partial class faculty
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
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFaculty
            // 
            this.txtFaculty.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculty.Location = new System.Drawing.Point(52, 171);
            this.txtFaculty.Multiline = true;
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(400, 51);
            this.txtFaculty.TabIndex = 20;
            this.txtFaculty.TextChanged += new System.EventHandler(this.txtFaculty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Faculty Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 71);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Faculty";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(530, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 548);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.label1);
            this.Name = "faculty";
            this.Text = "faculty";
            this.Load += new System.EventHandler(this.faculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}