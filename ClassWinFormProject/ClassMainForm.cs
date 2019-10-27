using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class ClassMainForm : Form
    {
        public ClassMainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ClassWinFormProject.exe");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ClassWinFormProject.exe");
        }
    }
}