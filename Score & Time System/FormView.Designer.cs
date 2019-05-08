namespace Object_Moving
{
    partial class FormView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_PastTime = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_RemainTime = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_PastTime
            // 
            this.lbl_PastTime.AutoSize = true;
            this.lbl_PastTime.Location = new System.Drawing.Point(124, 450);
            this.lbl_PastTime.Name = "lbl_PastTime";
            this.lbl_PastTime.Size = new System.Drawing.Size(33, 12);
            this.lbl_PastTime.TabIndex = 0;
            this.lbl_PastTime.Text = "0.0초";
            this.lbl_PastTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(182, 450);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(35, 12);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "15000";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lbl_RemainTime
            // 
            this.lbl_RemainTime.AutoSize = true;
            this.lbl_RemainTime.Location = new System.Drawing.Point(36, 450);
            this.lbl_RemainTime.Name = "lbl_RemainTime";
            this.lbl_RemainTime.Size = new System.Drawing.Size(33, 12);
            this.lbl_RemainTime.TabIndex = 2;
            this.lbl_RemainTime.Text = "0.0초";
            this.lbl_RemainTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 420);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 12);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "남은 시간";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "지난 시간";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "점수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_RemainTime);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_PastTime);
            this.DoubleBuffered = true;
            this.Name = "FormView";
            this.Text = "Object Moving";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PastTime;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lbl_RemainTime;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

