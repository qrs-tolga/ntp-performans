namespace Uygulama
{
    partial class Form2
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
            this.kayit_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kayit_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kayitButton = new FontAwesome.Sharp.IconButton();
            this.geriButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // kayit_kullanici_adi
            // 
            this.kayit_kullanici_adi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kayit_kullanici_adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayit_kullanici_adi.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayit_kullanici_adi.ForeColor = System.Drawing.Color.White;
            this.kayit_kullanici_adi.Location = new System.Drawing.Point(111, 9);
            this.kayit_kullanici_adi.Multiline = true;
            this.kayit_kullanici_adi.Name = "kayit_kullanici_adi";
            this.kayit_kullanici_adi.Size = new System.Drawing.Size(124, 20);
            this.kayit_kullanici_adi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kayit_sifre
            // 
            this.kayit_sifre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kayit_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kayit_sifre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayit_sifre.ForeColor = System.Drawing.Color.White;
            this.kayit_sifre.Location = new System.Drawing.Point(111, 35);
            this.kayit_sifre.Multiline = true;
            this.kayit_sifre.Name = "kayit_sifre";
            this.kayit_sifre.Size = new System.Drawing.Size(124, 20);
            this.kayit_sifre.TabIndex = 1;
            this.kayit_sifre.TextChanged += new System.EventHandler(this.kayit_sifre_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kayitButton
            // 
            this.kayitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kayitButton.FlatAppearance.BorderSize = 0;
            this.kayitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitButton.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitButton.ForeColor = System.Drawing.Color.White;
            this.kayitButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.kayitButton.IconColor = System.Drawing.Color.White;
            this.kayitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kayitButton.IconSize = 30;
            this.kayitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayitButton.Location = new System.Drawing.Point(111, 74);
            this.kayitButton.Name = "kayitButton";
            this.kayitButton.Size = new System.Drawing.Size(124, 35);
            this.kayitButton.TabIndex = 2;
            this.kayitButton.Text = "Kayıt Ol";
            this.kayitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kayitButton.UseVisualStyleBackColor = false;
            this.kayitButton.Click += new System.EventHandler(this.kayitButton_Click);
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
            this.geriButton.Location = new System.Drawing.Point(10, 74);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(95, 35);
            this.geriButton.TabIndex = 3;
            this.geriButton.Text = "Geri";
            this.geriButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.kayitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.geriButton;
            this.ClientSize = new System.Drawing.Size(244, 116);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.kayitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayit_sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayit_kullanici_adi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kayit_kullanici_adi;
        private Label label1;
        private TextBox kayit_sifre;
        private Label label2;
        private FontAwesome.Sharp.IconButton kayitButton;
        private FontAwesome.Sharp.IconButton geriButton;
    }
}