using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MembershipApplication
{
    public partial class MembershipInformation : Form
    {
        string name;

        MembershipDataClass value;
      
        public MembershipInformation(string name, MembershipDataClass value)
        {
            this.name = name;
            this.value = value;

            InitializeComponent();

            InitControl();

            SetDataGrideValue();
        }
        public void InitControl() //컨트롤의 초기 값을 설정하는 함수
        {
            dataGridView.ColumnCount = 5; //열의 개수
            dataGridView.Columns[0].Name = "강의명"; //첫 번째 열의 값
            dataGridView.Columns[1].Name = "강사명"; //두 번째 열의 값
            dataGridView.Columns[2].Name = "교육대상"; //세 번째 열의 값
            dataGridView.Columns[3].Name = "교육시간"; //네 번째 열의 값
            dataGridView.Columns[4].Name = "수강료"; //다섯 번째 열의 값
        }

        public void SetDataGrideValue() //회원의 정보를 띄워주기 위한 함수
        {
            ProgramDataClass programDataClass = new ProgramDataClass();

            dataGridView.Rows.Clear();

            label18.Text = name;
            label22.Text = value.number.ToString();
            label23.Text = value.birthDay.ToString("yyyyMMdd");
            label25.Text = value.sex;
            label24.Text = value.period;
            label19.Text = value.student;

            for (int i = 0; i < 13; i++)
            {
                if (programDataClass.ProgramInformation[i, 0] != value.lecture.ToString())
                {
                    continue;
                }
                else
                {
                    string[] row = { programDataClass.ProgramInformation[i, 0], programDataClass.ProgramInformation[i, 1], programDataClass.ProgramInformation[i, 2], programDataClass.ProgramInformation[i, 3], programDataClass.ProgramInformation[i, 4] };  //row ={"강의명","강사명","교육대상", "교육시간","수강료"};
                    dataGridView.Rows.Add(row); //row에 저장된 값을 차례대로 띄워줌
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
