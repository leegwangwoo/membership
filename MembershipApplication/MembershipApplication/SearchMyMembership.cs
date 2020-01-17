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
    public partial class SearchMyMembership : Form
    {
        public SearchMyMembership()
        {
            InitializeComponent();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Dictionary<string, MembershipDataClass> MembershipDataList = DataClass.GetMembershipDataList();

            if (string.IsNullOrEmpty(this.txtName.Text) == true) //성함을 입력하지 않은 경우 (txtName컨트롤의 문자열이 Null이거나 Empty일 때 true반환)
            {
                MessageBox.Show("성함을 입력하세요", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (string Key in MembershipDataList.Keys) //Key값을 순환시킴
                {

                    if (Key.Contains(txtName.Text) == false || MembershipDataList[Key].birthDay.ToString("yyyyMMdd").Contains(dateBirth.Value.ToString("yyyyMMdd")) == false)
                    {
                        continue;
                    }
                    else
                    {
                        int Number = MembershipDataList[Key].number;

                        string message = Key + "님의 회원번호는" +" "+ Number + "입니다.";

                        MessageBox.Show(message, "조회결과", MessageBoxButtons.OK, MessageBoxIcon.Information); //message에 저장된 값을 띄워줌

                        Dispose();

                    }
                }
            }
        }
    }
}
