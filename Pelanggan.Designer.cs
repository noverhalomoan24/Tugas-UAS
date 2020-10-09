namespace UAS
{
    partial class Pelanggan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.silver = new System.Windows.Forms.RadioButton();
            this.gold = new System.Windows.Forms.RadioButton();
            this.basic = new System.Windows.Forms.RadioButton();
            this.dtp_pel = new System.Windows.Forms.DateTimePicker();
            this.kota_pel = new System.Windows.Forms.TextBox();
            this.nama_pel = new System.Windows.Forms.TextBox();
            this.kode_pel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_tampil = new System.Windows.Forms.DataGridView();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.nama_tampil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_New);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.silver);
            this.groupBox1.Controls.Add(this.gold);
            this.groupBox1.Controls.Add(this.basic);
            this.groupBox1.Controls.Add(this.dtp_pel);
            this.groupBox1.Controls.Add(this.kota_pel);
            this.groupBox1.Controls.Add(this.nama_pel);
            this.groupBox1.Controls.Add(this.kode_pel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(196, 196);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(50, 23);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(137, 196);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(50, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(13, 196);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(50, 23);
            this.btn_New.TabIndex = 12;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // silver
            // 
            this.silver.AutoSize = true;
            this.silver.Location = new System.Drawing.Point(145, 159);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(51, 17);
            this.silver.TabIndex = 10;
            this.silver.TabStop = true;
            this.silver.Text = "Silver";
            this.silver.UseVisualStyleBackColor = true;
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Location = new System.Drawing.Point(202, 159);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(47, 17);
            this.gold.TabIndex = 9;
            this.gold.TabStop = true;
            this.gold.Text = "Gold";
            this.gold.UseVisualStyleBackColor = true;
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Location = new System.Drawing.Point(88, 161);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(51, 17);
            this.basic.TabIndex = 0;
            this.basic.TabStop = true;
            this.basic.Text = "Basic";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // dtp_pel
            // 
            this.dtp_pel.Location = new System.Drawing.Point(89, 128);
            this.dtp_pel.Name = "dtp_pel";
            this.dtp_pel.Size = new System.Drawing.Size(151, 20);
            this.dtp_pel.TabIndex = 8;
            // 
            // kota_pel
            // 
            this.kota_pel.Location = new System.Drawing.Point(88, 95);
            this.kota_pel.Name = "kota_pel";
            this.kota_pel.Size = new System.Drawing.Size(152, 20);
            this.kota_pel.TabIndex = 7;
            // 
            // nama_pel
            // 
            this.nama_pel.Location = new System.Drawing.Point(88, 61);
            this.nama_pel.Name = "nama_pel";
            this.nama_pel.Size = new System.Drawing.Size(152, 20);
            this.nama_pel.TabIndex = 6;
            // 
            // kode_pel
            // 
            this.kode_pel.Location = new System.Drawing.Point(88, 29);
            this.kode_pel.Name = "kode_pel";
            this.kode_pel.Size = new System.Drawing.Size(100, 20);
            this.kode_pel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registrasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tampil);
            this.groupBox2.Controls.Add(this.btn_tampil);
            this.groupBox2.Controls.Add(this.nama_tampil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampil";
            // 
            // dgv_tampil
            // 
            this.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tampil.Location = new System.Drawing.Point(20, 61);
            this.dgv_tampil.Name = "dgv_tampil";
            this.dgv_tampil.Size = new System.Drawing.Size(434, 241);
            this.dgv_tampil.TabIndex = 18;
            // 
            // btn_tampil
            // 
            this.btn_tampil.Location = new System.Drawing.Point(266, 28);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(84, 23);
            this.btn_tampil.TabIndex = 17;
            this.btn_tampil.Text = "Tampil";
            this.btn_tampil.UseVisualStyleBackColor = true;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // nama_tampil
            // 
            this.nama_tampil.Location = new System.Drawing.Point(184, 28);
            this.nama_tampil.Name = "nama_tampil";
            this.nama_tampil.Size = new System.Drawing.Size(76, 20);
            this.nama_tampil.TabIndex = 16;
            this.nama_tampil.TextChanged += new System.EventHandler(this.nama_tampil_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nama";
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pelanggan";
            this.Text = "Pelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton silver;
        private System.Windows.Forms.RadioButton gold;
        private System.Windows.Forms.RadioButton basic;
        private System.Windows.Forms.DateTimePicker dtp_pel;
        private System.Windows.Forms.TextBox kota_pel;
        private System.Windows.Forms.TextBox nama_pel;
        private System.Windows.Forms.TextBox kode_pel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_tampil;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.TextBox nama_tampil;
        private System.Windows.Forms.Label label6;
    }
}