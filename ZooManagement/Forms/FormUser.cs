using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ZooManagement.Forms
{
    public partial class FormUser : Form
    {

        string ConnectionName = @"Data Source=DESKTOP-G0G5EEO;Initial Catalog = ZooManagement; Integrated Security = True";
        public FormUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);
          
                conn.Open();
                int id = int.Parse(txt_Id.Text);
                string name = txt_name.Text;
                string dOB = txt_DateOfBirth.Text;
                string address = txt_addess.Text;
                string phoneNumber = txt_Password.Text;
                string passWord = txt_Password.Text;
                int gender;
                if (rdb_Male.Checked == true)
                {
                     gender = 1;
                }
                else gender = 0;

                    string sql = "insert into Employee values (@ID,@NAME,@dOB,@gender,@address,@phoneNumber,@passWord)" ;
             
                SqlCommand cmd2 = new SqlCommand(sql, conn);
                cmd2.Parameters.AddWithValue("@ID", id);
                cmd2.Parameters.AddWithValue("@NAME", name);
                cmd2.Parameters.AddWithValue("@dOB", dOB);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("@address", address);
                cmd2.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd2.Parameters.AddWithValue("@passWord", passWord);
                cmd2.ExecuteNonQuery();
                conn.Close();
                 MessageBox.Show("SUCCESS");

        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            int id = int.Parse(txt_Id.Text);
            string name = txt_name.Text;
            string dOB = txt_DateOfBirth.Text;
            string address = txt_addess.Text;
            string phoneNumber = txt_Password.Text;
            string passWord = txt_Password.Text;
            int gender;
            if (rdb_Male.Checked == true)
            {
                gender = 1;
            }
            else gender = 0;

            string sql = "Update Employee set Employee_name=@Name, Date_of_birth=@dOB,Gender=@gender" +
                ", Employee_Address=@address,Phone=@phoneNumber,Password=@passWord where ID=@ID"   ;
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@ID", id);
            cmd2.Parameters.AddWithValue("@NAME", name);
            cmd2.Parameters.AddWithValue("@dOB", dOB);
            cmd2.Parameters.AddWithValue("@gender", gender);
            cmd2.Parameters.AddWithValue("@address", address);
            cmd2.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd2.Parameters.AddWithValue("@passWord", passWord);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SUCCESS");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            int id = int.Parse(txt_Id.Text);
            string sql = "Delete from Employee where ID=@ID" ;
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@ID", id);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SUCCESS");
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            string sql = "Select * from Employee";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt_employee.DataSource = dt;

        }
    }
}
