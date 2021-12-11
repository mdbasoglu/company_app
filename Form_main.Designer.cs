namespace Otel254v2
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.pnlDrawer = new System.Windows.Forms.Panel();
            this.label_isimlik = new System.Windows.Forms.Label();
            this.label_duyuru = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.button_profil = new System.Windows.Forms.Button();
            this.button_kadro = new System.Windows.Forms.Button();
            this.button_musteriler = new System.Windows.Forms.Button();
            this.button_istatistik = new System.Windows.Forms.Button();
            this.button_odalar = new System.Windows.Forms.Button();
            this.button_mesajlar = new System.Windows.Forms.Button();
            this.btnToggleDrawer = new System.Windows.Forms.Label();
            this.pictureBox_profilResimi = new System.Windows.Forms.PictureBox();
            this.pnlDrawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilResimi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrawer
            // 
            this.pnlDrawer.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawer.Controls.Add(this.button_ayarlar);
            this.pnlDrawer.Controls.Add(this.button_profil);
            this.pnlDrawer.Controls.Add(this.button_kadro);
            this.pnlDrawer.Controls.Add(this.button_musteriler);
            this.pnlDrawer.Controls.Add(this.button_istatistik);
            this.pnlDrawer.Controls.Add(this.button_odalar);
            this.pnlDrawer.Controls.Add(this.button_mesajlar);
            this.pnlDrawer.Controls.Add(this.btnToggleDrawer);
            this.pnlDrawer.Controls.Add(this.label_isimlik);
            this.pnlDrawer.Controls.Add(this.pictureBox_profilResimi);
            this.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrawer.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawer.Name = "pnlDrawer";
            this.pnlDrawer.Size = new System.Drawing.Size(233, 681);
            this.pnlDrawer.TabIndex = 3;
            // 
            // label_isimlik
            // 
            this.label_isimlik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_isimlik.ForeColor = System.Drawing.Color.Black;
            this.label_isimlik.Location = new System.Drawing.Point(6, 114);
            this.label_isimlik.Name = "label_isimlik";
            this.label_isimlik.Size = new System.Drawing.Size(224, 35);
            this.label_isimlik.TabIndex = 1;
            this.label_isimlik.Text = "İsim Soyisim";
            this.label_isimlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_duyuru
            // 
            this.label_duyuru.BackColor = System.Drawing.Color.DarkCyan;
            this.label_duyuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_duyuru.ForeColor = System.Drawing.SystemColors.Control;
            this.label_duyuru.Location = new System.Drawing.Point(233, 647);
            this.label_duyuru.Name = "label_duyuru";
            this.label_duyuru.Size = new System.Drawing.Size(711, 34);
            this.label_duyuru.TabIndex = 5;
            this.label_duyuru.Text = "Duyuru varsa burada görünecektir.";
            this.label_duyuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_duyuru.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Otel254v2.Properties.Resources.arkaplan2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 681);
            this.panel1.TabIndex = 4;
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ayarlar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ayarlar.Image = global::Otel254v2.Properties.Resources.settings_50px;
            this.button_ayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ayarlar.Location = new System.Drawing.Point(0, 476);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(233, 54);
            this.button_ayarlar.TabIndex = 28;
            this.button_ayarlar.Text = "Ayarlar";
            this.button_ayarlar.UseVisualStyleBackColor = false;
            // 
            // button_profil
            // 
            this.button_profil.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_profil.ForeColor = System.Drawing.Color.White;
            this.button_profil.Image = global::Otel254v2.Properties.Resources.profiles_50px;
            this.button_profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profil.Location = new System.Drawing.Point(0, 152);
            this.button_profil.Name = "button_profil";
            this.button_profil.Size = new System.Drawing.Size(233, 54);
            this.button_profil.TabIndex = 25;
            this.button_profil.Text = "Profil";
            this.button_profil.UseVisualStyleBackColor = false;
            this.button_profil.Click += new System.EventHandler(this.Button_profil_Click);
            // 
            // button_kadro
            // 
            this.button_kadro.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_kadro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kadro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kadro.ForeColor = System.Drawing.SystemColors.Window;
            this.button_kadro.Image = global::Otel254v2.Properties.Resources.checklist_100px;
            this.button_kadro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kadro.Location = new System.Drawing.Point(0, 206);
            this.button_kadro.Name = "button_kadro";
            this.button_kadro.Size = new System.Drawing.Size(233, 54);
            this.button_kadro.TabIndex = 21;
            this.button_kadro.Text = "Kadro";
            this.button_kadro.UseVisualStyleBackColor = false;
            // 
            // button_musteriler
            // 
            this.button_musteriler.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_musteriler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_musteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_musteriler.ForeColor = System.Drawing.SystemColors.Window;
            this.button_musteriler.Image = global::Otel254v2.Properties.Resources.envelope_50px;
            this.button_musteriler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_musteriler.Location = new System.Drawing.Point(0, 260);
            this.button_musteriler.Name = "button_musteriler";
            this.button_musteriler.Size = new System.Drawing.Size(233, 54);
            this.button_musteriler.TabIndex = 24;
            this.button_musteriler.Text = "Müşteriler";
            this.button_musteriler.UseVisualStyleBackColor = false;
            // 
            // button_istatistik
            // 
            this.button_istatistik.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_istatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_istatistik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_istatistik.ForeColor = System.Drawing.SystemColors.Window;
            this.button_istatistik.Image = global::Otel254v2.Properties.Resources.price_tag_50px;
            this.button_istatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_istatistik.Location = new System.Drawing.Point(0, 314);
            this.button_istatistik.Name = "button_istatistik";
            this.button_istatistik.Size = new System.Drawing.Size(233, 54);
            this.button_istatistik.TabIndex = 23;
            this.button_istatistik.Text = "İstatistik";
            this.button_istatistik.UseVisualStyleBackColor = false;
            // 
            // button_odalar
            // 
            this.button_odalar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_odalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_odalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_odalar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_odalar.Image = global::Otel254v2.Properties.Resources.customer_support_80px;
            this.button_odalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_odalar.Location = new System.Drawing.Point(0, 368);
            this.button_odalar.Name = "button_odalar";
            this.button_odalar.Size = new System.Drawing.Size(233, 54);
            this.button_odalar.TabIndex = 22;
            this.button_odalar.Text = "Toplantı";
            this.button_odalar.UseVisualStyleBackColor = false;
            // 
            // button_mesajlar
            // 
            this.button_mesajlar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_mesajlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mesajlar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_mesajlar.ForeColor = System.Drawing.SystemColors.Window;
            this.button_mesajlar.Image = global::Otel254v2.Properties.Resources.language_100px;
            this.button_mesajlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mesajlar.Location = new System.Drawing.Point(0, 422);
            this.button_mesajlar.Name = "button_mesajlar";
            this.button_mesajlar.Size = new System.Drawing.Size(233, 54);
            this.button_mesajlar.TabIndex = 20;
            this.button_mesajlar.Text = "Mesajlar";
            this.button_mesajlar.UseVisualStyleBackColor = false;
            // 
            // btnToggleDrawer
            // 
            this.btnToggleDrawer.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnToggleDrawer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnToggleDrawer.ForeColor = System.Drawing.Color.Black;
            this.btnToggleDrawer.Image = global::Otel254v2.Properties.Resources.menu_64px;
            this.btnToggleDrawer.Location = new System.Drawing.Point(12, 9);
            this.btnToggleDrawer.Name = "btnToggleDrawer";
            this.btnToggleDrawer.Size = new System.Drawing.Size(27, 27);
            this.btnToggleDrawer.TabIndex = 8;
            this.btnToggleDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggleDrawer.Click += new System.EventHandler(this.BtnToggleDrawer_Click);
            // 
            // pictureBox_profilResimi
            // 
            this.pictureBox_profilResimi.Image = global::Otel254v2.Properties.Resources.logo;
            this.pictureBox_profilResimi.Location = new System.Drawing.Point(69, 12);
            this.pictureBox_profilResimi.Name = "pictureBox_profilResimi";
            this.pictureBox_profilResimi.Size = new System.Drawing.Size(99, 99);
            this.pictureBox_profilResimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profilResimi.TabIndex = 0;
            this.pictureBox_profilResimi.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.label_duyuru);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDrawer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.Resize += new System.EventHandler(this.Form_main_Resize);
            this.pnlDrawer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profilResimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_ayarlar;
        private System.Windows.Forms.Button button_profil;
        private System.Windows.Forms.Button button_kadro;
        private System.Windows.Forms.Button button_musteriler;
        private System.Windows.Forms.Button button_istatistik;
        private System.Windows.Forms.Button button_odalar;
        private System.Windows.Forms.Button button_mesajlar;
        private System.Windows.Forms.Label btnToggleDrawer;
        public System.Windows.Forms.Label label_isimlik;
        private System.Windows.Forms.PictureBox pictureBox_profilResimi;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlDrawer;
        public System.Windows.Forms.Label label_duyuru;
    }
}