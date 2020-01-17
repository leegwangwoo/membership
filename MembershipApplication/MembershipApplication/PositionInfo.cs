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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        //visivle을 이용, 층별로 보여주는 방식 사용
        private void Floor2_1F_Click(object sender, EventArgs e)
        {
            //1층
            Gangdang.Visible = false;
            B1F_1F.Visible = false;
            Floor2_1F.Visible = false;
            Floor1_where.Visible = false;
            //지하1층
            Pool_B1F.Visible = false;
            Shower_B1F.Visible = false;
            Lounge_B1F.Visible = false;
            Gym_B1F.Visible = false;
            B1F_where.Visible = false;
            Floor1_B1F.Visible = false;
            Floor2_B1F.Visible = false;
            //2층
            B1F_2F.Visible = true;
            Floor1_2F.Visible = true;
            Gangdang_2F.Visible = true;
            Yoga_2F.Visible = true;
            Multi_2F.Visible = true;
            Floor2_where.Visible = true;
        }

        private void B1F_1F_Click(object sender, EventArgs e)
        {
            //1층
            Gangdang.Visible = false;
            B1F_1F.Visible = false;
            Floor2_1F.Visible = false;
            Floor1_where.Visible = false;
            //2층
            B1F_2F.Visible = false;
            Floor1_2F.Visible = false;
            Gangdang_2F.Visible = false;
            Yoga_2F.Visible = false;
            Multi_2F.Visible = false;
            Floor2_where.Visible = false;
            //지하1층
            Pool_B1F.Visible = true;
            Shower_B1F.Visible = true;
            Lounge_B1F.Visible = true;
            Gym_B1F.Visible = true;
            B1F_where.Visible = true;
            Floor1_B1F.Visible = true;
            Floor2_B1F.Visible = true;

            
        }

        private void B1F_2F_Click(object sender, EventArgs e)
        {
            //2층
            B1F_2F.Visible = false;
            Floor1_2F.Visible = false;
            Gangdang_2F.Visible = false;
            Yoga_2F.Visible = false;
            Multi_2F.Visible = false;
            Floor2_where.Visible = false;
            //1층
            Gangdang.Visible = false;
            B1F_1F.Visible = false;
            Floor2_1F.Visible = false;
            Floor1_where.Visible = false;
            //지하1층
            Pool_B1F.Visible = true;
            Shower_B1F.Visible = true;
            Lounge_B1F.Visible = true;
            Gym_B1F.Visible = true;
            B1F_where.Visible = true;
            Floor1_B1F.Visible = true;
            Floor2_B1F.Visible = true;
        }

        private void Floor1_2F_Click(object sender, EventArgs e)
        {
            //2층
            B1F_2F.Visible = false;
            Floor1_2F.Visible = false;
            Gangdang_2F.Visible = false;
            Yoga_2F.Visible = false;
            Multi_2F.Visible = false;
            Floor2_where.Visible = false;
            //지하1층
            Pool_B1F.Visible = false;
            Shower_B1F.Visible = false;
            Lounge_B1F.Visible = false;
            Gym_B1F.Visible = false;
            B1F_where.Visible = false;
            Floor1_B1F.Visible = false;
            Floor2_B1F.Visible = false;
            //1층
            Gangdang.Visible = true;
            B1F_1F.Visible = true;
            Floor2_1F.Visible = true;
            Floor1_where.Visible = true;
        }

        private void Floor1_B1F_Click(object sender, EventArgs e)
        {
            //지하1층
            Pool_B1F.Visible = false;
            Shower_B1F.Visible = false;
            Lounge_B1F.Visible = false;
            Gym_B1F.Visible = false;
            B1F_where.Visible = false;
            Floor1_B1F.Visible = false;
            Floor2_B1F.Visible = false;
            //2층
            B1F_2F.Visible = false;
            Floor1_2F.Visible = false;
            Gangdang_2F.Visible = false;
            Yoga_2F.Visible = false;
            Multi_2F.Visible = false;
            //1층
            Gangdang.Visible = true;
            B1F_1F.Visible = true;
            Floor2_1F.Visible = true;
            Floor1_where.Visible = true;
        }

        private void Floor2_B1F_Click(object sender, EventArgs e)
        {
            //지하1층
            Pool_B1F.Visible = false;
            Shower_B1F.Visible = false;
            Lounge_B1F.Visible = false;
            Gym_B1F.Visible = false;
            B1F_where.Visible = false;
            Floor1_B1F.Visible = false;
            Floor2_B1F.Visible = false;
            //1층
            Gangdang.Visible = false;
            B1F_1F.Visible = false;
            Floor2_1F.Visible = false;
            Floor1_where.Visible = false;
            //2층
            B1F_2F.Visible = true;
            Floor1_2F.Visible = true;
            Gangdang_2F.Visible = true;
            Yoga_2F.Visible = true;
            Multi_2F.Visible = true;
            Floor2_where.Visible = true;
        }

        private void 강당_Click(object sender, EventArgs e)
        {
            Button sendbtn = (Button)sender;
            Data form2 = new Data(sendbtn.Name);
            form2.ShowDialog();
        }
        //각 시설 클릭시의 이벤트
        private void Yoga_2F_Click(object sender, EventArgs e)
        {
            Button Yoga = (Button)sender;
            Data form2 = new Data(Yoga.Name);
            form2.ShowDialog();
        }

        private void Pool_B1F_Click(object sender, EventArgs e)
        {
            Button swim = (Button)sender;
            Data form2 = new Data(swim.Name);
            form2.ShowDialog();
        }

        private void Multi_2F_Click(object sender, EventArgs e)
        {
            Button Multi = (Button)sender;
            Data form2 = new Data(Multi.Name);
            form2.ShowDialog();
        }

        private void Gym_B1F_Click(object sender, EventArgs e)
        {
            Button Gym = (Button)sender;
            Data form2 = new Data(Gym.Name);
            form2.ShowDialog();
        }

        private void shower_B1F_Click(object sender, EventArgs e)
        {
            Button shower = (Button)sender;
            Data form2 = new Data(shower.Name);
            form2.ShowDialog();
        }

        private void lounge_B1F_Click(object sender, EventArgs e)
        {
            Button lounge = (Button)sender;
            Data form2 = new Data(lounge.Name);
            form2.ShowDialog();
        }
    }
}
