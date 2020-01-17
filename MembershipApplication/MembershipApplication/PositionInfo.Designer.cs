namespace MembershipApplication
{
    partial class Map
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gangdang = new System.Windows.Forms.Button();
            this.B1F_1F = new System.Windows.Forms.Button();
            this.Floor2_1F = new System.Windows.Forms.Button();
            this.Floor1_where = new System.Windows.Forms.Label();
            this.Gangdang_2F = new System.Windows.Forms.Button();
            this.B1F_2F = new System.Windows.Forms.Button();
            this.Floor1_2F = new System.Windows.Forms.Button();
            this.Floor2_where = new System.Windows.Forms.Label();
            this.Multi_2F = new System.Windows.Forms.Button();
            this.Yoga_2F = new System.Windows.Forms.Button();
            this.Pool_B1F = new System.Windows.Forms.Button();
            this.Shower_B1F = new System.Windows.Forms.Button();
            this.Floor1_B1F = new System.Windows.Forms.Button();
            this.Floor2_B1F = new System.Windows.Forms.Button();
            this.B1F_where = new System.Windows.Forms.Label();
            this.Lounge_B1F = new System.Windows.Forms.Button();
            this.Gym_B1F = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gangdang
            // 
            this.Gangdang.Location = new System.Drawing.Point(13, 13);
            this.Gangdang.Name = "Gangdang";
            this.Gangdang.Size = new System.Drawing.Size(775, 277);
            this.Gangdang.TabIndex = 0;
            this.Gangdang.Text = "강당";
            this.Gangdang.UseVisualStyleBackColor = true;
            this.Gangdang.Click += new System.EventHandler(this.강당_Click);
            // 
            // B1F_1F
            // 
            this.B1F_1F.Location = new System.Drawing.Point(13, 583);
            this.B1F_1F.Name = "B1F_1F";
            this.B1F_1F.Size = new System.Drawing.Size(75, 39);
            this.B1F_1F.TabIndex = 1;
            this.B1F_1F.Text = "지하1층";
            this.B1F_1F.UseVisualStyleBackColor = true;
            this.B1F_1F.Click += new System.EventHandler(this.B1F_1F_Click);
            // 
            // Floor2_1F
            // 
            this.Floor2_1F.Location = new System.Drawing.Point(106, 583);
            this.Floor2_1F.Name = "Floor2_1F";
            this.Floor2_1F.Size = new System.Drawing.Size(75, 39);
            this.Floor2_1F.TabIndex = 2;
            this.Floor2_1F.Text = "2층";
            this.Floor2_1F.UseVisualStyleBackColor = true;
            this.Floor2_1F.Click += new System.EventHandler(this.Floor2_1F_Click);
            // 
            // Floor1_where
            // 
            this.Floor1_where.Location = new System.Drawing.Point(343, 591);
            this.Floor1_where.Name = "Floor1_where";
            this.Floor1_where.Size = new System.Drawing.Size(100, 23);
            this.Floor1_where.TabIndex = 3;
            this.Floor1_where.Text = "1층";
            this.Floor1_where.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gangdang_2F
            // 
            this.Gangdang_2F.Location = new System.Drawing.Point(13, 13);
            this.Gangdang_2F.Name = "Gangdang_2F";
            this.Gangdang_2F.Size = new System.Drawing.Size(775, 277);
            this.Gangdang_2F.TabIndex = 4;
            this.Gangdang_2F.Text = "강당관람석";
            this.Gangdang_2F.UseVisualStyleBackColor = true;
            this.Gangdang_2F.Visible = false;
            // 
            // B1F_2F
            // 
            this.B1F_2F.Location = new System.Drawing.Point(12, 583);
            this.B1F_2F.Name = "B1F_2F";
            this.B1F_2F.Size = new System.Drawing.Size(75, 39);
            this.B1F_2F.TabIndex = 5;
            this.B1F_2F.Text = "지하1층";
            this.B1F_2F.UseVisualStyleBackColor = true;
            this.B1F_2F.Visible = false;
            this.B1F_2F.Click += new System.EventHandler(this.B1F_2F_Click);
            // 
            // Floor1_2F
            // 
            this.Floor1_2F.Location = new System.Drawing.Point(106, 583);
            this.Floor1_2F.Name = "Floor1_2F";
            this.Floor1_2F.Size = new System.Drawing.Size(75, 39);
            this.Floor1_2F.TabIndex = 6;
            this.Floor1_2F.Text = "1층";
            this.Floor1_2F.UseVisualStyleBackColor = true;
            this.Floor1_2F.Visible = false;
            this.Floor1_2F.Click += new System.EventHandler(this.Floor1_2F_Click);
            // 
            // Floor2_where
            // 
            this.Floor2_where.Location = new System.Drawing.Point(343, 591);
            this.Floor2_where.Name = "Floor2_where";
            this.Floor2_where.Size = new System.Drawing.Size(100, 23);
            this.Floor2_where.TabIndex = 7;
            this.Floor2_where.Text = "2층";
            this.Floor2_where.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Floor2_where.Visible = false;
            // 
            // Multi_2F
            // 
            this.Multi_2F.Location = new System.Drawing.Point(540, 417);
            this.Multi_2F.Name = "Multi_2F";
            this.Multi_2F.Size = new System.Drawing.Size(248, 156);
            this.Multi_2F.TabIndex = 8;
            this.Multi_2F.Text = "다목적실";
            this.Multi_2F.UseVisualStyleBackColor = true;
            this.Multi_2F.Visible = false;
            this.Multi_2F.Click += new System.EventHandler(this.Multi_2F_Click);
            // 
            // Yoga_2F
            // 
            this.Yoga_2F.Location = new System.Drawing.Point(261, 417);
            this.Yoga_2F.Name = "Yoga_2F";
            this.Yoga_2F.Size = new System.Drawing.Size(248, 156);
            this.Yoga_2F.TabIndex = 9;
            this.Yoga_2F.Text = "요가실";
            this.Yoga_2F.UseVisualStyleBackColor = true;
            this.Yoga_2F.Visible = false;
            this.Yoga_2F.Click += new System.EventHandler(this.Yoga_2F_Click);
            // 
            // Pool_B1F
            // 
            this.Pool_B1F.Location = new System.Drawing.Point(13, 13);
            this.Pool_B1F.Name = "Pool_B1F";
            this.Pool_B1F.Size = new System.Drawing.Size(775, 217);
            this.Pool_B1F.TabIndex = 10;
            this.Pool_B1F.Text = "수영장";
            this.Pool_B1F.UseVisualStyleBackColor = true;
            this.Pool_B1F.Visible = false;
            this.Pool_B1F.Click += new System.EventHandler(this.Pool_B1F_Click);
            // 
            // Shower_B1F
            // 
            this.Shower_B1F.Location = new System.Drawing.Point(13, 248);
            this.Shower_B1F.Name = "Shower_B1F";
            this.Shower_B1F.Size = new System.Drawing.Size(279, 223);
            this.Shower_B1F.TabIndex = 11;
            this.Shower_B1F.Text = "샤워실";
            this.Shower_B1F.UseVisualStyleBackColor = true;
            this.Shower_B1F.Visible = false;
            this.Shower_B1F.Click += new System.EventHandler(this.shower_B1F_Click);
            // 
            // Floor1_B1F
            // 
            this.Floor1_B1F.Location = new System.Drawing.Point(12, 583);
            this.Floor1_B1F.Name = "Floor1_B1F";
            this.Floor1_B1F.Size = new System.Drawing.Size(75, 39);
            this.Floor1_B1F.TabIndex = 12;
            this.Floor1_B1F.Text = "1층";
            this.Floor1_B1F.UseVisualStyleBackColor = true;
            this.Floor1_B1F.Visible = false;
            this.Floor1_B1F.Click += new System.EventHandler(this.Floor1_B1F_Click);
            // 
            // Floor2_B1F
            // 
            this.Floor2_B1F.Location = new System.Drawing.Point(106, 583);
            this.Floor2_B1F.Name = "Floor2_B1F";
            this.Floor2_B1F.Size = new System.Drawing.Size(75, 39);
            this.Floor2_B1F.TabIndex = 13;
            this.Floor2_B1F.Text = "2층";
            this.Floor2_B1F.UseVisualStyleBackColor = true;
            this.Floor2_B1F.Visible = false;
            this.Floor2_B1F.Click += new System.EventHandler(this.Floor2_B1F_Click);
            // 
            // B1F_where
            // 
            this.B1F_where.Location = new System.Drawing.Point(343, 591);
            this.B1F_where.Name = "B1F_where";
            this.B1F_where.Size = new System.Drawing.Size(100, 23);
            this.B1F_where.TabIndex = 14;
            this.B1F_where.Text = "지하1층";
            this.B1F_where.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B1F_where.Visible = false;
            // 
            // Lounge_B1F
            // 
            this.Lounge_B1F.Location = new System.Drawing.Point(13, 488);
            this.Lounge_B1F.Name = "Lounge_B1F";
            this.Lounge_B1F.Size = new System.Drawing.Size(279, 85);
            this.Lounge_B1F.TabIndex = 15;
            this.Lounge_B1F.Text = "휴게실";
            this.Lounge_B1F.UseVisualStyleBackColor = true;
            this.Lounge_B1F.Visible = false;
            this.Lounge_B1F.Click += new System.EventHandler(this.lounge_B1F_Click);
            // 
            // Gym_B1F
            // 
            this.Gym_B1F.Location = new System.Drawing.Point(540, 248);
            this.Gym_B1F.Name = "Gym_B1F";
            this.Gym_B1F.Size = new System.Drawing.Size(248, 325);
            this.Gym_B1F.TabIndex = 16;
            this.Gym_B1F.Text = "헬스장";
            this.Gym_B1F.UseVisualStyleBackColor = true;
            this.Gym_B1F.Visible = false;
            this.Gym_B1F.Click += new System.EventHandler(this.Gym_B1F_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.Gym_B1F);
            this.Controls.Add(this.Lounge_B1F);
            this.Controls.Add(this.B1F_where);
            this.Controls.Add(this.Floor2_B1F);
            this.Controls.Add(this.Floor1_B1F);
            this.Controls.Add(this.Shower_B1F);
            this.Controls.Add(this.Pool_B1F);
            this.Controls.Add(this.Yoga_2F);
            this.Controls.Add(this.Multi_2F);
            this.Controls.Add(this.Floor2_where);
            this.Controls.Add(this.Floor1_2F);
            this.Controls.Add(this.B1F_2F);
            this.Controls.Add(this.Gangdang_2F);
            this.Controls.Add(this.Floor1_where);
            this.Controls.Add(this.Floor2_1F);
            this.Controls.Add(this.B1F_1F);
            this.Controls.Add(this.Gangdang);
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gangdang;
        private System.Windows.Forms.Button B1F_1F;
        private System.Windows.Forms.Button Floor2_1F;
        private System.Windows.Forms.Label Floor1_where;
        private System.Windows.Forms.Button Gangdang_2F;
        private System.Windows.Forms.Button B1F_2F;
        private System.Windows.Forms.Button Floor1_2F;
        private System.Windows.Forms.Label Floor2_where;
        private System.Windows.Forms.Button Multi_2F;
        private System.Windows.Forms.Button Yoga_2F;
        private System.Windows.Forms.Button Pool_B1F;
        private System.Windows.Forms.Button Shower_B1F;
        private System.Windows.Forms.Button Floor1_B1F;
        private System.Windows.Forms.Button Floor2_B1F;
        private System.Windows.Forms.Label B1F_where;
        private System.Windows.Forms.Button Lounge_B1F;
        private System.Windows.Forms.Button Gym_B1F;
    }
}

