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
    public partial class Input_Diskon_Merek_Untuk_Pelanggan : Form
    {

        SqlConnection conn;//digunakan untuk koneksi ke database ini merupakan deklarasi variabel
        SqlDataAdapter da; //mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
        SqlDataReader dr;//dekllarasi variabel yang digunakan untuk membaca data pada sql
        public Input_Diskon_Merek_Untuk_Pelanggan()
        {
            InitializeComponent();
            jlh_listBlmRekam.Text = "0";//melakukan set data ke listbox jlh data yang belum direkam
            jlh_listInput.Text = "0";//melakukan set data ke listbox jlh data yang akan direkam
            jlh_listRekam.Text = "0";//melakukan set data ke listbox jlh data yang direkam
            DataTable DataTampilPel = new DataTable();//membuat sebuah tabel
            DataTampilPel.Columns.Add("Kode");//membuat kolom kode pada tabel
            DataTampilPel.Columns.Add("Nama");//membuat kolom nama pada tabel
            DataTampilPel.Columns.Add("Merek");//membuat kolom merek pada tabel
            DataTampilPel.Columns.Add("Diskon");//membuat kolom diskon pada tabel
            dgv_tampildiskon.DataSource = DataTampilPel;//menampilkan data ke datagridview
            nupdown.Value = 1;//menset nilai numericUpDown menjadi 1
            jlh_listBlmRekam.TextAlign = HorizontalAlignment.Center;//membuat textbox pada umlah data merek yang belum direkam menjadi rata tengah
            jlh_listInput.TextAlign = HorizontalAlignment.Center;//membuat textbox jumlah merek yang akan direkam menjadi rata tengah
            jlh_listRekam.TextAlign = HorizontalAlignment.Center;//membuat textbox jumlah merek yang sudah direkam menjadi rata tengah
        }

        private void txt_kode_pel_DragEnter(object sender, DragEventArgs e)
        {
            //even yang tidak jadi digunakan 
        }

        private void txt_kode_pel_Enter(object sender, EventArgs e)
        {
            //event yang tidak jadi digunakan
        }
        private void TampilDataID(string id)
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//melakukan koneksi kedatabase kedalam sistem SQL server
            da = new SqlDataAdapter();//mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
            conn.Open();//membuka database yang telah dilakukan koneksi sebelumnya sehingga pembacaan,penulisan dan pemanggilan dll dapat dilakukan manipulasi
            string lihat = String.Format("select * from diskonpelanggan");//membuat sebuah perintah untuk dapat dieksekusi didalam sql server *perintah lihat
            SqlCommand cm = new SqlCommand(lihat, conn); //mengirimkan perintah kedalam sql server
            dr = cm.ExecuteReader();//mulai melakukan membaca isi dalam data sql server
            //DataTable DataPelanggan = new DataTable();
            DataTable DataTampilPel = new DataTable();//membuat sebuah tabel
            DataTampilPel.Columns.Add("Kode");//membuat kolom kode pada tabel
            DataTampilPel.Columns.Add("Nama");//membuat kolom nama pada tabel
            DataTampilPel.Columns.Add("Merek");//membuat kolom merek pada tabel
            DataTampilPel.Columns.Add("Diskon");//membuat kolom diskon pada tabel

            while (dr.Read())//membaca data secara line by line
            {
                if (id == dr.GetSqlString(0))//mengecek data apakah data sesuai dengan id yang diinput
                {
                    DataRow rows_pelanggan = DataTampilPel.NewRow();//membuat data perbaris untuk dimasukan kedalam data tabel
                    rows_pelanggan["Kode"] = dr.GetSqlString(0);//mengisi setiap baris pada kolom kode
                    rows_pelanggan["Nama"] = txt_nama_pel.Text;//mengisi setiap baris pada kolom nama
                    rows_pelanggan["Merek"] = dr.GetSqlString(1);//mengisi setiap baris pada kolom merek
                    rows_pelanggan["Diskon"] = dr.GetSqlValue(2);//mengisi setiap baris pada kolom Diskon

                    DataTampilPel.Rows.Add(rows_pelanggan);//memasukan data baris kedalam tabel
                }
                
            }
            dgv_tampildiskon.DataSource = DataTampilPel;//mebampilkan data tabel ke data grid view
            conn.Close();//keluar dari sql
        }

        private void showdata()
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//melakukan koneksi kedatabase kedalam sistem SQL server
            da = new SqlDataAdapter();//mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
            conn.Open();//membuka database yang telah dilakukan koneksi sebelumnya sehingga pembacaan,penulisan dan pemanggilan dll dapat dilakukan manipulasi
            string lihat = String.Format("select * from barang"); //membuat sebuah perintah untuk dapat dieksekusi didalam sql server
            SqlCommand cm = new SqlCommand(lihat, conn);//mengirimkan perintah kedalam sql server
            dr = cm.ExecuteReader();//mulai melakukan membaca isi dalam data sql server
            List<string> merekdata = new List<string>();// membuat sebuah list untuk dimasukan kedalam listbox pada data yang belum direkam
            while (dr.Read())//mengecek pembacaan data secara baris, sehingga setiap baris data sql dapat dibaca secara line by line
            {
                merekdata.Add(dr.GetSqlString(2).ToString());//memasukan data kedalam list merek_data agar mudah dibaca.
            }
            //txt_nama_barang.Text = merekdata.Count.ToString();//untuk mengecek data yang yang sudah masuk kedalam list merek_data
            
            merekdata = merekdata.Distinct().ToList();//menghapus semua data duplicate pada list merek_data
            lb_blmRekam.Items.Clear();//menghapus semua data pada listbox agar data yang masuk tidak terjadi tumpa tindih
            for (int i=0;i<merekdata.Count;i++)//melakukan perualangan untuk mengambil data di list merek data
            {
                lb_blmRekam.Items.Add(merekdata[i]);//memasukan list data kedalam listbox data yang blm direkam
            }
            //lb_blmRekam.SelectionMode = Mul;//fungsi selection yang tidak jadi digunakan
            jlh_listBlmRekam.Text = merekdata.Count.ToString();//memasukan berapa jumlah data pada listbox data yang belum direkam
            //cetak();//ke preosedur cetak hasil dari data
            conn.Close();//keluar dari dari data sql
        }

        private void txt_kode_pel_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//melakukan koneksi kedatabase kedalam sistem SQL server
            da = new SqlDataAdapter();//mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
            conn.Open();//membuka database yang telah dilakukan koneksi sebelumnya sehingga pembacaan,penulisan dan pemanggilan dll dapat dilakukan manipulasi
            string lihat = String.Format("select * from pelanggan");//string untuk perintah melihat data pelanggan
            SqlCommand cm = new SqlCommand(lihat, conn);//untuk melakukan eksekusi terhadap sql
            dr = cm.ExecuteReader();//mulai melakukan pembacaan data pada sql
            

            while (dr.Read())//membaca data sql line by line
            {
                if (txt_kode_pel.Text == dr.GetSqlString(0).ToString()) /// check data apakah ada data yang sesuai dengan kode pelanggan
                {
                    txt_nama_pel.Text = dr.GetSqlString(1).ToString();//mengisi textbox nama pelanggan dengan data sesuai sql 
                    TampilDataID(dr.GetSqlString(0).ToString());//melakukan pengiriman data id untuk melihat data diskon pelanggan sesuai id
                    showdata();//menampilkan data pada listbox
                    break;//memberhentikan pembacaan data sql

                }
            }
                                  
            conn.Close();//keluar dari sql
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            var selectedValue = lb_blmRekam.SelectedItem;//mengambil data sesuai yang dipilih pada listbox data yang blm direkam
            if (selectedValue != null)//melakukan pengecekan apakah data yang dipilih ada atau tidak
            {
                lb_Input.Items.Add(selectedValue.ToString());//melakukan input kedalam list yang akan direkam
                lb_blmRekam.Items.Remove(selectedValue);//menghapus data dilist yang blm direkam
            }
            jlh_listBlmRekam.Text = lb_blmRekam.Items.Count.ToString();///mengisi textbox jumlah data yang belum direkam
            jlh_listInput.Text = lb_Input.Items.Count.ToString();//mengisi text box jumlah data yang akan diinput
        }

        private void btn_output_Click(object sender, EventArgs e)
        {
            var selectedValue = lb_Input.SelectedItem;//mengambil data sesuai yang dipilih pada listbox data input
            if (selectedValue != null)//melakukan pengecekan apakah data yang dipilih ada atau tidak
            {
                lb_blmRekam.Items.Add(selectedValue.ToString());//melakukan input kedalamlist data yang belum direkam
                lb_Input.Items.Remove(selectedValue);//menghapus data yang dipilih pada data yang akan diinput
            }
            jlh_listBlmRekam.Text = lb_blmRekam.Items.Count.ToString();///mengisi textbox jumlah data yang belum direkam
            jlh_listInput.Text = lb_Input.Items.Count.ToString();//mengisi text box jumlah data yang akan diinput
        }

        private void Btn_tambah_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//melakukan koneksi kedatabase kedalam sistem SQL server
            da = new SqlDataAdapter();//mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
            conn.Open();//membuka database yang telah dilakukan koneksi sebelumnya sehingga pembacaan,penulisan dan pemanggilan dll dapat dilakukan manipulasi
            string sql = "";//deklarasi sebuah string
            for (int i = 0; i < lb_Input.Items.Count; i++)//perulangan untuk mengambil data dari list box yang akan diinput
            {
                lb_sudahrekam.Items.Add(lb_Input.Items[i]);//memasukan data yang sudah direkam
                sql = String.Concat("insert into diskonpelanggan values('", txt_kode_pel.Text, "', '",lb_Input.Items[i].ToString() , "', '", nupdown.Value, "')");
                //membuat perintah untuk memasukan data kedalam diskon pelanggan
            }
            da.InsertCommand = new SqlCommand(sql, conn);//mengirimkan perintah kedalam sql
            try//melakukan percobaan apakah sintak didalam ini berhasil dijalankan 
            {
                if (da.InsertCommand.ExecuteNonQuery() == 1)//untuk mengecek dan mengeksekusi perinta sql
                {
                    ///tidak ada aksi hanya melakukan pengecekan karena ada masalah yaknik inputan yang memiliki same primary key
                }
            }
            catch//menghasilkan sebuah exception data jika code try salah
            {
                MessageBox.Show("Data Berhasil");//memberitahu data berhasil diinput
            }
            jlh_listRekam.Text = lb_sudahrekam.Items.Count.ToString();//mengisi textbox jumlah data yang sudah direkam
            TampilDataID(txt_kode_pel.Text);//menampilkan data sesuai dengan id
            conn.Close();//keluar dari sql


        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = DESKTOP-HH336H9\\SQLEXPRESS; Database = UAS-SC-B-TIPEB; Integrated Security = SSPI");//melakukan koneksi kedatabase kedalam sistem SQL server
            da = new SqlDataAdapter();//mendeklarasikan data adapter yang berfungsi untuk mengisi dan memperbaharui database
            conn.Open();//membuka database yang telah dilakukan koneksi sebelumnya sehingga pembacaan,penulisan dan pemanggilan dll dapat dilakukan manipulasi
            string lihat = String.Format("select * from diskonpelanggan");//membuat sebuah perintah untuk dapat dieksekusi didalam sql server *perintah lihat
            SqlCommand cm = new SqlCommand(lihat, conn); //mengirimkan perintah kedalam sql server
            dr = cm.ExecuteReader();//mulai melakukan membaca isi dalam data sql server
            DataTable DataTampilPel = new DataTable();//membuat sebuah tabel
            DataTampilPel.Columns.Add("Kode");//membuat kolom kode pada tabel
            DataTampilPel.Columns.Add("Nama");//membuat kolom nama pada tabel
            DataTampilPel.Columns.Add("Merek");//membuat kolom merek pada tabel
            DataTampilPel.Columns.Add("Diskon");//membuat kolom diskon pada tabel
            bool benar = true;//mendeklarasikan boolean untuk cek data
            while (dr.Read())//membaca data sesuai dengan data sql line by line
            {
                if (dr.GetSqlString(1) == txt_nama_barang.Text)//mengecek data apakah data yang diinput pada textbox sesuai
                {
                    DataRow rows_pelanggan = DataTampilPel.NewRow();//membuat data perbaris untuk dimasukan kedalam data tabel
                    rows_pelanggan["Kode"] = dr.GetSqlString(0);//mengisi setiap baris pada kolom kode
                    rows_pelanggan["Nama"] = txt_nama_pel.Text;//mengisi setiap baris pada kolom nama
                    rows_pelanggan["Merek"] = dr.GetSqlString(1);//mengisi setiap baris pada kolom merek
                    rows_pelanggan["Diskon"] = dr.GetSqlValue(2);//mengisi setiap baris pada kolom Diskon
                    benar = false;//menginput benar dengan salah
                    DataTampilPel.Rows.Add(rows_pelanggan);//memasukan data baris kedalam tabel
                }
            }
            if(benar != false)//mengecek apakah nilai boolean benar
            {
                MessageBox.Show("Data Tidak Ditemukan ");//menampilkan pesan data tidak ditemukan
            }
            dgv_tampildiskon.DataSource = DataTampilPel;//mebampilkan data tabel ke data grid view
            conn.Close();//keluar dari sql
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_kode_pel.ResetText();//mengembalikan textbox jumlah list rekam ke kondisi awal(kosong)
            txt_nama_barang.ResetText();//mengembalikan textbox jumlah list rekam ke kondisi awal(kosong)
            txt_nama_pel.ResetText();//mengembalikan textbox jumlah list rekam ke kondisi awal(kosong)
            lb_blmRekam.Items.Clear();//menghapus semua data pada listbox
            lb_Input.Items.Clear();//menghapus semua data pada listbox
            lb_sudahrekam.Items.Clear();//menghapus semua data pada listbox
            nupdown.Value = 1;//mengembalikan numeric up down kekondisi 1
            jlh_listBlmRekam.ResetText();//mengembalikan textbox jumlah list blm rekam ke kondisi awal(kosong)
            jlh_listInput.ResetText();//mengembalikan textbox jumlah list input ke kondisi awal(kosong)
            jlh_listRekam.ResetText();//mengembalikan textbox jumlah list rekam ke kondisi awal(kosong)
            dgv_tampildiskon.DataSource = null;//menghapus semua data yang ada di data gridview
            DataTable DataTampilPel = new DataTable();//membuat sebuah tabel
            DataTampilPel.Columns.Add("Kode");//membuat kolom kode pada tabel
            DataTampilPel.Columns.Add("Nama");//membuat kolom nama pada tabel
            DataTampilPel.Columns.Add("Merek");//membuat kolom merek pada tabel
            DataTampilPel.Columns.Add("Diskon");//membuat kolom diskon pada tabel
            dgv_tampildiskon.DataSource = DataTampilPel;//menampilkan data ke datagridview
        } 

        private void txt_nama_barang_TextChanged(object sender, EventArgs e)
        {
            TampilDataID(txt_kode_pel.Text);//ke prosedur tampil data ID untuk mencetak hasil data
        }
    }
}
