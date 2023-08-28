namespace 도리도리강좌
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button4 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.Size = new Size(943, 515);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(button5, 4, 0);
            tableLayoutPanel2.Controls.Add(button6, 0, 1);
            tableLayoutPanel2.Controls.Add(button7, 1, 1);
            tableLayoutPanel2.Controls.Add(button9, 3, 1);
            tableLayoutPanel2.Controls.Add(button10, 4, 1);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button8, 2, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 437);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.Size = new Size(937, 75);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(751, 3);
            button5.Name = "button5";
            button5.Size = new Size(183, 33);
            button5.TabIndex = 4;
            button5.Text = "캡슐화";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 42);
            button6.Name = "button6";
            button6.Size = new Size(181, 29);
            button6.TabIndex = 5;
            button6.Text = "파일입출력";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(190, 42);
            button7.Name = "button7";
            button7.Size = new Size(181, 29);
            button7.TabIndex = 6;
            button7.Text = "타이머+암호복호";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(564, 42);
            button9.Name = "button9";
            button9.Size = new Size(181, 29);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.InactiveCaptionText;
            button10.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.Red;
            button10.Location = new Point(751, 42);
            button10.Name = "button10";
            button10.Size = new Size(183, 30);
            button10.TabIndex = 9;
            button10.Text = "exit";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.Location = new Point(564, 3);
            button4.Name = "button4";
            button4.Size = new Size(181, 33);
            button4.TabIndex = 3;
            button4.Text = "상속 그림그리기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Location = new Point(377, 42);
            button8.Name = "button8";
            button8.Size = new Size(181, 29);
            button8.TabIndex = 7;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(181, 33);
            button1.TabIndex = 10;
            button1.Text = "연산자+진수변환기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 3);
            button2.Name = "button2";
            button2.Size = new Size(181, 33);
            button2.TabIndex = 11;
            button2.Text = "Enum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(377, 3);
            button3.Name = "button3";
            button3.Size = new Size(181, 33);
            button3.TabIndex = 12;
            button3.Text = "배열";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 428);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 515);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += form_load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}