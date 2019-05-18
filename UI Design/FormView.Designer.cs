namespace UI_Design
{
    partial class FormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pause1 = new UI_Design.Pause();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_PastTime = new System.Windows.Forms.Label();
            this.lbl_RemainTime = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.Item0 = new System.Windows.Forms.Label();
            this.Item4 = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.Label();
            this.Item2 = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.Label();
            this.Item6 = new System.Windows.Forms.Label();
            this.Item5 = new System.Windows.Forms.Label();
            this.Item8 = new System.Windows.Forms.Label();
            this.Item7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pause1
            // 
            this.pause1.BackColor = System.Drawing.SystemColors.Control;
            this.pause1.Location = new System.Drawing.Point(12, 8);
            this.pause1.Name = "pause1";
            this.pause1.Size = new System.Drawing.Size(1190, 673);
            this.pause1.TabIndex = 0;
            this.pause1.Visible = false;
            this.pause1.Load += new System.EventHandler(this.pause1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "남은 시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(216, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "지난 시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(445, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "점수";
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Score.Location = new System.Drawing.Point(445, 557);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(108, 41);
            this.lbl_Score.TabIndex = 6;
            this.lbl_Score.Text = "15000";
            // 
            // lbl_PastTime
            // 
            this.lbl_PastTime.AutoSize = true;
            this.lbl_PastTime.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_PastTime.Location = new System.Drawing.Point(216, 557);
            this.lbl_PastTime.Name = "lbl_PastTime";
            this.lbl_PastTime.Size = new System.Drawing.Size(94, 41);
            this.lbl_PastTime.TabIndex = 5;
            this.lbl_PastTime.Text = "0.0초";
            // 
            // lbl_RemainTime
            // 
            this.lbl_RemainTime.AutoSize = true;
            this.lbl_RemainTime.Font = new System.Drawing.Font("함초롬돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_RemainTime.Location = new System.Drawing.Point(28, 557);
            this.lbl_RemainTime.Name = "lbl_RemainTime";
            this.lbl_RemainTime.Size = new System.Drawing.Size(94, 41);
            this.lbl_RemainTime.TabIndex = 4;
            this.lbl_RemainTime.Text = "0.0초";
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Item0
            // 
            this.Item0.AutoSize = true;
            this.Item0.Location = new System.Drawing.Point(1031, 34);
            this.Item0.Name = "Item0";
            this.Item0.Size = new System.Drawing.Size(35, 12);
            this.Item0.TabIndex = 7;
            this.Item0.Text = "Item0";
            // 
            // Item4
            // 
            this.Item4.AutoSize = true;
            this.Item4.Location = new System.Drawing.Point(1037, 314);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(38, 12);
            this.Item4.TabIndex = 8;
            this.Item4.Text = "label5";
            // 
            // Item3
            // 
            this.Item3.AutoSize = true;
            this.Item3.Location = new System.Drawing.Point(1031, 239);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(38, 12);
            this.Item3.TabIndex = 9;
            this.Item3.Text = "label6";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.Location = new System.Drawing.Point(1031, 182);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(38, 12);
            this.Item2.TabIndex = 10;
            this.Item2.Text = "label7";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.Location = new System.Drawing.Point(1031, 123);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(38, 12);
            this.Item1.TabIndex = 11;
            this.Item1.Text = "label8";
            // 
            // Item6
            // 
            this.Item6.AutoSize = true;
            this.Item6.Location = new System.Drawing.Point(1037, 436);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(38, 12);
            this.Item6.TabIndex = 12;
            this.Item6.Text = "label9";
            // 
            // Item5
            // 
            this.Item5.AutoSize = true;
            this.Item5.Location = new System.Drawing.Point(1031, 385);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(44, 12);
            this.Item5.TabIndex = 13;
            this.Item5.Text = "label10";
            // 
            // Item8
            // 
            this.Item8.AutoSize = true;
            this.Item8.Location = new System.Drawing.Point(1037, 523);
            this.Item8.Name = "Item8";
            this.Item8.Size = new System.Drawing.Size(38, 12);
            this.Item8.TabIndex = 14;
            this.Item8.Text = "label5";
            // 
            // Item7
            // 
            this.Item7.AutoSize = true;
            this.Item7.Location = new System.Drawing.Point(1037, 495);
            this.Item7.Name = "Item7";
            this.Item7.Size = new System.Drawing.Size(38, 12);
            this.Item7.TabIndex = 15;
            this.Item7.Text = "label6";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 669);
            this.Controls.Add(this.Item7);
            this.Controls.Add(this.Item8);
            this.Controls.Add(this.Item5);
            this.Controls.Add(this.Item6);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.Item0);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_PastTime);
            this.Controls.Add(this.lbl_RemainTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pause1);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormView_FormClosing);
            this.Load += new System.EventHandler(this.FormView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pause pause1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_PastTime;
        private System.Windows.Forms.Label lbl_RemainTime;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label Item0;
        private System.Windows.Forms.Label Item4;
        private System.Windows.Forms.Label Item3;
        private System.Windows.Forms.Label Item2;
        private System.Windows.Forms.Label Item1;
        private System.Windows.Forms.Label Item6;
        private System.Windows.Forms.Label Item5;
        private System.Windows.Forms.Label Item8;
        private System.Windows.Forms.Label Item7;
    }
}