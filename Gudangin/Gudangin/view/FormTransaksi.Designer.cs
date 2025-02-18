namespace Gudangin.view
{
    partial class FormTransaksi
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
            this.DataTransaksi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonBarang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGudangin = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxJenisTransaksi = new System.Windows.Forms.ComboBox();
            this.comboBoxNamaBarang = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(215, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(733, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transaksi";
            // 
            // DataTransaksi
            // 
            this.DataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksi.Location = new System.Drawing.Point(5, 21);
            this.DataTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataTransaksi.Name = "DataTransaksi";
            this.DataTransaksi.RowHeadersWidth = 51;
            this.DataTransaksi.RowTemplate.Height = 24;
            this.DataTransaksi.Size = new System.Drawing.Size(721, 223);
            this.DataTransaksi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jenis Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
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
            this.panel1.TabIndex = 10;
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
            this.panelStats.Location = new System.Drawing.Point(1, 193);
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 425);
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
            this.buttonPesanan.Click += new System.EventHandler(this.buttonPesanan_Click);
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
            this.panel2.TabIndex = 11;
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
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnExport);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxCari);
            this.groupBoxSearch.Location = new System.Drawing.Point(215, 303);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Size = new System.Drawing.Size(733, 62);
            this.groupBoxSearch.TabIndex = 17;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(557, 25);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(129, 28);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.textBoxCari.Size = new System.Drawing.Size(444, 22);
            this.textBoxCari.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah";
            // 
            // comboBoxJenisTransaksi
            // 
            this.comboBoxJenisTransaksi.FormattingEnabled = true;
            this.comboBoxJenisTransaksi.Items.AddRange(new object[] {
            "Masuk",
            "Keluar"});
            this.comboBoxJenisTransaksi.Location = new System.Drawing.Point(140, 39);
            this.comboBoxJenisTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJenisTransaksi.Name = "comboBoxJenisTransaksi";
            this.comboBoxJenisTransaksi.Size = new System.Drawing.Size(209, 24);
            this.comboBoxJenisTransaksi.TabIndex = 5;
            // 
            // comboBoxNamaBarang
            // 
            this.comboBoxNamaBarang.FormattingEnabled = true;
            this.comboBoxNamaBarang.Location = new System.Drawing.Point(140, 81);
            this.comboBoxNamaBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNamaBarang.Name = "comboBoxNamaBarang";
            this.comboBoxNamaBarang.Size = new System.Drawing.Size(209, 24);
            this.comboBoxNamaBarang.TabIndex = 6;
            this.comboBoxNamaBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamaBarang_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(492, 41);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker.TabIndex = 7;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(492, 82);
            this.tbJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(209, 22);
            this.tbJumlah.TabIndex = 8;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(325, 142);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(84, 28);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Controls.Add(this.tbJumlah);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxNamaBarang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxJenisTransaksi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(216, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(732, 229);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Transaksi";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 615);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksi)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPesanan;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonBarang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGudangin;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxJenisTransaksi;
        private System.Windows.Forms.ComboBox comboBoxNamaBarang;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
    }
}