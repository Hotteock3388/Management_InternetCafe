namespace LeftTimeManagement_InternetCafe
{
    partial class SignInForUseSeat
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
            this.btn_Select = new System.Windows.Forms.Button();
            this.text_Pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(76, 181);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(91, 33);
            this.btn_Select.TabIndex = 6;
            this.btn_Select.Text = "시작 하기";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // text_Pw
            // 
            this.text_Pw.Location = new System.Drawing.Point(120, 112);
            this.text_Pw.Name = "text_Pw";
            this.text_Pw.PasswordChar = '●';
            this.text_Pw.Size = new System.Drawing.Size(100, 25);
            this.text_Pw.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호 :";
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(120, 72);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(100, 25);
            this.text_Id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "아이디 :";
            // 
            // SignInForUseSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 299);
            this.Controls.Add(this.text_Pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Select);
            this.Name = "SignInForUseSeat";
            this.Text = "CheckIdForUseSeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.TextBox text_Pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label1;
    }
}