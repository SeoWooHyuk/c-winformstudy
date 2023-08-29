namespace 도리도리강좌.ucPannel
{
    partial class UserControl6
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            xmlbt1 = new Button();
            xmlbt2 = new Button();
            textBox3 = new TextBox();
            xmlbt4 = new Button();
            xmlbt3 = new Button();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            checkBox2 = new CheckBox();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(47, 42);
            button1.Name = "button1";
            button1.Size = new Size(126, 30);
            button1.TabIndex = 0;
            button1.Text = "txt파일가져오기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(47, 78);
            button2.Name = "button2";
            button2.Size = new Size(126, 30);
            button2.TabIndex = 1;
            button2.Text = "txt파일저장하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(34, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 266);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(500, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 155);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "config세팅";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 27);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(107, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 101);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 103);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "숫자";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "체크박스";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "텍스트";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(812, 42);
            button3.Name = "button3";
            button3.Size = new Size(109, 30);
            button3.TabIndex = 4;
            button3.Text = "설정가져오기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(812, 112);
            button4.Name = "button4";
            button4.Size = new Size(109, 30);
            button4.TabIndex = 5;
            button4.Text = "설정하기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // xmlbt1
            // 
            xmlbt1.AutoSize = true;
            xmlbt1.Location = new Point(257, 42);
            xmlbt1.Name = "xmlbt1";
            xmlbt1.Size = new Size(133, 30);
            xmlbt1.TabIndex = 6;
            xmlbt1.Text = "xml파일가져오기";
            xmlbt1.UseVisualStyleBackColor = true;
            xmlbt1.Click += xmlbt1_Click;
            // 
            // xmlbt2
            // 
            xmlbt2.AutoSize = true;
            xmlbt2.Location = new Point(257, 78);
            xmlbt2.Name = "xmlbt2";
            xmlbt2.Size = new Size(133, 30);
            xmlbt2.TabIndex = 7;
            xmlbt2.Text = "xml파일저장하기";
            xmlbt2.UseVisualStyleBackColor = true;
            xmlbt2.Click += xmlbt2_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(235, 114);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 266);
            textBox3.TabIndex = 8;
            // 
            // xmlbt4
            // 
            xmlbt4.AutoSize = true;
            xmlbt4.Location = new Point(812, 297);
            xmlbt4.Name = "xmlbt4";
            xmlbt4.Size = new Size(109, 30);
            xmlbt4.TabIndex = 11;
            xmlbt4.Text = "설정하기";
            xmlbt4.UseVisualStyleBackColor = true;
            xmlbt4.Click += xmlbt4_Click;
            // 
            // xmlbt3
            // 
            xmlbt3.AutoSize = true;
            xmlbt3.Location = new Point(812, 227);
            xmlbt3.Name = "xmlbt3";
            xmlbt3.Size = new Size(109, 30);
            xmlbt3.TabIndex = 10;
            xmlbt3.Text = "설정가져오기";
            xmlbt3.UseVisualStyleBackColor = true;
            xmlbt3.Click += xmlbt3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(500, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 155);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "xmlconfig세팅";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 33);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 27);
            textBox4.TabIndex = 5;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(107, 68);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 24);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(104, 101);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 103);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 2;
            label4.Text = "숫자";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 72);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 1;
            label5.Text = "체크박스";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 36);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "텍스트";
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(xmlbt4);
            Controls.Add(xmlbt3);
            Controls.Add(groupBox2);
            Controls.Add(textBox3);
            Controls.Add(xmlbt2);
            Controls.Add(xmlbt1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UserControl6";
            Size = new Size(937, 439);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button xmlbt1;
        private Button xmlbt2;
        private TextBox textBox3;
        private Button xmlbt4;
        private Button xmlbt3;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private CheckBox checkBox2;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
