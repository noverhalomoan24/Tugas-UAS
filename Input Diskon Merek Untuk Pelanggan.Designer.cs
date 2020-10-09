namespace UAS
{
    partial class Input_Diskon_Merek_Untuk_Pelanggan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kode_pel = new System.Windows.Forms.TextBox();
            this.txt_nama_pel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jlh_listBlmRekam = new System.Windows.Forms.TextBox();
            this.jlh_listInput = new System.Windows.Forms.TextBox();
            this.jlh_listRekam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_blmRekam = new System.Windows.Forms.ListBox();
            this.lb_Input = new System.Windows.Forms.ListBox();
            this.lb_sudahrekam = new System.Windows.Forms.ListBox();
            this.nupdown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_output = new System.Windows.Forms.Button();
            this.Btn_tambah = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.dgv_tampildiskon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampildiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // txt_kode_pel
            // 
            this.txt_kode_pel.Location = new System.Drawing.Point(144, 16);
            this.txt_kode_pel.Name = "txt_kode_pel";
            this.txt_kode_pel.Size = new System.Drawing.Size(100, 20);
            this.txt_kode_pel.TabIndex = 2;
            this.txt_kode_pel.TextChanged += new System.EventHandler(this.txt_kode_pel_TextChanged);
            this.txt_kode_pel.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt_kode_pel_DragEnter);
            this.txt_kode_pel.Enter += new System.EventHandler(this.txt_kode_pel_Enter);
            // 
            // txt_nama_pel
            // 
            this.txt_nama_pel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nama_pel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_pel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nama_pel.Location = new System.Drawing.Point(424, 19);
            this.txt_nama_pel.Name = "txt_nama_pel";
            this.txt_nama_pel.Size = new System.Drawing.Size(100, 20);
            this.txt_nama_pel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_output);
            this.groupBox1.Controls.Add(this.btn_input);
            this.groupBox1.Controls.Add(this.lb_sudahrekam);
            this.groupBox1.Controls.Add(this.lb_Input);
            this.groupBox1.Controls.Add(this.lb_blmRekam);
            this.groupBox1.Controls.Add(this.jlh_listRekam);
            this.groupBox1.Controls.Add(this.jlh_listInput);
            this.groupBox1.Controls.Add(this.jlh_listBlmRekam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Merek pelanggan Yang Belum Direkam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Merek Yang Akan DiInput";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Merek Pelanggan Yang Telah Direkam";
            // 
            // jlh_listBlmRekam
            // 
            this.jlh_listBlmRekam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.jlh_listBlmRekam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlh_listBlmRekam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jlh_listBlmRekam.Location = new System.Drawing.Point(33, 215);
            this.jlh_listBlmRekam.Name = "jlh_listBlmRekam";
            this.jlh_listBlmRekam.Size = new System.Drawing.Size(100, 22);
            this.jlh_listBlmRekam.TabIndex = 8;
            // 
            // jlh_listInput
            // 
            this.jlh_listInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.jlh_listInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlh_listInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jlh_listInput.Location = new System.Drawing.Point(359, 215);
            this.jlh_listInput.Name = "jlh_listInput";
            this.jlh_listInput.Size = new System.Drawing.Size(100, 22);
            this.jlh_listInput.TabIndex = 11;
            // 
            // jlh_listRekam
            // 
            this.jlh_listRekam.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.jlh_listRekam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlh_listRekam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jlh_listRekam.Location = new System.Drawing.Point(617, 214);
            this.jlh_listRekam.Name = "jlh_listRekam";
            this.jlh_listRekam.Size = new System.Drawing.Size(100, 22);
            this.jlh_listRekam.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Besar % Diskon";
            // 
            // lb_blmRekam
            // 
            this.lb_blmRekam.FormattingEnabled = true;
            this.lb_blmRekam.Location = new System.Drawing.Point(13, 53);
            this.lb_blmRekam.Name = "lb_blmRekam";
            this.lb_blmRekam.Size = new System.Drawing.Size(189, 147);
            this.lb_blmRekam.TabIndex = 14;
            // 
            // lb_Input
            // 
            this.lb_Input.FormattingEnabled = true;
            this.lb_Input.Location = new System.Drawing.Point(310, 51);
            this.lb_Input.Name = "lb_Input";
            this.lb_Input.Size = new System.Drawing.Size(189, 147);
            this.lb_Input.TabIndex = 15;
            // 
            // lb_sudahrekam
            // 
            this.lb_sudahrekam.FormattingEnabled = true;
            this.lb_sudahrekam.Location = new System.Drawing.Point(567, 53);
            this.lb_sudahrekam.Name = "lb_sudahrekam";
            this.lb_sudahrekam.Size = new System.Drawing.Size(189, 147);
            this.lb_sudahrekam.TabIndex = 16;
            // 
            // nupdown
            // 
            this.nupdown.Location = new System.Drawing.Point(386, 322);
            this.nupdown.Name = "nupdown";
            this.nupdown.Size = new System.Drawing.Size(62, 20);
            this.nupdown.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min = 1. Max = 30";
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(232, 71);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(58, 42);
            this.btn_input.TabIndex = 16;
            this.btn_input.Text = ">";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_output
            // 
            this.btn_output.Location = new System.Drawing.Point(232, 129);
            this.btn_output.Name = "btn_output";
            this.btn_output.Size = new System.Drawing.Size(58, 42);
            this.btn_output.TabIndex = 17;
            this.btn_output.Text = "<";
            this.btn_output.UseVisualStyleBackColor = true;
            this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
            // 
            // Btn_tambah
            // 
            this.Btn_tambah.Location = new System.Drawing.Point(307, 359);
            this.Btn_tambah.Name = "Btn_tambah";
            this.Btn_tambah.Size = new System.Drawing.Size(99, 27);
            this.Btn_tambah.TabIndex = 18;
            this.Btn_tambah.Text = "Tambah";
            this.Btn_tambah.UseVisualStyleBackColor = true;
            this.Btn_tambah.Click += new System.EventHandler(this.Btn_tambah_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(434, 359);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 27);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tampildiskon);
            this.groupBox2.Controls.Add(this.btn_tampil);
            this.groupBox2.Location = new System.Drawing.Point(21, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 222);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampil";
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(399, 409);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(100, 20);
            this.txt_nama_barang.TabIndex = 21;
            this.txt_nama_barang.TextChanged += new System.EventHandler(this.txt_nama_barang_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nama Barang";
            // 
            // btn_tampil
            // 
            this.btn_tampil.Location = new System.Drawing.Point(502, 13);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(99, 24);
            this.btn_tampil.TabIndex = 22;
            this.btn_tampil.Text = "Tampil";
            this.btn_tampil.UseVisualStyleBackColor = true;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // dgv_tampildiskon
            // 
            this.dgv_tampildiskon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tampildiskon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tampildiskon.Location = new System.Drawing.Point(6, 51);
            this.dgv_tampildiskon.Name = "dgv_tampildiskon";
            this.dgv_tampildiskon.Size = new System.Drawing.Size(780, 144);
            this.dgv_tampildiskon.TabIndex = 23;
            // 
            // Input_Diskon_Merek_Untuk_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 649);
            this.Controls.Add(this.txt_nama_barang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.Btn_tambah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nama_pel);
            this.Controls.Add(this.txt_kode_pel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input_Diskon_Merek_Untuk_Pelanggan";
            this.Text = "Input_Diskon_Merek_Untuk_Pelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampildiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kode_pel;
        private System.Windows.Forms.TextBox txt_nama_pel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_output;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lb_sudahrekam;
        private System.Windows.Forms.ListBox lb_Input;
        private System.Windows.Forms.ListBox lb_blmRekam;
        private System.Windows.Forms.TextBox jlh_listRekam;
        private System.Windows.Forms.TextBox jlh_listInput;
        private System.Windows.Forms.TextBox jlh_listBlmRekam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_tambah;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_tampildiskon;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label8;
    }
}