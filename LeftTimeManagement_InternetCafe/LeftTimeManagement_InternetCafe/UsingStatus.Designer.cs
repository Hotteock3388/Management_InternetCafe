using System.Windows.Forms;

namespace LeftTimeManagement_InternetCafe
{
    partial class UsingStatus
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
            this.PC_1 = new System.Windows.Forms.GroupBox();
            this.PC1_StopButton = new System.Windows.Forms.Button();
            this.PC1_LeftTime = new System.Windows.Forms.Label();
            this.PC1_Name = new System.Windows.Forms.Label();
            this.PC1_StartButton = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PC2_StopButton = new System.Windows.Forms.Button();
            this.PC2_LeftTime = new System.Windows.Forms.Label();
            this.PC2_Name = new System.Windows.Forms.Label();
            this.PC2_StartButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PC3_StopButton = new System.Windows.Forms.Button();
            this.PC3_LeftTime = new System.Windows.Forms.Label();
            this.PC3_Name = new System.Windows.Forms.Label();
            this.PC3_StartButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PC6_StopButton = new System.Windows.Forms.Button();
            this.PC6_LeftTime = new System.Windows.Forms.Label();
            this.PC6_Name = new System.Windows.Forms.Label();
            this.PC6_StartButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PC5_StopButton = new System.Windows.Forms.Button();
            this.PC5_LeftTime = new System.Windows.Forms.Label();
            this.PC5_Name = new System.Windows.Forms.Label();
            this.PC5_StartButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PC4_StopButton = new System.Windows.Forms.Button();
            this.PC4_LeftTime = new System.Windows.Forms.Label();
            this.PC4_Name = new System.Windows.Forms.Label();
            this.PC4_StartButton = new System.Windows.Forms.Button();
            this.PC_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PC_1
            // 
            this.PC_1.Controls.Add(this.PC1_StopButton);
            this.PC_1.Controls.Add(this.PC1_LeftTime);
            this.PC_1.Controls.Add(this.PC1_Name);
            this.PC_1.Controls.Add(this.PC1_StartButton);
            this.PC_1.Location = new System.Drawing.Point(40, 68);
            this.PC_1.Name = "PC_1";
            this.PC_1.Size = new System.Drawing.Size(200, 100);
            this.PC_1.TabIndex = 0;
            this.PC_1.TabStop = false;
            this.PC_1.Text = "PC 1";
            // 
            // PC1_StopButton
            // 
            this.PC1_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC1_StopButton.Name = "PC1_StopButton";
            this.PC1_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC1_StopButton.TabIndex = 3;
            this.PC1_StopButton.Text = "종료";
            this.PC1_StopButton.UseVisualStyleBackColor = true;
            this.PC1_StopButton.Visible = false;
            this.PC1_StopButton.Click += new System.EventHandler(this.PC1_StopButton_Click);
            // 
            // PC1_LeftTime
            // 
            this.PC1_LeftTime.AutoSize = true;
            this.PC1_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC1_LeftTime.Name = "PC1_LeftTime";
            this.PC1_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC1_LeftTime.TabIndex = 2;
            this.PC1_LeftTime.Text = "남은 시간";
            this.PC1_LeftTime.Visible = false;
            // 
            // PC1_Name
            // 
            this.PC1_Name.AutoSize = true;
            this.PC1_Name.Location = new System.Drawing.Point(71, 43);
            this.PC1_Name.Name = "PC1_Name";
            this.PC1_Name.Size = new System.Drawing.Size(37, 15);
            this.PC1_Name.TabIndex = 1;
            this.PC1_Name.Text = "이름";
            this.PC1_Name.Visible = false;
            // 
            // PC1_StartButton
            // 
            this.PC1_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC1_StartButton.Name = "PC1_StartButton";
            this.PC1_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC1_StartButton.TabIndex = 0;
            this.PC1_StartButton.Text = "사용하기";
            this.PC1_StartButton.UseVisualStyleBackColor = true;
            this.PC1_StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "뒤로가기";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PC2_StopButton);
            this.groupBox1.Controls.Add(this.PC2_LeftTime);
            this.groupBox1.Controls.Add(this.PC2_Name);
            this.groupBox1.Controls.Add(this.PC2_StartButton);
            this.groupBox1.Location = new System.Drawing.Point(272, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC 2";
            // 
            // PC2_StopButton
            // 
            this.PC2_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC2_StopButton.Name = "PC2_StopButton";
            this.PC2_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC2_StopButton.TabIndex = 3;
            this.PC2_StopButton.Text = "종료";
            this.PC2_StopButton.UseVisualStyleBackColor = true;
            this.PC2_StopButton.Visible = false;
            this.PC2_StopButton.Click += new System.EventHandler(this.PC2_StopButton_Click);
            // 
            // PC2_LeftTime
            // 
            this.PC2_LeftTime.AutoSize = true;
            this.PC2_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC2_LeftTime.Name = "PC2_LeftTime";
            this.PC2_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC2_LeftTime.TabIndex = 2;
            this.PC2_LeftTime.Text = "남은 시간";
            this.PC2_LeftTime.Visible = false;
            // 
            // PC2_Name
            // 
            this.PC2_Name.AutoSize = true;
            this.PC2_Name.Location = new System.Drawing.Point(71, 43);
            this.PC2_Name.Name = "PC2_Name";
            this.PC2_Name.Size = new System.Drawing.Size(37, 15);
            this.PC2_Name.TabIndex = 1;
            this.PC2_Name.Text = "이름";
            this.PC2_Name.Visible = false;
            // 
            // PC2_StartButton
            // 
            this.PC2_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC2_StartButton.Name = "PC2_StartButton";
            this.PC2_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC2_StartButton.TabIndex = 0;
            this.PC2_StartButton.Text = "사용하기";
            this.PC2_StartButton.UseVisualStyleBackColor = true;
            this.PC2_StartButton.Click += new System.EventHandler(this.PC2_StartButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PC3_StopButton);
            this.groupBox2.Controls.Add(this.PC3_LeftTime);
            this.groupBox2.Controls.Add(this.PC3_Name);
            this.groupBox2.Controls.Add(this.PC3_StartButton);
            this.groupBox2.Location = new System.Drawing.Point(512, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC 3";
            // 
            // PC3_StopButton
            // 
            this.PC3_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC3_StopButton.Name = "PC3_StopButton";
            this.PC3_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC3_StopButton.TabIndex = 3;
            this.PC3_StopButton.Text = "종료";
            this.PC3_StopButton.UseVisualStyleBackColor = true;
            this.PC3_StopButton.Visible = false;
            this.PC3_StopButton.Click += new System.EventHandler(this.PC3_StopButton_Click);
            // 
            // PC3_LeftTime
            // 
            this.PC3_LeftTime.AutoSize = true;
            this.PC3_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC3_LeftTime.Name = "PC3_LeftTime";
            this.PC3_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC3_LeftTime.TabIndex = 2;
            this.PC3_LeftTime.Text = "남은 시간";
            this.PC3_LeftTime.Visible = false;
            // 
            // PC3_Name
            // 
            this.PC3_Name.AutoSize = true;
            this.PC3_Name.Location = new System.Drawing.Point(71, 43);
            this.PC3_Name.Name = "PC3_Name";
            this.PC3_Name.Size = new System.Drawing.Size(37, 15);
            this.PC3_Name.TabIndex = 1;
            this.PC3_Name.Text = "이름";
            this.PC3_Name.Visible = false;
            // 
            // PC3_StartButton
            // 
            this.PC3_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC3_StartButton.Name = "PC3_StartButton";
            this.PC3_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC3_StartButton.TabIndex = 0;
            this.PC3_StartButton.Text = "사용하기";
            this.PC3_StartButton.UseVisualStyleBackColor = true;
            this.PC3_StartButton.Click += new System.EventHandler(this.PC3_StartButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PC6_StopButton);
            this.groupBox3.Controls.Add(this.PC6_LeftTime);
            this.groupBox3.Controls.Add(this.PC6_Name);
            this.groupBox3.Controls.Add(this.PC6_StartButton);
            this.groupBox3.Location = new System.Drawing.Point(512, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PC 6";
            // 
            // PC6_StopButton
            // 
            this.PC6_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC6_StopButton.Name = "PC6_StopButton";
            this.PC6_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC6_StopButton.TabIndex = 3;
            this.PC6_StopButton.Text = "종료";
            this.PC6_StopButton.UseVisualStyleBackColor = true;
            this.PC6_StopButton.Visible = false;
            this.PC6_StopButton.Click += new System.EventHandler(this.PC6_StopButton_Click);
            // 
            // PC6_LeftTime
            // 
            this.PC6_LeftTime.AutoSize = true;
            this.PC6_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC6_LeftTime.Name = "PC6_LeftTime";
            this.PC6_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC6_LeftTime.TabIndex = 2;
            this.PC6_LeftTime.Text = "남은 시간";
            this.PC6_LeftTime.Visible = false;
            // 
            // PC6_Name
            // 
            this.PC6_Name.AutoSize = true;
            this.PC6_Name.Location = new System.Drawing.Point(71, 43);
            this.PC6_Name.Name = "PC6_Name";
            this.PC6_Name.Size = new System.Drawing.Size(37, 15);
            this.PC6_Name.TabIndex = 1;
            this.PC6_Name.Text = "이름";
            this.PC6_Name.Visible = false;
            // 
            // PC6_StartButton
            // 
            this.PC6_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC6_StartButton.Name = "PC6_StartButton";
            this.PC6_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC6_StartButton.TabIndex = 0;
            this.PC6_StartButton.Text = "사용하기";
            this.PC6_StartButton.UseVisualStyleBackColor = true;
            this.PC6_StartButton.Click += new System.EventHandler(this.PC6_StartButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PC5_StopButton);
            this.groupBox4.Controls.Add(this.PC5_LeftTime);
            this.groupBox4.Controls.Add(this.PC5_Name);
            this.groupBox4.Controls.Add(this.PC5_StartButton);
            this.groupBox4.Location = new System.Drawing.Point(272, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PC 5";
            // 
            // PC5_StopButton
            // 
            this.PC5_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC5_StopButton.Name = "PC5_StopButton";
            this.PC5_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC5_StopButton.TabIndex = 3;
            this.PC5_StopButton.Text = "종료";
            this.PC5_StopButton.UseVisualStyleBackColor = true;
            this.PC5_StopButton.Visible = false;
            this.PC5_StopButton.Click += new System.EventHandler(this.PC5_StopButton_Click);
            // 
            // PC5_LeftTime
            // 
            this.PC5_LeftTime.AutoSize = true;
            this.PC5_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC5_LeftTime.Name = "PC5_LeftTime";
            this.PC5_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC5_LeftTime.TabIndex = 2;
            this.PC5_LeftTime.Text = "남은 시간";
            this.PC5_LeftTime.Visible = false;
            // 
            // PC5_Name
            // 
            this.PC5_Name.AutoSize = true;
            this.PC5_Name.Location = new System.Drawing.Point(71, 43);
            this.PC5_Name.Name = "PC5_Name";
            this.PC5_Name.Size = new System.Drawing.Size(37, 15);
            this.PC5_Name.TabIndex = 1;
            this.PC5_Name.Text = "이름";
            this.PC5_Name.Visible = false;
            // 
            // PC5_StartButton
            // 
            this.PC5_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC5_StartButton.Name = "PC5_StartButton";
            this.PC5_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC5_StartButton.TabIndex = 0;
            this.PC5_StartButton.Text = "사용하기";
            this.PC5_StartButton.UseVisualStyleBackColor = true;
            this.PC5_StartButton.Click += new System.EventHandler(this.PC5_StartButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PC4_StopButton);
            this.groupBox5.Controls.Add(this.PC4_LeftTime);
            this.groupBox5.Controls.Add(this.PC4_Name);
            this.groupBox5.Controls.Add(this.PC4_StartButton);
            this.groupBox5.Location = new System.Drawing.Point(40, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PC 4";
            // 
            // PC4_StopButton
            // 
            this.PC4_StopButton.Location = new System.Drawing.Point(142, 12);
            this.PC4_StopButton.Name = "PC4_StopButton";
            this.PC4_StopButton.Size = new System.Drawing.Size(52, 23);
            this.PC4_StopButton.TabIndex = 3;
            this.PC4_StopButton.Text = "종료";
            this.PC4_StopButton.UseVisualStyleBackColor = true;
            this.PC4_StopButton.Visible = false;
            this.PC4_StopButton.Click += new System.EventHandler(this.PC4_StopButton_Click);
            // 
            // PC4_LeftTime
            // 
            this.PC4_LeftTime.AutoSize = true;
            this.PC4_LeftTime.Location = new System.Drawing.Point(57, 69);
            this.PC4_LeftTime.Name = "PC4_LeftTime";
            this.PC4_LeftTime.Size = new System.Drawing.Size(72, 15);
            this.PC4_LeftTime.TabIndex = 2;
            this.PC4_LeftTime.Text = "남은 시간";
            this.PC4_LeftTime.Visible = false;
            // 
            // PC4_Name
            // 
            this.PC4_Name.AutoSize = true;
            this.PC4_Name.Location = new System.Drawing.Point(71, 43);
            this.PC4_Name.Name = "PC4_Name";
            this.PC4_Name.Size = new System.Drawing.Size(37, 15);
            this.PC4_Name.TabIndex = 1;
            this.PC4_Name.Text = "이름";
            this.PC4_Name.Visible = false;
            // 
            // PC4_StartButton
            // 
            this.PC4_StartButton.Location = new System.Drawing.Point(54, 43);
            this.PC4_StartButton.Name = "PC4_StartButton";
            this.PC4_StartButton.Size = new System.Drawing.Size(75, 23);
            this.PC4_StartButton.TabIndex = 0;
            this.PC4_StartButton.Text = "사용하기";
            this.PC4_StartButton.UseVisualStyleBackColor = true;
            this.PC4_StartButton.Click += new System.EventHandler(this.PC4_StartButton_Click);
            // 
            // UsingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.PC_1);
            this.Name = "UsingStatus";
            this.Text = "usingStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsingStatus_FormClosing);
            this.PC_1.ResumeLayout(false);
            this.PC_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PC_1;
        private System.Windows.Forms.Button PC1_StartButton;
        private System.Windows.Forms.Button PC1_StopButton;
        private System.Windows.Forms.Label PC1_LeftTime;
        private System.Windows.Forms.Label PC1_Name;
        private Button btn_Back;
        private GroupBox groupBox1;
        private Button PC2_StopButton;
        private Label PC2_LeftTime;
        private Label PC2_Name;
        private Button PC2_StartButton;
        private GroupBox groupBox2;
        private Button PC3_StopButton;
        private Label PC3_LeftTime;
        private Label PC3_Name;
        private Button PC3_StartButton;
        private GroupBox groupBox3;
        private Button PC6_StopButton;
        private Label PC6_LeftTime;
        private Label PC6_Name;
        private Button PC6_StartButton;
        private GroupBox groupBox4;
        private Button PC5_StopButton;
        private Label PC5_LeftTime;
        private Label PC5_Name;
        private Button PC5_StartButton;
        private GroupBox groupBox5;
        private Button PC4_StopButton;
        private Label PC4_LeftTime;
        private Label PC4_Name;
        private Button PC4_StartButton;
    }
}