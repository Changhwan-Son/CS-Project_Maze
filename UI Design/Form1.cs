using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace UI_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnHome.Top;
            home1.BringToFront();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            SidePanel.Top = btnPlay.Top;
            playSelect1.BringToFront();
            
            
            
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnCredit.Top;
            credit1.BringToFront();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnRank.Top;
            rank1.BringToFront();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnOption.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home1.BringToFront();

        }
    }
}
