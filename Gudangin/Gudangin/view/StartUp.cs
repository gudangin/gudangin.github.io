﻿using System;
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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainApp mainapp = new MainApp();
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            { 
                timer1.Dispose();
                Close();
            }
        }
    }
}
