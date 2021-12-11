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
    public partial class Form_kaydol : Form
    {
        public Form_kaydol()
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

        private void Form_kaydol_Load(object sender, EventArgs e)
        {
        }

        private void Button_geri_Click(object sender, EventArgs e)
        {
            string uyariIcerik = "";
            string uyariBaslik = "";
            degiskenler.baglanti.Open();
            degiskenler.komut = new MySqlCommand("SELECT dil.dil_nesne_degeri FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1 and dil.dil_nesne_name='messageBox_degisiklikler_kaybedilecektir'", degiskenler.baglanti);
            degiskenler.dr = degiskenler.komut.ExecuteReader();
            if (degiskenler.dr.Read())
            {
                uyariIcerik = degiskenler.dr["dil_nesne_degeri"].ToString();
            }
            degiskenler.baglanti.Close();
            degiskenler.baglanti.Open();
            degiskenler.komut = new MySqlCommand("SELECT dil.dil_nesne_degeri FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1 and dil.dil_nesne_name='messageBox_uyari_basligi'", degiskenler.baglanti);
            degiskenler.dr = degiskenler.komut.ExecuteReader();
            if (degiskenler.dr.Read())
            {
                uyariBaslik = degiskenler.dr["dil_nesne_degeri"].ToString();
            }
            degiskenler.baglanti.Close();
            DialogResult diares = MessageBox.Show(uyariIcerik, uyariBaslik, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (diares == DialogResult.Yes)
            {
                kontrol.formAc(this, degiskenler.frm_baslangic);
                kontrol.textboxlariSifirla(this);
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox t = item as TextBox;
                        kontrol.textboxiBeyazlat(t);
                    }
                }
                textBox_telefon.Text = "+905";
            }
        }

        private void Form_kaydol_FormClosing(object sender, FormClosingEventArgs e)
        {
           e.Cancel = true;
            this.Hide();
        }

        private void TextBox_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == 8 && textBox_telefon.TextLength <= 4)
            {
                e.Handled = true;
            }
        }

        private void Button_ileri_Click(object sender, EventArgs e)
        {

            #region Boş Textbox Kontrol İşlemi
            bool bosTextboxVar = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    if (item.Text == "" || item.Text =="+905")
                    {
                        bosTextboxVar = true;
                        kontrol.textboxiKizart(t);
                    }
                    else
                    {
                        item.Text.Trim();
                        kontrol.textboxiBeyazlat(t);
                    }
                }
            }
            #endregion
            // Yukarda ki  foreach kontrolü ile textboxlar boş mu dolumu kontrol ettik. Boşsa kırmızı arkaplan beyaz yazı, doluysa beyaz arkaplan siyah yazı rengi yaptık
            if (bosTextboxVar) kontrol.uyariMesajiVer("messageBox_bos_alan_mevcut"); // boş textbox varsa uyarı verdi
            // Bir alt satırda ki kod okudum anladım işareti işaretlenmediyse hata verdirdik.
            else if (checkBox_kaydol_aciklama11.Checked == false) kontrol.uyariMesajiVer("messageBox_kullanici_sozlesmesi");
            else if (!kontrol.Email(textBox_kaydol_ePosta.Text)) // eposta formatını kontrol ettirdik.
            {
                kontrol.uyariMesajiVer("messageBox_hatali_mail");
                kontrol.textboxiKizart(textBox_kaydol_ePosta);
            }
            else if (textBox_kullaniciAdi.Text.Length < 6 || textBox_kaydol_sifre.Text.Length < 6)
            {
                kontrol.uyariMesajiVer("messageBox_kullanici_adi_sifre_eksik");
            }
            else if (textBox_kaydol_sifre.Text != textBox_sifreTekrar.Text)
            {
                kontrol.uyariMesajiVer("messageBox_sifreler_uyusmuyor");
            }
            else // her şey hazır gibi duruyor başlayabiliriz.
            {
                try
                {
                    degiskenler.baglanti.Open();
                    degiskenler.komut = new MySqlCommand("INSERT INTO firma_sahibi(firma_sahibi_ad,firma_sahibi_soyad,firma_sahibi_kullanici_adi,firma_sahibi_telefon_numarasi,firma_sahibi_sifre,firma_sahibi_eposta,firma_sahibi_isletme_adi,firma_sahibi_kayit_tarihi,firma_sahibi_onay_durumu) " +
                        "values(@firma_sahibi_ad,@firma_sahibi_soyad," +
                        "@firma_sahibi_kullanici_adi,@firma_sahibi_telefon_numarasi,@firma_sahibi_sifre,@firma_sahibi_eposta," +
                        "@firma_sahibi_isletme_adi,@firma_sahibi_kayit_tarihi,'0')", degiskenler.baglanti);
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_ad", textBox_ad.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_soyad", textBox_soyad.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_kullanici_adi", textBox_kullaniciAdi.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_telefon_numarasi", textBox_telefon.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_sifre", textBox_kaydol_sifre.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_eposta", textBox_kaydol_ePosta.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_isletme_adi", textBox_isletmeAdi.Text.Trim());
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_kayit_tarihi", DateTime.Now.ToShortDateString());
                    degiskenler.komut.ExecuteNonQuery();
                    degiskenler.baglanti.Close();
                    kontrol.formAc(this, degiskenler.frm_kayitOnay);
                }
                catch (Exception)
                {
                    kontrol.uyariMesajiVer("messageBox_bilinmeyen_bir_hata_olustu");
                }

                kontrol.textboxlariSifirla(this);
                // Son işlem sıfırlama
            }
        }

        private void TextBox_telefon_TextChanged(object sender, EventArgs e)
        {
            if (textBox_telefon.TextLength <= 4)
            {
                textBox_telefon.Text = "+905";
            }
        }
    }
}
