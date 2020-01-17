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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(1); //객체 생성하면서, 사물함의 번호를 매개변수로 넘김
            form2.ShowDialog();

            int Status = form2.GetStatus(); //사물함 신청 상태를 가져옴(1일 때, 신청 상태)

            if(Status == 1) //신청 완료 상태일 때
            {
                string[] a = { "1" }; 
                StreamWriter One = new StreamWriter("1.txt", false); 
                One.Write(a[0]);  //1(신청완료)을 1.txt파일에 입력
                One.Close();

                button2.Enabled = !button2.Enabled;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(2);
            form2.ShowDialog();

            int Status = form2.GetStatus();

            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Two = new StreamWriter("2.txt", false);
                Two.Write(a[0]);
                Two.Close();

                button3.Enabled = !button3.Enabled;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(3);
            form2.ShowDialog();

            int Status = form2.GetStatus();

            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Three = new StreamWriter("3.txt", false);
                Three.Write(a[0]);
                Three.Close();

                button4.Enabled = !button4.Enabled;
            }

        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(4);
            form2.ShowDialog();
            
            int Status = form2.GetStatus();

            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Four = new StreamWriter("4.txt", false);
                Four.Write(a[0]);
                Four.Close();
                button5.Enabled = !button5.Enabled;
            }

      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(5);
            form2.ShowDialog();

            int Status = form2.GetStatus();

            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Five = new StreamWriter("5.txt", false);
                Five.Write(a[0]);
                Five.Close();

                button6.Enabled = !button6.Enabled;
            }

      
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(6);
            form2.ShowDialog();

            int Status = form2.GetStatus();

            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Six = new StreamWriter("6.txt", false);
                Six.Write(a[0]);
                Six.Close();
                button7.Enabled = !button7.Enabled;
            }

        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(7);
            form2.ShowDialog();

            int Status = form2.GetStatus();


            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Seven = new StreamWriter("7.txt", false);
                Seven.Write(a[0]);
                Seven.Close();
                button8.Enabled = !button8.Enabled;
            }
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(8);
            form2.ShowDialog();

            int Status = form2.GetStatus();


            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Eight = new StreamWriter("8.txt", false);
                Eight.Write(a[0]);
                Eight.Close();
                button9.Enabled = !button9.Enabled;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(9);
            form2.ShowDialog();

            int Status = form2.GetStatus();


            if (Status == 1)
            {
                string[] a = { "1" };
                StreamWriter Nine = new StreamWriter("9.txt", false);
                Nine.Write(a[0]);
                Nine.Close();

                button10.Enabled = !button10.Enabled;
            }


      

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("1.txt"))
            {
                StreamReader one = new StreamReader("1.txt");
                string One = one.ReadToEnd();

                if (Int32.Parse(One) == 1) //1.txt파일에 저장된 내용을 가져와 신청한 상태인지 확인(1일 때, 신청 상태)
                {
                    button2.Enabled = !button2.Enabled;
                }
            }
            if (System.IO.File.Exists("2.txt"))
            {
                StreamReader two = new StreamReader("2.txt");
                string Two = two.ReadToEnd();

                if (Int32.Parse(Two) == 1)
                {
                    button3.Enabled = !button3.Enabled;
                }
            }
            if (System.IO.File.Exists("3.txt"))
            {
                StreamReader three = new StreamReader("3.txt");
                string Three = three.ReadToEnd();

                if (Int32.Parse(Three) == 1)
                {
                    button4.Enabled = !button4.Enabled;
                }
            }
            if (System.IO.File.Exists("4.txt"))
            {
                StreamReader four = new StreamReader("4.txt");
                string Four = four.ReadToEnd();

                if (Int32.Parse(Four) == 1)
                {
                    button5.Enabled = !button5.Enabled;
                }
            }
            if (System.IO.File.Exists("5.txt"))
            {
                StreamReader five = new StreamReader("5.txt");
                string Five = five.ReadToEnd();

                if (Int32.Parse(Five) == 1)
                {
                    button6.Enabled = !button6.Enabled;
                }
            }
            if (System.IO.File.Exists("6.txt"))
            {
                StreamReader six = new StreamReader("6.txt");
                string Six = six.ReadToEnd();

                if (Int32.Parse(Six) == 1)
                {
                    button7.Enabled = !button7.Enabled;
                }
            }
            if (System.IO.File.Exists("7.txt"))
            {
                StreamReader seven = new StreamReader("7.txt");
                string Seven = seven.ReadToEnd();

                if (Int32.Parse(Seven) == 1)
                {
                    button8.Enabled = !button8.Enabled;
                }
            }
            if (System.IO.File.Exists("8.txt"))
            {
                StreamReader eight = new StreamReader("8.txt");
                string Eight = eight.ReadToEnd();

                if (Int32.Parse(Eight) == 1)
                {
                    button9.Enabled = !button9.Enabled;
                }
            }
            if (System.IO.File.Exists("9.txt"))
            {
                StreamReader nine = new StreamReader("9.txt");
                string Nine = nine.ReadToEnd();

                if (Int32.Parse(Nine) == 1)
                {
                    button10.Enabled = !button10.Enabled;
                }
            }

        }
    }
}
