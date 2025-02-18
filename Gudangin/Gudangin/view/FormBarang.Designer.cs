﻿namespace Gudangin.view
{
    partial class FormBarang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonBarang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGudangin = new System.Windows.Forms.Label();
            this.panelDataBarang = new System.Windows.Forms.Panel();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.groupBoxInputBarang = new System.Windows.Forms.GroupBox();
            this.textBoxNamaBrg = new System.Windows.Forms.TextBox();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelStok = new System.Windows.Forms.Label();
            this.groupBoxTombolAksi = new System.Windows.Forms.GroupBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.groupBoxDataBarang = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataBarang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDataBarang.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxInputBarang.SuspendLayout();
            this.groupBoxTombolAksi.SuspendLayout();
            this.groupBoxDataBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelStats);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonPesanan);
            this.panel1.Controls.Add(this.buttonTransaksi);
            this.panel1.Controls.Add(this.buttonBarang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 615);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Gudangin.Properties.Resources.iventory_removebg_preview1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelStats.Location = new System.Drawing.Point(3, 103);
            this.panelStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(5, 36);
            this.panelStats.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Location = new System.Drawing.Point(0, 513);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(200, 36);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPesanan
            // 
            this.buttonPesanan.FlatAppearance.BorderSize = 0;
            this.buttonPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesanan.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesanan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesanan.Location = new System.Drawing.Point(3, 282);
            this.buttonPesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPesanan.Name = "buttonPesanan";
            this.buttonPesanan.Size = new System.Drawing.Size(200, 36);
            this.buttonPesanan.TabIndex = 2;
            this.buttonPesanan.Text = "Pesanan";
            this.buttonPesanan.UseVisualStyleBackColor = true;
            this.buttonPesanan.Click += new System.EventHandler(this.buttonLaporan_Click);
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.FlatAppearance.BorderSize = 0;
            this.buttonTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaksi.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTransaksi.Location = new System.Drawing.Point(3, 193);
            this.buttonTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(200, 36);
            this.buttonTransaksi.TabIndex = 1;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = true;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // buttonBarang
            // 
            this.buttonBarang.FlatAppearance.BorderSize = 0;
            this.buttonBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarang.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBarang.Location = new System.Drawing.Point(3, 103);
            this.buttonBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBarang.Name = "buttonBarang";
            this.buttonBarang.Size = new System.Drawing.Size(197, 36);
            this.buttonBarang.TabIndex = 0;
            this.buttonBarang.Text = "Barang";
            this.buttonBarang.UseVisualStyleBackColor = true;
            this.buttonBarang.Click += new System.EventHandler(this.buttonBarang_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.labelGudangin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 41);
            this.panel2.TabIndex = 1;
            // 
            // labelGudangin
            // 
            this.labelGudangin.AutoSize = true;
            this.labelGudangin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGudangin.Location = new System.Drawing.Point(20, 9);
            this.labelGudangin.Name = "labelGudangin";
            this.labelGudangin.Size = new System.Drawing.Size(96, 22);
            this.labelGudangin.TabIndex = 0;
            this.labelGudangin.Text = "Gudangin";
            // 
            // panelDataBarang
            // 
            this.panelDataBarang.Controls.Add(this.groupBoxSearch);
            this.panelDataBarang.Controls.Add(this.groupBoxInputBarang);
            this.panelDataBarang.Controls.Add(this.groupBoxTombolAksi);
            this.panelDataBarang.Controls.Add(this.groupBoxDataBarang);
            this.panelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataBarang.Location = new System.Drawing.Point(200, 41);
            this.panelDataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDataBarang.Name = "panelDataBarang";
            this.panelDataBarang.Size = new System.Drawing.Size(760, 574);
            this.panelDataBarang.TabIndex = 2;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxCari);
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 244);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Size = new System.Drawing.Size(755, 62);
            this.groupBoxSearch.TabIndex = 16;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 20);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(93, 25);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(560, 22);
            this.textBoxCari.TabIndex = 7;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // groupBoxInputBarang
            // 
            this.groupBoxInputBarang.Controls.Add(this.textBoxNamaBrg);
            this.groupBoxInputBarang.Controls.Add(this.labelNamaBarang);
            this.groupBoxInputBarang.Controls.Add(this.comboBoxKategori);
            this.groupBoxInputBarang.Controls.Add(this.labelKategori);
            this.groupBoxInputBarang.Controls.Add(this.textBoxStok);
            this.groupBoxInputBarang.Controls.Add(this.labelStok);
            this.groupBoxInputBarang.Location = new System.Drawing.Point(5, 350);
            this.groupBoxInputBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputBarang.Name = "groupBoxInputBarang";
            this.groupBoxInputBarang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputBarang.Size = new System.Drawing.Size(372, 193);
            this.groupBoxInputBarang.TabIndex = 15;
            this.groupBoxInputBarang.TabStop = false;
            this.groupBoxInputBarang.Text = "Input Data Barang";
            // 
            // textBoxNamaBrg
            // 
            this.textBoxNamaBrg.Location = new System.Drawing.Point(109, 30);
            this.textBoxNamaBrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNamaBrg.Name = "textBoxNamaBrg";
            this.textBoxNamaBrg.Size = new System.Drawing.Size(223, 22);
            this.textBoxNamaBrg.TabIndex = 11;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Location = new System.Drawing.Point(5, 34);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(91, 16);
            this.labelNamaBarang.TabIndex = 8;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "Peralatan Dapur",
            "Peralatan Kebersihan",
            "Peralatan Elektronik Rumah Tangga",
            "Peralatan Kamar & Ruang Tamu"});
            this.comboBoxKategori.Location = new System.Drawing.Point(109, 94);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(223, 24);
            this.comboBoxKategori.TabIndex = 13;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(5, 96);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(57, 16);
            this.labelKategori.TabIndex = 9;
            this.labelKategori.Text = "Kategori";
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(109, 153);
            this.textBoxStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(223, 22);
            this.textBoxStok.TabIndex = 12;
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(5, 159);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(34, 16);
            this.labelStok.TabIndex = 10;
            this.labelStok.Text = "Stok";
            // 
            // groupBoxTombolAksi
            // 
            this.groupBoxTombolAksi.Controls.Add(this.buttonTambah);
            this.groupBoxTombolAksi.Controls.Add(this.buttonEdit);
            this.groupBoxTombolAksi.Controls.Add(this.buttonHapus);
            this.groupBoxTombolAksi.Controls.Add(this.buttonClear);
            this.groupBoxTombolAksi.Controls.Add(this.buttonDisplay);
            this.groupBoxTombolAksi.Location = new System.Drawing.Point(441, 350);
            this.groupBoxTombolAksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTombolAksi.Name = "groupBoxTombolAksi";
            this.groupBoxTombolAksi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTombolAksi.Size = new System.Drawing.Size(307, 193);
            this.groupBoxTombolAksi.TabIndex = 14;
            this.groupBoxTombolAksi.TabStop = false;
            this.groupBoxTombolAksi.Text = "Tombol Aksi";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(3, 34);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(147, 30);
            this.buttonTambah.TabIndex = 2;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(155, 34);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(147, 30);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(5, 82);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(147, 30);
            this.buttonHapus.TabIndex = 4;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(155, 82);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(147, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(5, 132);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(295, 30);
            this.buttonDisplay.TabIndex = 6;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // groupBoxDataBarang
            // 
            this.groupBoxDataBarang.Controls.Add(this.dataGridViewDataBarang);
            this.groupBoxDataBarang.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataBarang.Name = "groupBoxDataBarang";
            this.groupBoxDataBarang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataBarang.Size = new System.Drawing.Size(760, 235);
            this.groupBoxDataBarang.TabIndex = 0;
            this.groupBoxDataBarang.TabStop = false;
            this.groupBoxDataBarang.Text = "Data Barang";
            // 
            // dataGridViewDataBarang
            // 
            this.dataGridViewDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBarang.Location = new System.Drawing.Point(0, 21);
            this.dataGridViewDataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDataBarang.Name = "dataGridViewDataBarang";
            this.dataGridViewDataBarang.RowHeadersWidth = 51;
            this.dataGridViewDataBarang.RowTemplate.Height = 24;
            this.dataGridViewDataBarang.Size = new System.Drawing.Size(760, 217);
            this.dataGridViewDataBarang.TabIndex = 0;
            this.dataGridViewDataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataBarang_CellClick);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 615);
            this.Controls.Add(this.panelDataBarang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDataBarang.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxInputBarang.ResumeLayout(false);
            this.groupBoxInputBarang.PerformLayout();
            this.groupBoxTombolAksi.ResumeLayout(false);
            this.groupBoxDataBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBarang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDataBarang;
        private System.Windows.Forms.Button buttonPesanan;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelGudangin;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxDataBarang;
        private System.Windows.Forms.DataGridView dataGridViewDataBarang;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.TextBox textBoxNamaBrg;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.GroupBox groupBoxInputBarang;
        private System.Windows.Forms.GroupBox groupBoxTombolAksi;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}