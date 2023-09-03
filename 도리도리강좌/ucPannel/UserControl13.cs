using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 도리도리강좌.ucPannel
{
    public partial class UserControl13 : UserControl
    {

        const string sLEVEL = "LEVEL";
        const string sNAME = "NAME";
        const string sATTRIBUTE = "ATTRIBUTE";

        DataTable dt;

        enum EnumName
        {
            슬라임,
            가고일,
            골렘,
            코볼트,
            고블린,
            고스트,
            언데드,
            노움,
            드래곤,
            웜,
            서큐버스,
            데빌,
            만티코어,
            바실리스트,
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            번개,
            어둠,
            빛,
            땅,
            나무,
        }


        public UserControl13()
        {
            InitializeComponent();
        }

        private void UserControl13_Load(object sender, EventArgs e)
        {
            DataTableCreate();  // Data Table 생성
            EnemyCreate(); // Data row값 입력
        }

        private void DataTableCreate()
        {
            dt = new DataTable("Enemy");

            //DataColumn 생성
            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int));
            DataColumn colName = new DataColumn(sNAME, typeof(string));
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string));

            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);

        }

        private void EnemyCreate()
        {
            Random random = new Random();
            comboboxCreate();


            foreach (EnumName Ename in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = dt.NewRow();
                dr[sLEVEL] = random.Next(1, 11);
                dr[sNAME] = Ename.ToString();
                int iAttributelength = Enum.GetValues(typeof(EnumAttribute)).Length;
                int iAttribute = random.Next(iAttributelength);
                dr[sATTRIBUTE] = (EnumAttribute)iAttribute;

                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void comboboxCreate()
        {
            foreach (EnumAttribute item in Enum.GetValues(typeof(EnumAttribute)))
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
        }


        //정렬
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;

            DataTable dtcopy = dataGridView1.DataSource as DataTable;

            IEnumerable<DataRow> vSortTable = null;


            switch (button.Name)
            {

                case "button1":
                    vSortTable = from oRow in dtcopy.AsEnumerable()
                                 orderby oRow.Field<int>(sLEVEL) // 정렬 기준
                                 select oRow;

                    break;

                case "button2":
                    vSortTable = from oRow in dtcopy.AsEnumerable()
                                 orderby oRow.Field<string>(sNAME) // 정렬 기준
                                 select oRow;

                    break;

                case "button3":
                    vSortTable = from oRow in dtcopy.AsEnumerable()
                                 orderby oRow.Field<string>(sATTRIBUTE) // 정렬 기준
                                 select oRow;

                    break;




                default:
                    break;
            }

            dtcopy = vSortTable.CopyToDataTable();
            dataGridView1.DataSource = dtcopy;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dtcopy = dataGridView1.DataSource as DataTable;
            IEnumerable<DataRow> vSortTable = from oRow in dtcopy.AsEnumerable()
                                              where oRow.Field<string>(sATTRIBUTE) == comboBox1.Text &&
                                              (oRow.Field<int>(sLEVEL) >= numericUpDown1.Value && oRow.Field<int>(sLEVEL) <= numericUpDown2.Value)
                                              select oRow;


            if (vSortTable.Count() > 0)
            {
                dtcopy = vSortTable.CopyToDataTable();
                dataGridView1.DataSource = dtcopy;
            }
            else
            {
                MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
