namespace _1
{
    partial class FrmAntrenman
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 31);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Üye Seçin:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 25);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(409, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 25);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(530, 28);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "Hareket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(530, 71);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 6;
            label3.Text = "Set";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(530, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 7;
            label4.Text = "Tekrar";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(409, 169);
            button1.Name = "button1";
            button1.Size = new Size(131, 26);
            button1.TabIndex = 8;
            button1.Text = "PROGRAMA EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 276);
            dataGridView1.TabIndex = 9;
            // 
            // FrmAntrenman
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(605, 400);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "FrmAntrenman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antrenman Programı Oluştur";
            Load += FrmAntrenman_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
    }
}