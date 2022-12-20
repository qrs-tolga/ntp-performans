namespace Uygulama
{
    partial class Form3
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
            this.geriButton = new FontAwesome.Sharp.IconButton();
            this.girisButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.giris_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.giris_kullanici_adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // geriButton
            // 
            this.geriButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.geriButton.FlatAppearance.BorderSize = 0;
            this.geriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriButton.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geriButton.ForeColor = System.Drawing.Color.White;
            this.geriButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.geriButton.IconColor = System.Drawing.Color.White;
            this.geriButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.geriButton.IconSize = 30;
            this.geriButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.geriButton.Location = new System.Drawing.Point(10, 73);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(95, 35);
            this.geriButton.TabIndex = 3;
            this.geriButton.Text = "Geri";
            this.geriButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisButton.ForeColor = System.Drawing.Color.White;
            this.girisButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.girisButton.IconColor = System.Drawing.Color.White;
            this.girisButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.girisButton.IconSize = 30;
            this.girisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisButton.Location = new System.Drawing.Point(111, 73);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(124, 35);
            this.girisButton.TabIndex = 2;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giris_sifre
            // 
            this.giris_sifre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.giris_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giris_sifre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giris_sifre.ForeColor = System.Drawing.Color.White;
            this.giris_sifre.Location = new System.Drawing.Point(111, 34);
            this.giris_sifre.Multiline = true;
            this.giris_sifre.Name = "giris_sifre";
            this.giris_sifre.Size = new System.Drawing.Size(124, 20);
            this.giris_sifre.TabIndex = 1;
            this.giris_sifre.TextChanged += new System.EventHandler(this.giris_sifre_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giris_kullanici_adi
            // 
            this.giris_kullanici_adi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.giris_kullanici_adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giris_kullanici_adi.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giris_kullanici_adi.ForeColor = System.Drawing.Color.White;
            this.giris_kullanici_adi.Location = new System.Drawing.Point(111, 8);
            this.giris_kullanici_adi.Multiline = true;
            this.giris_kullanici_adi.Name = "giris_kullanici_adi";
            this.giris_kullanici_adi.Size = new System.Drawing.Size(124, 20);
            this.giris_kullanici_adi.TabIndex = 0;
            // 
            // Form3
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.geriButton;
            this.ClientSize = new System.Drawing.Size(244, 116);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giris_sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris_kullanici_adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton geriButton;
        private FontAwesome.Sharp.IconButton girisButton;
        private Label label2;
        private TextBox giris_sifre;
        private Label label1;
        private TextBox giris_kullanici_adi;
    }
}