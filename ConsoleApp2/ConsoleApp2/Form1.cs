using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class Form1 : Form
    {
        int x = 50, y = 50;
        bool[ , ] arr = new bool[500, 500];
        public void reset()
        {
            for(int i=0; i<500; i++)
            {
                for (int j = 0; j < 500; j++)
                    arr[i, j] = false;
            }
        }
        public void set(int x_start, int y_start, int width, int height)
        {
            for(int i=x_start+1; i<x_start+width; i++)
            {
                for(int j=y_start+1; j<y_start+height; j++)
                {
                    arr[i, j] = true;
                }
            }
        }
        private void Make_Maze(int start_x, int start_y, int width, int height, object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Brushes.Blue), start_x, start_y, width, height);
            set(start_x, start_y, width, height);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            reset();
            e.Graphics.FillRectangle((Brushes.Blue), x, y, 10, 10);
            Make_Maze(0, 0, 11, 35, sender, e);
            Make_Maze(11, 35, 100, 11, sender, e);
            Make_Maze(100, 100, 11, 100, sender, e);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                if (arr[x + 15, y] == false && arr[x + 15, y + 10] == false && arr[x + 5, y + 10] == false && arr[x + 5, y] == false)
                {
                    x += 5;
                    Invalidate();
                }
                else if (arr[x + 14, y] == false && arr[x + 14, y + 10] == false && arr[x + 4, y + 10] == false && arr[x + 4, y] == false)
                {
                    x += 4;
                    Invalidate();
                }
                else if (arr[x + 13, y] == false && arr[x + 13, y + 10] == false && arr[x + 13, y + 10] == false && arr[x + 3, y] == false)
                {
                    x += 3;
                    Invalidate();
                }
                else if (arr[x + 12, y] == false && arr[x + 12, y + 10] == false && arr[x + 12, y + 10] == false && arr[x + 2, y] == false)
                {
                    x += 2;
                    Invalidate();
                }
                else if (arr[x + 11, y] == false && arr[x + 11, y + 10] == false && arr[x + 11, y + 10] == false && arr[x + 1, y] == false)
                {
                    x += 1;
                    Invalidate();
                }
            }
            else if (e.KeyData == Keys.Left)
            {
                if (arr[x - 5, y] == false && arr[x - 5, y + 10] == false && arr[x + 5, y] == false && arr[x + 5, y + 10] == false)
                {
                    x -= 5;
                    Invalidate();
                }
                else if (arr[x - 4, y] == false && arr[x - 4, y + 10] == false && arr[x + 6, y] == false && arr[x + 6, y + 10] == false)
                {
                    x -= 4;
                    Invalidate();
                }
                else if (arr[x - 3, y] == false && arr[x - 3, y + 10] == false && arr[x + 7, y] == false && arr[x + 7, y + 10] == false)
                {
                    x -= 3;
                    Invalidate();
                }
                else if (arr[x - 2, y] == false && arr[x - 2, y + 10] == false && arr[x + 8, y] == false && arr[x + 8, y + 10] == false)
                {
                    x -= 2;
                    Invalidate();
                }
                else if (arr[x - 1, y] == false && arr[x - 1, y + 10] == false && arr[x + 9, y] == false && arr[x + 9, y + 10] == false)
                {
                    x -= 1;
                    Invalidate();
                }
            }
            else if (e.KeyData == Keys.Up) {
                if (arr[x, y - 5] == false && arr[x + 10, y - 5] == false && arr[x, y + 5] == false && arr[x + 10, y + 5] == false)
                {
                    y -= 5;
                    Invalidate();
                }
                else if (arr[x, y - 4] == false && arr[x + 10, y - 4] == false && arr[x, y + 6] == false && arr[x + 10, y + 6] == false)
                {
                    y -= 4;
                    Invalidate();
                }
                else if (arr[x, y - 3] == false && arr[x + 10, y - 3] == false && arr[x, y + 7] == false && arr[x + 10, y + 7] == false)
                {
                    y -= 3;
                    Invalidate();
                }
                else if (arr[x, y - 2] == false && arr[x + 10, y - 2] == false && arr[x, y + 8] == false && arr[x + 10, y + 8] == false)
                {
                    y -= 2;
                    Invalidate();
                }
                else if (arr[x, y - 1] == false && arr[x + 10, y - 1] == false && arr[x, y + 9] == false && arr[x + 10, y + 9] == false)
                {
                    y -= 1;
                    Invalidate();
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                if (arr[x, y + 15] == false && arr[x + 10, y + 15] == false && arr[x, y + 5] == false && arr[x + 10, y + 5] == false)
                {
                    y += 5;
                    Invalidate();
                }
                else if (arr[x, y + 14] == false && arr[x + 10, y + 14] == false && arr[x, y + 4] == false && arr[x + 10, y + 4] == false)
                {
                    y += 4;
                    Invalidate();
                }
                else if (arr[x, y + 13] == false && arr[x + 10, y + 13] == false && arr[x, y + 3] == false && arr[x + 10, y + 3] == false)
                {
                    y += 3;
                    Invalidate();
                }
                else if (arr[x, y + 12] == false && arr[x + 10, y + 12] == false && arr[x, y + 2] == false && arr[x + 10, y + 2] == false)
                {
                    y += 2;
                    Invalidate();
                }
                else if (arr[x, y + 11] == false && arr[x + 10, y + 11] == false && arr[x, y + 1] == false && arr[x + 10, y + 1] == false)
                {
                    y += 1;
                    Invalidate();
                }

            }
        }
    }
}
