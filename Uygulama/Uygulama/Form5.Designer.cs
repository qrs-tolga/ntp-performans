namespace Uygulama
{
    partial class Form5
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
            this.tekOyunculu = new FontAwesome.Sharp.IconButton();
            this.ciftOyunculu = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tekOyunculu
            // 
            this.tekOyunculu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tekOyunculu.FlatAppearance.BorderSize = 0;
            this.tekOyunculu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tekOyunculu.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tekOyunculu.ForeColor = System.Drawing.Color.White;
            this.tekOyunculu.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.tekOyunculu.IconColor = System.Drawing.Color.White;
            this.tekOyunculu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tekOyunculu.IconSize = 30;
            this.tekOyunculu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tekOyunculu.Location = new System.Drawing.Point(12, 43);
            this.tekOyunculu.Name = "tekOyunculu";
            this.tekOyunculu.Size = new System.Drawing.Size(124, 44);
            this.tekOyunculu.TabIndex = 3;
            this.tekOyunculu.Text = "Tek Oyunculu";
            this.tekOyunculu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tekOyunculu.UseVisualStyleBackColor = false;
            this.tekOyunculu.Click += new System.EventHandler(this.tekOyunculu_Click);
            // 
            // ciftOyunculu
            // 
            this.ciftOyunculu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ciftOyunculu.FlatAppearance.BorderSize = 0;
            this.ciftOyunculu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciftOyunculu.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ciftOyunculu.ForeColor = System.Drawing.Color.White;
            this.ciftOyunculu.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ciftOyunculu.IconColor = System.Drawing.Color.White;
            this.ciftOyunculu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciftOyunculu.IconSize = 30;
            this.ciftOyunculu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ciftOyunculu.Location = new System.Drawing.Point(142, 43);
            this.ciftOyunculu.Name = "ciftOyunculu";
            this.ciftOyunculu.Size = new System.Drawing.Size(124, 44);
            this.ciftOyunculu.TabIndex = 3;
            this.ciftOyunculu.Text = "Çift Oyunculu";
            this.ciftOyunculu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ciftOyunculu.UseVisualStyleBackColor = false;
            this.ciftOyunculu.Click += new System.EventHandler(this.ciftOyunculu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seçim Yapınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(278, 100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ciftOyunculu);
            this.Controls.Add(this.tekOyunculu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş Kağıt Makas";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton tekOyunculu;
        private FontAwesome.Sharp.IconButton ciftOyunculu;
        private Label label1;
    }
}