using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace UI_Design
{
    public partial class Rank : UserControl
    {
        // 파일스트림 전역변수
        public string file_path = @"C:\Users\Son\source\repos\UI Design\bin\Debug\score.txt";
        public FileStream fs_read;
        public StreamReader sr;

        public Rank()
        {
            InitializeComponent();
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            score_Load();
        }

        private void score_Load()
        {
            fs_read = new FileStream(file_path, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs_read, Encoding.UTF8);

            string text = sr.ReadToEnd();
            string[] words = text.Split(' ', '\n');

            lbl_Name.Text = null;
            lbl_Score.Text = null;

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (i % 2 == 0)
                    lbl_Name.Text += words[i] + '\n';

                else
                    lbl_Score.Text += words[i];
            }

            sr.Close();
            sr.Dispose();
            fs_read.Close();
            fs_read.Dispose();
        }
    }
}
