﻿using GUI.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            productManager.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffManager staffManager = new StaffManager();
            staffManager.Show();
        }
    }
}
