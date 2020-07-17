using Org.BouncyCastle.Asn1.Crmf;
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
    public partial class AddTime : Form
    {
        private static int selectedTime = 0;

        public static int passTime
        {
            get { return selectedTime; }

            set { selectedTime = value; }
        }

        private static int selectedProfit = 0;

        public static int passProfit
        {
            get { return selectedProfit; }

            set { selectedProfit = value; }
        }

        public AddTime()
        {
            InitializeComponent();
        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Close();
        }

        private void btn1000_3_Click(object sender, EventArgs e)
        {
            button_click(3, 1000);


        }

        private void btn2000_6_Click(object sender, EventArgs e)
        {
            button_click(6, 2000);
        }

        private void btn3000_9_Click(object sender, EventArgs e)
        {
            button_click(9, 3000);
        }

        private void btn5000_20_Click(object sender, EventArgs e)
        {
            button_click(20, 5000);
        }

        private void btn10000_50_Click(object sender, EventArgs e)
        {
            button_click(50, 10000);
        }

        private void btn20000_300_Click(object sender, EventArgs e)
        {
            button_click(300, 20000);
        }

        private void btn50000_1500_Click(object sender, EventArgs e)
        {
            button_click(1500, 50000);
        }

        public void button_click(int time,int profit)
        {
            passTime = time;
            passProfit = profit;
            CheckIdForAddTime checkIdForAddTime = new CheckIdForAddTime();
            checkIdForAddTime.ShowDialog();
        }

    }
}
