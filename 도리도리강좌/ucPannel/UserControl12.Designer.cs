namespace 도리도리강좌.ucPannel
{
    partial class UserControl12
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            btstart = new Button();
            numberup = new NumericUpDown();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberup).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btstart);
            groupBox1.Controls.Add(numberup);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(466, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(353, 324);
            listBox1.TabIndex = 3;
            // 
            // btstart
            // 
            btstart.Location = new Point(211, 37);
            btstart.Name = "btstart";
            btstart.Size = new Size(94, 29);
            btstart.TabIndex = 2;
            btstart.Text = "시작";
            btstart.UseVisualStyleBackColor = true;
            btstart.Click += btstart_Click;
            // 
            // numberup
            // 
            numberup.Location = new Point(107, 37);
            numberup.Name = "numberup";
            numberup.Size = new Size(82, 27);
            numberup.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "player 수 : ";
            // 
            // UserControl12
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "UserControl12";
            Size = new Size(937, 439);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button btstart;
        private NumericUpDown numberup;
        private Label label1;
    }
}
