using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gudangin.view
{
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonBarang.Height;
            panelStats.Top = buttonBarang.Top;
            panelDataBarang.Visible = true;

        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonTransaksi.Height;
            panelStats.Top = buttonTransaksi.Top;
            panelDataBarang.Visible = false;
            this.Hide();
            FormTransaksi formTransaksi = new FormTransaksi();
            formTransaksi.ShowDialog();
            this.Close();
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            panelStats.Height = buttonLaporan.Height;
            panelStats.Top = buttonLaporan.Top;

        }
    }
}
