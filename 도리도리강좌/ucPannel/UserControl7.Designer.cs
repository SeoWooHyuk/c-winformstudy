namespace 도리도리강좌.ucPannel
{
    partial class UserControl7
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 159);
            label1.Name = "label1";
            label1.Size = new Size(299, 81);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(150, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 298);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(150, 333);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(123, 111);
            label2.Name = "label2";
            label2.Size = new Size(299, 38);
            label2.TabIndex = 4;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 267);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 5;
            label3.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 302);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 6;
            label4.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 337);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 7;
            label5.Text = "50";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 122);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 8;
            label6.Text = "틱 포인트";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 267);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 9;
            label7.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 302);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 10;
            label8.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 337);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 11;
            label9.Text = "5000";
            // 
            // label10
            // 
            label10.BackColor = Color.Lime;
            label10.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(94, 24);
            label10.Name = "label10";
            label10.Size = new Size(766, 38);
            label10.TabIndex = 12;
            label10.Text = "틱포인트 게임 +암호화 복호화 예제";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControl7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserControl7";
            Size = new Size(937, 439);
            Load += UserControl7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
