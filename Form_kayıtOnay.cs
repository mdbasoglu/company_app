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
    public partial class Form_kayıtOnay : Form
    {
        public Form_kayıtOnay()
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

        private void Form_kayıtOnay_Load(object sender, EventArgs e)
        {
        }

        private void Button_giriseDon_Click(object sender, EventArgs e)
        {
            kontrol.formAc(this, degiskenler.frm_giris);
        }

        private void Form_kayıtOnay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
