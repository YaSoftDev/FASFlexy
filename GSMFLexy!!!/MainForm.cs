﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSMFLexy___
{
    public partial class MainForm : Form
    {
        public static MainForm Instance
        {
            get;
            set;
        }
        public MainForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
