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
    public partial class FormFood : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Food
                         select new
                         {
                             ID = c.ID,
                             Food_Name = c.Food_name,
                             Uses = c.Uses,
                             Unit = c.Unit,
                         };
            dt_Food.DataSource = result.ToList();
        }

        void AddFood()
        {
            zE.Food.Add(new Food()
            {
                Food_name = txt_name.Text,
                Uses = txt_Uses.Text,
                Unit = Convert.ToInt32(txt_Unit.Text)
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteFood()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Food a = zE.Food.Where(p => p.ID == id).SingleOrDefault();
            zE.Food.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateFood()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Food a = zE.Food.Find(id);

            a.Food_name = txt_name.Text;
            a.Uses = txt_Uses.Text;
            a.Unit = Convert.ToInt32(txt_Unit.Text);

            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddFood();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateFood();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteFood();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Food.Columns.Count; i++)
            {
                if (dt_Food.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Food.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dt_Food.CurrentRow.Cells[1].Value.ToString();
                txt_Uses.Text = dt_Food.CurrentRow.Cells[2].Value.ToString();
                txt_Unit.Text = dt_Food.CurrentRow.Cells[3].Value.ToString();
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

        private void txt_Uses_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Uses.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txt_Uses, "please enter value !");
            }
        }

        public void validate(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }
    }
}
