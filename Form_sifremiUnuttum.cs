using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel254v2
{
    public partial class Form_sifremiUnuttum : Form
    {
        public Form_sifremiUnuttum()
        {
            InitializeComponent();
            this.MouseDown += Form_giris_MouseDown;
            this.MouseMove += Form_giris_MouseMove;
            this.MouseUp += Form_giris_MouseUp;
        }

        #region Formu Gövdeden Sürükleme İşlemi
        bool suruklenme = false; // Sürükleme ile ilgili bool değişkeni
        Point ilkkonum;
        private void Form_giris_MouseDown(object sender, MouseEventArgs e)
        {
            suruklenme = true; // Butona basıldığında suruklenmeyi aktif ettik.
            ilkkonum = e.Location; // Mousenin ilk konumunu belirledil.
        }
        private void Form_giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (suruklenme == true) // Sürüklenme aktifse yani mouseye basılıyorsa
            {
                this.Left = e.X + this.Left - (ilkkonum.X); // Butonun left ten uzaklığını veriyoruz.
                this.Top = e.Y + this.Top - (ilkkonum.Y); // Aynı şekilde üstten
            }
        }
        private void Form_giris_MouseUp(object sender, MouseEventArgs e)
        {
            suruklenme = false;  // Sürüklenmeyi bitiriyoruz.
        }
        #endregion

        private void Button_geri_Click(object sender, EventArgs e)
        {
            kontrol.formAc(this, degiskenler.frm_baslangic);
            textBox_ePosta.Text = "E-posta adresi";
        }

        private void Button_gonder_Click(object sender, EventArgs e)
        {
            if (!kontrol.Email(textBox_ePosta.Text)) // eposta formatını kontrol ettirdik.
            {
                kontrol.textboxiKizart(textBox_ePosta);
            }
            else // eposta formatı doğruysa veritabanı kontrolü yapacağız.
            {

            }
        }

        private void Label_buBilgiyeErisimimYok_Click(object sender, EventArgs e)
        {
            kontrol.uyariMesajiVer("label_sifremiUnuttum_aciklama4");
        }

        private void Form_sifremiUnuttum_Load(object sender, EventArgs e)
        {
        }
    }
}
