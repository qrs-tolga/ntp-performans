namespace Uygulama
{
    partial class Form8
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
            this.gonder = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tahmin_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.geriButton.Location = new System.Drawing.Point(12, 100);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(95, 35);
            this.geriButton.TabIndex = 16;
            this.geriButton.Text = "Geri";
            this.geriButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geriButton.UseVisualStyleBackColor = false;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // gonder
            // 
            this.gonder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gonder.FlatAppearance.BorderSize = 0;
            this.gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gonder.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gonder.ForeColor = System.Drawing.Color.White;
            this.gonder.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.gonder.IconColor = System.Drawing.Color.White;
            this.gonder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gonder.IconSize = 30;
            this.gonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gonder.Location = new System.Drawing.Point(150, 100);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(124, 35);
            this.gonder.TabIndex = 15;
            this.gonder.Text = "Gönder";
            this.gonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gonder.UseVisualStyleBackColor = false;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "1-10 Arası";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tahmininizi Yazınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tahmin_textbox
            // 
            this.tahmin_textbox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tahmin_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tahmin_textbox.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tahmin_textbox.ForeColor = System.Drawing.Color.White;
            this.tahmin_textbox.Location = new System.Drawing.Point(150, 9);
            this.tahmin_textbox.Multiline = true;
            this.tahmin_textbox.Name = "tahmin_textbox";
            this.tahmin_textbox.Size = new System.Drawing.Size(124, 20);
            this.tahmin_textbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kalan Hak : 5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Puan : 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form8
            // 
            this.AcceptButton = this.gonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.geriButton;
            this.ClientSize = new System.Drawing.Size(286, 147);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tahmin_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmin Etme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton geriButton;
        private FontAwesome.Sharp.IconButton gonder;
        private Label label2;
        private Label label1;
        private TextBox tahmin_textbox;
        private Label label3;
        private Label label4;
    }
}