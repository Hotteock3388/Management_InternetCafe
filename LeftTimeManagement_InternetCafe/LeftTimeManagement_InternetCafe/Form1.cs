using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeftTimeManagement_InternetCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            UsingStatus usingStatus = new UsingStatus();
            usingStatus.ShowDialog();

            this.Close();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            SignUpForm signupForm = new SignUpForm();
            signupForm.ShowDialog();
            this.Close();
        }

        private void btn_addTime_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            AddTime addTime = new AddTime();
            addTime.ShowDialog();

            this.Close();
        }

        private void showAdmin_Click(object sender, EventArgs e)
        {

            if(text_Adminpw.Text == "9876")
            {
                this.Visible = false;

                RealAdminForm realAdmin = new RealAdminForm();
                realAdmin.ShowDialog();

                this.Close();
            }
            if(text_Adminpw.Text == "")
            {
                MessageBox.Show("패스워드를 입력해주세요!");
            }
            else
            {
                MessageBox.Show("패스워드가 틀렸습니다!");
            }
            
        }
    }
}
