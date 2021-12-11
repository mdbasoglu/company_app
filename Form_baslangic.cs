using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Otel254v2
{
    public partial class Form_baslangic : Form
    {
        public Form_baslangic()
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

        public static void tekKullaniciModuBaslangic(string mesajIcerigi,string mesajBasligi)
        {
            MessageBox.Show(mesajIcerigi, mesajBasligi, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void PictureBox_kapat_Click(object sender, EventArgs e) { Application.ExitThread(); }

        bool tiklamaAktifligi = false;
        //Eğer internet varsa true yoksa false değeri gelecek. Bunu if ile kontrol edelim
        private void Form_baslangic_Load(object sender, EventArgs e)
        {

            label_baslangic_misafir_olarak_devam_et.Visible = false;
            bool internetDenetleme = kontrol.InternetKontrol(); // Kontrol fonksiyonumuzu çağırdık.
            bool sunucuDenetleme = true; // sunucu varsayılan olarak açık şuan
                                         /* if (internetDenetleme == true) // internet var ise bunu true yap
                                          {*/
            degiskenler.csb = new MySqlConnectionStringBuilder();
            degiskenler.csb.Server = "localhost";
            degiskenler.csb.UserID = "root";
            degiskenler.csb.Password = "";
            degiskenler.csb.Database = "254company";
            degiskenler.baglanti = new MySqlConnection(degiskenler.csb.ConnectionString);// Veritabanı bağlantı ayarları
                                                                                         /*  try
                                                                                           {*/
            degiskenler.baglanti.Open();
            degiskenler.komut = new MySqlCommand("Select * from ayarlar", degiskenler.baglanti);
            degiskenler.dr = degiskenler.komut.ExecuteReader();
            if (degiskenler.dr.Read())
            {
                degiskenler.pr_adi = degiskenler.dr["pr_adi"].ToString();
                degiskenler.pr_surumu = degiskenler.dr["pr_surumu"].ToString();
                degiskenler.pr_baslik = degiskenler.dr["pr_baslik"].ToString();
                degiskenler.pr_webSite = degiskenler.dr["pr_webSite"].ToString();
                degiskenler.pr_mailAdresi = degiskenler.dr["pr_mailAdresi"].ToString();
                degiskenler.pr_simgesi = degiskenler.dr["pr_simgesi"].ToString();
            }
            degiskenler.baglanti.Close();

            kontrol.ayarVer(degiskenler.frm_sifremiUnuttum);
            kontrol.ayarVer(degiskenler.frm_main);
            kontrol.dilVerPanele(degiskenler.frm_main.pnlDrawer);
            kontrol.ayarVer(degiskenler.frm_adminMain);
            kontrol.dilVerPanele(degiskenler.frm_adminMain.pnlDrawer);
            kontrol.ayarVer(degiskenler.frm_kaydol);
            kontrol.ayarVer(degiskenler.frm_giris);
            kontrol.ayarVer(degiskenler.frm_baslangic);
            kontrol.ayarVer(degiskenler.frm_kayitOnay);

            tiklamaAktifligi = sunucuDenetleme = true;
            button_kaydol.Cursor = button_girisYap.Cursor = Cursors.Default;
            label_baslangic_misafir_olarak_devam_et.Visible = false;
            /* }
             catch (Exception)// Sunucuya ulaşılmadıysa program kapalıdır.
             {
                 kontrol.uyariMesajiVer("messageBox_sunucu_kapali");
                 sunucuDenetleme = false;
             }
         }
         if(sunucuDenetleme == false || internetDenetleme == true) // sunucu veya internet yoksa misafir modu
         {
             tiklamaAktifligi = false;
             button_kaydol.Cursor = button_girisYap.Cursor = Cursors.No;
             label_baslangic_misafir_olarak_devam_et.Visible = true;
         }*/
            kontrol.ayarVer(this);
        }

        private void Button_kaydol_Click(object sender, EventArgs e)
        {
            if (tiklamaAktifligi == true)
            {
                kontrol.formAc(this, degiskenler.frm_kaydol);
                //kontrol.ayarVer(degiskenler.frm_kaydol);
            }
        }

        private void Button_girisYap_Click(object sender, EventArgs e)
        {
            if (tiklamaAktifligi == true) {
                kontrol.formAc(this, degiskenler.frm_giris);
               // kontrol.ayarVer(degiskenler.frm_giris);
            }
        }
    }
}
