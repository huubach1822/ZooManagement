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
    public partial class FormCage : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormCage()
        {
            InitializeComponent();
        }

        private void FormCage_Load(object sender, EventArgs e)
        {

        }

        #region methods

        void LoadData()
        {
            var result = from c in zE.Cage
                         select new
                         {
                             ID = c.ID,
                             Species = c.Species.Species_name,
                             Area = c.Area.Area_name,
                             Cage_area = c.Cage_area,
                             Height = c.Height,
                             Capacity = c.Capacity,
                             Condition = c.Condition.Condition_name,
                             Employee = c.Employee.Employee_name,
                             Note = c.Note
                         };
            dt_Cage.DataSource = result.ToList();

            var SpeciesName = from d in zE.Species select new { ID = d.ID, Name = d.Species_name };
            cbb_Species.DataSource = SpeciesName.ToList();
            cbb_Species.ValueMember = "ID";
            cbb_Species.DisplayMember = "Name";

            var AreaName = from e in zE.Area select new { ID = e.ID, Name = e.Area_name };
            cbb_Area.DataSource = AreaName.ToList();
            cbb_Area.ValueMember = "ID";
            cbb_Area.DisplayMember = "Name";

            var ConditionName = from f in zE.Condition select new { ID = f.ID, Name = f.Condition_name };
            cbb_Condition.DataSource = ConditionName.ToList();
            cbb_Condition.ValueMember = "ID";
            cbb_Condition.DisplayMember = "Name";

            var EmployeeName = from g in zE.Employee select new { ID = g.ID, Name = g.Employee_name };
            cbb_Employee.DataSource = EmployeeName.ToList();
            cbb_Employee.ValueMember = "ID";
            cbb_Employee.DisplayMember = "Name";

        }

        void AddCage()
        {
            zE.Cage.Add(new Cage()
            {
                Species_ID = Convert.ToInt32(cbb_Species.SelectedValue),
                Area_ID = Convert.ToInt32(cbb_Area.SelectedValue),
                Cage_area = Convert.ToInt32(txt_cagearea.Text),
                Height = Convert.ToInt32(txt_height.Text),
                Capacity = Convert.ToInt32(txt_capacity.Text),
                Condition_ID = Convert.ToInt32(cbb_Condition.SelectedValue),
                Employee_ID = Convert.ToInt32(cbb_Employee.SelectedValue),
                Note = txt_Note.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteCage()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Cage a = zE.Cage.Where(p => p.ID == id).SingleOrDefault();
            zE.Cage.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateCage()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Cage a = zE.Cage.Find(id);

            a.Species_ID = Convert.ToInt32(cbb_Species.SelectedValue);
            a.Area_ID = Convert.ToInt32(cbb_Area.SelectedValue);
            a.Cage_area = Convert.ToInt32(txt_cagearea.Text);
            a.Height = Convert.ToInt32(txt_height.Text);
            a.Capacity = Convert.ToInt32(txt_capacity.Text);
            a.Condition_ID = Convert.ToInt32(cbb_Condition.SelectedValue);
            a.Employee_ID = Convert.ToInt32(cbb_Employee.SelectedValue);
            a.Note = txt_Note.Text;

            zE.SaveChanges();
            LoadData();
        }




        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddCage();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateCage();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteCage();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Cage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Cage.Columns.Count; i++)
            {
                if (dt_Cage.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_Cage.CurrentRow.Cells[0].Value.ToString();
                txt_cagearea.Text = dt_Cage.CurrentRow.Cells[3].Value.ToString();
                txt_height.Text = dt_Cage.CurrentRow.Cells[4].Value.ToString();
                txt_capacity.Text = dt_Cage.CurrentRow.Cells[5].Value.ToString();
                txt_Note.Text = dt_Cage.CurrentRow.Cells[8].Value.ToString();
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

        private void txt_cagearea_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }

        private void txt_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }

        private void txt_capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
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
