using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeftTimeManagement_InternetCafe
{


    public partial class CheckIdForAddTime : Form
    {
        public static string addid = "";
        public static string addId
        {
            get { return addid; }
            set { addid = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }

        private MySqlConnection sqlconn = null;
        string constr = "Server=35.202.81.62;Port=3306;Database=personal_computer_room;Uid=root2;Pwd=789456123;";



        public CheckIdForAddTime()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            addId = text_Id.Text;

            string sql = "select count(*) as c from member_info where id='" + text_Id.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
            MySqlDataReader table = cmd.ExecuteReader();


            //   MessageBox.Show(table["c"].ToString());
            table.Read();
            
            if (table["c"].ToString() == "1")
            {
                table.Close();
                string sqlInsert = $"update member_info set remain=remain+{AddTime.passTime * 60 * 60} where id='{text_Id.Text}' ";

                MySqlCommand insertCmd = new MySqlCommand(sqlInsert, sqlconn);

                if (insertCmd.ExecuteNonQuery() == 1)
                {


                    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    int year = dt.Year;
                    int month = dt.Month;
                    int day = dt.Day;

                    //4. 날짜, 결제금액, 아이디, 이름 DB에 넣기
                    string profitLog = $"insert into profit_data (dates,profit,id) values('{year }-{month}-{day}',{AddTime.passProfit},'{text_Id.Text}')";
                    MySqlCommand profitLogCmd = new MySqlCommand(profitLog, sqlconn);

                    if(profitLogCmd.ExecuteNonQuery() == 1){ MessageBox.Show(AddTime.passTime + "시간 충전됐습니다."); this.Close(); }
                    else { MessageBox.Show("실패");  }

                    //this.Close();
                }
                else
                {
                    MessageBox.Show("시간 충전에 실패했습니다.");
                }

                //this.Close();
                //MessageBox.Show(AddTime.passTime.ToString() + "시간 충전 완료!");
            }
            else
            {
                MessageBox.Show("존재하지 않는 아이디입니다.");
            }
            sqlconn.Close();

        }

    }
}
