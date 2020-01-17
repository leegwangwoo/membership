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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            InitControl();
        }
        public void InitControl()
        {
            dataGridView1.ColumnCount = 3; //열의 개수
            dataGridView1.Columns[0].Name = "사물함 번호";
            dataGridView1.Columns[1].Name = "회원 성함";
            dataGridView1.Columns[2].Name = "회원 번호";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Dictionary<string, LockerDataClass> LockerDataList = LockerData.GetLockerList();

            foreach (string Key in LockerDataList.Keys) //Key값을 순환시킴
            {

                string[] row = { LockerDataList[Key].lockernumber.ToString(), Key, LockerDataList[Key].number.ToString() };
                dataGridView1.Rows.Add(row); //row에 저장된 값을 차례대로 띄워줌



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
