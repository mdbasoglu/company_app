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
    class degiskenler
    {
        public static MySqlConnectionStringBuilder csb; // Global veritabanı değişkenlerimiz
        public static MySqlConnection baglanti;
        public static MySqlCommand komut;
        public static MySqlDataReader dr;

        public static string pr_adi = "Misafir - Firma Yönetim";
        public static string pr_surumu = "v1.0";
        public static string pr_baslik = "Tek kullanıcılı deneme sürümü - Firma Yönetim";
        public static string pr_webSite = "https://www.projevekod.com";
        public static string pr_mailAdresi = "projevekod@projevekod.com";
        public static string pr_simgesi = "Simge şuan aktif değildir.";


        public static string girisYapanKullaniciAdi = "Misafir";

        #region Form Değişkenleri
        public static Form_baslangic frm_baslangic = new Form_baslangic();
        public static Form_giris frm_giris = new Form_giris();
        public static Form_kaydol frm_kaydol = new Form_kaydol();
        public static Form_sifremiUnuttum frm_sifremiUnuttum = new Form_sifremiUnuttum();
        public static Form_kayıtOnay frm_kayitOnay = new Form_kayıtOnay();
        public static Form_main frm_main = new Form_main();
        public static Form_adminMain frm_adminMain = new Form_adminMain();
        public static Form_profil frm_profil = new Form_profil();
        #endregion
    }
}
