using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI_Design
{
    public partial class FormView : Form
    {
        int _x = 10;     // 말 x 좌표
        int _y = 10;     // 말 y 좌표 

        int char_width = 50;
        int char_height = 50;

        int feet_type = 1;

        bool[,] arr = new bool[500, 500];
        PaintEventArgs n;

        private int time = 0; // 시간 변수
        private int score = 15000; // 점수 변수
        private const int REDUCE = 25; // 감소폭 상수

        //아이템 관련 전역 변수
        int[] arr1 = new int[10];       //아이템 배치 배열 x좌표
        int[] arr2 = new int[10];       //아이템 배치 배열 y좌표
        int[] Item_array = new int[10]; //아이템 배열
        bool set_Item = false;          //아이템 배치는 한번만
        int x, y; // 폭탄 위치
        int jump_count = 0; // 쓸수 있는 점프 갯수
        bool boom = false; // 아이템 폭탄 발동 조건
        bool jump = false;  // 아이템 점프 발동 조건
        int[] bomb_array_x = new int[10]; //폭탄 발생 지점 저장
        int[] bomb_array_y = new int[10]; //폭탄 발생 지점 저장
        int count_bomb = 0; // 쓸수 잇는 폭탄갯수
        int speed = 10; // 초기화 스피드
        int jump_jump = 100; // 점프 상한선
        //파일스트림 관련 전역변수
        public string file_path = "score.txt";
        public FileStream fs_write;
        public StreamWriter sw;

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
        public void set_False(int x_start, int y_start, int width, int height) // 벽 파괴 함수
        {
            for (int i = x_start; i < x_start + width; i++)
                for (int j = y_start; j < y_start + height; j++)
                    arr[i, j] = false;
        }
        

        // 벽 그려주고 Map 에서 true 설정
        private void Make_Maze(int start_x, int start_y, int width, int height, object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Brushes.DarkSlateGray), start_x, start_y, width, height);
            set(start_x, start_y, width, height);
        }
        private void Destroy_Maze(int start_x, int start_y, int width, int height, object sender, PaintEventArgs e) // 벽파괴 실행
        {
            x = start_x;
            y = start_y;
            bomb_array_x[count_bomb] = x;
            bomb_array_y[count_bomb] = y;


            count_bomb++;
            boom = false;
        }
        private void Show_Bomb(PaintEventArgs e) // 벽파괴 범위 그려주고 파괴시키기
        {
            for (int i = 0; i < count_bomb; i++)
            {
                e.Graphics.FillRectangle((Brushes.Red), bomb_array_x[i] + 50, bomb_array_y[i], char_width, char_height);
                e.Graphics.FillRectangle((Brushes.Red), bomb_array_x[i] - 50, bomb_array_y[i], char_width, char_height);
                e.Graphics.FillRectangle((Brushes.Red), bomb_array_x[i], bomb_array_y[i] + 50, char_width, char_height);
                e.Graphics.FillRectangle((Brushes.Red), bomb_array_x[i], bomb_array_y[i] - 50, char_width, char_height);
                set_False(bomb_array_x[i] + 50, bomb_array_y[i], char_width, char_height);
                set_False(bomb_array_x[i], bomb_array_y[i] + 50, char_width, char_height);
                set_False(bomb_array_x[i] - 50, bomb_array_y[i], char_width, char_height);
                set_False(bomb_array_x[i], bomb_array_y[i] - 50, char_width, char_height);


            }
        }
        public FormView()
        {
            InitializeComponent();
        }
        private void Miro1(object sender, PaintEventArgs e)
        {
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

        }
        // 말 생성
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            reset();
            ItemBox(700, 700, e); // 아이템 박스
            //Miro1(sender, e);
            Make_Maze(0, 0, 10, 420, sender, e);        // 위 테두리
            Make_Maze(0, 0, 420, 10, sender, e);        // 왼쪽 테두리
            Make_Maze(0, 410, 420, 10, sender, e);      // 밑 테두리
            Make_Maze(410, 0, 10, 410, sender, e);      // 오른쪽 테두리

            Make_Maze(60, 10, 50, 50, sender, e);
            Make_Maze(310, 10, 50, 50, sender, e);
            Make_Maze(10, 110, 150, 50, sender, e);
            Make_Maze(160, 60, 100, 50, sender, e);
            Make_Maze(310, 110, 50, 50, sender, e);

            Make_Maze(160, 160, 50, 50, sender, e);
            Make_Maze(260, 160, 50, 50, sender, e);
            Make_Maze(60, 260, 50, 50, sender, e);
            Make_Maze(210, 210, 50, 50, sender, e);
            Make_Maze(60, 210, 50, 50, sender, e);
            Make_Maze(160, 210, 50, 50, sender, e);
            Make_Maze(260, 210, 50, 50, sender, e);
            Make_Maze(360, 210, 50, 50, sender, e);
            Make_Maze(360, 260, 50, 50, sender, e);
            Make_Maze(110, 310, 50, 50, sender, e);
            Make_Maze(210, 310, 50, 50, sender, e);
            Make_Maze(310, 310, 100, 50, sender, e);
            Make_Maze(10, 360, 100, 50, sender, e);

            
            Draw_Item(e);
            Eat_Item(e);
            if (boom == true)// X키 눌렀을 때 발동
                Destroy_Maze(_x, _y, 50, 50, sender, e);
            Show_Bomb(e);
            /*            Image DarkSight = Image.FromFile("1500.png"); // 사용할 이미지 로드(이미지는 exe 파일과 같은 디렉토리에 둘 것!)
                        Graphics g; // 시야제한 이미지를 담을 새로운 변수
                        g = e.Graphics;
                        g.DrawImage(DarkSight, _x - (DarkSight.Width / 2) + (char_width / 2), _y - (DarkSight.Height / 2) + (char_height / 2));
            */
            //e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, char_width, char_height); // 말 생성 (반드시 시야제한 넣은 이후에!)
            
            Image imageFile = Image.FromFile("./feet.png"); ;
            switch (feet_type)
            {
                case 1:
                    imageFile = Image.FromFile("./feet.png");
                    break;
                case 2:
                    imageFile = Image.FromFile("./feet_right.png");
                    break;
                case 3:
                    imageFile = Image.FromFile("./feet_down.png");
                    break;
                case 4:
                    imageFile = Image.FromFile("./feet_left.png");
                    break;

            }


            e.Graphics.DrawImage(imageFile, _x, _y, char_width, char_height);
        
        }

        // 키 입력
        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Hourglass();
            else if (e.KeyCode == Keys.D1 && Item0.Text == "1번째 아이템")
                Item0.Text = "asd";
            else if (e.KeyCode == Keys.D2 && Item1.Text == "2번째 아이템")
                Item1.Text = "asd";
            else if (e.KeyCode == Keys.D3 && Item2.Text == "3번째 아이템")
                Item2.Text = "asd";
            else if (e.KeyCode == Keys.D4 && Item3.Text == "4번째 아이템")
                Item3.Text = "asd";
            else if (e.KeyCode == Keys.D5 && Item4.Text == "5번째 아이템")
                Item4.Text = "asd";
            else if (e.KeyCode == Keys.D6 && Item5.Text == "6번째 아이템")
                Item5.Text = "asd";
            else if (e.KeyCode == Keys.D7 && Item6.Text == "7번째 아이템")
                Item6.Text = "asd";
            else if (e.KeyCode == Keys.D8 && Item7.Text == "8번째 아이템")
                Item7.Text = "asd";
            else if (e.KeyCode == Keys.D9 && Item8.Text == "9번째 아이템")
                Item8.Text = "asd";
            // 오른쪽 방향키 입력
            if (e.KeyCode == Keys.Right)
            {
                if (jump == true && jump_count < jump_jump)
                {
                    if (!arr[_x + char_width / 2 - 30, _y + char_height / 2])
                        _x += 55;
                    jump = false;
                    jump_count++;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (!arr[_x + char_width / 2 + 30, _y + char_height / 2])
                        _x += 5;
                    feet_type = 2;
                    Invalidate();
                    //Delay(1);
                    activate_Timer();

                }

            }

            // 왼쪽 방향키 입력
            else if (e.KeyCode == Keys.Left)
            {
                if (jump == true && jump_count < jump_jump)
                {
                    if (!arr[_x + char_width / 2 + 30, _y + char_height / 2])
                        _x -= 55;
                    jump = false;
                    jump_count++;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (!arr[_x + char_width / 2 - 30, _y + char_height / 2])
                        _x -= 5;

                    feet_type = 4;
                    Invalidate();
                    //Delay(1);
                    activate_Timer();

                }
            }

            // 위쪽 방향키 입력
            else if (e.KeyCode == Keys.Up)
            {
                if (jump == true && jump_count < jump_jump)
                {
                    if (!arr[_x + char_width / 2, _y + char_height / 2 - 30])

                        _y += 55;
                    jump = false;
                    jump_count++;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (!arr[_x + char_width / 2, _y + char_height / 2 - 30])
                        _y -= 5;
                    feet_type = 1;
                    Invalidate();
                    //Delay(1);
                    activate_Timer();

                }
            }

            // 아래쪽 방향키 입력
            else if (e.KeyCode == Keys.Down)
            {
                if (jump == true && jump_count < jump_jump)
                {
                    if (!arr[_x + char_width / 2, _y + char_height / 2 + 30])
                        _y -= 55;
                    jump = false;
                    jump_count++;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (!arr[_x + char_width / 2, _y + char_height / 2 + 30])
                        _y += 5;
                    feet_type = 3;
                    Invalidate();
                    //Delay(1);
                    activate_Timer();

                }
            }
            else if (e.KeyCode == Keys.X) // 폭탄 발동
            {
                boom = true;
            }
            else if (e.KeyCode == Keys.Z) // 점프 발동
            {
                jump = true;
            }

            // 일시정지
            if (e.KeyCode == Keys.Escape)
            {
                pause1.BackColor = Color.FromArgb(200, 224, 224, 224);
                    
                pause1.Visible = true;
            }

            if(e.KeyCode == Keys.S)
                score_Save();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void Hourglass()            //모래 시계(시간 추가 아이템)
        {
            Random rand = new Random();
            int save_score = score;
            int count = 0;
            count = rand.Next(1, 3);
            if (count == 1)        //시간 늘리기
                score += rand.Next(2500, 7500);                      //1000=4초    10초 ~ 30초 안으로 랜덤 추가
            else
                score -= rand.Next(2000, 4000);                     //8초 ~ 16초 안으로 시간 감소
        }

        private void ItemBox(int x, int y, PaintEventArgs e)          //옆에 생기는 갈색 선
        {
            e.Graphics.FillRectangle((Brushes.Brown), x, 0, 20, y);
            for (int i = 1; i < 10; i++)
            {
                e.Graphics.FillRectangle((Brushes.Brown), x, (y * i) / 10, 100, 10);
            }
        }

        private void Random_Item(PaintEventArgs e)          //랜덤으로 아이템 배치 좌표 구하기
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    arr1[i] = rand.Next(0, 410);
                    arr2[i] = rand.Next(0, 410);

                    if (arr[arr1[i], arr2[i]] == false && arr[arr1[i] + 9, arr2[i]] == false && arr[arr1[i], arr2[i] + 9] == false && arr[arr1[i] + 9, arr2[i] + 9] == false)
                    {
                        break;
                    }
                }
            }
        }

        private void Draw_Item(PaintEventArgs e)        //Random_Item에서 구한 좌표에다가 아이템 배치
        {
            if (set_Item == false)
            {
                Random_Item(e);
                set_Item = true;
            }
            for (int i = 0; i < 10; i++)
            {
                if (arr1[i] != -1 && arr2[i] != -1)
                    e.Graphics.FillRectangle(Brushes.Pink, arr1[i], arr2[i], 7, 7);
            }
        }

        private void Eat_Item(PaintEventArgs e)         //아이템 먹기
        {
            for (int i = 0; i < 10; i++)
            {
                if (arr1[i] + 3 >= _x && arr1[i] + 3 <= _x + 10 && arr2[i] + 3 >= _y && arr2[i] + 3 <= _y + 10)
                {
                    arr1[i] = -1;
                    arr2[i] = -1;
                    Item_array[i] = -1;
                    Item_window();
                }
            }
        }

        private void Item_window()          //아이템 창 목록
        {
            if (Item0.Text == "asd")
                Item0.Text = "1번째 아이템";
            else if (Item1.Text == "asd")
                Item1.Text = "2번째 아이템";
            else if (Item2.Text == "asd")
                Item2.Text = "3번째 아이템";
            else if (Item3.Text == "asd")
                Item3.Text = "4번째 아이템";
            else if (Item4.Text == "asd")
                Item4.Text = "5번째 아이템";
            else if (Item5.Text == "asd")
                Item5.Text = "6번째 아이템";
            else if (Item6.Text == "asd")
                Item6.Text = "7번째 아이템";
            else if (Item7.Text == "asd")
                Item7.Text = "8번째 아이템";
            else if (Item8.Text == "asd")
                Item8.Text = "9번째 아이템";
        }

        private void Use_Item(object sender, KeyEventArgs e)        //아이템 사용
        {
            string Key = e.KeyValue.ToString();
            if (Key == "0" && Item0.Text == "0번째 아이템")
                Item0.Text = "asd";

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            // 경과시간 출력
            time++;
            lbl_PastTime.Text = Convert.ToString(time / 10 + "." + time % 10 + "초");

            // 점수 출력
            score -= REDUCE; // 점수 감소폭
            lbl_Score.Text = Convert.ToString(score);

            // 남은시간 출력
            lbl_RemainTime.Text = Convert.ToString(score / REDUCE / 10 + "." + score / REDUCE % 10 + "초");

            if (score / REDUCE / 10 <= 14) // 시간이 얼마 안 남으면 라벨 배경,텍스트 색상 변경
            {
                lbl_RemainTime.BackColor = Color.Black;
                lbl_RemainTime.ForeColor = Color.Red;
            }

            // 사망 판정
            if (score <= 0)
            {
                tmr1.Enabled = false; // 타이멍 작동 정지
                MessageBox.Show("엌ㅋㅋㅋㅋ! 죽었습니닼ㅋㅋㅋㅋ!!");
                this.Close(); // 폼 종료
            }
        }

        private void activate_Timer()
        {
            if (!tmr1.Enabled)
                tmr1.Enabled = true; // 작동시작
        }

        private void pause1_Load(object sender, EventArgs e)
        {

        }

        private void score_Save()
        {
            fs_write = new FileStream(file_path, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs_write, Encoding.UTF8);

            MessageBox.Show("<닉네임 : " + score + "> 저장!");

            sw.WriteLine("닉네임 " + score);
            sw.Close();
            sw.Dispose();
            fs_write.Close();
            fs_write.Dispose();
        }
    }
}
