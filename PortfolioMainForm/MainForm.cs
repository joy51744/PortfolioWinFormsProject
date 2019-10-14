using System;
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
            ClassWinFormProject.Form1 main = new ClassWinFormProject.Form1();
            this.Visible = false;
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassWinFormProject1.Form1 main = new ClassWinFormProject1.Form1();
            this.Visible = false;
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateWinFormProject.CalculateMainForm main = new CalculateWinFormProject.CalculateMainForm();
            this.Visible = false;
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameWinFormProject.Form1 main = new GameWinFormProject.Form1();
            this.Visible = false;
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToolWinFormProject.Form1 main = new ToolWinFormProject.Form1();
            this.Visible = false;
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagementSystemWinFormProject.Form1 main = new ManagementSystemWinFormProject.Form1();
            this.Visible = false;
            main.Show();
        }
    }
}