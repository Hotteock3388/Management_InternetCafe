namespace LeftTimeManagement_InternetCafe
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_usableId = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(141, 57);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(100, 25);
            this.text_Name.TabIndex = 1;
            // 
            // text_PhoneNumber
            // 
            this.text_PhoneNumber.Location = new System.Drawing.Point(141, 115);
            this.text_PhoneNumber.Name = "text_PhoneNumber";
            this.text_PhoneNumber.Size = new System.Drawing.Size(100, 25);
            this.text_PhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "핸드폰 번호 :";
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(141, 172);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(100, 25);
            this.text_Id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "아이디 :";
            // 
            // text_Pw
            // 
            this.text_Pw.Location = new System.Drawing.Point(141, 232);
            this.text_Pw.Name = "text_Pw";
            this.text_Pw.Size = new System.Drawing.Size(100, 25);
            this.text_Pw.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "비밀번호 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "중복 검사";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_usableId
            // 
            this.text_usableId.AutoSize = true;
            this.text_usableId.Location = new System.Drawing.Point(138, 200);
            this.text_usableId.Name = "text_usableId";
            this.text_usableId.Size = new System.Drawing.Size(172, 15);
            this.text_usableId.TabIndex = 10;
            this.text_usableId.Text = "중복 검사를 눌러주세요!";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(13, 13);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 11;
            this.btn_Back.Text = "뒤로가기";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 408);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.text_usableId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Pw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_PhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label text_usableId;
        private System.Windows.Forms.Button btn_Back;
    }
}