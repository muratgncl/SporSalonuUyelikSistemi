namespace _1
{
    partial class FrmSecimEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UyeGirisBttn = new Button();
            AntGirisBttn = new Button();
            SuspendLayout();
            // 
            // UyeGirisBttn
            // 
            UyeGirisBttn.BackColor = Color.Gold;
            UyeGirisBttn.Cursor = Cursors.Hand;
            UyeGirisBttn.FlatAppearance.BorderSize = 0;
            UyeGirisBttn.FlatStyle = FlatStyle.Flat;
            UyeGirisBttn.ForeColor = Color.Black;
            UyeGirisBttn.Location = new Point(279, 181);
            UyeGirisBttn.Margin = new Padding(4, 3, 4, 3);
            UyeGirisBttn.Name = "UyeGirisBttn";
            UyeGirisBttn.Size = new Size(387, 93);
            UyeGirisBttn.TabIndex = 0;
            UyeGirisBttn.Text = "Üye Girişi";
            UyeGirisBttn.UseVisualStyleBackColor = false;
            UyeGirisBttn.Click += UyeGirisBttn_Click;
            // 
            // AntGirisBttn
            // 
            AntGirisBttn.BackColor = Color.Gold;
            AntGirisBttn.Cursor = Cursors.Hand;
            AntGirisBttn.FlatAppearance.BorderSize = 0;
            AntGirisBttn.FlatStyle = FlatStyle.Flat;
            AntGirisBttn.ForeColor = Color.Black;
            AntGirisBttn.Location = new Point(697, 181);
            AntGirisBttn.Margin = new Padding(4, 3, 4, 3);
            AntGirisBttn.Name = "AntGirisBttn";
            AntGirisBttn.Size = new Size(357, 93);
            AntGirisBttn.TabIndex = 1;
            AntGirisBttn.Text = "Antrenör Girişi";
            AntGirisBttn.UseVisualStyleBackColor = false;
            AntGirisBttn.Click += AntGirisBttn_Click;
            // 
            // FrmSecimEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1322, 536);
            Controls.Add(AntGirisBttn);
            Controls.Add(UyeGirisBttn);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmSecimEkrani";
            Text = "Spor Salonu Giriş Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button UyeGirisBttn;
        private Button AntGirisBttn;
    }
}
