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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBarang formBarang = new FormBarang();
            formBarang.ShowDialog();
            this.Close();
        }
    }
}
