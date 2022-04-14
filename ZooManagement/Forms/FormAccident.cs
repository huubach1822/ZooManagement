using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagement.Forms
{
    public partial class FormAccident : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormAccident()
        {
            InitializeComponent();
        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Accident
                         select new
                         {
                             ID = c.ID,
                             Accident_Name = c.Accident_name,
                             Note = c.Note
                         };
            dt_Accident.DataSource = result.ToList();
        }

        void AddAccident()
        {
            zE.Accident.Add(new Accident()
            {
                Accident_name = txt_name.Text,
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteAccident()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Accident a = zE.Accident.Where(p => p.ID == id).SingleOrDefault();
            zE.Accident.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateAccident()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Accident a = zE.Accident.Find(id);
            a.Note = txt_Note.Text;
            a.Accident_name = txt_name.Text;
            zE.SaveChanges();
            LoadData();
        }

        #endregion


        private void FormAccident_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddAccident();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateAccident();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteAccident();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Accident_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Accident.Columns.Count; i++)
            {
                if (dt_Accident.CurrentRow.Cells[i].Value == null)
                {
                    flag = false; break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Some cells is missing value");
            }
            else
            {
                txt_Id.Text = dt_Accident.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Accident.CurrentRow.Cells[1].Value.ToString();
                txt_Note.Text = dt_Accident.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_name, "please enter value !");
            }
        }

        private void txt_Note_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Note.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_Note, "please enter value !");
            }
        }
    }
}
