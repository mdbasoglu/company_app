namespace Otel254v2
{
    partial class Form_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_giris));
            this.button_geri = new System.Windows.Forms.Button();
            this.label_pr_adi = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_pr_adi_giris = new System.Windows.Forms.Label();
            this.textBox_giris = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_girisYap = new System.Windows.Forms.Button();
            this.label_giris_sifreni_mi_unuttun = new System.Windows.Forms.Label();
            this.label_giris_burada_yeni_misin = new System.Windows.Forms.Label();
            this.label_kaydol = new System.Windows.Forms.Label();
            this.label_giris_aciklama1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button_geri
            // 
            this.button_geri.AutoSize = true;
            this.button_geri.BackColor = System.Drawing.Color.Transparent;
            this.button_geri.BackgroundImage = global::Otel254v2.Properties.Resources.button_menu;
            this.button_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_geri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_geri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geri.ForeColor = System.Drawing.Color.White;
            this.button_geri.Location = new System.Drawing.Point(527, 10);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 33);
            this.button_geri.TabIndex = 5;
            this.button_geri.Text = "Geri";
            this.button_geri.UseVisualStyleBackColor = false;
            this.button_geri.Click += new System.EventHandler(this.Button_geri_Click);
            // 
            // label_pr_adi
            // 
            this.label_pr_adi.AutoSize = true;
            this.label_pr_adi.BackColor = System.Drawing.Color.Transparent;
            this.label_pr_adi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_pr_adi.ForeColor = System.Drawing.Color.White;
            this.label_pr_adi.Location = new System.Drawing.Point(20, 20);
            this.label_pr_adi.Name = "label_pr_adi";
            this.label_pr_adi.Size = new System.Drawing.Size(94, 21);
            this.label_pr_adi.TabIndex = 16;
            this.label_pr_adi.Text = "x Programı";
            this.label_pr_adi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Otel254v2.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(738, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label_pr_adi_giris
            // 
            this.label_pr_adi_giris.AutoSize = true;
            this.label_pr_adi_giris.BackColor = System.Drawing.Color.Transparent;
            this.label_pr_adi_giris.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pr_adi_giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_pr_adi_giris.Location = new System.Drawing.Point(592, 145);
            this.label_pr_adi_giris.Name = "label_pr_adi_giris";
            this.label_pr_adi_giris.Size = new System.Drawing.Size(241, 24);
            this.label_pr_adi_giris.TabIndex = 12;
            this.label_pr_adi_giris.Text = "x Programı\'na giriş yap";
            // 
            // textBox_giris
            // 
            this.textBox_giris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_giris.ForeColor = System.Drawing.Color.Gray;
            this.textBox_giris.Location = new System.Drawing.Point(596, 183);
            this.textBox_giris.MaxLength = 17;
            this.textBox_giris.Name = "textBox_giris";
            this.textBox_giris.Size = new System.Drawing.Size(353, 29);
            this.textBox_giris.TabIndex = 0;
            this.textBox_giris.Text = "Telefon, e-posta veya kullanıcı adı";
            this.textBox_giris.TextChanged += new System.EventHandler(this.TextBox_giris_TextChanged);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sifre.ForeColor = System.Drawing.Color.Gray;
            this.textBox_sifre.Location = new System.Drawing.Point(596, 227);
            this.textBox_sifre.MaxLength = 20;
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(353, 29);
            this.textBox_sifre.TabIndex = 1;
            this.textBox_sifre.Text = "Şifre";
            // 
            // button_girisYap
            // 
            this.button_girisYap.BackColor = System.Drawing.Color.Transparent;
            this.button_girisYap.BackgroundImage = global::Otel254v2.Properties.Resources.button_menu;
            this.button_girisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_girisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_girisYap.ForeColor = System.Drawing.Color.White;
            this.button_girisYap.Location = new System.Drawing.Point(596, 262);
            this.button_girisYap.Name = "button_girisYap";
            this.button_girisYap.Size = new System.Drawing.Size(97, 43);
            this.button_girisYap.TabIndex = 2;
            this.button_girisYap.Text = "Giriş yap";
            this.button_girisYap.UseVisualStyleBackColor = false;
            this.button_girisYap.Click += new System.EventHandler(this.Button_girisYap_Click);
            // 
            // label_giris_sifreni_mi_unuttun
            // 
            this.label_giris_sifreni_mi_unuttun.AutoSize = true;
            this.label_giris_sifreni_mi_unuttun.BackColor = System.Drawing.Color.Transparent;
            this.label_giris_sifreni_mi_unuttun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_giris_sifreni_mi_unuttun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_giris_sifreni_mi_unuttun.Location = new System.Drawing.Point(806, 273);
            this.label_giris_sifreni_mi_unuttun.Name = "label_giris_sifreni_mi_unuttun";
            this.label_giris_sifreni_mi_unuttun.Size = new System.Drawing.Size(143, 21);
            this.label_giris_sifreni_mi_unuttun.TabIndex = 3;
            this.label_giris_sifreni_mi_unuttun.Text = "Şifreni mi unuttun?";
            this.label_giris_sifreni_mi_unuttun.Click += new System.EventHandler(this.Label_sifrenimiUnuttun_Click);
            // 
            // label_giris_burada_yeni_misin
            // 
            this.label_giris_burada_yeni_misin.AutoSize = true;
            this.label_giris_burada_yeni_misin.BackColor = System.Drawing.Color.Transparent;
            this.label_giris_burada_yeni_misin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_giris_burada_yeni_misin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_giris_burada_yeni_misin.Location = new System.Drawing.Point(593, 322);
            this.label_giris_burada_yeni_misin.Name = "label_giris_burada_yeni_misin";
            this.label_giris_burada_yeni_misin.Size = new System.Drawing.Size(141, 18);
            this.label_giris_burada_yeni_misin.TabIndex = 19;
            this.label_giris_burada_yeni_misin.Text = "Burada yeni misin?";
            // 
            // label_kaydol
            // 
            this.label_kaydol.AutoSize = true;
            this.label_kaydol.BackColor = System.Drawing.Color.Transparent;
            this.label_kaydol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_kaydol.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_kaydol.Location = new System.Drawing.Point(740, 320);
            this.label_kaydol.Name = "label_kaydol";
            this.label_kaydol.Size = new System.Drawing.Size(122, 21);
            this.label_kaydol.TabIndex = 4;
            this.label_kaydol.Text = "Hemen kaydol »";
            this.label_kaydol.Click += new System.EventHandler(this.Label_kaydol_Click);
            // 
            // label_giris_aciklama1
            // 
            this.label_giris_aciklama1.BackColor = System.Drawing.Color.Transparent;
            this.label_giris_aciklama1.ForeColor = System.Drawing.Color.White;
            this.label_giris_aciklama1.Location = new System.Drawing.Point(1, 159);
            this.label_giris_aciklama1.Name = "label_giris_aciklama1";
            this.label_giris_aciklama1.Size = new System.Drawing.Size(508, 146);
            this.label_giris_aciklama1.TabIndex = 21;
            this.label_giris_aciklama1.Text = "Programa hızlıca giriş yapabilirsiniz.";
            // 
            // Form_giris
            // 
            this.AcceptButton = this.button_girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel254v2.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.label_giris_aciklama1);
            this.Controls.Add(this.label_kaydol);
            this.Controls.Add(this.label_giris_burada_yeni_misin);
            this.Controls.Add(this.label_giris_sifreni_mi_unuttun);
            this.Controls.Add(this.button_girisYap);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_giris);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.label_pr_adi);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_pr_adi_giris);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_giris";
            this.Text = "Türkiye\'nin Yerli ve Milli X Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_giris_FormClosing);
            this.Load += new System.EventHandler(this.Form_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label_pr_adi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_pr_adi_giris;
        private System.Windows.Forms.TextBox textBox_giris;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button_girisYap;
        private System.Windows.Forms.Label label_giris_sifreni_mi_unuttun;
        private System.Windows.Forms.Label label_giris_burada_yeni_misin;
        private System.Windows.Forms.Label label_kaydol;
        private System.Windows.Forms.Label label_giris_aciklama1;
    }
}