namespace 도리도리강좌.ucPannel
{
    partial class UserControl9
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelpick1 = new Label();
            labelpick2 = new Label();
            labelpick3 = new Label();
            labelpick4 = new Label();
            pictureBox1 = new PictureBox();
            lbtotalcount = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pictureBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(labelpick1, 0, 1);
            tableLayoutPanel1.Controls.Add(labelpick2, 1, 1);
            tableLayoutPanel1.Controls.Add(labelpick3, 2, 1);
            tableLayoutPanel1.Controls.Add(labelpick4, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(100, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(669, 139);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources._4;
            pictureBox4.Location = new Point(504, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(162, 102);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources._3;
            pictureBox3.Location = new Point(337, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(161, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(170, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Click;
            // 
            // labelpick1
            // 
            labelpick1.AutoSize = true;
            labelpick1.Dock = DockStyle.Fill;
            labelpick1.Location = new Point(3, 108);
            labelpick1.Name = "labelpick1";
            labelpick1.Size = new Size(161, 31);
            labelpick1.TabIndex = 0;
            labelpick1.Text = "0";
            labelpick1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelpick2
            // 
            labelpick2.AutoSize = true;
            labelpick2.Dock = DockStyle.Fill;
            labelpick2.Location = new Point(170, 108);
            labelpick2.Name = "labelpick2";
            labelpick2.Size = new Size(161, 31);
            labelpick2.TabIndex = 1;
            labelpick2.Text = "1";
            labelpick2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelpick3
            // 
            labelpick3.AutoSize = true;
            labelpick3.Dock = DockStyle.Fill;
            labelpick3.Location = new Point(337, 108);
            labelpick3.Name = "labelpick3";
            labelpick3.Size = new Size(161, 31);
            labelpick3.TabIndex = 2;
            labelpick3.Text = "2";
            labelpick3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelpick4
            // 
            labelpick4.AutoSize = true;
            labelpick4.Dock = DockStyle.Fill;
            labelpick4.Location = new Point(504, 108);
            labelpick4.Name = "labelpick4";
            labelpick4.Size = new Size(162, 31);
            labelpick4.TabIndex = 3;
            labelpick4.Text = "3";
            labelpick4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Click;
            // 
            // lbtotalcount
            // 
            lbtotalcount.AutoSize = true;
            lbtotalcount.Location = new Point(100, 204);
            lbtotalcount.Name = "lbtotalcount";
            lbtotalcount.Size = new Size(105, 20);
            lbtotalcount.TabIndex = 1;
            lbtotalcount.Text = "total count : 0";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(669, 188);
            dataGridView1.TabIndex = 2;
            // 
            // UserControl9
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(lbtotalcount);
            Controls.Add(tableLayoutPanel1);
            Name = "UserControl9";
            Size = new Size(937, 439);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelpick1;
        private Label labelpick2;
        private Label labelpick3;
        private Label labelpick4;
        private Label lbtotalcount;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
