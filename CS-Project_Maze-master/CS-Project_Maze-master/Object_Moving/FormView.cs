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
                for (int j = 0; j < 500; j++)
                    arr[i, j] = false;
        }

        // Map 에서 true false 로 벽 생성 함수
        public void set(int x_start, int y_start, int width, int height)
        {
            for (int i = x_start + 1; i < x_start + width; i++)
                for (int j = y_start + 1; j < y_start + height; j++)
                    arr[i, j] = true;
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
           
            Make_Maze(0, 0, 10, 400, sender, e);        // 위 테두리
            Make_Maze(0, 0, 400, 10, sender, e);        // 왼쪽 테두리
            Make_Maze(0, 400, 390, 10, sender, e);      // 밑 테두리
            Make_Maze(400, 0, 10, 410, sender, e);      // 오른쪽 테두리

            Make_Maze(20, 10, 10, 20, sender, e);
            Make_Maze(10, 40, 20, 10, sender, e);
            Make_Maze(20, 40, 10, 30, sender, e);
            Make_Maze(80, 10, 10, 60, sender, e);
            Make_Maze(60, 20, 70, 10, sender, e);
            Make_Maze(40, 20, 10, 70, sender, e);
            Make_Maze(50, 40, 40, 10, sender, e);
            Make_Maze(60, 60, 20, 10, sender, e);
            Make_Maze(20, 80, 20, 10, sender, e);
            Make_Maze(100, 20, 10, 70, sender, e);
            Make_Maze(120, 20, 10, 90, sender, e);
            Make_Maze(60, 80, 40, 10, sender, e);
            Make_Maze(60, 90, 10, 40, sender, e);
            Make_Maze(20, 100, 70, 10, sender, e);
            Make_Maze(20, 110, 10, 20, sender, e);
            Make_Maze(30, 120, 20, 10, sender, e);
            Make_Maze(10, 140, 20, 10, sender, e);
            Make_Maze(10, 160, 20, 10, sender, e);
            Make_Maze(40, 130, 10, 120, sender, e);
            Make_Maze(20, 180, 20, 10, sender, e);
            Make_Maze(20, 190, 10, 20, sender, e);
            Make_Maze(20, 220, 20, 10, sender, e);
            Make_Maze(20, 230, 10, 20, sender, e);
            Make_Maze(10, 260, 20, 10, sender, e);
            Make_Maze(10, 280, 20, 10, sender, e);
            Make_Maze(10, 300, 20, 10, sender, e);
            Make_Maze(10, 340, 20, 10, sender, e);
            Make_Maze(20, 320, 10, 20, sender, e);
            Make_Maze(20, 360, 70, 10, sender, e);
            Make_Maze(10, 380, 40, 10, sender, e);
            Make_Maze(60, 380, 10, 20, sender, e);
            Make_Maze(80, 370, 10, 30, sender, e);
            Make_Maze(40, 260, 70, 10, sender, e);
            Make_Maze(60, 270, 10, 20, sender, e);
            Make_Maze(40, 280, 20, 10, sender, e);
            Make_Maze(40, 290, 10, 20, sender, e);
            Make_Maze(40, 320, 10, 30, sender, e);
            Make_Maze(50, 340, 80, 10, sender, e);
            Make_Maze(60, 300, 30, 10, sender, e);
            Make_Maze(60, 320, 30, 10, sender, e);
            Make_Maze(80, 310, 10, 30, sender, e);
            Make_Maze(70, 120, 30, 10, sender, e);
            Make_Maze(100, 100, 10, 50, sender, e);
            Make_Maze(80, 130, 10, 80, sender, e);
            Make_Maze(60, 140, 20, 10, sender, e);
            Make_Maze(60, 150, 10, 40, sender, e);
            Make_Maze(60, 200, 20, 10, sender, e);
            Make_Maze(60, 210, 10, 20, sender, e);
            Make_Maze(70, 220, 20, 10, sender, e);
            Make_Maze(50, 240, 20, 10, sender, e);
            Make_Maze(80, 230, 10, 20, sender, e);
            Make_Maze(80, 270, 10, 20, sender, e);
            Make_Maze(100, 160, 50, 10, sender, e);
            Make_Maze(100, 170, 10, 20, sender, e);
            Make_Maze(100, 200, 190, 10, sender, e);
            Make_Maze(100, 220, 10, 40, sender, e);
            Make_Maze(110, 240, 10, 10, sender, e);
            Make_Maze(120, 210, 10, 60, sender, e);
            Make_Maze(140, 210, 10, 20, sender, e);
            Make_Maze(160, 210, 10, 20, sender, e);
            Make_Maze(180, 210, 10, 20, sender, e);
            Make_Maze(100, 280, 50, 10, sender, e);
            Make_Maze(100, 300, 10, 30, sender, e);
            Make_Maze(110, 320, 80, 10, sender, e);
            Make_Maze(100, 350, 10, 40, sender, e);
            Make_Maze(110, 380, 10, 10, sender, e);
            Make_Maze(120, 360, 10, 40, sender, e);
            Make_Maze(120, 120, 50, 10, sender, e);
            Make_Maze(120, 130, 10, 20, sender, e);
            Make_Maze(120, 180, 50, 10, sender, e);
            Make_Maze(140, 20, 130, 10, sender, e);
            Make_Maze(140, 30, 10, 20, sender, e);
            Make_Maze(260, 10, 10, 10, sender, e);
            Make_Maze(140, 60, 210, 10, sender, e);
            Make_Maze(140, 70, 10, 20, sender, e);
            Make_Maze(160, 70, 10, 20, sender, e);
            Make_Maze(140, 100, 170, 10, sender, e);
            Make_Maze(140, 140, 10, 20, sender, e);
            Make_Maze(150, 140, 40, 10, sender, e);
            Make_Maze(160, 110, 10, 70, sender, e);
            Make_Maze(170, 160, 20, 10, sender, e);
            Make_Maze(140, 240, 10, 30, sender, e);
            Make_Maze(150, 240, 20, 10, sender, e);
            Make_Maze(160, 250, 10, 30, sender, e);
            Make_Maze(140, 290, 10, 10, sender, e);
            Make_Maze(120, 300, 60, 10, sender, e);
            Make_Maze(140, 240, 10, 30, sender, e);
            Make_Maze(140, 280, 10, 20, sender, e);
            Make_Maze(160, 280, 10, 20, sender, e);
            Make_Maze(170, 280, 20, 10, sender, e);
            Make_Maze(180, 280, 10, 50, sender, e);
            Make_Maze(140, 380, 10, 20, sender, e);
            Make_Maze(160, 380, 10, 20, sender, e);
            Make_Maze(140, 340, 10, 30, sender, e);
            Make_Maze(150, 360, 40, 10, sender, e);
            Make_Maze(180, 340, 10, 50, sender, e);
            Make_Maze(190, 380, 60, 10, sender, e);
            Make_Maze(220, 390, 10, 10, sender, e);
            Make_Maze(160, 40, 60, 10, sender, e);
            Make_Maze(210, 30, 10, 10, sender, e);
            Make_Maze(180, 80, 30, 10, sender, e);
            Make_Maze(180, 110, 10, 20, sender, e);
            Make_Maze(200, 90, 10, 80, sender, e);
            Make_Maze(220, 80, 10, 20, sender, e);
            Make_Maze(240, 70, 10, 20, sender, e);
            Make_Maze(260, 80, 80, 10, sender, e);
            Make_Maze(240, 40, 50, 10, sender, e);
            Make_Maze(280, 50, 10, 10, sender, e);
            Make_Maze(280, 20, 30, 10, sender, e);
            Make_Maze(300, 10, 10, 10, sender, e);
            Make_Maze(300, 40, 10, 20, sender, e);
            Make_Maze(320, 20, 50, 10, sender, e);
            Make_Maze(340, 10, 10, 10, sender, e);
            Make_Maze(380, 10, 10, 20, sender, e);
            Make_Maze(360, 30, 10, 20, sender, e);
            Make_Maze(320, 40, 40, 10, sender, e);
            Make_Maze(320, 50, 10, 10, sender, e);
            Make_Maze(340, 70, 10, 120, sender, e);
            Make_Maze(320, 100, 20, 10, sender, e);
            Make_Maze(300, 110, 10, 20, sender, e);
            Make_Maze(310, 120, 30, 10, sender, e);
            Make_Maze(260, 110, 10, 40, sender, e);
            Make_Maze(220, 120, 40, 10, sender, e);
            Make_Maze(220, 130, 10, 50, sender, e);
            Make_Maze(180, 180, 70, 10, sender, e);
            Make_Maze(240, 130, 10, 20, sender, e);
            Make_Maze(270, 140, 20, 10, sender, e);
            Make_Maze(280, 110, 10, 20, sender, e);
            Make_Maze(240, 160, 50, 10, sender, e);
            Make_Maze(260, 170, 10, 30, sender, e);
            Make_Maze(280, 170, 10, 20, sender, e);
            Make_Maze(300, 180, 10, 10, sender, e);
            Make_Maze(320, 130, 10, 10, sender, e);
            Make_Maze(300, 140, 30, 10, sender, e);
            Make_Maze(300, 150, 10, 60, sender, e);
            Make_Maze(320, 160, 20, 10, sender, e);
            Make_Maze(320, 180, 20, 10, sender, e);
            Make_Maze(320, 190, 10, 20, sender, e);
            Make_Maze(360, 60, 40, 10, sender, e);
            Make_Maze(360, 70, 10, 20, sender, e);
            Make_Maze(380, 40, 10, 90, sender, e);
            Make_Maze(360, 120, 20, 10, sender, e);
            Make_Maze(360, 100, 20, 10, sender, e);
            Make_Maze(360, 130, 10, 20, sender, e);
            Make_Maze(380, 140, 20, 10, sender, e);
            Make_Maze(360, 160, 40, 10, sender, e);
            Make_Maze(360, 180, 40, 10, sender, e);
            Make_Maze(180, 240, 20, 10, sender, e);
            Make_Maze(180, 250, 10, 20, sender, e);
            Make_Maze(200, 220, 10, 50, sender, e);
            Make_Maze(210, 260, 20, 10, sender, e);
            Make_Maze(220, 270, 10, 60, sender, e);
            Make_Maze(200, 280, 20, 10, sender, e);
            Make_Maze(200, 300, 50, 10, sender, e);
            Make_Maze(200, 300, 10, 30, sender, e);
            Make_Maze(200, 340, 30, 10, sender, e);
            Make_Maze(200, 350, 10, 30, sender, e);
            Make_Maze(210, 360, 30, 10, sender, e);
            Make_Maze(240, 340, 10, 30, sender, e);
            Make_Maze(220, 220, 30, 10, sender, e);
            Make_Maze(240, 230, 10, 10, sender, e);
            Make_Maze(220, 240, 50, 10, sender, e);
            Make_Maze(260, 50, 10, 10, sender, e);
            Make_Maze(240, 260, 40, 10, sender, e);
            Make_Maze(260, 220, 30, 10, sender, e);
            Make_Maze(160, 330, 10, 10, sender, e);
            Make_Maze(160, 340, 30, 10, sender, e);
            Make_Maze(260, 250, 10, 10, sender, e);
            Make_Maze(240, 280, 10, 20, sender, e);
            Make_Maze(250, 280, 60, 10, sender, e);
            Make_Maze(280, 230, 10, 100, sender, e);
            Make_Maze(260, 300, 20, 10, sender, e);
            Make_Maze(240, 320, 40, 10, sender, e);
            Make_Maze(260, 330, 10, 20, sender, e);
            Make_Maze(260, 360, 10, 20, sender, e);
            Make_Maze(260, 380, 50, 10, sender, e);
            Make_Maze(280, 340, 10, 40, sender, e);
            Make_Maze(300, 340, 10, 60, sender, e);
            Make_Maze(300, 260, 90, 10, sender, e);
            Make_Maze(300, 270, 10, 10, sender, e);
            Make_Maze(300, 220, 10, 20, sender, e);
            Make_Maze(320, 220, 10, 20, sender, e);
            Make_Maze(300, 240, 50, 10, sender, e);
            Make_Maze(340, 200, 10, 40, sender, e);
            Make_Maze(350, 220, 30, 10, sender, e);
            Make_Maze(360, 200, 30, 10, sender, e);
            Make_Maze(380, 210, 10, 30, sender, e);
            Make_Maze(360, 240, 40, 10, sender, e);
            Make_Maze(360, 250, 10, 40, sender, e);
            Make_Maze(320, 270, 10, 40, sender, e);
            Make_Maze(300, 300, 20, 10, sender, e);
            Make_Maze(340, 270, 10, 40, sender, e);
            Make_Maze(380, 270, 10, 30, sender, e);
            Make_Maze(360, 300, 30, 10, sender, e);
            Make_Maze(300, 320, 90, 10, sender, e);
            Make_Maze(320, 340, 30, 10, sender, e);
            Make_Maze(340, 350, 10, 10, sender, e);
            Make_Maze(320, 360, 60, 10, sender, e);
            Make_Maze(320, 380, 30, 10, sender, e);
            Make_Maze(340, 390, 10, 10, sender, e);
            Make_Maze(360, 340, 10, 20, sender, e);
            Make_Maze(360, 380, 10, 20, sender, e);

            Make_Maze(380, 330, 10, 70, sender, e);

/*            Image DarkSight = Image.FromFile("1500.png"); // 사용할 이미지 로드(이미지는 exe 파일과 같은 디렉토리에 둘 것!)
            Graphics g; // 시야제한 이미지를 담을 새로운 변수
            g = e.Graphics;
            g.DrawImage(DarkSight, _x - (DarkSight.Width / 2) + (char_width / 2), _y - (DarkSight.Height / 2) + (char_height / 2));
*/
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, char_width, char_height); // 말 생성 (반드시 시야제한 넣은 이후에!)
        }

        // 키 입력
        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            // 오른쪽 방향키 입력
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(!arr[_x + char_width / 2 + 5, _y + char_height / 2])
                        _x += 1;
                    Invalidate();
                    //Delay(1);
                }
              
            }
            
            // 왼쪽 방향키 입력
            else if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!arr[_x + char_width / 2 - 5, _y + char_height / 2])
                        _x -= 1;
                    Invalidate();
                    //Delay(1);
                }
            }

            // 위쪽 방향키 입력
            else if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(!arr[_x + char_width / 2, _y + char_height / 2 - 5])
                        _y -= 1;
                    Invalidate();
                    //Delay(1);
                } 
            }

            // 아래쪽 방향키 입력
            else if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(!arr[_x + char_width / 2, _y + char_height / 2 + 5])
                        _y += 1;
                    Invalidate();
                    //Delay(1);
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
