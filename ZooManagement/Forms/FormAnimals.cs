using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagement.Forms
{
    public partial class FormAnimals : Form
    {
        ZooManagementEntities2 zE = new ZooManagementEntities2();
        bool Active = true;
        public FormAnimals()
        {
            InitializeComponent();
            LoadData();



        }

        #region methods

        void LoadData()
        {

            var result = from c in zE.Animal
                         select new
                         {
                             ID = c.ID,
                             Name = c.Vietnamese_name,
                             Species = c.Species.Species_name,
                             Origin = c.Origin.Birth_type_name,
                             Quantity = c.Quantity,
                             Age = c.Age,
                             Gender = c.Gender,
                             RedList = c.Red_list,
                             c.Date_of_joint
,
                             Picture = c.Picture,
                             Feature = c.Feature,
                             c.Date_of_birth,
                             c.Sciene_name,
                             c.English_name
                         };
            dt_Animals.DataSource = result.ToList();

            var SpeciesName = from d in zE.Species select new { ID = d.ID, Name = d.Species_name };
            cbb_Species.DataSource = SpeciesName.ToList();
            cbb_Species.ValueMember = "ID";
            cbb_Species.DisplayMember = "Name";

            var tOB = from e in zE.TypeOfBirth select new { ID = e.ID, Name = e.Name_Birth };
            cbb_typeOfBirth.DataSource = tOB.ToList();
            cbb_typeOfBirth.ValueMember = "ID";
            cbb_typeOfBirth.DisplayMember = "Name";

            var Origin = from g in zE.Origin select new { ID = g.ID, Name = g.Birth_type_name };
            cbb_Origin.DataSource = Origin.ToList();
            cbb_Origin.ValueMember = "ID";
            cbb_Origin.DisplayMember = "Name";


        }
        void AddAnimals()
        {
           
                

            bool redlist = false, gender = true;

            if (cb_redList.Checked == true)
            {
                redlist = true;
            }
            if (rdo_fmale.Checked == true)
            {
                gender = false;
            }

            zE.Animal.Add(new Animal()
            {
                Vietnamese_name = txt_vnName.Text,
                Species_ID = Convert.ToInt32(cbb_Species.SelectedValue),
                Quantity = Convert.ToInt32(txt_quantity.Text),
                Red_list = redlist,
                Sciene_name = txt_ScieneName.Text,
                English_name = txt_EngName.Text,
                TypeOfBirth_ID = Convert.ToInt32(cbb_typeOfBirth.SelectedValue),
                Gender = gender,
                Date_of_joint = DateTime.Parse(mskDateOfJoin.Text),
                Date_of_birth = DateTime.Parse(mskDateOfBirth.Text),
                Origin_ID = Convert.ToInt32(cbb_Origin.SelectedValue),
                Picture = pathImg,
                Age = Convert.ToInt32(txtAge.Text),
                 Feature = txtFeature.Text,

            });
            zE.SaveChanges();
            LoadData();

        }
        void DeleteAnimals()
        {
            int id = Convert.ToInt32(txt_Id.Text);
            Animal a = zE.Animal.Where(p => p.ID == id).SingleOrDefault();
            zE.Animal.Remove(a);
            zE.SaveChanges();
            LoadData();
        }
        void UpdateAnimals()
        {
            bool redlist = false, gender = true;

            if (cb_redList.Checked == true)
            {
                redlist = true;
            }
            if (rdo_fmale.Checked == true)
            {
                gender = false;
            }

            int id = Convert.ToInt32(txt_Id.Text);

            Animal a = zE.Animal.Find(id);

            a.Vietnamese_name = txt_vnName.Text;
            a.Species_ID = Convert.ToInt32(cbb_Species.SelectedValue);
            a.Quantity = Convert.ToInt32(txt_quantity.Text);
            a.Red_list = redlist;
            a.Sciene_name = txt_ScieneName.Text;
            a.English_name = txt_EngName.Text;
            a.TypeOfBirth_ID = Convert.ToInt32(cbb_typeOfBirth.SelectedValue);
            a.Gender = gender;
            a.Date_of_joint = DateTime.Parse(mskDateOfJoin.Text);
            a.Picture = pathImg;
            a.Feature = txtFeature.Text;
            a.Date_of_birth = DateTime.Parse(mskDateOfBirth.Text);
            a.Date_of_birth = DateTime.Parse(mskDateOfBirth.Text);
            a.Origin_ID = Convert.ToInt32(cbb_Origin.SelectedValue);
            a.Age = Convert.ToInt32(txtAge.Text);

            zE.SaveChanges();
            LoadData();

        }

        #endregion

        #region Events
        private void FormAnimals_Load(object sender, EventArgs e)
        {




        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                AddAnimals();
                LoadData();
            }
    

        }

        private void txt_Update_Click(object sender, EventArgs e)
        {
            UpdateAnimals();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteAnimals();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            LoadData();


        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // tim doc anh img
        string pathImg;
        byte[] binaryphoto;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            file.Title = "Select an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(file.OpenFile());
                pictureBox1.MaximumSize = pictureBox1.Image.Size;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pathImg = file.FileName;
                FileStream fs = new FileStream(pathImg, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();

            }
        }


        // Binding ( hien thi du lieu thong qua viec click vao datagridview)
        private void dt_Animals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = true;
            for(int i=0;i<dt_Animals.Columns.Count;i++)
            {
                if(dt_Animals.CurrentRow.Cells[i].Value == null)
                {
                    flag = false;break;
                }
            }

            if(flag == false)
            {
                MessageBox.Show("Some cells is missing value");
            }    
              else
            {
                txt_Id.Text = dt_Animals.CurrentRow.Cells[0].Value.ToString();
                txt_vnName.Text = dt_Animals.CurrentRow.Cells[1].Value.ToString();
                txt_quantity.Text = dt_Animals.CurrentRow.Cells[4].Value.ToString();
                txtAge.Text = dt_Animals.CurrentRow.Cells[5].Value.ToString();
                mskDateOfJoin.Text = dt_Animals.CurrentRow.Cells[8].Value.ToString();
                txtFeature.Text = dt_Animals.CurrentRow.Cells[10].Value.ToString();
                mskDateOfBirth.Text = dt_Animals.CurrentRow.Cells[11].Value.ToString();
                txt_ScieneName.Text = dt_Animals.CurrentRow.Cells[12].Value.ToString();
                txt_EngName.Text = dt_Animals.CurrentRow.Cells[13].Value.ToString();
               pictureBox1.ImageLocation = dt_Animals.CurrentRow.Cells[9].Value.ToString();
            }
        }





        // validate number
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
        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }
        // Chi nhap number
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }
        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate(sender, e);
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
          
                e.Cancel = true;
                txtAge.Focus();
                errorProvider.SetError(txtAge, "please enter value !");
            }
        }

        private void txt_vnName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_vnName.Text.Trim()))
            {
         
                e.Cancel = true;
                txt_vnName.Focus();
                errorProvider.SetError(txt_vnName, "please enter value !");
            }
        }

        private void txt_quantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_quantity.Text.Trim()))
            {
       
                e.Cancel = true;
                txt_quantity.Focus();
                errorProvider.SetError(txt_quantity, "please enter value !");
            }
        }

        private void txt_ScieneName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ScieneName.Text.Trim()))
            {

                e.Cancel = true;
                txt_ScieneName.Focus();
                errorProvider.SetError(txt_ScieneName, "please enter value !");
            }
        }

        private void txt_EngName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EngName.Text.Trim()))
            {

                e.Cancel = true;
                txt_EngName.Focus();
                errorProvider.SetError(txt_EngName, "please enter value !");
            }
        }

        private void mskDateOfJoin_Validating(object sender, CancelEventArgs e)
        {
            if (mskDateOfJoin.Text == "")
            {

                e.Cancel = true;
                mskDateOfJoin.Focus();
                errorProvider.SetError(mskDateOfJoin, "please enter value !");
            }
        }

        private void mskDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (mskDateOfBirth.Text == "")
            {

                e.Cancel = true;
                mskDateOfBirth.Focus();
                errorProvider.SetError(mskDateOfBirth, "please enter value !");
            }
        }

        private void txtFeature_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFeature.Text.Trim()))
            {

                e.Cancel = true;
                txtFeature.Focus();
                errorProvider.SetError(txtFeature, "please enter value !");
            }
        }
    }
}
