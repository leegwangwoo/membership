namespace MembershipApplication
{
    partial class OnlineMembership
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineMembership));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxlecture = new System.Windows.Forms.ComboBox();
            this.cbxPeriod = new System.Windows.Forms.ComboBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTuition = new System.Windows.Forms.Label();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Agree = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cheAgree = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "온라인 회원 등록";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(259, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "등록기간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "강좌";
            // 
            // cbxlecture
            // 
            this.cbxlecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxlecture.FormattingEnabled = true;
            this.cbxlecture.Location = new System.Drawing.Point(62, 141);
            this.cbxlecture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxlecture.Name = "cbxlecture";
            this.cbxlecture.Size = new System.Drawing.Size(191, 23);
            this.cbxlecture.TabIndex = 10;
            this.cbxlecture.SelectedIndexChanged += new System.EventHandler(this.cbxlecture_SelectedIndexChanged);
            // 
            // cbxPeriod
            // 
            this.cbxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriod.FormattingEnabled = true;
            this.cbxPeriod.Location = new System.Drawing.Point(355, 142);
            this.cbxPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(203, 23);
            this.cbxPeriod.TabIndex = 9;
            this.cbxPeriod.SelectedIndexChanged += new System.EventHandler(this.cbxPeriod_SelectedIndexChanged);
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Location = new System.Drawing.Point(62, 107);
            this.cbxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(191, 23);
            this.cbxSex.TabIndex = 8;
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(354, 74);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(203, 21);
            this.dateBirth.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 74);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 21);
            this.txtName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "성함";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(259, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "생년월일";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(12, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "성별";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbTuition);
            this.groupBox2.Controls.Add(this.btn_Cancle);
            this.groupBox2.Controls.Add(this.btn_Agree);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.cheAgree);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(16, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(583, 252);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결제정보";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "- 체 육 관 이 용 약 관 -",
            "",
            "",
            "제1조(목적) 이 약관은 체력단련장과 체력단련장이 제공하는 시설 및 서비스를 이용하는 자(이하 ‘이용자’라 합니다) 사이에 체결된 계약에 따른 권" +
                "리의무에 관한 사항을 정함을 목적으로 합니다.",
            "",
            "제2조(적용대상) 이 약관은 체력단련장을 이용하는 모든 이용자에게 적용합니다.",
            "",
            "제3조(이용계약 및 약관 교부)  ",
            "① 이용자는 체력단련장(이하 ‘사업자’라 합니다)이 정한 절차에 따라 이용 신청을 하고 이용료를 납부하여야 합니다.",
            "② 사업자는 체력단련장 이용신청을 승낙할 경우 이용자에게 이용증과 약식 약관(이용증 이면에 첨부)을 교부하여야 합니다.",
            "③ 사업자는 제2항의 약식약관의 교부에 관계없이 이용자가 요구할 경우 약관의 사본을 교부하여야 합니다.",
            "",
            "제4조(게시설명의무)  ",
            "① 사업자는 이용자가 용이하게 볼 수 있는 장소에 다음 사항을 게시하여야 합니다.",
            "1.시간별 프로그램 내용 및 정원",
            "2.지도강사의 인적사항",
            "3.강습의 변경",
            "4.이용료",
            "5.약관내용",
            "6.소지품 보관시 유의 사항 등",
            "7.이용자 안전수칙 등 기타 필요사항",
            "② 사업자는 이용자가 체력단련장 시설 및 기구를 안전하게 이용할 수 있도록 이용방법 및 주의사항 설명 등 선량한 관리자로서 의무를 다하여야 합니다" +
                ".",
            "",
            "제5조(이용증 제시)  ",
            "① 이용자는 사업자가 이용증 제시를 요구할 경우 이용증을 제시하여야 합니다.",
            "② 이용자는 이용증을 분실하였을 경우 지체없이사업자에게 그 사실을 통지 하고 재교부를 받아야 합니다.",
            "",
            "제6조(이용신청 철회)  ",
            "① 이용자가 체력단련장 이용을 할부계약으로 신청한 경우 신청일로부터 7일 이내 서면으로, 방문사원 권유로 신청한 경우에는 신청일로부터 14일 이내" +
                "에 이용신청을 철회할 수 있습니다.",
            "단 신청일에 계약서(또는 약관)을 교부받지 못한 경우 이용 개시일을 기준으로 합니다.",
            "② 제1항의 경우 사업자는 ‘할부거래에관한법률’ 제6조, ‘방문판매등에관한법률’ 제9조에 따른 원상회복의 의무를 집니다.",
            "",
            "제7조(이용 연기)  ",
            "① 이용자는 체력단련장 이용 전 또는 이용 중 연기가 필요한 경우 사업자와 협의하여 이용시기를 연기할 수 있습니다.",
            "  ",
            "② 제1항의 경우에 이용자는 연기신청서를 사업자에게 제출하여야 합니다.",
            "③ 제2항의 신청을 받은 사업자는 특별한 사정이 없는 한 승낙하여야 합니다.",
            "",
            "제8조(계약의 해제해지)     (이하 생략)"});
            this.textBox1.Location = new System.Drawing.Point(14, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(543, 103);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // lbTuition
            // 
            this.lbTuition.AutoSize = true;
            this.lbTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTuition.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTuition.Location = new System.Drawing.Point(211, 208);
            this.lbTuition.Name = "lbTuition";
            this.lbTuition.Size = new System.Drawing.Size(57, 20);
            this.lbTuition.TabIndex = 17;
            this.lbTuition.Text = "label8";
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Cancle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Cancle.Location = new System.Drawing.Point(435, 204);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(122, 32);
            this.btn_Cancle.TabIndex = 16;
            this.btn_Cancle.Text = "취  소";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Agree
            // 
            this.btn_Agree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Agree.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agree.Location = new System.Drawing.Point(307, 204);
            this.btn_Agree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Agree.Name = "btn_Agree";
            this.btn_Agree.Size = new System.Drawing.Size(122, 32);
            this.btn_Agree.TabIndex = 15;
            this.btn_Agree.Text = "결  제";
            this.btn_Agree.UseVisualStyleBackColor = true;
            this.btn_Agree.Click += new System.EventHandler(this.btn_Agree_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "✔신규회원 가입약관";
            // 
            // cheAgree
            // 
            this.cheAgree.AutoSize = true;
            this.cheAgree.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cheAgree.Location = new System.Drawing.Point(418, 159);
            this.cheAgree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cheAgree.Name = "cheAgree";
            this.cheAgree.Size = new System.Drawing.Size(116, 21);
            this.cheAgree.TabIndex = 1;
            this.cheAgree.Text = "이용약관에 동의";
            this.cheAgree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(83, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "총 수강료(원)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 115);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 224);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbxlecture);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cbxPeriod);
            this.tabPage1.Controls.Add(this.cbxSex);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.dateBirth);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(575, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "👥개인정보";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(355, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(259, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "재학생 여부";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "✔실제로 수강할 회원명으로 회원가입 하여야 하며, \r\n  회원가입 후 회원 번호를 발급 받으실 수 있습니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 60);
            this.label2.TabIndex = 24;
            this.label2.Text = "✔ 할인 정보\r\n재학생 → 1개월 등록 시, 20%할인  일반인 →  6개월 등록 시, 20%할인\r\n                6개월 등록 시," +
    " 40%할인                   1년 등록 시, 40%할인\r\n                1년 등록 시, 50%할인 ";
            // 
            // OnlineMembership
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "OnlineMembership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Online Membership";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxlecture;
        private System.Windows.Forms.ComboBox cbxPeriod;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cheAgree;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Agree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTuition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}