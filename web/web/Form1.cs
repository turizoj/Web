﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                webBrowser.Navigate(txtUrl.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            webBrowser.Navigate(txtUrl.Text);
        }
    }
}
