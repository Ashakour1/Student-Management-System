namespace Std_management_system
{
    partial class Finance
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 71);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Fee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(46, 82);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(400, 51);
            this.txtAmount.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Amount";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(46, 218);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(400, 51);
            this.txtDesc.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "Student";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(499, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(504, 556);
            this.dataGridView1.TabIndex = 29;
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Name = "Finance";
            this.Text = "Finance";
            this.Load += new System.EventHandler(this.Finance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}