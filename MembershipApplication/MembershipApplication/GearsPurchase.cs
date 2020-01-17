using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipApplication
{
    public partial class GearsPurchase : Form
    {
        public GearsPurchase()
        {
            InitializeComponent();
        }

        int n = 1; //배드민턴 라켓 갯수.
        int n2 = 1; //셔틀콕 갯수
        int n3 = 1; //탁구채 갯수
        int n4 = 1; //탁구공 갯수
        int t = 0; //배드민턴 라켓 총 가격
        int t2 = 0; //셔틀콕 총 가격
        int t3 = 0; //탁구채 총 가격
        int t4 = 0; //탁구공 총 가격
        public class B_racket //배드민턴 라켓 클래스
        {
            public static string name = "배드민턴 라켓";
            public static int price = 20000;
        }
        public class Shuttle //셔틀콕 클래스
        {
            public static string name = "셔틀콕";
            public static int price = 1000;
        }
        public class T_racket //탁구 라켓
        {
            public static string name = "탁구 라켓";
            public static int price = 12000;
        }
        public class T_ball //탁구공
        {
            public static string name = "탁구공";
            public static int price = 1000;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = (string)listBox1.SelectedItem;

            if (listBox1.SelectedItems != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);               

                if (s == B_racket.name) //배드민턴 라켓을 중복할 경우
                {
                    label6.Text = B_racket.name + "x" + n;
                    t = (n * B_racket.price);
                    label3.Text = t + t2 + t3 +t4 +"원";                   
                    n++;
                }
                if(s == Shuttle.name) //셔틀콕을 중복할 경우
                {                   
                    label7.Text = Shuttle.name + "x" + n2;
                    t2 = (n2 * Shuttle.price);
                    label3.Text = t + t2 + t3 + t4+"원";                   
                    n2++;
                }
                if(s == T_racket.name) //탁구채를 중복할 경우
                {
                    label8.Text = T_racket.name + "x" + n3;
                    t3 = (n3 * T_racket.price);
                    label3.Text = t + t2 + t3 + "원";
                    n3++;
                }
                if(s == T_ball.name) //탁구공을 중복할 경우
                {
                    label9.Text = T_ball.name + "x" + n4;
                    t4 = (n4 * T_ball.price);
                    label3.Text = t + t2 + t3 + t4 + "원";
                    n4++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = (string)listBox2.SelectedItem;

            if (listBox2.SelectedItems != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            if (s == B_racket.name)
            {
                    if (n != 0)
                    {
                        n--;
                        label6.Text = B_racket.name + "x" + (n-1);
                        t = (n - 1) * B_racket.price;
                        label3.Text = t+t2+t3+t4 + "원";
                    }
                    if ((n-1) == 0)
                    {
                        label6.Text = "";                       
                    }
            }
            if (s == Shuttle.name)
            {
                if (n2 != 0)
                {
                    n2--;
                    label7.Text = Shuttle.name + "x" + (n2 - 1);
                    t2 = (n2 - 1) * Shuttle.price;
                    label3.Text = t + t2 + t3 + t4 + "원";
                }
                if ((n2 - 1) == 0)
                {
                    label7.Text = "";                   
                }
            }
            if (s == T_racket.name)
            {
                if (n3 != 0)
                {
                    n3--;
                    label8.Text = T_racket.name + "x" + (n3 - 1);
                    t3 = (n3 - 1) * T_racket.price;
                    label3.Text = t + t2 + t3 + t4 + "원";
                }
                if ((n3 - 1) == 0)
                {
                    label8.Text = "";
                }
            }
            if (s == T_ball.name)
            {
                if (n4 != 0)
                {
                    n4--;
                    label9.Text = T_ball.name + "x" + (n4 - 1);
                    t4 = (n4 - 1) * T_ball.price;
                    label3.Text = t + t2 + t3 + t4 + "원";
                }
                if ((n4 - 1) == 0)
                {
                    label9.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "원가: " + (t + t2 + t3 + t4 ) + "\n할인가:" + (t + t2 + t3 + t4 ) * 0.8 + "원";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "원가: " + (t + t2 + t3 + t4) + "\n할인가:" + (t + t2 + t3 + t4) * 0.9 + "원";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

