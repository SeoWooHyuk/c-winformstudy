using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl10 : UserControl
    {

        DataSet ds = new DataSet();  // 반의 정보를 가지고 있을 DataSet


        public UserControl10()
        {
            InitializeComponent();
        }

        //등록
        private void button1_Click(object sender, EventArgs e)
        {
            bool bCheckIsTalbe = false;

            // DataSet안에 해당하는 DataTable이 있는지 확인 한다
            if (ds.Tables.Contains(comboBox1.Text))
            {
                bCheckIsTalbe = true;
            }

            DataTable dt = null;

            if (!bCheckIsTalbe) //데이타 테이블이 없으면 생성
            {
                dt = new DataTable(comboBox1.Text);

                //DataColumn 생성
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                //생성된 Column을 DataTable에 Add
                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);

            }
            else
            {  //데이터테이블이있으면 
                dt = ds.Tables[comboBox1.Text];
            }



            //Row 생성
            DataRow row = dt.NewRow();
            row["NAME"] = textBox1.Text;

            if (radioButton1.Checked)
            {
                row["SEX"] = "여자";
            }
            else if (radioButton2.Checked)
            {
                row["SEX"] = "남자";
            }

            row["REF"] = textBox2.Text;


            //dt.Rows.Add(row);   // 신규로 작성한 DataTable에 Row를 등록 하고, 


            if (bCheckIsTalbe)
            {
                //ds.Tables.Remove(comboBox1.Text);  테이블이있으면 삭제하고 다시 등록한다
                //ds.Tables.Add(dt);

                ds.Tables[comboBox1.Text].Rows.Add(row); //기존에 값에 + 테이블의 값을 추가한다 
            }
            else
            {
                ds.Tables.Add(dt);  // 등록한 DataTable을 DataSet에 추가한다
            }
            comboBox2_SelectedIndexChanged(this, null);
        }

        //삭제
        private void button2_Click(object sender, EventArgs e)
        {

            int iSelectRow = dataGridView1.SelectedRows[0].Index;  // 선택 한 Row 중에서 첫번째 Row번호를 가져온다
            ds.Tables[comboBox2.Text].Rows.RemoveAt(iSelectRow);   // Table에서 선택한 Row를 삭제 한다

            comboBox2_SelectedIndexChanged(this, null);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox2.Text];


            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dataGridView1.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        //수정하기
        private void button3_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(textBox1.Text)) //값이있으면
            {
                foreach (DataRow item in ds.Tables[comboBox1.Text].Rows)
                {
                    if (item["NAME"].Equals(textBox1.Text))
                    {
                        if (radioButton1.Checked)
                        {
                            item["SEX"] = "여자";
                        }
                        else if (radioButton2.Checked)
                        {
                            item["SEX"] = "남자";
                        }

                        item["REF"] = textBox2.Text;
                    }
                }

                comboBox2_SelectedIndexChanged(this, null);
            }



        }
    }
}
