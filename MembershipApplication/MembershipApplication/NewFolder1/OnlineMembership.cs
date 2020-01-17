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
    public partial class OnlineMembership : Form
    {
        public OnlineMembership()
        {
            InitializeComponent();
            
            InitControl();
        }

        private void InitControl()
        {
            this.txtName.Text = "";
            
            this.cbxSex.Items.Clear();
            this.cbxSex.Items.Add(enSex.남.ToString());
            this.cbxSex.Items.Add(enSex.여.ToString());
            this.cbxSex.SelectedIndex = 0;

            this.cbxPeriod.Items.Clear();
            this.cbxPeriod.Items.Add(enPeriod.OneMonth.ToString());
            this.cbxPeriod.Items.Add(enPeriod.HalfYear.ToString());
            this.cbxPeriod.Items.Add(enPeriod.OneYear.ToString());
            this.cbxPeriod.SelectedIndex = 0;
            
            this.cbxlecture.Items.Clear();
            this.cbxlecture.Items.Add(enLecture.A강의.ToString());
            this.cbxlecture.Items.Add(enLecture.B강의.ToString());
            this.cbxlecture.Items.Add(enLecture.C강의.ToString());
            this.cbxlecture.SelectedIndex = 0;

            this.cheAgree.Checked = false;
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text) == true)
            {
                MessageBox.Show("이름을 입력하세요", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (cheAgree.Checked == false)
            {
                MessageBox.Show("결제 동의 필요합니다.", "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MembershipDataClass membershipDataClass = new MembershipDataClass();
                membershipDataClass.birthDay = dateBirth.Value;
                membershipDataClass.sex = cbxSex.SelectedItem.ToString();
                membershipDataClass.period = cbxPeriod.SelectedItem.ToString();
                membershipDataClass.lecture = cbxlecture.SelectedItem.ToString();

                DialogResult ret = MessageBox.Show("결제 하시겠습니까?", "결제 선택", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ret == System.Windows.Forms.DialogResult.Yes)
                {
                    membershipDataClass.number = RandomMembershipNum();

                    string message = "회원이름 : " + txtName.Text + Environment.NewLine;
                    message += "생년월일 : " + dateBirth.Value.ToString("yyyy년 MM월 dd일") + Environment.NewLine;
                    message += "성별 : " + cbxSex.SelectedItem.ToString() + Environment.NewLine;
                    message += "등록기간 : " + cbxPeriod.SelectedItem.ToString() + Environment.NewLine;
                    message += "강좌 : " + cbxlecture.SelectedItem.ToString() + Environment.NewLine;
                    message += "회원번호 : " + membershipDataClass.number.ToString() + Environment.NewLine;

                    DataClass.SetMembershipData(txtName.Text, membershipDataClass);
                    MessageBox.Show(message, "승인 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        




    }
}
