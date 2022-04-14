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
    public partial class FormEvent : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        public FormEvent()
        {
            InitializeComponent();
            LoadData();
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {

        }

        #region method

        void LoadData()
        {
            var result = from c in zE.Animal_Accident
                         select new
                         {
                             Accident = c.Accident.Accident_name,
                             Animal = c.Animal.Vietnamese_name,
                             c.Start_day,
                             c.End_day,
                             Reason = c.Reason.Reason_name,
                             Fix = c.Fix.Fix_name
                         };
            dt_Event.DataSource = result.ToList();

            var AccidentName = from d in zE.Accident select new { ID = d.ID, Name = d.Accident_name };
            cbb_Accident.DataSource = AccidentName.ToList();
            cbb_Accident.ValueMember = "ID";
            cbb_Accident.DisplayMember = "Name";

            var FixName = from e in zE.Fix select new { ID = e.ID, Name = e.Fix_name };
            cbb_Fix.DataSource = FixName.ToList();
            cbb_Fix.ValueMember = "ID";
            cbb_Fix.DisplayMember = "Name";

            var ReasonName = from g in zE.Reason select new { ID = g.ID, Name = g.Reason_name };
            cbb_Reason.DataSource = ReasonName.ToList();
            cbb_Reason.ValueMember = "ID";
            cbb_Reason.DisplayMember = "Name";

            var AnimalName = from f in zE.Animal select new { ID = f.ID, Name = f.Vietnamese_name };
            cbb_Animal.DataSource = AnimalName.ToList();
            cbb_Animal.ValueMember = "ID";
            cbb_Animal.DisplayMember = "Name";

        }

        void AddEvent()
        {
            zE.Animal_Accident.Add(new Animal_Accident()
            {
                Accident_ID = Convert.ToInt32(cbb_Accident.SelectedValue),
                Animal_ID = Convert.ToInt32(cbb_Animal.SelectedValue),
                Reason_ID = Convert.ToInt32(cbb_Reason.SelectedValue),
                Fix_ID = Convert.ToInt32(cbb_Fix.SelectedValue),
                Start_day = DateTime.Parse(mskStartDay.Text),
                End_day = DateTime.Parse(mskEndDay.Text),
            });
            zE.SaveChanges();
            LoadData();
        }

        void DeleteEvent()
        {
            int id1 = Convert.ToInt32(cbb_Accident.SelectedValue);
            int id2 = Convert.ToInt32(cbb_Animal.SelectedValue);


            Animal_Accident a = zE.Animal_Accident.Where(p => p.Accident_ID == id1 && p.Animal_ID == id2).SingleOrDefault();
            if (a != null)
            {
                zE.Animal_Accident.Remove(a);
                zE.SaveChanges();
                LoadData();
            } else
            {
                MessageBox.Show("Can't find record to delete");
            }
        }

        void UpdateEvent()
        {
            int id1 = Convert.ToInt32(cbb_Accident.SelectedValue);
            int id2 = Convert.ToInt32(cbb_Animal.SelectedValue);

            Animal_Accident a = zE.Animal_Accident.Where(p => p.Accident_ID == id1 && p.Animal_ID == id2).SingleOrDefault();

            if (a != null)
            {

                a.Reason_ID = Convert.ToInt32(cbb_Reason.SelectedValue);
                a.Fix_ID = Convert.ToInt32(cbb_Fix.SelectedValue);
                a.Start_day = DateTime.Parse(mskStartDay.Text);
                a.End_day = DateTime.Parse(mskEndDay.Text);

                zE.SaveChanges();
                LoadData();
            } else
            {
                MessageBox.Show("Can't find record to change");
            }
        }

        #endregion

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            AddEvent();
            LoadData();
        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateEvent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteEvent();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dt_Event_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < dt_Event.Columns.Count; i++)
            {
                if (dt_Event.CurrentRow.Cells[i].Value == null)
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
                mskStartDay.Text = dt_Event.CurrentRow.Cells[2].Value.ToString();
                mskEndDay.Text = dt_Event.CurrentRow.Cells[3].Value.ToString(); 
            }
           }
    }
}
