﻿using System;
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
    public partial class FormTOB : Form
    {
        string ConnectionName = @"Data Source=DESKTOP-G0G5EEO;Initial Catalog = ZooManagement; Integrated Security = True";

        public FormTOB()
        {
            InitializeComponent();
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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            string name = txt_name.Text;
            string note = txt_Note.Text;
            string sql = "insert into TypeOfBirth values (@NAME,@NOTE)";

            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@NAME", name);
            cmd2.Parameters.AddWithValue("@NOTE", note);
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
            string note = txt_Note.Text;

            string sql = "Update TypeOfBirth set Name_Birth=@Name,Note=@NOTE where ID=@ID";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@ID", id);
            cmd2.Parameters.AddWithValue("@NAME", name);
            cmd2.Parameters.AddWithValue("@NOTE", note);

            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SUCCESS");
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            string sql = "Select * from TypeOfBirth";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt_TOB.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConnectionName);

            conn.Open();
            int id = int.Parse(txt_Id.Text);
            string sql = "Delete from TypeOfBirth where ID=@ID";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@ID", id);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("SUCCESS");
        }

        private void FormTOB_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dt_TOB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
