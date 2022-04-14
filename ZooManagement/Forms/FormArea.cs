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
    public partial class FormArea : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormArea()
        {
            InitializeComponent();
        }

        private void FormArea_Load(object sender, EventArgs e)
        {

        }


        #region method

        void LoadData()
        {
            var result = from c in zE.Area
                         select new
                         {
                             ID = c.ID,
                             Area_Name = c.Area_name,
                             Note = c.Note
                         };
            dt_Area.DataSource = result.ToList();
        }

        void AddArea()
        {
            zE.Area.Add(new Area()
            {
                Area_name = txt_name.Text,
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteArea()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Area a = zE.Area.Where(p => p.ID == id).SingleOrDefault();
            zE.Area.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateArea()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Area a = zE.Area.Find(id);
            a.Note = txt_Note.Text;
            a.Area_name = txt_name.Text;
            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddArea();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateArea();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteArea();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Area_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Area.Columns.Count; i++)
            {
                if (dt_Area.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Area.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Area.CurrentRow.Cells[1].Value.ToString();
                txt_Note.Text = dt_Area.CurrentRow.Cells[2].Value.ToString();
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
