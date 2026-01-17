namespace _1
{
    partial class FrmAntrenorGiris
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
            AntNoTxtBox = new TextBox();
            AntSifreTxtBox = new TextBox();
            AntGirisBttn = new Button();
            AntNoLbl = new Label();
            AntSifreLbl = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AntNoTxtBox
            // 
            AntNoTxtBox.Location = new Point(256, 112);
            AntNoTxtBox.Margin = new Padding(4, 3, 4, 3);
            AntNoTxtBox.Name = "AntNoTxtBox";
            AntNoTxtBox.Size = new Size(315, 27);
            AntNoTxtBox.TabIndex = 0;
            // 
            // AntSifreTxtBox
            // 
            AntSifreTxtBox.Location = new Point(256, 145);
            AntSifreTxtBox.Margin = new Padding(4, 3, 4, 3);
            AntSifreTxtBox.Name = "AntSifreTxtBox";
            AntSifreTxtBox.Size = new Size(315, 27);
            AntSifreTxtBox.TabIndex = 1;
            // 
            // AntGirisBttn
            // 
            AntGirisBttn.BackColor = Color.Gold;
            AntGirisBttn.Cursor = Cursors.Hand;
            AntGirisBttn.FlatAppearance.BorderSize = 0;
            AntGirisBttn.FlatStyle = FlatStyle.Flat;
            AntGirisBttn.ForeColor = Color.Black;
            AntGirisBttn.Location = new Point(256, 187);
            AntGirisBttn.Margin = new Padding(4, 3, 4, 3);
            AntGirisBttn.Name = "AntGirisBttn";
            AntGirisBttn.Size = new Size(220, 45);
            AntGirisBttn.TabIndex = 2;
            AntGirisBttn.Text = "Giriş";
            AntGirisBttn.UseVisualStyleBackColor = false;
            AntGirisBttn.Click += AntGirisBttn_Click;
            // 
            // AntNoLbl
            // 
            AntNoLbl.AutoSize = true;
            AntNoLbl.ForeColor = Color.Gold;
            AntNoLbl.Location = new Point(68, 115);
            AntNoLbl.Margin = new Padding(4, 0, 4, 0);
            AntNoLbl.Name = "AntNoLbl";
            AntNoLbl.Size = new Size(168, 20);
            AntNoLbl.TabIndex = 3;
            AntNoLbl.Text = "Antrenör Kullanıcı Adı:";
            // 
            // AntSifreLbl
            // 
            AntSifreLbl.AutoSize = true;
            AntSifreLbl.ForeColor = Color.Gold;
            AntSifreLbl.Location = new Point(68, 148);
            AntSifreLbl.Margin = new Padding(4, 0, 4, 0);
            AntSifreLbl.Name = "AntSifreLbl";
            AntSifreLbl.Size = new Size(45, 20);
            AntSifreLbl.TabIndex = 4;
            AntSifreLbl.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(68, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(334, 20);
            label3.TabIndex = 5;
            label3.Text = "HOŞGELDİNİZ LÜTFEN BİLGİLERİNİZİ GİRİNİZ";
            // 
            // FrmAntrenorGiris
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(757, 377);
            Controls.Add(label3);
            Controls.Add(AntSifreLbl);
            Controls.Add(AntNoLbl);
            Controls.Add(AntGirisBttn);
            Controls.Add(AntSifreTxtBox);
            Controls.Add(AntNoTxtBox);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAntrenorGiris";
            Text = "Spor Salonu Antrenör Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AntNoTxtBox;
        private TextBox AntSifreTxtBox;
        private Button AntGirisBttn;
        private Label AntNoLbl;
        private Label AntSifreLbl;
        private Label label3;
    }
}