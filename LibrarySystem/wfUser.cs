﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class wfUser : Form
    {
        public wfUser()
        {
            InitializeComponent();
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfUser_Load(object sender, EventArgs e)
        {
            ucUser c = new ucUser();
            panel1.Controls.Add(c);
            c.SendToBack();
            c.Dock = DockStyle.Fill;
        }
    }
}
