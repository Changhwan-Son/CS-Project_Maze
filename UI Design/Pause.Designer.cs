namespace UI_Design
{
    partial class Pause
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnContinue.Location = new System.Drawing.Point(389, 79);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(429, 135);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "계속하기";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOption
            // 
            this.btnOption.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOption.Location = new System.Drawing.Point(389, 283);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(429, 135);
            this.btnOption.TabIndex = 5;
            this.btnOption.Text = "환경설정";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMain.Location = new System.Drawing.Point(389, 488);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(429, 135);
            this.btnMain.TabIndex = 6;
            this.btnMain.Text = "메인메뉴";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnContinue);
            this.Name = "Pause";
            this.Size = new System.Drawing.Size(1208, 708);
            this.Load += new System.EventHandler(this.Pause_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnMain;
    }
}
