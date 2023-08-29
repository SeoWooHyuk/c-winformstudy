namespace 도리도리강좌.ucPannel
{
    partial class UserControl1
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
            textBox1 = new TextBox();
            shiftbox = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // shiftbox
            // 
            shiftbox.Location = new Point(346, 324);
            shiftbox.Name = "shiftbox";
            shiftbox.Size = new Size(173, 27);
            shiftbox.TabIndex = 1;
            shiftbox.TextChanged += shiftbox_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(280, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(426, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(280, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(426, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(280, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(426, 27);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(536, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(645, 324);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 184);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 9;
            label1.Text = "2진수";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 217);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 10;
            label2.Text = "8진수";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 250);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "16진수";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 327);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 12;
            label4.Text = "쉬프트 연산자용";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 137);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 13;
            label5.Text = "result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(225, 41);
            label6.Name = "label6";
            label6.Size = new Size(517, 57);
            label6.TabIndex = 14;
            label6.Text = "진수 변환기 쉬프트연산자";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(shiftbox);
            Controls.Add(textBox1);
            Name = "UserControl1";
            Size = new Size(937, 439);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox shiftbox;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
