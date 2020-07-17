using MySql.Data.MySqlClient;
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
    public partial class SignInForUseSeat : Form
    {

        public static bool[] login = { false, false, false, false, false, false, false};

        private MySqlConnection sqlconn = null;
        string constr = "Server=35.202.81.62;Port=3306;Database=personal_computer_room;Uid=root2;Pwd=789456123;";
        public SignInForUseSeat()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
           
            sqlconn = new MySqlConnection(constr);
            sqlconn.Open();

            string sql = "select count(*) as c from member_info where id='" + text_Id.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
            MySqlDataReader table = cmd.ExecuteReader();


            //   MessageBox.Show(table["c"].ToString());
            table.Read();

            if (table["c"].ToString() == "1")
            {
                table.Close();
                //reader["password"].ToString() 
                string pwCheckcmd = "select password as p from member_info where id='" + text_Id.Text + "'";
                MySqlCommand pwC = new MySqlCommand(pwCheckcmd, sqlconn);
                MySqlDataReader pwCheckReader = pwC.ExecuteReader();
                pwCheckReader.Read();

                if (pwCheckReader["p"].ToString() == text_Pw.Text)
                {
                    bool isUsingNow = false;
                    for (int i = 0; i < 6; i++)
                    {
                        if (UsingStatus.usingUser[i] == text_Id.Text)
                            isUsingNow = true;
                    }


                    if(isUsingNow == false)
                    {
                        UsingStatus.usingUser[UsingStatus.selNum] = text_Id.Text;
                        MessageBox.Show("성공!");

                        this.Close();
                        login[UsingStatus.selNum] = true;
                        pwCheckReader.Close();

                    }
                    else
                    {
                        MessageBox.Show("이미 사용중입니다!");
                    }
                }
                else
                {
                    MessageBox.Show("패스워드를 확인해주세요!");
                }

            }
            else
            {
                MessageBox.Show("존재하지 않는 아이디입니다.");
            }
            sqlconn.Close();

        }
    }
}
