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
    public partial class FormFoodPrice : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormFoodPrice()
        {
            InitializeComponent();
        }

        private void FormFoodPrice_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Food_Price
                         select new
                         {
                             ID = c.ID,
                             Food = c.Food.Food_name,
                             Price = c.Price,
                             Applied_date = c.Applied_date,
                         };
            dt_FoodPrice.DataSource = result.ToList();

            var FoodName = from d in zE.Food select new { ID = d.ID, Name = d.Food_name };
            cbb_Food.DataSource = FoodName.ToList();
            cbb_Food.ValueMember = "ID";
            cbb_Food.DisplayMember = "Name";

        }

        void AddFoodPrice()
        {
            zE.Food_Price.Add(new Food_Price()
            {
                Food_ID = Convert.ToInt32(cbb_Food.SelectedValue),
                Price = Convert.ToInt32(txt_Price.Text),
                Applied_date = DateTime.Parse(msk_AppliedDate.Text),
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteFoodPrice()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Food_Price a = zE.Food_Price.Where(p => p.ID == id).SingleOrDefault();
            zE.Food_Price.Remove(a);
            zE.SaveChanges();
            LoadData();
        }

        void UpdateFoodPrice()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Food_Price a = zE.Food_Price.Find(id);

            a.Food_ID = Convert.ToInt32(cbb_Food.SelectedValue);
            a.Price = Convert.ToInt32(txt_Price.Text);
            a.Applied_date = DateTime.Parse(msk_AppliedDate.Text);

            zE.SaveChanges();
            LoadData();
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            AddFoodPrice();
            LoadData();
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateFoodPrice();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteFoodPrice();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_FoodPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_FoodPrice.Columns.Count; i++)
            {
                if (dt_FoodPrice.CurrentRow.Cells[i].Value == null)
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
                txt_Id.Text = dt_FoodPrice.CurrentRow.Cells[0].Value.ToString();
                txt_Price.Text = dt_FoodPrice.CurrentRow.Cells[2].Value.ToString();
                msk_AppliedDate.Text = dt_FoodPrice.CurrentRow.Cells[3].Value.ToString();
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

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);  
        }
    }
}
