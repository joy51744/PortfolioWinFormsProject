﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioMainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ClassWinFormProject.exe");
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ControlWinFormProject.exe");
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CalculateWinFormProject.exe");
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("GameWinFormProject.exe");
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ToolWinFormProject.exe");
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ManagementSystemWinFormProject.exe");
            this.Visible = false;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}