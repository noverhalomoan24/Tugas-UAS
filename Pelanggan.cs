using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UAS
{
    public partial class Pelanggan : Form
    {
        SqlConnection conn;//digunakan untuk koneksi ke database ini merupakan deklarasi variabel
        SqlDataAdapter da; //mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
        SqlDataReader dr;//dekllarasi variabel yang digunakan untuk membaca data pada sql
        public Pelanggan()
        {
            InitializeComponent();
            
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//path yang digunakan untuk mengkoneksikan sql server to c#
            da = new SqlDataAdapter(); //deklarasi dari data adapter
            conn.Open();//melakukan buka database yang akan dibaca
            bool benar = true;//variabel boolean
            string lihat = String.Format("select * from Pelanggan");//string yang digunakan untuk membaca isi dari tabel
            SqlCommand cm = new SqlCommand(lihat, conn); //melakukan pengiriman data ke sql
            dr = cm.ExecuteReader();//mulai melakukan pembacaan file
            
            DataTable DataTampilPel = new DataTable();//deklarasi tabe;
            DataTampilPel.Columns.Add("Kode");//deklarasi kolom kode
            DataTampilPel.Columns.Add("Nama");//deklarasi kolom nama
            DataTampilPel.Columns.Add("Kota");//deklarasi kolom kota
            DataTampilPel.Columns.Add("Tgl Registrasi");//deklarasi kolom tanggal registrasi
            DataTampilPel.Columns.Add("Tipe"); //deklarasi kolom tipe

            while (dr.Read())//membaca tavel pada sql berdasarkan baris
            {
                DataRow rows_pelanggan = DataTampilPel.NewRow();//melakukan deklarasi baris
                rows_pelanggan["Kode"] = dr.GetSqlString(0);//mengsi baris, pada setiap kolom kode
                rows_pelanggan["Nama"] = dr.GetSqlString(1);//mengsi baris, pada setiap kolom nama
                rows_pelanggan["Kota"] = dr.GetSqlString(2);//mengsi baris, pada setiap kolom kota
                rows_pelanggan["Tgl Registrasi"] = dr.GetValue(3);//mengsi baris, pada setiap kolom tgl registrasi
                if (dr.GetSqlString(4) == "1") //melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Basic";//mengsi baris, pada setiap kolom tipe
                }
                if (dr.GetSqlString(4) == "2")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Silver";//mengsi baris, pada setiap kolom tipe
                }
                if (dr.GetSqlString(4) == "3")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Gold";//mengsi baris, pada setiap kolom tipe
                }
                DataTampilPel.Rows.Add(rows_pelanggan); //manyatukan setiap baris sesuai kolom
                benar = false;//mengecek apakah database ada data
            }
            dgv_tampil.DataSource = DataTampilPel;//melakukan collection terhadap data untuk ditampilkan datagridview
            if(benar==false)//kondisi jika benar
            {
                MessageBox.Show("Selmat Datang SQL Running......!!!");//message box
            }
          
            conn.Close();//keluar dari databse
        }

        private void cetak()//prosedur untuk mencetak ke data gridview
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//path yang digunakan untuk mengkoneksikan sql server to c#            
            conn.Open();//melakukan buka database yang akan dibaca
            da = new SqlDataAdapter(); //deklarasi dari data adapter
            string lihat = String.Format("select * from Pelanggan");//string yang digunakan untuk membaca isi dari tabel
            SqlCommand cm = new SqlCommand(lihat, conn); //melakukan pengiriman data ke sql
            dr = cm.ExecuteReader();//mulai melakukan pembacaan file

            DataTable DataTampilPel = new DataTable();//deklarasi tabe;
            DataTampilPel.Columns.Add("Kode");//deklarasi kolom kode
            DataTampilPel.Columns.Add("Nama");//deklarasi kolom nama
            DataTampilPel.Columns.Add("Kota");//deklarasi kolom kota
            DataTampilPel.Columns.Add("Tgl Registrasi");//deklarasi kolom tanggal registrasi
            DataTampilPel.Columns.Add("Tipe"); //deklarasi kolom tipe

            while (dr.Read())//membaca tavel pada sql berdasarkan baris
            {
                DataRow rows_pelanggan = DataTampilPel.NewRow();//melakukan deklarasi baris
                rows_pelanggan["Kode"] = dr.GetSqlString(0);//mengsi baris, pada setiap kolom kode
                rows_pelanggan["Nama"] = dr.GetSqlString(1);//mengsi baris, pada setiap kolom nama
                rows_pelanggan["Kota"] = dr.GetSqlString(2);//mengsi baris, pada setiap kolom kota
                rows_pelanggan["Tgl Registrasi"] = dr.GetValue(3);//mengsi baris, pada setiap kolom tgl registrasi
                if (dr.GetSqlString(4) == "1") //melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Basic";//mengsi baris, pada setiap kolom tipe
                }
                if (dr.GetSqlString(4) == "2")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Silver";//mengsi baris, pada setiap kolom tipe
                }
                if (dr.GetSqlString(4) == "3")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                {
                    rows_pelanggan["Tipe"] = "Gold";//mengsi baris, pada setiap kolom tipe
                }
                DataTampilPel.Rows.Add(rows_pelanggan); //manyatukan setiap baris sesuai kolom
                
            }
            dgv_tampil.DataSource = DataTampilPel;//melakukan collection terhadap data untuk ditampilkan datagridview

            conn.Close();//keluar dari databse
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//path yang digunakan untuk mengkoneksikan sql server to c#            
            conn.Open();//melakukan buka database yang akan dibaca
            string sql=""; //string unttuk insert 
            if(gold.Checked == true)//mndapatkan nilai radio button
            {
                sql = String.Concat("insert into pelanggan values('", kode_pel.Text, "', '", nama_pel.Text, "', '", kota_pel.Text, "','", this.dtp_pel.Value.ToString("yyyy-MM-dd"), "','", '3', "')");
                //mengisi string sesuai perinta insert sql server
            }
            if (silver.Checked == true)//mndapatkan nilai radio button
            {
                sql = String.Concat("insert into pelanggan values('", kode_pel.Text, "', '", nama_pel.Text, "', '", kota_pel.Text, "','", this.dtp_pel.Value.ToString("yyyy-MM-dd"), "','", '2', "')");
                //mengisi string sesuai perinta insert sql server
            }
            if (basic.Checked == true)//mndapatkan nilai radio button
            {
                sql = String.Concat("insert into pelanggan values('", kode_pel.Text, "', '", nama_pel.Text, "', '", kota_pel.Text, "','", this.dtp_pel.Value.ToString("yyyy-MM-dd"), "','", '1', "')");
                //mengisi string sesuai perinta insert sql server
            }
            da.InsertCommand = new SqlCommand(sql, conn);//mengirikan alamat dan sintak untuk insert
            da.InsertCommand.ExecuteNonQuery();  //melakukan eksekusi insert
            cetak();//melakukan cetak hasil ke prosedur cetal
            string pesan = "Data Berhasil Diinput";//string untuk pesan 
            MessageBox.Show(pesan);//menampilkan pesan 
            conn.Close();//kelauar dari database
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            nama_pel.ResetText();//mengosongkan semua nama pelangan pada textbox
            kota_pel.ResetText();//mengosongkan semua kota pelanggan pada textbox
            kode_pel.ResetText();//mengosongkan semua kode pelanggan pada textbox
            dtp_pel.ResetText();//mengosongkan semua date time pelangan pada textbox
            basic.Checked = true;//mengmbalikan checkbox ke awal
        }

        private void caridata()
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//path yang digunakan untuk mengkoneksikan sql server to c#            
            conn.Open();//melakukan buka database yang akan dibaca
            da = new SqlDataAdapter(); //deklarasi dari data adapter
            string lihat = String.Format("select * from Pelanggan");//string yang digunakan untuk membaca isi dari tabel
            SqlCommand cm = new SqlCommand(lihat, conn); //melakukan pengiriman data ke sql
            dr = cm.ExecuteReader();//mulai melakukan pembacaan file
            bool benar = true;//untuk mengecek data
            DataTable DataTampilPel = new DataTable();//deklarasi tabe;
            DataTampilPel.Columns.Add("Kode");//deklarasi kolom kode
            DataTampilPel.Columns.Add("Nama");//deklarasi kolom nama
            DataTampilPel.Columns.Add("Kota");//deklarasi kolom kota
            DataTampilPel.Columns.Add("Tgl Registrasi");//deklarasi kolom tanggal registrasi
            DataTampilPel.Columns.Add("Tipe"); //deklarasi kolom tipe

            while (dr.Read())//membaca data sqql berdasarkan baris
            {
                if (nama_tampil.Text.ToString() == dr.GetSqlString(1))//mengambil nilai pada database kemudian dicek untuk mencari data
                {
                    DataRow rows_pelanggan = DataTampilPel.NewRow();//melakukan deklarasi baris
                    rows_pelanggan["Kode"] = dr.GetSqlString(0);//mengsi baris, pada setiap kolom kode
                    rows_pelanggan["Nama"] = dr.GetSqlString(1);//mengsi baris, pada setiap kolom nama
                    rows_pelanggan["Kota"] = dr.GetSqlString(2);//mengsi baris, pada setiap kolom kota
                    rows_pelanggan["Tgl Registrasi"] = dr.GetValue(3);//mengsi baris, pada setiap kolom tgl registrasi
                    if (dr.GetSqlString(4) == "1") //melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                    {
                        rows_pelanggan["Tipe"] = "Basic";//mengsi baris, pada setiap kolom tipe
                    }
                    if (dr.GetSqlString(4) == "2")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                    {
                        rows_pelanggan["Tipe"] = "Silver";//mengsi baris, pada setiap kolom tipe
                    }
                    if (dr.GetSqlString(4) == "3")//melakukan pengecekan nilai type untuk menampilkan kata gold,silver,basic
                    {
                        rows_pelanggan["Tipe"] = "Gold";//mengsi baris, pada setiap kolom tipe
                    }
                    DataTampilPel.Rows.Add(rows_pelanggan); //manyatukan setiap baris sesuai kolom
                    benar = false;
                }

            }
            if(benar != false)//cek kebenaran dari benar
            {
                cetak();//mencetak data
                MessageBox.Show("Data Tidak Ditemukan ");//message box
            }
            dgv_tampil.DataSource = DataTampilPel;//melakukan collection terhadap data untuk ditampilkan datagridview
            conn.Close();//le;uar dari sql
        }
        private void btn_tampil_Click(object sender, EventArgs e)
        {
            caridata();//ke prosedur fungsi
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//path yang digunakan untuk mengkoneksikan sql server to c#
            da = new SqlDataAdapter(); //deklarasi dari data adapter
            conn.Open();//melakukan buka database yang akan dibaca
            try//melakukan pencobaan code apakah berjalan
            {
                string sql = String.Concat("Delete From pelanggan Where Kode = '", kode_pel.Text, "'");//string untuk hapus data 
                SqlCommand cmd = new SqlCommand(sql, conn);//mengirimkan sintak dan data sql
                cmd.ExecuteNonQuery();//melakukan eksekusi pendeletan file
                MessageBox.Show("Hapus Berhasil");//kelauaran pesan
                cetak();//mencetak hasil
            }
            catch //fungsi else jika kode tidak berfungsi
            {
                MessageBox.Show("Gagal Menghapus");//message box
            }
            conn.Close();//kelauar dari sql

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();//keluar dari form pelanggan
        }

        private void nama_tampil_TextChanged(object sender, EventArgs e)
        {
            cetak(); //ke prosedure cetak untuk mencetak ke datagridview
        }
    }
}
