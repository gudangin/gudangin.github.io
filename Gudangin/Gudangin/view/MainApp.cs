﻿using Gudangin.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi Frmtransaksi = new FormTransaksi();
            Frmtransaksi.MdiParent = this;
            Frmtransaksi.Show();
        }
    }
}
