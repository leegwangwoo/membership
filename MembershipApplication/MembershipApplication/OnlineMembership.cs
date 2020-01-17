using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MembershipApplication
{
    public partial class OnlineMembership : Form
    {
        byte[] data = new byte[13];

        ProgramDataClass programDataClass = new ProgramDataClass();

        public OnlineMembership(byte[] data)
        {
            this.data = data;

            InitializeComponent();
            
            InitControl();

        }

        private void InitControl()  //컨트롤의 초기 값을 설정하는 함수
        {
            this.txtName.Text = "";
            
            this.cbxSex.Items.Clear();
            this.cbxSex.Items.Add(enSex.남.ToString()); //열거형 사용(DataClass에 열거형 정의했습니다.)
            this.cbxSex.Items.Add(enSex.여.ToString());
            this.cbxSex.SelectedIndex = 0;

            this.cbxPeriod.Items.Clear();
            this.cbxPeriod.Items.Add(enPeriod.OneMonth.ToString());
            this.cbxPeriod.Items.Add(enPeriod.HalfYear.ToString());
            this.cbxPeriod.Items.Add(enPeriod.OneYear.ToString());
            this.cbxPeriod.SelectedIndex = 0;

            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add(enStudent.재학생.ToString()); //열거형 사용(DataClass에 열거형 정의했습니다.)
            this.comboBox1.Items.Add(enStudent.일반인.ToString());
            this.comboBox1.SelectedIndex = 0;

            this.cbxlecture.Items.Clear();
            for(int i=0; i <13; i++)
            {
                this.cbxlecture.Items.Add(programDataClass.ProgramInformation[i,0].ToString());
            }
            this.cbxlecture.SelectedIndex = 0;

            this.cheAgree.Checked = false;
        }

        private void cbxlecture_SelectedIndexChanged(object sender, EventArgs e) //강의 선택을 변경한 경우 발생하는 이벤트
        {
            lbTuition.Text = ""; 

            int Lecture_SelectedIndex = cbxlecture.SelectedIndex; //선택한 강의의 위치 값을 가져옴  (수영_오전A→0, 수영_오전B→1, 수영_오후C→2....등등...)
            int Period_SelectedIndex = cbxPeriod.SelectedIndex; //선택한 기간의 위치 값을 가져옴 (OneMonth→0, HalfYear→1, OneYear→2)

            if (comboBox1.SelectedIndex == 0) //재학생인 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = (Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 0.8).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.7).ToString(); break;  //HalfYear인 경우의 수강료 30% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.5).ToString(); break; //OneYear인 경우의 수강료 50% 할인

                }
            }
            else //일반인의 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.9).ToString(); break;  //HalfYear인 경우의 수강료 10% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.7).ToString(); break; //OneYear인 경우의 수강료 30% 할인

                }
            }
        }
        private void cbxPeriod_SelectedIndexChanged(object sender, EventArgs e) //기간 선택을 변경한 경우 발생하는 이벤트
        {
            lbTuition.Text = "";

            int Lecture_SelectedIndex = cbxlecture.SelectedIndex; //선택한 강의의 위치 값을 가져옴
            Lecture_SelectedIndex = 0; //지우면 오류 뜸
            int Period_SelectedIndex = cbxPeriod.SelectedIndex; //선택한 기간의 위치 값을 가져옴 (OneMonth→0, HalfYear→1, OneYear→2)

            if (comboBox1.SelectedIndex == 0) //재학생인 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = (Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 0.8).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.7).ToString(); break;  //HalfYear인 경우의 수강료 30% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.5).ToString(); break; //OneYear인 경우의 수강료 50% 할인

                }
            }
            else //일반인의 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.9).ToString(); break;  //HalfYear인 경우의 수강료 10% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.7).ToString(); break; //OneYear인 경우의 수강료 30% 할인

                }
            }
        }
        private void btn_Agree_Click(object sender, EventArgs e) //결제 버튼을 누른 경우 발생하는 이벤트
        {
            if (string.IsNullOrEmpty(this.txtName.Text) == true) //성함을 입력하지 않은 경우 (txtName컨트롤의 문자열이 Null이거나 Empty일 때 true반환)
            {
                MessageBox.Show("성함을 입력하세요", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cheAgree.Checked == false) //체크박스를 선택하지 않은경우  
            {
                MessageBox.Show("결제 동의가 필요합니다.", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int Lecture_SelectedIndex = cbxlecture.SelectedIndex;

                if (data[Lecture_SelectedIndex]== 0)
                {
                    MessageBox.Show("수강 인원의 초과로 신청하실 수 없는 강좌입니다.", "신청불가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    data[Lecture_SelectedIndex] -= 1;

                    MembershipApplication membershipApplication = new MembershipApplication();
                    membershipApplication.data = data;

                    ProgramInformation programInformation = new ProgramInformation();
                    programInformation.data = data;



                    MembershipDataClass membershipDataClass = new MembershipDataClass(); //MembershipDataClass구조체(DataClass에 생성하였습니다.)의 객체를 생성한 뒤, 입력 받은 정보를 저장시킴
                    membershipDataClass.birthDay = dateBirth.Value;
                    membershipDataClass.sex = cbxSex.SelectedItem.ToString();
                    membershipDataClass.period = cbxPeriod.SelectedItem.ToString();
                    membershipDataClass.lecture = cbxlecture.SelectedItem.ToString();
                    membershipDataClass.student = comboBox1.SelectedItem.ToString();


                    DialogResult ret = MessageBox.Show("결제 하시겠습니까?", "결제 선택", MessageBoxButtons.YesNo, MessageBoxIcon.Information); //MessageBox창에서 누른 버튼의 값을 가져와 저장시킴(Yes→ret=Yes, No→ret=No)

                    if (ret == System.Windows.Forms.DialogResult.Yes) //Yes버튼을 누른 경우 
                    {
                        membershipDataClass.number = RandomMembershipNum(); //난수를 발생시키는 함수 호출(회원 번호를 생성하기 위해)→결과 값을 number에 저장시킴

                        //결제 완료 후 회원 정보를 띄워주기 위해, message에 값을 할당시킴
                        string message = "회원성명 : " + txtName.Text + Environment.NewLine;
                        message += "생년월일 : " + dateBirth.Value.ToString("yyyy년 MM월 dd일") + Environment.NewLine;
                        message += "성별 : " + cbxSex.SelectedItem.ToString() + Environment.NewLine;
                        message += "등록기간 : " + cbxPeriod.SelectedItem.ToString() + Environment.NewLine;
                        message += "재학생여부 : " + comboBox1.SelectedItem.ToString() + Environment.NewLine;
                        message += "강좌 : " + cbxlecture.SelectedItem.ToString() + Environment.NewLine;
                        message += "회원번호 : " + membershipDataClass.number.ToString() + Environment.NewLine; /* ex) message=회원이름:홍길동
                                                                                                                           생년월일:1995년 04월 21일 
                                                                                                                           성별:남 
                                                                                                                           등록기간:OneYear 
                                                                                                                           강좌:수영_오전A
                                                                                                                           회원번호:00001*/

                        DataClass.SetMembershipData(txtName.Text, membershipDataClass); //회원의 정보를 Dictionary에 저장시키기 위해 SetMembershipData함수 호출(매개변수 → 회원의 이름, 회원의 전체 정보/DataClass에 생성하였습니다.)
                        MessageBox.Show(message, "승인 정보", MessageBoxButtons.OK, MessageBoxIcon.Information); //message에 저장된 값을 띄워줌

                        Dispose();
                    }
                }

            }
        }
        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private int RandomMembershipNum()
        {
            int MembershipNum = 0; 
            int numStart = 10000; 
            int numEnd = 99999; 
            int numRange = numEnd - numStart + 1;

            Random random = new Random((int)DateTime.Now.Ticks);
            int[] randomList = Enumerable.Range(numStart, numRange).ToArray();

            for (int i = 0; i < randomList.Count(); i++)
            {
                int randomIdex = random.Next(numRange);
                MembershipNum= randomList[randomIdex];
                break;
            }

            return MembershipNum;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTuition.Text = "";

            int Lecture_SelectedIndex = cbxlecture.SelectedIndex; //선택한 강의의 위치 값을 가져옴
            Lecture_SelectedIndex = 0; //지우면 오류 뜸
            int Period_SelectedIndex = cbxPeriod.SelectedIndex; //선택한 기간의 위치 값을 가져옴 (OneMonth→0, HalfYear→1, OneYear→2)

            if (comboBox1.SelectedIndex == 0) //재학생인 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = (Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 0.8).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.7).ToString(); break;  //HalfYear인 경우의 수강료 30% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.5).ToString(); break; //OneYear인 경우의 수강료 50% 할인

                }
            }
            else //일반인의 경우
            {
                switch (Period_SelectedIndex)
                {   //Int32.Parse→문자를 숫자로 변환 후 ToString()→문자열 값으로 변환
                    case 0: lbTuition.Text = Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]).ToString(); break; //OneMonth인 경우의 수강료
                    case 1: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 6) * 0.9).ToString(); break;  //HalfYear인 경우의 수강료 10% 할인
                    case 2: lbTuition.Text = ((Int32.Parse(programDataClass.ProgramInformation[Lecture_SelectedIndex, 4]) * 12) * 0.7).ToString(); break; //OneYear인 경우의 수강료 30% 할인

                }
            }
        }
    }
}
