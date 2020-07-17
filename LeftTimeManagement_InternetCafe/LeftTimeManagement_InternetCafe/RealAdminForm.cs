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
    public partial class RealAdminForm : Form
    {

        private MySqlConnection sqlconn = null;
        string constr = "Server=35.202.81.62;Port=3306;Database=personal_computer_room;Uid=root2;Pwd=789456123;";

        public RealAdminForm()
        {
            InitializeComponent();
        }

      

        private void btn_ShowAccount_Click(object sender, EventArgs e)
        {
            DataSet account = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                //연결이 안되었어도 자동적으로 연결하고 연결을 끊는다.
                string sql = $"SELECT member_info.*, SUM(profit_data.profit) FROM member_info INNER JOIN profit_data ON member_info.id = profit_data.id GROUP BY member_info.id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(account, "name__");
                conn.Close();
            }
           
            dataGridView1.DataSource = account.Tables[0];
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {


            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                string rId = removeId.Text;
                MySqlCommand command = new MySqlCommand();

                command.Connection = conn;
                command.CommandText = $"DELETE FROM member_info WHERE id = '{rId}';";
                command.ExecuteNonQuery();

                btn_ShowAccount_Click(null, null); //재조회 
            }

        }


        private void btn_ShowProfitLog_Click(object sender, EventArgs e)
        {
            DataSet profit = new DataSet();
            
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                //연결이 안되었어도 자동적으로 연결하고 연결을 끊는다.
                string sql = "select * from profit_data";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(profit, "name__");
                conn.Close();
            }
            dataGridView1.DataSource = profit.Tables[0];
        }

       


        private void btn_ShowUseLog_Click(object sender, EventArgs e)
        {
            DataSet useLog = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                conn.Open();
                //연결이 안되었어도 자동적으로 연결하고 연결을 끊는다.
                string sql = "select * from use_data";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(useLog, "name__");
                conn.Close();
            }
            dataGridView1.DataSource = useLog.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
