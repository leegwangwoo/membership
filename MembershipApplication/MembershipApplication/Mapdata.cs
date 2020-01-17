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
    public partial class Data : Form
    {
        public Data(string name)
        {
            InitializeComponent();

            //클릭된 버튼의 정보를 받아 시설의 대한 정보를 폼에 띄움
            switch (name)
            {
                case "Gangdang": this.ItemTextbox.Text = GangDang_Text; break;
                case "Pool_B1F": this.ItemTextbox.Text = Swim_Text; break;
                case "Yoga_2F": this.ItemTextbox.Text = Yoga_Text; break;
                case "Gym_B1F": this.ItemTextbox.Text = Gym_Text; break;
                case "Multi_2F": this.ItemTextbox.Text = Multi_Text; break;
                case "Shower_B1F": this.ItemTextbox.Text = Shower_Text; break;
                case "Lounge_B1F":this.ItemTextbox.Text = Lounge_Text; break;
            }
        }
    }
}
