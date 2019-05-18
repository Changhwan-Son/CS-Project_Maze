using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class PlaySelect : UserControl
    {
        public PlaySelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindForm().Visible = false;
            FormView Form2 = new FormView();
            Form2.Show();
        }
    }
}
