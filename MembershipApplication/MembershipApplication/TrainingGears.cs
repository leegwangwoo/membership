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
    public partial class TrainingGears : Form
    {
        public TrainingGears()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GearsPurchase 용품안내_구매 = new GearsPurchase();
            용품안내_구매.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GearsRental 용품안내_대여 = new GearsRental();
            용품안내_대여.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
