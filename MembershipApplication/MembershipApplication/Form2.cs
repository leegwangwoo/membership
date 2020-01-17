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
    public partial class Form2 : Form
    {
        int LockerNumber;
        int Status=0;

        public Form2(int LockerNumber)

        {
            this.LockerNumber = LockerNumber;
            InitializeComponent();
        }
        public int GetStatus()
        {
            return Status;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
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
                        continue;
                    }
                    else
                    {
                        DialogResult ret = MessageBox.Show("신청하시겠습니까?", "신청 선택", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (ret == System.Windows.Forms.DialogResult.Yes) //Yes버튼을 누른 경우 
                        {

                            LockerDataClass lockerDataClass = new LockerDataClass();

                            lockerDataClass.number = Int32.Parse(txtNumber.Text);
                            lockerDataClass.lockernumber = LockerNumber;


                            LockerData.SetMembershipData(txtName.Text, lockerDataClass);


                            MessageBox.Show("신청완료 되었습니다.", "신청 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Status = 1; //신청 완료시 상태를 1로 바꿔줌
                        }
                    }

                    Dispose();
                }
            }
        }
    }
}