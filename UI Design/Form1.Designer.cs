namespace UI_Design
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home1 = new UI_Design.Home();
            this.credit1 = new UI_Design.Credit();
            this.playSelect1 = new UI_Design.PlaySelect();
            this.loading1 = new UI_Design.loading();
            this.rank1 = new UI_Design.Rank();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCredit);
            this.panel1.Controls.Add(this.btnOption);
            this.panel1.Controls.Add(this.btnRank);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 669);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Lavender;
            this.SidePanel.Location = new System.Drawing.Point(0, 70);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 83);
            this.SidePanel.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(28, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(258, 83);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "        EXIT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.FlatAppearance.BorderSize = 0;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.ForeColor = System.Drawing.Color.White;
            this.btnCredit.Image = ((System.Drawing.Image)(resources.GetObject("btnCredit.Image")));
            this.btnCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredit.Location = new System.Drawing.Point(28, 426);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(258, 83);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "        CREDIT";
            this.btnCredit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnOption
            // 
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.Color.White;
            this.btnOption.Image = ((System.Drawing.Image)(resources.GetObject("btnOption.Image")));
            this.btnOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.Location = new System.Drawing.Point(28, 337);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(258, 83);
            this.btnOption.TabIndex = 1;
            this.btnOption.Text = "        OPTION";
            this.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnRank
            // 
            this.btnRank.FlatAppearance.BorderSize = 0;
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRank.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.White;
            this.btnRank.Image = ((System.Drawing.Image)(resources.GetObject("btnRank.Image")));
            this.btnRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRank.Location = new System.Drawing.Point(28, 248);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(258, 83);
            this.btnRank.TabIndex = 3;
            this.btnRank.Text = "        RANK";
            this.btnRank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(28, 159);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(258, 83);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "        PLAY";
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(28, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(258, 83);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "        Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 19);
            this.panel2.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(333, 70);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(795, 471);
            this.home1.TabIndex = 8;
            // 
            // credit1
            // 
            this.credit1.Location = new System.Drawing.Point(333, 102);
            this.credit1.Name = "credit1";
            this.credit1.Size = new System.Drawing.Size(817, 431);
            this.credit1.TabIndex = 7;
            // 
            // playSelect1
            // 
            this.playSelect1.Location = new System.Drawing.Point(333, 102);
            this.playSelect1.Name = "playSelect1";
            this.playSelect1.Size = new System.Drawing.Size(817, 431);
            this.playSelect1.TabIndex = 5;
            // 
            // loading1
            // 
            this.loading1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.loading1.Location = new System.Drawing.Point(0, 0);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(1205, 669);
            this.loading1.TabIndex = 9;
            // 
            // rank1
            // 
            this.rank1.Location = new System.Drawing.Point(288, 70);
            this.rank1.Name = "rank1";
            this.rank1.Size = new System.Drawing.Size(914, 489);
            this.rank1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1192, 669);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.credit1);
            this.Controls.Add(this.playSelect1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rank1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel SidePanel;
        private PlaySelect playSelect1;
        private Credit credit1;
        private Home home1;
        private loading loading1;
        private Rank rank1;
    }
}

