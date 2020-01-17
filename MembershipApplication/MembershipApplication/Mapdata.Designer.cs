namespace MembershipApplication
{
    partial class Data
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
            this.ItemTextbox = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemTextbox
            // 
            this.ItemTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemTextbox.Location = new System.Drawing.Point(25, 27);
            this.ItemTextbox.Name = "ItemTextbox";
            this.ItemTextbox.Size = new System.Drawing.Size(647, 521);
            this.ItemTextbox.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(558, 551);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(101, 27);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "돌아가기";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 590);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ItemTextbox);
            this.Name = "Data";
            this.Text = "정보";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemTextbox;
        private System.Windows.Forms.Button ButtonCancel;

        private const string GangDang_Text = "- 강당 -\n* 시설정보\n - 크기 : 면적 700m^2, 약 200명 수용가능, 2층 관람석 200석\n - 시설 : 농구 골대, 코트 4set/ 배구 코트, 넷트 2set/ 배드민턴 코트, 넷트 4set\n\n* 프로그램 \n - 배구\n     시간 : 화, 목 11:00 ~ 13:00, 시간외에도 이용가능\n     비용 : 월 5만원, 회원등록시 월 4만5천원\n  - 배드민턴\n     시간 : 월, 금 11:00 ~ 13:00, 시간외에도 이용가능\n     비용 : 월5만원, 회원등록시 월 4만5천원\n  - 농구\n     시간 : 수, 토 11:00 ~ 13:00, 시간외에도 이용가능\n     비용 : 월5만원, 회원등록시 월 4만5천원\n  - 다목적 실내 활동\n     시간 : 모든 요일 수업제외 시간.\n     비용 : 일일 5천원";
        private const string Swim_Text = "\n- 수영장 -\n *프로그램\n   - 어린이 수영(초심) :\n        대상 : 4세 ~ 13세 유아, 어린이\n       시간 : 평일 5일중 선택 3일, 일일 1시간 20분\n   - 기본 수영 프로그램 \n       대상 : 14세 이상\n       시간 : 평일 5일중 선택 3일, 일일 1시간30분\n   - 자유 수영\n       대상 : 모든 회원\n        시간 : 주말 09:00 ~ 20:00\n\n *시설정보\n   - 면적 : 360m^2\n  - 아동용 풀 1개, 50m풀 라인 4라인";
        private const string Yoga_Text = "\n- 요가실 -\n *프로그램\n  - 실내 요가 \n       시간 : 월, 목 18:00 ~ 19:30\n      비용 : 월 10만, 체육관 회원 등록시 8만원\n  - 댄스 다이어트\n      시간 : 화 수 금 18:00 ~ 19:30\n     비용 : 월 10만, 체육관 회원 등록시 8만원\n - 다목적 실내 활동\n      시간 : 주말\n      비용 : 이용 시간당 비용 계산\n *시설정보\n  - 면적 : 65m^2\n";
        private const string Gym_Text = "\n- 헬스장 -\n *비용 \n  - 시간 등록 ( 월10만원, 체육센터 회원등록시 월 8만원)\n *시설 정보\n    - 다양한 운동기구 설비\n   - 기구 신청시 구입 및 설치";
        private const string Multi_Text = "\n- 다목적실 -\n *프로그램 정보\n  - 탁구\n     시간 : 월 ~ 토 11:00 ~ 16:00 중 원하는 시간에 등록 일일 1시간 30분 수업\n      비용 : 월 10만, 체육관 회원 등록시 8만원\n               등록없이 이용시 5천원\n\n  - 댄스 다이어트\n      시간 : 월, 목 18:00 ~ 19:30\n     비용 : 월 10만, 체육관 회원 등록시 8만원\n - 실내 요가\n    시간 : 화, 수 18:00 ~ 19:30\n     비용 : 월 10만, 체육관 회원 등록시 8만원\n  - 기구 필라테스\n     시간 : 금 18:00 ~ 19:30\n     비용 :  월 10만, 체육관 회원 등록시 8만원\n *시설 정보\n   - 면적 65m^2\n   - 탁구대, 넷트 4set\n   - 필라테스용 기구\n   - 대형 스피커 2대\n   - 면적 65m^2\n   - 탁구대, 넷트 4set\n   - 필라테스용 기구";
        private const string Shower_Text = "\n- 샤워장 -\n   - 면적 : 100m^2\n   - 20명 동시 샤워 가능";
        private const string Lounge_Text = "\n- 휴계실 - \n   - 면적 36m^2\n   - 인터넷용 컴퓨터\n   - 회원등록 전용 기기\n   - 자판기\n   - 의자 및 책상";
    }
}