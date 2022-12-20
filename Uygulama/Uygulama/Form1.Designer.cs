namespace Uygulama
{
    partial class Form1
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
            this.girisButton = new FontAwesome.Sharp.IconButton();
            this.kayitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.girisButton.Location = new System.Drawing.Point(146, 52);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(128, 46);
            this.girisButton.TabIndex = 1;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
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
            this.kayitButton.Location = new System.Drawing.Point(12, 53);
            this.kayitButton.Name = "kayitButton";
            this.kayitButton.Size = new System.Drawing.Size(128, 46);
            this.kayitButton.TabIndex = 0;
            this.kayitButton.Text = "Kayıt Ol";
            this.kayitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kayitButton.UseVisualStyleBackColor = false;
            this.kayitButton.Click += new System.EventHandler(this.kayitButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyunlar İçin Giriş Yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(289, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitButton);
            this.Controls.Add(this.girisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Uygulaması";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton girisButton;
        private FontAwesome.Sharp.IconButton kayitButton;
        private Label label1;
    }
}