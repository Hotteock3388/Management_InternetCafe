namespace LeftTimeManagement_InternetCafe
{
    partial class Form1
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
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_addTime = new System.Windows.Forms.Button();
            this.showAdmin = new System.Windows.Forms.Button();
            this.text_Adminpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(352, 83);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(354, 100);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.Text = "좌석 보기";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(352, 444);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(354, 100);
            this.btn_User.TabIndex = 1;
            this.btn_User.Text = "회원가입";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_addTime
            // 
            this.btn_addTime.Location = new System.Drawing.Point(352, 268);
            this.btn_addTime.Name = "btn_addTime";
            this.btn_addTime.Size = new System.Drawing.Size(354, 100);
            this.btn_addTime.TabIndex = 2;
            this.btn_addTime.Text = "시간 추가";
            this.btn_addTime.UseVisualStyleBackColor = true;
            this.btn_addTime.Click += new System.EventHandler(this.btn_addTime_Click);
            // 
            // showAdmin
            // 
            this.showAdmin.Location = new System.Drawing.Point(1015, 12);
            this.showAdmin.Name = "showAdmin";
            this.showAdmin.Size = new System.Drawing.Size(75, 23);
            this.showAdmin.TabIndex = 3;
            this.showAdmin.Text = "관리자";
            this.showAdmin.UseVisualStyleBackColor = true;
            this.showAdmin.Click += new System.EventHandler(this.showAdmin_Click);
            // 
            // text_Adminpw
            // 
            this.text_Adminpw.Location = new System.Drawing.Point(990, 41);
            this.text_Adminpw.Name = "text_Adminpw";
            this.text_Adminpw.Size = new System.Drawing.Size(100, 25);
            this.text_Adminpw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pw: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Adminpw);
            this.Controls.Add(this.showAdmin);
            this.Controls.Add(this.btn_addTime);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_addTime;
        private System.Windows.Forms.Button showAdmin;
        private System.Windows.Forms.TextBox text_Adminpw;
        private System.Windows.Forms.Label label1;
    }
}

