namespace MembershipApplication
{
    partial class MembershipApplication
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bntMembership = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "체육시설 관리프로그램";
            // 
            // bntMembership
            // 
            this.bntMembership.Location = new System.Drawing.Point(191, 145);
            this.bntMembership.Name = "bntMembership";
            this.bntMembership.Size = new System.Drawing.Size(265, 36);
            this.bntMembership.TabIndex = 1;
            this.bntMembership.Text = "1. 등록";
            this.bntMembership.UseVisualStyleBackColor = true;
            this.bntMembership.Click += new System.EventHandler(this.bntMembership_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(191, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(265, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "2. 조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "3. 비용안내";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MembershipApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.bntMembership);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 455);
            this.MinimumSize = new System.Drawing.Size(700, 455);
            this.Name = "MembershipApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntMembership;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button3;
    }
}

