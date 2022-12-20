namespace Uygulama
{
    partial class Form4
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
            this.oyun_1 = new FontAwesome.Sharp.IconButton();
            this.oyun_2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oyun_1
            // 
            this.oyun_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.oyun_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oyun_1.FlatAppearance.BorderSize = 0;
            this.oyun_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oyun_1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oyun_1.ForeColor = System.Drawing.Color.White;
            this.oyun_1.IconChar = FontAwesome.Sharp.IconChar.HandRock;
            this.oyun_1.IconColor = System.Drawing.Color.White;
            this.oyun_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.oyun_1.IconSize = 30;
            this.oyun_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oyun_1.Location = new System.Drawing.Point(23, 50);
            this.oyun_1.Name = "oyun_1";
            this.oyun_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oyun_1.Size = new System.Drawing.Size(98, 71);
            this.oyun_1.TabIndex = 0;
            this.oyun_1.Text = "Taş \r\nKağıt \r\nMakas";
            this.oyun_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.oyun_1.UseVisualStyleBackColor = false;
            this.oyun_1.Click += new System.EventHandler(this.oyun_1_Click);
            // 
            // oyun_2
            // 
            this.oyun_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.oyun_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oyun_2.FlatAppearance.BorderSize = 0;
            this.oyun_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oyun_2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oyun_2.ForeColor = System.Drawing.Color.White;
            this.oyun_2.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.oyun_2.IconColor = System.Drawing.Color.White;
            this.oyun_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.oyun_2.IconSize = 30;
            this.oyun_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oyun_2.Location = new System.Drawing.Point(127, 50);
            this.oyun_2.Name = "oyun_2";
            this.oyun_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oyun_2.Size = new System.Drawing.Size(98, 71);
            this.oyun_2.TabIndex = 1;
            this.oyun_2.Text = "Sayı \r\nTahmin \r\nEtme";
            this.oyun_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.oyun_2.UseVisualStyleBackColor = false;
            this.oyun_2.Click += new System.EventHandler(this.oyun_2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oyunlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(246, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyun_2);
            this.Controls.Add(this.oyun_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyunlar";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton oyun_1;
        private FontAwesome.Sharp.IconButton oyun_2;
        private Label label1;
    }
}