﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_Doctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Doctor d = new Doctor();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
