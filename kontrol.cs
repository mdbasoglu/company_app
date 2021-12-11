using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Otel254v2
{
    class kontrol
    {
        public static bool Email(string s)
        {
            return Regex.IsMatch(s, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static void formAc(Form kapatilan, Form acilan)
        {
            acilan.Location = kapatilan.Location;
            kapatilan.Hide();
            acilan.Show();
        }
        public static void textboxiKizart(TextBox t)
        {
            t.BackColor = Color.Red;
            t.ForeColor = Color.White;
        }
        public static void textboxiBeyazlat(TextBox t)
        {
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }
        public static void uyariMesajiVer(string veritabani_dil_nesne_name)
        {
            string uyariIcerik = "";
            string uyariBaslik = "";
            degiskenler.baglanti.Open();
            degiskenler.komut = new MySqlCommand("SELECT dil.dil_nesne_degeri FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1 and dil.dil_nesne_name='"+ veritabani_dil_nesne_name + "'", degiskenler.baglanti);
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
            MessageBox.Show(uyariIcerik, uyariBaslik,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void textboxlariSifirla(Form formAdi)
        {
            foreach (Control item in formAdi.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = item as TextBox;
                    t.Text = "";
                }
            }
        }
        public static void ayarVer(Form formAdi)
        {
            try
            {
                foreach (Control item in formAdi.Controls)
                {
                    if (item is Label)
                    {
                        Label l = item as Label;
                        if (l.Name == "label_pr_adi") l.Text = degiskenler.pr_adi;
                        if (l.Name == "label_pr_adi_giris" && formAdi.Name == "Form_giris")
                        {
                            degiskenler.baglanti.Open();
                            degiskenler.komut = new MySqlCommand("SELECT dil.dil_nesne_degeri FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1 and dil.dil_nesne_name='button_girisYap'", degiskenler.baglanti);
                            degiskenler.dr = degiskenler.komut.ExecuteReader();
                            if (degiskenler.dr.Read())
                            {
                                l.Text = degiskenler.pr_adi + "'e " + degiskenler.dr["dil_nesne_degeri"].ToString();
                            }
                            degiskenler.baglanti.Close();
                            
                        }
                        if (l.Name == "label_pr_surumu") l.Text = degiskenler.pr_surumu;
                        if (l.Name == "label_pr_baslik") l.Text = degiskenler.pr_baslik;
                        if (l.Name == "label_pr_mailAdresi") l.Text = degiskenler.pr_mailAdresi;
                        if (l.Name == "label_pr_webSite") l.Text = degiskenler.pr_webSite;
                    }
                }
                formAdi.Text = degiskenler.pr_baslik;

                #region Dil ayarları --- 
                degiskenler.baglanti.Open();
                degiskenler.komut = new MySqlCommand("SELECT * FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1", degiskenler.baglanti);
                degiskenler.dr = degiskenler.komut.ExecuteReader();
                while (degiskenler.dr.Read())
                {
                    foreach (Control item in formAdi.Controls)
                    {
                        if (item.Name == degiskenler.dr["dil_nesne_name"].ToString())
                        {
                            item.Text = degiskenler.dr["dil_nesne_degeri"].ToString();
                        }
                    }
                }
                degiskenler.baglanti.Close();
                #endregion // Dil ayarları
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        public static void dilVerPanele(Panel p)
        {
            try
            {
                #region Dil ayarları --- 
                degiskenler.baglanti.Open();
                degiskenler.komut = new MySqlCommand("SELECT * FROM dil INNER JOIN dil_ayar ON dil.dil_adi = dil_ayar.dil_adi where dil_ayar.aktif = 1", degiskenler.baglanti);
                degiskenler.dr = degiskenler.komut.ExecuteReader();
                while (degiskenler.dr.Read())
                {
                    foreach (Control item in p.Controls)
                    {
                        if (item.Name == degiskenler.dr["dil_nesne_name"].ToString())
                        {
                            item.Text = degiskenler.dr["dil_nesne_degeri"].ToString();
                        }
                    }
                }
                degiskenler.baglanti.Close();
                #endregion // Dil ayarları
            }
            catch (Exception ex) {}
        }


        public static bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void paneldeFormAc(Form Acilacak,Panel p)
        {
            Acilacak.TopLevel = false;
            p.Controls.Add(Acilacak); // panel1 içerisinde formu ekledik

            Acilacak.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            Acilacak.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            Acilacak.BringToFront(); // formu panel içinde en öne getirdik
        }
    }
}
