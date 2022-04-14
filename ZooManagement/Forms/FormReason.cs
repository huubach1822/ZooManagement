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
    public partial class FormReason : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormReason()
        {
            InitializeComponent();
        }

        private void FormReason_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Reason
                         select new
                         {
                             ID = c.ID,
                             Reason_Name = c.Reason_name,
                             Note = c.Note
                         };
            dt_Reason.DataSource = result.ToList();
        }

        void AddReason()
        {
            zE.Reason.Add(new Reason()
            {
                Reason_name = txt_name.Text,
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteReason()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Reason a = zE.Reason.Where(p => p.ID == id).SingleOrDefault();
            zE.Reason.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateReason()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Reason a = zE.Reason.Find(id);
            a.Note = txt_Note.Text;
            a.Reason_name = txt_name.Text;
            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddReason();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateReason();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteReason();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Reason_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Reason.Columns.Count; i++)
            {
                if (dt_Reason.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Reason.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Reason.CurrentRow.Cells[1].Value.ToString();
                txt_Note.Text = dt_Reason.CurrentRow.Cells[2].Value.ToString();
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
