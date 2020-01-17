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
    public partial class SearchMembership : Form
    {
        ProgramDataClass programDataClass = new ProgramDataClass();

        public SearchMembership()
        {
            InitializeComponent();

            InitControl();
        }

        public void InitControl() //컨트롤의 초기 값을 설정하는 함수
        {
            txtName.Text = "";
            txtNumber.Text = "";

        }
        private void btn_Search_Click(object sender, EventArgs e) //조회 버튼을 눌렀을 때 발생하는 이벤트 
        {
            int Inconsistent = 0;

            Dictionary<string, MembershipDataClass> MembershipDataList = DataClass.GetMembershipDataList(); //현재까지 Dictionary에 저장된 정보를 가져오기 위해, DataClass에 선언된 GetMembershipDataList함수 호출 → 이후 MembershipDataList에 저장시킴


            if (string.IsNullOrEmpty(this.txtName.Text) == true) //성함을 입력하지 않은 경우 (txtName컨트롤의 문자열이 Null이거나 Empty일 때 true반환)
            {
                MessageBox.Show("성함을 입력하세요", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(this.txtNumber.Text) == true) //체크박스를 선택하지 않은경우  
            {
                MessageBox.Show("회원 번호를 입력하세요", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (string Key in MembershipDataList.Keys) //Key값을 순환시킴
                {
                    //입력한 성함과 Key값과 입력한 회원번호와 Key에 해당하는 회원번호 둘 중 하나라도 일치하지 않으면 
                    if (Key.Contains(txtName.Text) == false || MembershipDataList[Key].number.ToString().Contains(txtNumber.Text) == false)
                    {
                        Inconsistent++;
                        continue;
                    }
                    else
                    {
                        MembershipInformation membershipInformation = new MembershipInformation(Key, MembershipDataList[Key]);

                        membershipInformation.ShowDialog();

                    }
                }

                Dispose();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchMyMembership searchMyMembership = new SearchMyMembership();
            searchMyMembership.ShowDialog();
        }
    }
}
