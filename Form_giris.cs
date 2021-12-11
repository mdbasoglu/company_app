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
    public partial class Form_giris : Form
    {
        public Form_giris()
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

        private void Form_giris_Load(object sender, EventArgs e)
        {
        }

        private void Form_giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void TextBox_giris_TextChanged(object sender, EventArgs e)
        {
            if (textBox_giris.Text == "") textBox_giris.Text = "Telefon, e-posta veya kullanıcı adı";
        }

        private void Label_kaydol_Click(object sender, EventArgs e)
        {
            kontrol.formAc(this, degiskenler.frm_kaydol);
        }

        private void Button_geri_Click(object sender, EventArgs e)
        {
            kontrol.formAc(this, degiskenler.frm_baslangic);
        }

        private void Button_girisYap_Click(object sender, EventArgs e)
        {
            if (textBox_giris.Text == "" || textBox_sifre.Text == "")
            {
                kontrol.uyariMesajiVer("messageBox_bos_alan_mevcut");
            }
            else
            {
                bool firmaGirisi = true;
                try
                {
                    degiskenler.baglanti.Open();
                    degiskenler.komut = new MySqlCommand("Select * from program_yoneticileri where yonetici_kullanici_adi=@yonetici_kullanici_adi", degiskenler.baglanti);
                    degiskenler.komut.Parameters.AddWithValue("@yonetici_kullanici_adi", textBox_giris.Text);

                    degiskenler.dr = degiskenler.komut.ExecuteReader();
                    if (degiskenler.dr.Read())
                    {
                        if (degiskenler.dr["yonetici_sifre"].ToString() == textBox_sifre.Text)
                        {
                            kontrol.formAc(this, degiskenler.frm_adminMain);
                            degiskenler.frm_adminMain.label_isimlik.Text = textBox_giris.Text;
                            firmaGirisi = false;
                        }
                    }
                    else
                    {
                        firmaGirisi = true;
                    }
                    degiskenler.baglanti.Close();
                    if (firmaGirisi == false)
                    {
                        kontrol.dilVerPanele(degiskenler.frm_adminMain.pnlDrawer);
                    }
                }
                catch (Exception)
                {
                }

                bool hataliSifre = false;
                if (firmaGirisi == true)
                {
                    bool onayUyarisi = false;
                    bool sktUyarisi = false;
                    degiskenler.baglanti.Open();
                    degiskenler.komut = new MySqlCommand("Select * from firma_sahibi where firma_sahibi_kullanici_adi=@firma_sahibi_kullanici_adi and firma_sahibi_sifre=@firma_sahibi_sifre", degiskenler.baglanti);
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_kullanici_adi", textBox_giris.Text);
                    degiskenler.komut.Parameters.AddWithValue("@firma_sahibi_sifre", textBox_sifre.Text);
                    degiskenler.dr = degiskenler.komut.ExecuteReader();
                    if (degiskenler.dr.Read())
                    {
                        if (degiskenler.dr["firma_sahibi_onay_durumu"].ToString() == "1" && Convert.ToDateTime(degiskenler.dr["firma_sahibi_program_son_kullanma_tarihi"].ToString()) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        {
                            kontrol.formAc(this, degiskenler.frm_main);
                            degiskenler.frm_adminMain.label_isimlik.Text = textBox_giris.Text;
                            hataliSifre = false;
                        }
                        else if (degiskenler.dr["firma_sahibi_onay_durumu"].ToString() == "0")
                        {
                            onayUyarisi = true;
                            hataliSifre = false;
                        }
                        else if (Convert.ToDateTime(degiskenler.dr["firma_sahibi_program_son_kullanma_tarihi"].ToString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        {
                            sktUyarisi = true;
                        }
                    }
                    else
                    {
                        hataliSifre = true;
                    }
                    degiskenler.baglanti.Close();
                    if (hataliSifre == false)
                    {
                        //kontrol.ayarVer(degiskenler.frm_main);
                        //kontrol.dilVerPanele(degiskenler.frm_main.pnlDrawer);

                        degiskenler.baglanti.Open();
                        degiskenler.komut = new MySqlCommand("SELECT * FROM duyuru", degiskenler.baglanti);
                        degiskenler.dr = degiskenler.komut.ExecuteReader();
                        if (degiskenler.dr.Read())
                        {
                            if (degiskenler.dr["duyuru_bilgi"].ToString() == "")
                            {
                                degiskenler.frm_main.label_duyuru.Visible = false;
                            }
                            else
                            {
                                degiskenler.frm_main.label_duyuru.Visible = true;
                                degiskenler.frm_main.label_duyuru.Text = degiskenler.dr["duyuru_bilgi"].ToString();
                            }
                        }
                        degiskenler.baglanti.Close();
                    }
                    if (onayUyarisi == true) kontrol.uyariMesajiVer("messageBox_onay_uyari");
                    if (hataliSifre == true) kontrol.uyariMesajiVer("messageBpx_hatalı_kullanici_adi_veya_sifre");
                    if (sktUyarisi == true) kontrol.uyariMesajiVer("messageBox_son_kullanma_tarihi");
                }
            }
            // Son işlem sıfırlama
            textBox_giris.Text = "Telefon, e-posta veya kullanıcı adı";
            textBox_sifre.Text = "Şifre";
        }

        private void Label_sifrenimiUnuttun_Click(object sender, EventArgs e)
        {
            kontrol.formAc(this,degiskenler.frm_sifremiUnuttum);
        }

    }
}
