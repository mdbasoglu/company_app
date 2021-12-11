namespace Otel254v2
{
    partial class Form_profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_profil));
            this.button_profil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_profil
            // 
            this.button_profil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_profil.AutoSize = true;
            this.button_profil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_profil.BackColor = System.Drawing.Color.Red;
            this.button_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_profil.ForeColor = System.Drawing.Color.White;
            this.button_profil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_profil.Location = new System.Drawing.Point(629, 0);
            this.button_profil.Name = "button_profil";
            this.button_profil.Size = new System.Drawing.Size(82, 31);
            this.button_profil.TabIndex = 26;
            this.button_profil.Text = "Çıkış yap";
            this.button_profil.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "Fotoğrafı değiştir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel254v2.Properties.Resources.arkaplan2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_profil);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_profil;
        private System.Windows.Forms.Button button1;
    }
}