﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDisplayOutput_Click(object sender, EventArgs e)
        {
            String buffer;
            buffer = "Mailing Label: " + Environment.NewLine + Environment.NewLine;
            buffer = buffer + "Name: " + txtName.Text + Environment.NewLine;
            buffer = buffer + "Address: " + txtAddress.Text + Environment.NewLine;
            buffer = buffer + "City: " + txtCity.Text +  "   State: " + txtState.Text +     "   Zip: " + txtZip.Text;
            txtDisplayOutput.Text = buffer;
           
        }
    }
}
