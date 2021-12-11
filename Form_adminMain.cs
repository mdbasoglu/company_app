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
    public partial class Form_adminMain : Form
    {
        public Form_adminMain()
        {
            InitializeComponent();
        }

        private void Form_adminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form_adminMain_Load(object sender, EventArgs e)
        {
           
        }

        private void Form_adminMain_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width <= 960 || this.Size.Height <= 720)
            {
                this.Size = new Size(960, 720);
            }
        }
        bool DrawerOpen = true;
        private void BtnToggleDrawer_Click(object sender, EventArgs e)
        {
            DrawerOpen = !DrawerOpen;
            //pnlDrawer.Visible = false;

            if (DrawerOpen)
            {
                //animated Drawer Open
                pnlDrawer.Width = 233;
                //btnToggleDrawer.Image = imageList1.Images[0];
            }
            else
            {
                //Aminated Drawer close
                pnlDrawer.Width = 56;
                ///btnToggleDrawer.Image = imageList1.Images[1];
            }
        }

        private void menuler(object sender, EventArgs e)
        {
            
        }

        private void Button_profil_Click(object sender, EventArgs e)
        {
        }
    }
}
