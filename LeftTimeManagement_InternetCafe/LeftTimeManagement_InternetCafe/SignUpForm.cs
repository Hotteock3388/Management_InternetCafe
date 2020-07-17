using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;    
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Org.BouncyCastle.Utilities;

namespace LeftTimeManagement_InternetCafe
{
    public partial class SignUpForm : Form
    {
        private MySqlConnection sqlconn = null;
        string constr = "Server=35.202.81.62;Port=3306;Database=personal_computer_room;Uid=root2;Pwd=789456123;";
        bool idCheck = false;

        public SignUpForm()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (text_Id.Text == "")
                {
                    MessageBox.Show("아이디를 입력해주세요!");
                }
                else
                {

                    sqlconn = new MySqlConnection(constr);
                    sqlconn.Open();

                    DataSet Lds = new DataSet();

                    string sql = "select count(*) as c from member_info where id='" + text_Id.Text + "'";


                    MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
                    MySqlDataReader table = cmd.ExecuteReader();


                    //   MessageBox.Show(table["c"].ToString());
                    table.Read();
                    if (table["c"].ToString() == "0")
                    {
                        MessageBox.Show("사용 가능한 아이디입니다.");
                        text_usableId.Text = "사용 가능";
                        text_usableId.ForeColor = Color.Blue;
                        idCheck = true;
                    }
                    else if (table["c"].ToString() == "1")
                    {
                        MessageBox.Show("이미 사용중인 아이디입니다.");
                        text_usableId.Text = "사용 불가능";
                        text_usableId.ForeColor = Color.Red;
                        idCheck = false;
                    }
                    sqlconn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //if (select count(*) from member_info where id__ = text_Id.Text)
            //    text_Id.Text = "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(text_Id.Text == "" || text_Name.Text == "" || text_PhoneNumber.Text == "" || text_Pw.Text == "")
            {
                MessageBox.Show("빈칸을 입력해주세요!");
            }
            else if(idCheck == false)
            {
                MessageBox.Show("아이디 중복 체크 버튼을 눌러주세요!");
            }
            else if (text_PhoneNumber.Text.Length != 11){
                MessageBox.Show("잘못된 전화번호 입니다!");
            }
            else{
                sqlconn = new MySqlConnection(constr);
                sqlconn.Open();

                string sql = "insert into member_info (name__, phone_no, id, password) values (" + "'" + text_Name.Text + "'" + "," +   "'" + text_PhoneNumber.Text + "'" + "," + "'" + text_Id.Text + "'" + "," + "'" + text_Pw.Text + "'" + ")";

                //MessageBox.Show(sql);


                //insert into memeber_info values(name__, phone_no, id, password) into("123", "123", "123", "123");
                MySqlCommand cmd1 = new MySqlCommand(sql, sqlconn);

                if (cmd1.ExecuteNonQuery() == 1)
                {

                    string sqlInsert = $"update member_info set remain=remain+{ 60} where id='{text_Id.Text}' ";

                    MySqlCommand insertCmd = new MySqlCommand(sqlInsert, sqlconn);

                    if (insertCmd.ExecuteNonQuery() == 1)
                    {


                        DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        int year = dt.Year;
                        int month = dt.Month;
                        int day = dt.Day;

                        //4. 날짜, 결제금액, 아이디, 이름 DB에 넣기
                        string profitLog = $"insert into profit_data (dates,profit,id) values('{year }-{month}-{day}',{0},'{text_Id.Text}')";
                        MySqlCommand profitLogCmd = new MySqlCommand(profitLog, sqlconn);

                        if (profitLogCmd.ExecuteNonQuery() == 1) {; }//{ MessageBox.Show(AddTime.passTime + "시간 충전됐습니다."); this.Close(); }

                        else { MessageBox.Show("실패"); }

                        //this.Close();
                    }


                    //Console.WriteLine("회원가입 성공");
                    MessageBox.Show("회원가입 성공");



                    this.Visible = false;
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                   
                }
                else
                {
                    //Console.WriteLine("회원가입 실패");
                    MessageBox.Show("회원가입 실패 관리자를 불러주세요.");
                }


                sqlconn.Close();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form1 form1 = new Form1();
            form1.ShowDialog();

            this.Close();
        }
    }
}
