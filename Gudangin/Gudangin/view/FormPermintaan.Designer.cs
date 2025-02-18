namespace Gudangin.view
{
    partial class FormPermintaan
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
            this.buttonSetuju = new System.Windows.Forms.Button();
            this.buttonTolak = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.panelDataBarang = new System.Windows.Forms.Panel();
            this.groupBoxTombolAksi = new System.Windows.Forms.GroupBox();
            this.groupBoxDataBarang = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataPermintaan = new System.Windows.Forms.DataGridView();
            this.labelGudangin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBarang = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSearch.SuspendLayout();
            this.panelDataBarang.SuspendLayout();
            this.groupBoxTombolAksi.SuspendLayout();
            this.groupBoxDataBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPermintaan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetuju
            // 
            this.buttonSetuju.Location = new System.Drawing.Point(3, 34);
            this.buttonSetuju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetuju.Name = "buttonSetuju";
            this.buttonSetuju.Size = new System.Drawing.Size(147, 30);
            this.buttonSetuju.TabIndex = 2;
            this.buttonSetuju.Text = "Setujui";
            this.buttonSetuju.UseVisualStyleBackColor = true;
            this.buttonSetuju.Click += new System.EventHandler(this.buttonSetuju_Click);
            // 
            // buttonTolak
            // 
            this.buttonTolak.Location = new System.Drawing.Point(155, 34);
            this.buttonTolak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTolak.Name = "buttonTolak";
            this.buttonTolak.Size = new System.Drawing.Size(147, 30);
            this.buttonTolak.TabIndex = 3;
            this.buttonTolak.Text = "Tolak";
            this.buttonTolak.UseVisualStyleBackColor = true;
            this.buttonTolak.Click += new System.EventHandler(this.buttonTolak_Click);
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
            // 
            // panelDataBarang
            // 
            this.panelDataBarang.Controls.Add(this.groupBoxSearch);
            this.panelDataBarang.Controls.Add(this.groupBoxTombolAksi);
            this.panelDataBarang.Controls.Add(this.groupBoxDataBarang);
            this.panelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataBarang.Location = new System.Drawing.Point(200, 41);
            this.panelDataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDataBarang.Name = "panelDataBarang";
            this.panelDataBarang.Size = new System.Drawing.Size(762, 551);
            this.panelDataBarang.TabIndex = 5;
            // 
            // groupBoxTombolAksi
            // 
            this.groupBoxTombolAksi.Controls.Add(this.buttonSetuju);
            this.groupBoxTombolAksi.Controls.Add(this.buttonTolak);
            this.groupBoxTombolAksi.Location = new System.Drawing.Point(15, 360);
            this.groupBoxTombolAksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTombolAksi.Name = "groupBoxTombolAksi";
            this.groupBoxTombolAksi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTombolAksi.Size = new System.Drawing.Size(307, 91);
            this.groupBoxTombolAksi.TabIndex = 14;
            this.groupBoxTombolAksi.TabStop = false;
            this.groupBoxTombolAksi.Text = "Tombol Aksi";
            // 
            // groupBoxDataBarang
            // 
            this.groupBoxDataBarang.Controls.Add(this.dataGridViewDataPermintaan);
            this.groupBoxDataBarang.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataBarang.Name = "groupBoxDataBarang";
            this.groupBoxDataBarang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataBarang.Size = new System.Drawing.Size(760, 235);
            this.groupBoxDataBarang.TabIndex = 0;
            this.groupBoxDataBarang.TabStop = false;
            this.groupBoxDataBarang.Text = "Data Barang";
            // 
            // dataGridViewDataPermintaan
            // 
            this.dataGridViewDataPermintaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataPermintaan.Location = new System.Drawing.Point(0, 21);
            this.dataGridViewDataPermintaan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDataPermintaan.Name = "dataGridViewDataPermintaan";
            this.dataGridViewDataPermintaan.RowHeadersWidth = 51;
            this.dataGridViewDataPermintaan.RowTemplate.Height = 24;
            this.dataGridViewDataPermintaan.Size = new System.Drawing.Size(760, 217);
            this.dataGridViewDataPermintaan.TabIndex = 0;
            this.dataGridViewDataPermintaan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataPermintaan_CellClick);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.labelGudangin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 41);
            this.panel2.TabIndex = 4;
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
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelStats.Location = new System.Drawing.Point(0, 285);
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
            this.panel1.Size = new System.Drawing.Size(200, 592);
            this.panel1.TabIndex = 3;
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
            // FormPermintaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 592);
            this.Controls.Add(this.panelDataBarang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPermintaan";
            this.Text = "FormPermintaan";
            this.Load += new System.EventHandler(this.FormPermintaan_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panelDataBarang.ResumeLayout(false);
            this.groupBoxTombolAksi.ResumeLayout(false);
            this.groupBoxDataBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataPermintaan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSetuju;
        private System.Windows.Forms.Button buttonTolak;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Panel panelDataBarang;
        private System.Windows.Forms.GroupBox groupBoxTombolAksi;
        private System.Windows.Forms.GroupBox groupBoxDataBarang;
        private System.Windows.Forms.DataGridView dataGridViewDataPermintaan;
        private System.Windows.Forms.Label labelGudangin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBarang;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPesanan;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Panel panel1;
    }
}