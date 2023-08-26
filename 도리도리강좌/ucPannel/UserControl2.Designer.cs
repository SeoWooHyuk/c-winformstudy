namespace 도리도리강좌.ucPannel
{
    partial class UserControl2
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
            textBoxname = new TextBox();
            listBoxDay = new ListBox();
            listBoxTime = new ListBox();
            buttonResult = new Button();
            buttonResult2 = new Button();
            tboxResult = new TextBox();
            SuspendLayout();
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(52, 29);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(125, 27);
            textBoxname.TabIndex = 0;
            // 
            // listBoxDay
            // 
            listBoxDay.FormattingEnabled = true;
            listBoxDay.ItemHeight = 20;
            listBoxDay.Location = new Point(52, 62);
            listBoxDay.Name = "listBoxDay";
            listBoxDay.Size = new Size(280, 224);
            listBoxDay.TabIndex = 1;
            // 
            // listBoxTime
            // 
            listBoxTime.FormattingEnabled = true;
            listBoxTime.ItemHeight = 20;
            listBoxTime.Location = new Point(351, 62);
            listBoxTime.Name = "listBoxTime";
            listBoxTime.Size = new Size(243, 224);
            listBoxTime.TabIndex = 2;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(170, 305);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(94, 29);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "결과보기";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonResult2
            // 
            buttonResult2.Location = new Point(283, 305);
            buttonResult2.Name = "buttonResult2";
            buttonResult2.Size = new Size(94, 29);
            buttonResult2.TabIndex = 4;
            buttonResult2.Text = "StringFormat test";
            buttonResult2.UseVisualStyleBackColor = true;
            buttonResult2.Click += buttonResult2_Click;
            // 
            // tboxResult
            // 
            tboxResult.Enabled = false;
            tboxResult.Location = new Point(626, 50);
            tboxResult.Multiline = true;
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(254, 303);
            tboxResult.TabIndex = 5;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tboxResult);
            Controls.Add(buttonResult2);
            Controls.Add(buttonResult);
            Controls.Add(listBoxTime);
            Controls.Add(listBoxDay);
            Controls.Add(textBoxname);
            Name = "UserControl2";
            Size = new Size(938, 428);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxname;
        private ListBox listBoxDay;
        private ListBox listBoxTime;
        private Button buttonResult;
        private Button buttonResult2;
        private TextBox tboxResult;
    }
}
