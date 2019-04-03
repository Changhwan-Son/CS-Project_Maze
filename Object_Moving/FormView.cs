using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Moving
{
    public partial class FormView : Form
    {
        int _x = 10;     // 말 x 좌표
        int _y = 30;     // 말 y 좌표 

        int char_width = 10;
        int char_height = 10;

        bool[,] arr = new bool[500, 500];

        // Map 전부 false 초기화 함수
        public void reset()
        {
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                    arr[i, j] = false;
            }
        }

        // Map 에서 true false 로 벽 생성 함수
        public void set(int x_start, int y_start, int width, int height)
        {
            for (int i = x_start + 1; i < x_start + width; i++)
            {
                for (int j = y_start + 1; j < y_start + height; j++)
                {
                    arr[i, j] = true;
                }
            }
        }

        // 벽 그려주고 Map 에서 true 설정
        private void Make_Maze(int start_x, int start_y, int width, int height, object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Brushes.DarkSlateGray), start_x, start_y, width, height);
            set(start_x, start_y, width, height);
        }

        public FormView()
        {
            InitializeComponent();

        }

        // 말 생성
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            reset();
           
            Make_Maze(0, 0, 10, 500, sender, e);        // 위 테두리
            Make_Maze(0, 0, 500, 10, sender, e);        // 왼쪽 테두리
            Make_Maze(0, 490, 500, 10, sender, e);      // 밑 테두리
            Make_Maze(490, 0, 10, 500, sender, e);      // 오른쪽 테두리


            Make_Maze(10, 20, 100, 10, sender, e);
            Make_Maze(10, 40, 100, 10, sender, e);
            Make_Maze(100, 100, 10, 100, sender, e);

            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, char_width, char_height);      // 말
        }

        // 키 입력
        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            // 오른쪽 방향키 입력
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < 10; i++)
                {
                    _x += 1;

                    if (arr[_x + char_width / 2 + 5 , _y + char_height / 2 ] == true)
                    {
                        _x -= 1;

                    }
                    Invalidate();
                    Delay(4);
                }
              
            }
            
            // 왼쪽 방향키 입력
            else if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < 10; i++)
                {
                    _x -= 1;

                    if (arr[_x + char_width / 2 - 5, _y + char_height / 2] == true)
                    {
                        _x += 1;
                    }

                    Invalidate();
                    Delay(4);
                }
            }
            // 위쪽 방향키 입력
            else if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < 10; i++)
                {
                    _y -= 1;
                    if (arr[_x + char_width / 2, _y + char_height / 2 - 5 ] == true)
                    {
                        _y += 1;
                    }
                    Invalidate();
                    Delay(4);
                } 
            }
            // 아래쪽 방향키 입력
            else if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < 10; i++)
                {
                    _y += 1;

                    if (arr[_x + char_width / 2, _y + char_height / 2 + 5] == true)
                    {
                        _y -= 1;
                    }

                    Invalidate();
                    Delay(4);
                }
            }
        }

        // Deley 함수 
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        
    }


}
