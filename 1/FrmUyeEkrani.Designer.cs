namespace _1
{
    partial class FrmUyeEkrani
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
            lblAdSoyad = new Label();
            lblBoy = new Label();
            lblKilo = new Label();
            lblYag = new Label();
            lblBMI = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuncelle = new Button();
            txtYeniYag = new TextBox();
            txtYeniKilo = new TextBox();
            txtYeniBoy = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = Color.Gold;
            lblAdSoyad.Location = new Point(12, 27);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(79, 20);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBoy.ForeColor = Color.Gold;
            lblBoy.Location = new Point(12, 60);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(74, 20);
            lblBoy.TabIndex = 2;
            lblBoy.Text = "Boyunuz:";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKilo.ForeColor = Color.Gold;
            lblKilo.Location = new Point(12, 89);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(65, 20);
            lblKilo.TabIndex = 3;
            lblKilo.Text = "Kilonuz:";
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYag.ForeColor = Color.Gold;
            lblYag.Location = new Point(12, 120);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(80, 20);
            lblYag.TabIndex = 4;
            lblYag.Text = "Yağ Oranı:";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBMI.ForeColor = Color.Gold;
            lblBMI.Location = new Point(12, 150);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(144, 20);
            lblBMI.TabIndex = 5;
            lblBMI.Text = "Vücut Kitle İndeksi:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(363, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(425, 363);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(417, 335);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Antrenman Programım";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(417, 339);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(417, 339);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mesajlarım";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-4, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(425, 343);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtYeniYag);
            groupBox1.Controls.Add(txtYeniKilo);
            groupBox1.Controls.Add(txtYeniBoy);
            groupBox1.Location = new Point(12, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 232);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ölçüm Gir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 6;
            label3.Text = "Yağ Oranı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "Kilo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 4;
            label1.Text = "Boy:";
            label1.Click += label1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(102, 172);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(104, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtYeniYag
            // 
            txtYeniYag.Location = new Point(106, 126);
            txtYeniYag.Name = "txtYeniYag";
            txtYeniYag.Size = new Size(100, 23);
            txtYeniYag.TabIndex = 2;
            // 
            // txtYeniKilo
            // 
            txtYeniKilo.Location = new Point(106, 79);
            txtYeniKilo.Name = "txtYeniKilo";
            txtYeniKilo.Size = new Size(100, 23);
            txtYeniKilo.TabIndex = 1;
            // 
            // txtYeniBoy
            // 
            txtYeniBoy.Location = new Point(106, 38);
            txtYeniBoy.Name = "txtYeniBoy";
            txtYeniBoy.Size = new Size(100, 23);
            txtYeniBoy.TabIndex = 0;
            // 
            // FrmUyeEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Controls.Add(lblBMI);
            Controls.Add(lblYag);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(lblAdSoyad);
            Name = "FrmUyeEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUyeEkrani";
            Load += FrmUyeEkrani_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAdSoyad;
        private Label lblBoy;
        private Label lblKilo;
        private Label lblYag;
        private Label lblBMI;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private TextBox txtYeniYag;
        private TextBox txtYeniKilo;
        private TextBox txtYeniBoy;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}