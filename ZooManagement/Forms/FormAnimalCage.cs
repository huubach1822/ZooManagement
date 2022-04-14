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
    public partial class FormAnimalCage : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormAnimalCage()
        {
            InitializeComponent();
        }

        private void FormAnimalCage_Load(object sender, EventArgs e)
        {

        }

        #region methods

        void LoadData()
        {
            var result = from c in zE.Animal_Cage
                         select new
                         {
                             Cage = c.Cage.ID,
                             Animal = c.Animal.Vietnamese_name,
                             c.Day_in,
                             Reason_in = c.Reason_in
                         };
            dt_AnimalCage.DataSource = result.ToList();

            var Cage = from d in zE.Cage select new { ID = d.ID};
            cbb_Cage.DataSource = Cage.ToList();
            cbb_Cage.ValueMember = "ID";
            cbb_Cage.DisplayMember = "ID";

            var AnimalName = from e in zE.Animal select new { ID = e.ID, Name = e.Vietnamese_name };
            cbb_Animal.DataSource = AnimalName.ToList();
            cbb_Animal.ValueMember = "ID";
            cbb_Animal.DisplayMember = "Name";

        }

        void AddAnimalCage()
        {
            zE.Animal_Cage.Add(new Animal_Cage()
            {
                Cage_ID = Convert.ToInt32(cbb_Cage.SelectedValue),
                Animal_ID = Convert.ToInt32(cbb_Animal.SelectedValue),
                Day_in = DateTime.Parse(msk_dayin.Text),
                Reason_in = txt_reason.Text
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteAnimalCage()
        {
            int id1 = Convert.ToInt32(cbb_Cage.SelectedValue);
            int id2 = Convert.ToInt32(cbb_Animal.SelectedValue);


            Animal_Cage a = zE.Animal_Cage.Where(p => p.Cage_ID == id1 && p.Animal_ID == id2).SingleOrDefault();
            if (a != null)
            {
                zE.Animal_Cage.Remove(a);
                zE.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Can't find record to delete");
            }
        }

        void UpdateAnimalCage()
        {
            int id1 = Convert.ToInt32(cbb_Cage.SelectedValue);
            int id2 = Convert.ToInt32(cbb_Animal.SelectedValue);

            Animal_Cage a = zE.Animal_Cage.Where(p => p.Cage_ID == id1 && p.Animal_ID == id2).SingleOrDefault();

            if (a != null)
            {
                a.Day_in = DateTime.Parse(msk_dayin.Text);
                a.Reason_in = txt_reason.Text;
                zE.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Can't find record to change");
            }

            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddAnimalCage();
                LoadData();
            }
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateAnimalCage();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteAnimalCage();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_AnimalCage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_AnimalCage.Columns.Count; i++)
            {
                if (dt_AnimalCage.CurrentRow.Cells[i].Value == null)
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
                msk_dayin.Text = dt_AnimalCage.CurrentRow.Cells[2].Value.ToString();
                txt_reason.Text = dt_AnimalCage.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void txt_reason_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_reason.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider.SetError(txt_reason, "please enter value !");
            }
        }
    }
}
