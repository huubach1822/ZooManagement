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
    public partial class FormFix : Form
    {   
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormFix()
        {
            InitializeComponent();
        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Fix
                         select new
                         {
                             ID = c.ID,
                             Fix_Name = c.Fix_name,
                             Note = c.Note
                         };
            dt_Fix.DataSource = result.ToList();
        }

        void AddFix()
        {
            zE.Fix.Add(new Fix()
            {
                Fix_name = txt_name.Text,
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteFix()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Fix a = zE.Fix.Where(p => p.ID == id).SingleOrDefault();
            zE.Fix.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateFix()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Fix a = zE.Fix.Find(id);
            a.Note = txt_Note.Text;
            a.Fix_name = txt_name.Text;
            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddFix();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateFix();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteFix();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Fix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Fix.Columns.Count; i++)
            {
                if (dt_Fix.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Fix.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Fix.CurrentRow.Cells[1].Value.ToString();
                txt_Note.Text = dt_Fix.CurrentRow.Cells[2].Value.ToString();
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

        private void FormFix_Load(object sender, EventArgs e)
        {

        }
    }
}
