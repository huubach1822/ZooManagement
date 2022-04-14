using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ZooManagement
{
    public partial class LoginForm : Form
    {
        string ConnectionName = @"Data Source=DESKTOP-G0G5EEO;Initial Catalog = ZooManagement; Integrated Security = True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);
            try
            {
                conn.Open();
                string username = txt_userName.Text;
                string password = txt_password.Text;
                string sql = "select * from Employee where Employee_name = '"+username+"' and password = '"+password+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                
                if(data.Read() == true)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Fail to login");
                    conn.Close();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Eror");
                conn.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
