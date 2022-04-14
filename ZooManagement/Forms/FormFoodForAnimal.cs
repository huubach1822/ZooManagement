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
    public partial class FormFoodForAnimal : Form
    {   
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormFoodForAnimal()
        {
            InitializeComponent();
            LoadData();
        }

        private void FormFoodForAnimal_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Animal_Food 
                         select new
                         {
                             Animal = c.Animal.Vietnamese_name,
                             Breakfast = c.Food.Food_name,
                             Amount_of_breakfast = c.Amount_of_breakfast,
                             Lunch = c.Food2.Food_name,
                             Amount_of_lunch = c.Amount_of_lunch,
                             Dinner = c.Food1.Food_name,
                             Amount_of_dinner = c.Amount_of_dinner
                         };
            dt_AnimalFood.DataSource = result.ToList();

            var Aname = from g in zE.Animal select new { ID = g.ID, Name = g.Vietnamese_name };
            cbb_Animal.DataSource = Aname.ToList();
            cbb_Animal.ValueMember = "ID";
            cbb_Animal.DisplayMember = "Name";

            var Bname = from d in zE.Food select new { ID = d.ID, Name = d.Food_name };
            cbb_Breakfast.DataSource = Bname.ToList();
            cbb_Breakfast.ValueMember = "ID";
            cbb_Breakfast.DisplayMember = "Name";

            var Lname = from e in zE.Food select new { ID = e.ID, Name = e.Food_name };
            cbb_Lunch.DataSource = Lname.ToList();
            cbb_Lunch.ValueMember = "ID";
            cbb_Lunch.DisplayMember = "Name";

            var Dname = from f in zE.Food select new { ID = f.ID, Name = f.Food_name };
            cbb_Dinner.DataSource = Dname.ToList();
            cbb_Dinner.ValueMember = "ID";
            cbb_Dinner.DisplayMember = "Name";

        }

        void AddAnimalFood()
        {
            zE.Animal_Food.Add(new Animal_Food()
            {
                Animal_ID = Convert.ToInt32(cbb_Animal.SelectedValue),
                Breakfast_ID = Convert.ToInt32(cbb_Breakfast.SelectedValue),
                Amount_of_breakfast = Convert.ToInt32(txt_AOB.Text),
                Lunch_ID = Convert.ToInt32(cbb_Lunch.SelectedValue),
                Amount_of_lunch = Convert.ToInt32(txt_AOL.Text),
                Dinner_ID = Convert.ToInt32(cbb_Dinner.SelectedValue),
                Amount_of_dinner = Convert.ToInt32(txt_AOD.Text),
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteAnimalFood()
        {
            int id = Convert.ToInt32(cbb_Animal.SelectedValue);
            Animal_Food a = zE.Animal_Food.Where(p => p.Animal_ID == id).SingleOrDefault();
            zE.Animal_Food.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateAnimalFood()
        {
            int id = Convert.ToInt32(cbb_Animal.SelectedValue);
            Animal_Food a = zE.Animal_Food.Find(id);

            a.Breakfast_ID = Convert.ToInt32(cbb_Breakfast.SelectedValue);
            a.Amount_of_breakfast = Convert.ToInt32(txt_AOB.Text);
            a.Lunch_ID = Convert.ToInt32(cbb_Lunch.SelectedValue);
            a.Amount_of_lunch = Convert.ToInt32(txt_AOL.Text);
            a.Dinner_ID = Convert.ToInt32(cbb_Dinner.SelectedValue);
            a.Amount_of_dinner = Convert.ToInt32(txt_AOD.Text);

            zE.SaveChanges();
            LoadData();
        }




        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            AddAnimalFood();
            LoadData();
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateAnimalFood();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteAnimalFood();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_AnimalFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_AnimalFood.Columns.Count; i++)
            {
                if (dt_AnimalFood.CurrentRow.Cells[i].Value == null)
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
                txt_AOB.Text = dt_AnimalFood.CurrentRow.Cells[2].Value.ToString();
                txt_AOL.Text = dt_AnimalFood.CurrentRow.Cells[4].Value.ToString();
                txt_AOD.Text = dt_AnimalFood.CurrentRow.Cells[6].Value.ToString();
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

        private void txt_AOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }

        private void txt_AOL_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }

        private void txt_AOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }
    }
}
