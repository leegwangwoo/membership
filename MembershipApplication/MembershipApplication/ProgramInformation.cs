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
    public partial class ProgramInformation : Form
    {
        ProgramDataClass programDataClass = new ProgramDataClass(); //프로그램의 정보를 가져오기 위해, ProgramDataClass클래스의 객체 생성

        public byte[] data;

        int k = 0; //행의 번호를 저장하는 변수 

        public ProgramInformation()
        {
            InitializeComponent();

            InitControl();
        }
        public void InitControl() //컨트롤의 초기 값을 설정하는 함수
        {
            this.txtInputData.Text = "";

            dataGridView.ColumnCount = 6; //열의 개수
            dataGridView.Columns[0].Name = "강의명"; //첫 번째 열의 값
            dataGridView.Columns[1].Name = "강사명"; //두 번째 열의 값
            dataGridView.Columns[2].Name = "교육대상"; //세 번째 열의 값
            dataGridView.Columns[3].Name = "교육시간"; //네 번째 열의 값
            dataGridView.Columns[4].Name = "수강료"; //다섯 번째 열의 값
            dataGridView.Columns[5].Name = "신청가능인원"; //여섯 번째 열의 값

            this.cbxSelect.Items.Clear();
            this.cbxSelect.Items.Add(enSelect.강의명.ToString());  //열거형 사용(DataClass에 열거형 정의했습니다.)
            this.cbxSelect.Items.Add(enSelect.강사명.ToString());
            this.cbxSelect.SelectedIndex = 0;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSelect.SelectedIndex == 0) //강의명으로 정보를 찾을 경우
            {
                for (int i = 0; i < 13; i++)
                {
                    if (programDataClass.ProgramInformation[i, 0] == txtInputData.Text.ToString()) //등록된 강의명과 입력한 강의명이 일치하는 경우(ex) i = 0일 때, programDataClass.ProgramInformation[0, 0]→수영_오전A / 여기서 입력한 값이 수영_오전A일 때 일치된다고 볼 수 있음)
                    {
                        dataGridView.Rows.Add(); //행 추가
                        dataGridView.Rows[k].Cells[0].Value = programDataClass.ProgramInformation[i, 0]; //k번째 행의 0번째 열 → 강의명 띄워줌 (ex) i = 0일 때, programDataClass.ProgramInformation[0, 0]→수영_오전A
                        dataGridView.Rows[k].Cells[1].Value = programDataClass.ProgramInformation[i, 1]; //k번째 행의 1번째 열 → 강사명 띄워줌                  programDataClass.ProgramInformation[0, 1]→홍길동
                        dataGridView.Rows[k].Cells[2].Value = programDataClass.ProgramInformation[i, 2]; //k번째 행의 2번째 열 → 교육대상 띄워줌                programDataClass.ProgramInformation[0, 2]→성인/청소년
                        dataGridView.Rows[k].Cells[3].Value = programDataClass.ProgramInformation[i, 3]; //k번째 행의 3번째 열 → 교육시간 띄워줌                programDataClass.ProgramInformation[0, 3]→월,수,금 09:00~09:50
                        dataGridView.Rows[k].Cells[4].Value = programDataClass.ProgramInformation[i, 4]; //k번째 행의 4번째 열 → 수강료 띄워줌                  programDataClass.ProgramInformation[0, 4]→55000)
                        dataGridView.Rows[k].Cells[5].Value = data[i];

                        k++; 
                    }
                }
            }
            else if (cbxSelect.SelectedIndex == 1) //강사명으로 정보를 찾을 경우
            {
                for (int i = 0; i < 13; i++)
                {
                    if (programDataClass.ProgramInformation[i, 1] == txtInputData.Text.ToString()) //등록된 강의명과 입력한 강의명이 일치하는 경우(ex) i = 0일 때, programDataClass.ProgramInformation[0, 1]→홍길동 / 여기서 입력한 값이 홍길동일 때 일치된다고 볼 수 있음)
                    {   //위와 동일
                        dataGridView.Rows.Add(); 
                        dataGridView.Rows[k].Cells[0].Value = programDataClass.ProgramInformation[i, 0];
                        dataGridView.Rows[k].Cells[1].Value = programDataClass.ProgramInformation[i, 1];
                        dataGridView.Rows[k].Cells[2].Value = programDataClass.ProgramInformation[i, 2];
                        dataGridView.Rows[k].Cells[3].Value = programDataClass.ProgramInformation[i, 3];
                        dataGridView.Rows[k].Cells[4].Value = programDataClass.ProgramInformation[i, 4];
                        dataGridView.Rows[k].Cells[5].Value = data[i];

                        k++;
                    }
                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
