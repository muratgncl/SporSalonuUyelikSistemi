namespace _1
{
    partial class FrmUyeGiris
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
            label3 = new Label();
            UyeSifreLbl = new Label();
            UyeNoLbl = new Label();
            UyeGirisBttn = new Button();
            UyeSifreTxtBox = new TextBox();
            UyeNoTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(265, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(334, 20);
            label3.TabIndex = 11;
            label3.Text = "HOŞGELDİNİZ LÜTFEN BİLGİLERİNİZİ GİRİNİZ";
            // 
            // UyeSifreLbl
            // 
            UyeSifreLbl.AutoSize = true;
            UyeSifreLbl.ForeColor = Color.Gold;
            UyeSifreLbl.Location = new Point(188, 179);
            UyeSifreLbl.Margin = new Padding(4, 0, 4, 0);
            UyeSifreLbl.Name = "UyeSifreLbl";
            UyeSifreLbl.Size = new Size(45, 20);
            UyeSifreLbl.TabIndex = 10;
            UyeSifreLbl.Text = "Şifre:";
            UyeSifreLbl.Click += UyeSifreLbl_Click;
            // 
            // UyeNoLbl
            // 
            UyeNoLbl.AutoSize = true;
            UyeNoLbl.ForeColor = Color.Gold;
            UyeNoLbl.Location = new Point(126, 142);
            UyeNoLbl.Margin = new Padding(4, 0, 4, 0);
            UyeNoLbl.Name = "UyeNoLbl";
            UyeNoLbl.Size = new Size(131, 20);
            UyeNoLbl.TabIndex = 9;
            UyeNoLbl.Text = "Üye Kullanıcı Adı:";
            UyeNoLbl.Click += UyeNoLbl_Click;
            // 
            // UyeGirisBttn
            // 
            UyeGirisBttn.BackColor = Color.Gold;
            UyeGirisBttn.Cursor = Cursors.Hand;
            UyeGirisBttn.FlatAppearance.BorderSize = 0;
            UyeGirisBttn.FlatStyle = FlatStyle.Flat;
            UyeGirisBttn.Location = new Point(265, 201);
            UyeGirisBttn.Margin = new Padding(4, 3, 4, 3);
            UyeGirisBttn.Name = "UyeGirisBttn";
            UyeGirisBttn.Size = new Size(220, 45);
            UyeGirisBttn.TabIndex = 8;
            UyeGirisBttn.Text = "Giriş";
            UyeGirisBttn.UseVisualStyleBackColor = false;
            UyeGirisBttn.Click += UyeGirisBttn_Click;
            // 
            // UyeSifreTxtBox
            // 
            UyeSifreTxtBox.Location = new Point(265, 168);
            UyeSifreTxtBox.Margin = new Padding(4, 3, 4, 3);
            UyeSifreTxtBox.Name = "UyeSifreTxtBox";
            UyeSifreTxtBox.Size = new Size(315, 27);
            UyeSifreTxtBox.TabIndex = 7;
            // 
            // UyeNoTxtBox
            // 
            UyeNoTxtBox.Location = new Point(265, 135);
            UyeNoTxtBox.Margin = new Padding(4, 3, 4, 3);
            UyeNoTxtBox.Name = "UyeNoTxtBox";
            UyeNoTxtBox.Size = new Size(315, 27);
            UyeNoTxtBox.TabIndex = 6;
            // 
            // FrmUyeGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(850, 432);
            Controls.Add(label3);
            Controls.Add(UyeSifreLbl);
            Controls.Add(UyeNoLbl);
            Controls.Add(UyeGirisBttn);
            Controls.Add(UyeSifreTxtBox);
            Controls.Add(UyeNoTxtBox);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmUyeGiris";
            Text = "Spor Salonu Üye Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label UyeSifreLbl;
        private Label UyeNoLbl;
        private Button UyeGirisBttn;
        private TextBox UyeSifreTxtBox;
        private TextBox UyeNoTxtBox;
    }
}