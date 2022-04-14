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
    public partial class FormCondition : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormCondition()
        {
            InitializeComponent();
        }

        private void FormCondition_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Condition
                         select new
                         {
                             ID = c.ID,
                             Condition_Name = c.Condition_name,
                             Note = c.Note
                         };
            dt_Condition.DataSource = result.ToList();
        }

        void AddCondition()
        {
            zE.Condition.Add(new Condition()
            {
                Condition_name = txt_name.Text,
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteCondition()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Condition a = zE.Condition.Where(p => p.ID == id).SingleOrDefault();
            zE.Condition.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateCondition()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Condition a = zE.Condition.Find(id);
            a.Note = txt_Note.Text;
            a.Condition_name = txt_name.Text;
            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddCondition();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateCondition();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteCondition();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Condition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Condition.Columns.Count; i++)
            {
                if (dt_Condition.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Condition.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Condition.CurrentRow.Cells[1].Value.ToString();
                txt_Note.Text = dt_Condition.CurrentRow.Cells[2].Value.ToString();
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
