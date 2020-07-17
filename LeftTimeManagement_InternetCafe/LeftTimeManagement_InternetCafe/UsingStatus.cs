using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LeftTimeManagement_InternetCafe
{
    public partial class UsingStatus : Form
    {

        private MySqlConnection sqlconn = null;
        string constr = "Server=35.202.81.62;Port=3306;Database=personal_computer_room;Uid=root2;Pwd=789456123;";
        //Timer timer1 = new Timer();
        Timer[] timer = { new Timer(), new Timer(), new Timer(), new Timer(), new Timer(), new Timer(), new Timer() };

        int[] start = new int[7];
        int[] stop = new int[7];
        
        int[] useTime = { 0, 0, 0, 0, 0, 0, 0};
        
        
        public static int selectNum = 0;

        int tt = 0;
        int[] leftTimes = new int[7];
        public static int selNum {get { return selectNum; } set { selectNum = value; } }

        public static string[] usingUser = new string[7]; // usingUser
//        public static string usingUser {
//            get { return user[]; }
//              set { user[dex] = value; } 
//}


        int usingSeat = 0;

        bool[] isUsing = { false, false, false, false, false, false, false };

        public UsingStatus()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++) { timer[i].Stop(); timer[i].Interval = 1000; }
            timer[1].Tick += timer1_Tick;
            timer[2].Tick += timer2_Tick;
            timer[3].Tick += timer3_Tick;
            timer[4].Tick += timer4_Tick;
            timer[5].Tick += timer5_Tick;
            timer[6].Tick += timer6_Tick;
        }

        private void UsingStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(usingSeat > 0)
            {
                if (e.CloseReason != CloseReason.WindowsShutDown) // 윈도우 종료가 아닐때만 프로그램 종료 안되게
                {
                    //this.Hide(); // 현재 창 숨기기
                    e.Cancel = true;
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 1;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();
           

            if (SignInForUseSeat.login[1] == true)
            {
                PC1_StartButton.Visible = false;
                PC1_LeftTime.Visible = true;
                PC1_Name.Visible = true;
                PC1_StopButton.Visible = true;



                SignInForUseSeat.login[1]= false;
                isUsing[1] = true;
                usingSeat++;



                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간
                
                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[1]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();

                table.Read();

                PC1_Name.Text = table["name__"].ToString();
                leftTimes[1] = int.Parse(table["remain"].ToString());



                if(leftTimes[1] <= 0)
                {
                    PC1_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }
                PC1_LeftTime.Text = (leftTimes[1] / 3600 + ":" + (leftTimes[1] / 3600) % 60 + ":" + leftTimes[1] % 60);

                //if (table["name__"].ToString() == "1")

                //timer[1].Tick += timer1_Tick;

                table.Close();
                timer[1].Start();
            }

            sqlconn.Close();


        }

        private void test() {
            int a = 2;
        }

        private void PC1_StopButton_Click(object sender, EventArgs e)
        {
            PC1_Stop();
        }
        private void PC1_Stop()
        {
            PC1_StartButton.Visible = true;
            PC1_LeftTime.Visible = false;
            PC1_Name.Visible = false;
            PC1_StopButton.Visible = false;
            record_use_data(1);
        }
        private void UsingStatus_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if(usingSeat == 0)
            {
                this.Visible = false;
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();   
            }
            else
            {
                MessageBox.Show("사용 종료를 눌러주세요!");
            }
            
        }

        private void PC2_StartButton_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 2;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();


            if (SignInForUseSeat.login[2] == true)
            {
                PC2_StartButton.Visible = false;
                PC2_LeftTime.Visible = true;
                PC2_Name.Visible = true;
                PC2_StopButton.Visible = true;
                SignInForUseSeat.login[2] = false;
                isUsing[2] = true;
                usingSeat++;


                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간

                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[2]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();


                //   MessageBox.Show(table["c"].ToString());
                table.Read();

                PC2_Name.Text = table["name__"].ToString();
                //PC2_LeftTime.Text = table["remain"].ToString();
                leftTimes[2] = int.Parse(table["remain"].ToString());
                if (leftTimes[2] <= 0)
                {
                    PC2_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }
                PC2_LeftTime.Text = (leftTimes[2] / 3600 + ":" + (leftTimes[2] / 3600) % 60 + ":" + leftTimes[2] % 60);
                //if (table["name__"].ToString() == "1")


                table.Close();
                timer[2].Start();
            }

            sqlconn.Close();

            
        }

        private void PC2_StopButton_Click(object sender, EventArgs e)
        {
            PC2_Stop();
        }
        private void PC2_Stop()
        {
            PC2_StartButton.Visible = true;
            PC2_LeftTime.Visible = false;
            PC2_Name.Visible = false;
            PC2_StopButton.Visible = false;         
            record_use_data(2);
        }
        private void PC3_StartButton_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 3;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();


            if (SignInForUseSeat.login[3] == true)
            {
                PC3_StartButton.Visible = false;
                PC3_LeftTime.Visible = true;
                PC3_Name.Visible = true;
                PC3_StopButton.Visible = true;
                SignInForUseSeat.login[3] = false;
                isUsing[3] = true;
                usingSeat++;

                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간

                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[3]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();


                //   MessageBox.Show(table["c"].ToString());
                table.Read();

                PC3_Name.Text = table["name__"].ToString();
                //PC3_LeftTime.Text = table["remain"].ToString();
                leftTimes[3] = int.Parse(table["remain"].ToString());

                if (leftTimes[3] <= 0)
                {
                    PC3_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }

                PC3_LeftTime.Text = (leftTimes[3] / 3600 + ":" + (leftTimes[3] / 3600) % 60 + ":" + leftTimes[3] % 60);
                //if (table["name__"].ToString() == "1")


                table.Close();
                timer[3].Start();
            }

            sqlconn.Close();

            
        }

        private void PC3_StopButton_Click(object sender, EventArgs e)
        {
            PC3_Stop();
        }
        private void PC3_Stop()
        {
            PC3_StartButton.Visible = true;
            PC3_LeftTime.Visible = false;
            PC3_Name.Visible = false;
            PC3_StopButton.Visible = false;
            record_use_data(3);
        }

        private void PC4_StartButton_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 4;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();


            if (SignInForUseSeat.login[4] == true)
            {
                PC4_StartButton.Visible = false;
                PC4_LeftTime.Visible = true;
                PC4_Name.Visible = true;
                PC4_StopButton.Visible = true;
                SignInForUseSeat.login[4] = false;
                isUsing[4] = true;
                usingSeat++;


                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간

                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[4]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();


                //   MessageBox.Show(table["c"].ToString());
                table.Read();

                PC4_Name.Text = table["name__"].ToString();
                //PC4_LeftTime.Text = table["remain"].ToString();
                leftTimes[4] = int.Parse(table["remain"].ToString());

                if (leftTimes[4] <= 0)
                {
                    PC4_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }

                PC4_LeftTime.Text = (leftTimes[4] / 3600 + ":" + (leftTimes[4] / 3600) % 60 + ":" + leftTimes[4] % 60);
                //if (table["name__"].ToString() == "1")


                table.Close();
                timer[4].Start();
            }

            sqlconn.Close();

            
        }

        private void PC4_StopButton_Click(object sender, EventArgs e)
        {
            PC4_Stop();
        }

        private void PC4_Stop()
        {
            PC4_StartButton.Visible = true;
            PC4_LeftTime.Visible = false;
            PC4_Name.Visible = false;
            PC4_StopButton.Visible = false;
            record_use_data(4);
        }

        private void PC5_StartButton_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 5;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();


            if (SignInForUseSeat.login[5] == true)
            {
                PC5_StartButton.Visible = false;
                PC5_LeftTime.Visible = true;
                PC5_Name.Visible = true;
                PC5_StopButton.Visible = true;
                SignInForUseSeat.login[5] = false;
                isUsing[5] = true;
                usingSeat++;
                timer[5].Start();

                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간

                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[5]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();


                //   MessageBox.Show(table["c"].ToString());
                table.Read();

                PC5_Name.Text = table["name__"].ToString();
                //PC5_LeftTime.Text = table["remain"].ToString();
                leftTimes[5] = int.Parse(table["remain"].ToString());


                if (leftTimes[5] <= 0)
                {
                    PC5_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }

                PC5_LeftTime.Text = (leftTimes[5] / 3600 + ":" + (leftTimes[5] / 3600) % 60 + ":" + leftTimes[5] % 60);
                //if (table["name__"].ToString() == "1")


                table.Close();

            }

            sqlconn.Close();

            
        }

        private void PC5_StopButton_Click(object sender, EventArgs e)
        {
            PC5_Stop();
        }

        private void PC5_Stop()
        {
            PC5_StartButton.Visible = true;
            PC5_LeftTime.Visible = false;
            PC5_Name.Visible = false;
            PC5_StopButton.Visible = false;
            record_use_data(5);
            
        }

        private void PC6_StartButton_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            selNum = 6;
            SignInForUseSeat checkIdForUseSeat = new SignInForUseSeat();
            checkIdForUseSeat.ShowDialog();


            if (SignInForUseSeat.login[6] == true)
            {
                PC6_StartButton.Visible = false;
                PC6_LeftTime.Visible = true;
                PC6_Name.Visible = true;
                PC6_StopButton.Visible = true;
                SignInForUseSeat.login[6] = false;
                isUsing[6] = true;
                usingSeat++;


                //PC1_NAME 에 이름, PC1_LeftTime에 남은 시간

                //ID값을 가지고 유저의 이름, 남은 시간 가져오는 쿼리문
                string name_time = $"select name__, remain from member_info where id='{usingUser[6]}'";

                MySqlCommand cmd = new MySqlCommand(name_time, sqlconn);
                MySqlDataReader table = cmd.ExecuteReader();


                //   MessageBox.Show(table["c"].ToString());
                table.Read();

                PC6_Name.Text = table["name__"].ToString();
                //PC6_LeftTime.Text = table["remain"].ToString();
                leftTimes[6] = int.Parse(table["remain"].ToString());

                if (leftTimes[6] <= 0)
                {
                    PC6_Stop();
                    MessageBox.Show("남은 시간이 없습니다!");
                }

                PC6_LeftTime.Text = (leftTimes[6] / 3600 + ":" + (leftTimes[6] / 3600) % 60 + ":" + leftTimes[6] % 60);
                //if (table["name__"].ToString() == "1")


                table.Close();
                timer[6].Start();   
            }

            sqlconn.Close();

            
        }




        private void PC6_StopButton_Click(object sender, EventArgs e)
        {
            PC6_Stop();
        }

        private void PC6_Stop()
        {
            PC6_StartButton.Visible = true;

            PC6_LeftTime.Visible = false;
            PC6_Name.Visible = false;
            PC6_StopButton.Visible = false;

            record_use_data(6);

            
        }




        //사용기록 남기기
        private void record_use_data(int index)
        {
            usingSeat--;
            timer[index].Stop();
            isUsing[index] = false;

            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();


            string reduceTime = $"update member_info set remain=remain-{useTime[index]} where id='{usingUser[index]}' ";

            MySqlCommand cmd = new MySqlCommand(reduceTime, sqlconn);


            if (cmd.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("사용 종료!") ;
            }
            else
            {
                MessageBox.Show("실패!");
            }

            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;

            if (useTime[index] > 0)
            {
                string useLog = $"insert into use_data (dates,id,seat_no,use_time) values('{year}-{month}-{day}', '{usingUser[index]}', {index},'{useTime[index]}')";

                MySqlCommand uselogcmd = new MySqlCommand(useLog, sqlconn);

                if (uselogcmd.ExecuteNonQuery() == 1)
                {
                    usingUser[index] = "";
                    MessageBox.Show("완료!!");
                }
                else
                {
                    MessageBox.Show("사용 종료!!");
                }
                sqlconn.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_tick(1);
            PC1_LeftTime.Text = (leftTimes[1] / 3600 + ":" + (leftTimes[1] / 3600) % 60 + ":" + leftTimes[1] % 60);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer_tick(2);
            PC2_LeftTime.Text = (leftTimes[2] / 3600 + ":" + (leftTimes[2] / 3600) % 60 + ":" + leftTimes[2] % 60);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer_tick(3);
            PC3_LeftTime.Text = (leftTimes[3] / 3600 + ":" + (leftTimes[3] / 3600) % 60 + ":" + leftTimes[3] % 60);
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            timer_tick(4);
            PC4_LeftTime.Text = (leftTimes[4] / 3600 + ":" + (leftTimes[4] / 3600) % 60 + ":" + leftTimes[4] % 60);
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            timer_tick(5);
            PC5_LeftTime.Text = (leftTimes[5] / 3600 + ":" + (leftTimes[5] / 3600) % 60 + ":" + leftTimes[5] % 60);
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            timer_tick(6);
            PC6_LeftTime.Text = (leftTimes[6] / 3600 + ":" + (leftTimes[6] / 3600) % 60 + ":" + leftTimes[6] % 60);
        }

        private void timer_tick(int index)
        {
            if (isUsing[index] == true)
            {
                if (leftTimes[index] <= 0)
                {
                    MessageBox.Show("남은 시간이 없습니다!");
                    switch (index)
                    {
                        case 1: PC1_Stop(); break;
                        case 2: PC2_Stop(); break;
                        case 3: PC3_Stop(); break;
                        case 4: PC4_Stop(); break;
                        case 5: PC5_Stop(); break;
                        case 6: PC6_Stop(); break;
                    }
                }

                leftTimes[index]--;
                useTime[index] += 1;
            }
        }
    }

}