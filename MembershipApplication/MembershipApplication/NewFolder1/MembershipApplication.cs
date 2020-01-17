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
    public partial class MembershipApplication : Form
    {
        OnlineMembership onlineMembership = null;
        SearchMembership searchMembership = null;

        public MembershipApplication()
        {
            InitializeComponent();
        }

        private void bntMembership_Click(object sender, EventArgs e)
        {
            if (onlineMembership != null)
            {
                onlineMembership.Close();
                onlineMembership = null;
            }

            onlineMembership = new OnlineMembership();
            onlineMembership.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchMembership != null)
            {
                searchMembership.Close();
                searchMembership = null;
            }

            searchMembership = new SearchMembership();
            searchMembership.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
