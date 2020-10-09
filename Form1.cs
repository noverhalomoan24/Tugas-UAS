using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UAS
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void DB_Click(object sender, EventArgs e)
        {
            //code tidak jadi digunakan
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan fpelanggan = new Pelanggan();//deklarasi form Pelanggan
            fpelanggan.Show();//menampilkan form Pelanggan
        }

        private void diskonUntukPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Diskon_Merek_Untuk_Pelanggan finputDiskon = new Input_Diskon_Merek_Untuk_Pelanggan(); //deklarasi form Input_Diskon_Merek_Untuk_Pelanggan 

            finputDiskon.Show();//menampilkan form Input_Diskon_Merek_Untuk_Pelanggan
        }
    }
}
