﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class waiterGUI : Form
    {
        public waiterGUI()
        {
            InitializeComponent();
        }

        private void btn_pd_Click(object sender, EventArgs e)
        {
            orderGUI ogui = new orderGUI();
            ogui.ShowDialog();
        }
    }
}
