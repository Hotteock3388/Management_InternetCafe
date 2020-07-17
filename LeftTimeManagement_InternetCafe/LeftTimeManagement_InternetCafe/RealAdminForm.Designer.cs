namespace LeftTimeManagement_InternetCafe
{
    partial class RealAdminForm
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
            this.btn_ShowAccount = new System.Windows.Forms.Button();
            this.btn_ShowProfitLog = new System.Windows.Forms.Button();
            this.btn_ShowUseLog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.removeId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowAccount
            // 
            this.btn_ShowAccount.Location = new System.Drawing.Point(799, 45);
            this.btn_ShowAccount.Name = "btn_ShowAccount";
            this.btn_ShowAccount.Size = new System.Drawing.Size(138, 99);
            this.btn_ShowAccount.TabIndex = 0;
            this.btn_ShowAccount.Text = "유저 정보";
            this.btn_ShowAccount.UseVisualStyleBackColor = true;
            this.btn_ShowAccount.Click += new System.EventHandler(this.btn_ShowAccount_Click);
            // 
            // btn_ShowProfitLog
            // 
            this.btn_ShowProfitLog.Location = new System.Drawing.Point(799, 226);
            this.btn_ShowProfitLog.Name = "btn_ShowProfitLog";
            this.btn_ShowProfitLog.Size = new System.Drawing.Size(138, 99);
            this.btn_ShowProfitLog.TabIndex = 1;
            this.btn_ShowProfitLog.Text = "결제 로그";
            this.btn_ShowProfitLog.UseVisualStyleBackColor = true;
            this.btn_ShowProfitLog.Click += new System.EventHandler(this.btn_ShowProfitLog_Click);
            // 
            // btn_ShowUseLog
            // 
            this.btn_ShowUseLog.Location = new System.Drawing.Point(799, 410);
            this.btn_ShowUseLog.Name = "btn_ShowUseLog";
            this.btn_ShowUseLog.Size = new System.Drawing.Size(138, 99);
            this.btn_ShowUseLog.TabIndex = 2;
            this.btn_ShowUseLog.Text = "사용 로그";
            this.btn_ShowUseLog.UseVisualStyleBackColor = true;
            this.btn_ShowUseLog.Click += new System.EventHandler(this.btn_ShowUseLog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(793, 558);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(825, 177);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "삭제";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // removeId
            // 
            this.removeId.Location = new System.Drawing.Point(816, 146);
            this.removeId.Name = "removeId";
            this.removeId.Size = new System.Drawing.Size(100, 25);
            this.removeId.TabIndex = 5;
            // 
            // RealAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 570);
            this.Controls.Add(this.removeId);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ShowUseLog);
            this.Controls.Add(this.btn_ShowProfitLog);
            this.Controls.Add(this.btn_ShowAccount);
            this.Name = "RealAdminForm";
            this.Text = "RealAdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowAccount;
        private System.Windows.Forms.Button btn_ShowProfitLog;
        private System.Windows.Forms.Button btn_ShowUseLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox removeId;
    }
}