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
    public partial class GearsRental : Form
    {
        public GearsRental()
        {
            InitializeComponent();
        }
        int n = 1; //배드민턴 라켓 갯수.
        int n2 = 1; //셔틀콕 갯수
        int n3 = 1; //탁구채 갯수
        int n4 = 1; //탁구공 갯수
        int n5 = 1; //운동복 갯수
        int n6 = 1; //수건 갯수
        int t = 0; //배드민턴 라켓 총 가격
        int t2 = 0; //셔틀콕 총 가격
        int t3 = 0; //탁구채 총 가격
        int t4 = 0; //탁구공 총 가격
        int t5 = 0; //운동복 총 가격
        int t6 = 0; //수건 총 가격
        public class Clothes
        {
            public static string name = "운동복";
            public static int price = 5000;
        }
        public class Towel
        {
            public static string name = "수건";
            public static int price = 1000;
        }
        public class B_racket //배드민턴 라켓 클래스
        {
            public static string name = "배드민턴 라켓";
            public static int price = 2000;
        }
        public class Shuttle //셔틀콕 클래스
        {
            public static string name = "셔틀콕";
            public static int price = 500;
        }
        public class T_racket //탁구 라켓
        {
            public static string name = "탁구 라켓";
            public static int price = 2000;
        }
        public class T_ball //탁구공
        {
            public static string name = "탁구공";
            public static int price = 500;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = (string)listBox1.SelectedItem;

            if (listBox1.SelectedItems != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);

                if (s == B_racket.name)
                {
                    label6.Text = B_racket.name + "x" + n;
                    t = (n * B_racket.price);
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                    n++;
                }
                if (s == Shuttle.name)
                {
                    label7.Text = Shuttle.name + "x" + n2;
                    t2 = (n2 * Shuttle.price);
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                    n2++;
                }
                if (s == T_racket.name)
                {
                    label8.Text = T_racket.name + "x" + n3;
                    t3 = (n3 * T_racket.price);
                    label3.Text = t + t2 + t3 + t4+ t5 + t6 + "원";
                    n3++;
                }
                if (s == T_ball.name)
                {
                    label9.Text = T_ball.name + "x" + n4;
                    t4 = (n4 * T_ball.price);
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                    n4++;
                }
                if(s==Clothes.name)
                {
                    label10.Text = Clothes.name + "x" + n5;
                    t5 = (n5 * Clothes.price);
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                    n5++;
                }
                if(s==Towel.name)
                {
                    label11.Text = Towel.name + "x" + n6;
                    t6 = (n6 * Towel.price);
                    label3.Text = t + t2 + t3 + t4 + t5 + t6+ "원";
                    n6++;
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
                    label6.Text = B_racket.name + "x" + (n - 1);
                    t = (n - 1) * B_racket.price;
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                }
                if ((n - 1) == 0)
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
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
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
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
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
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                }
                if ((n4 - 1) == 0)
                {
                    label9.Text = "";
                }           
            }
            if (s == Clothes.name)
            {
                if (n5 != 0)
                {
                    n5--;
                    label10.Text = Clothes.name + "x" + (n5 - 1);
                    t5 = (n5 - 1) * Clothes.price;
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                }
                if ((n5 - 1) == 0)
                {
                    label6.Text = "";
                }
            }
            if (s == Towel.name)
            {
                if (n6 != 0)
                {
                    n6--;
                    label11.Text = Towel.name + "x" + (n6 - 1);
                    t6 = (n6 - 1) * Towel.price;
                    label3.Text = t + t2 + t3 + t4 + t5 + t6 + "원";
                }
                if ((n6 - 1) == 0)
                {
                    label6.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "원가: "+ (t + t2 + t3 + t4 + t5 + t6) + "\n할인가:"+(t + t2 + t3 + t4 +t5 +t6) * 0.8 + "원";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "원가: " + (t + t2 + t3 + t4 + t5 + t6) + "\n할인가:"+(t + t2 + t3 + t4 + t5 + t6) * 0.9 + "원";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
