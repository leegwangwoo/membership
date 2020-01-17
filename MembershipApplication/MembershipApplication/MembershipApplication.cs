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
    public partial class MembershipApplication : Form
    {
        public byte[] data = { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }; //신청 가능한 인원 

        OnlineMembership onlineMembership = null;
        SearchMembership searchMembership = null;
        ProgramInformation programInformation = null;

        public MembershipApplication()
        {
             InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //종료
        {
            Dispose();
        }
        private void bntMembership_Click_1(object sender, EventArgs e) //회원등록
        {
            if (onlineMembership != null)
            {
                onlineMembership.Close();
                onlineMembership = null;
            }

            onlineMembership = new OnlineMembership(data);
            onlineMembership.ShowDialog();
        }

        private void btnSearch_Click_1(object sender, EventArgs e) //회원조회
        {
            if (searchMembership != null)
            {
                searchMembership.Close();
                searchMembership = null;
            }

            searchMembership = new SearchMembership();
            searchMembership.ShowDialog();
        }

        private void bntProgram_Click(object sender, EventArgs e) //프로그램안내
        {
            if (programInformation != null)
            {
                programInformation.Close();
                programInformation = null;
            }
            
            programInformation = new ProgramInformation();

            programInformation.data = data;

            programInformation.ShowDialog();
        }

        private void GearsInfo_Click(object sender, EventArgs e) //대여안내
        {
            TrainingGears trainingGears = new TrainingGears();
            trainingGears.ShowDialog();
        }

        private void Position_Click(object sender, EventArgs e) //시설안내
        {
            Map map = new Map();
            map.ShowDialog();
        }
        
        //메뉴바
        private void 회원등록ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (onlineMembership != null)
            {
                onlineMembership.Close();
                onlineMembership = null;
            }

            onlineMembership = new OnlineMembership(data);
            onlineMembership.ShowDialog();
        }

        private void 회원정보조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchMembership != null)
            {
                searchMembership.Close();
                searchMembership = null;
            }

            searchMembership = new SearchMembership();
            searchMembership.ShowDialog();
        }

        private void 시설안내ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.ShowDialog();
        }

        private void 프로그램안내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (programInformation != null)
            {
                programInformation.Close();
                programInformation = null;
            }

            programInformation = new ProgramInformation();
            programInformation.ShowDialog();
        }

        private void 물품대여ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingGears trainingGears = new TrainingGears();
            trainingGears.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
