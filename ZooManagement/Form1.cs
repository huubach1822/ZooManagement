using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagement
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("ROG Fonts", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelTitle.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUser(), sender);

        }
       
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAnimals(), sender);
            if (panel_Animals.Height == 360)
            {
                panel_Animals.Height = 76;
            }
            else
            {
                panel_Animals.Height = 360;
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (panel_Food.Height == 270)
            {
                panel_Food.Height = 76;
            }
            else
            {
                panel_Food.Height = 270;
            }
            OpenChildForm(new Forms.FormFoodForAnimal(), sender);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (panel_Event.Height == 360)
            {
                panel_Event.Height = 76;
            }
            else
            {
                panel_Event.Height = 360;
            }
            OpenChildForm(new Forms.FormEvent(), sender);
        }

        private void btnCages_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (panel_Cage.Height == 360)
            {
                panel_Cage.Height = 76;
            }
            else
            {
                panel_Cage.Height = 360;
            }
            OpenChildForm(new Forms.FormAnimalCage(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimunsize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // validate null
      
        private void Form1_Load(object sender, EventArgs e)
        {
            panel_Animals.Height = 76;
            panel_Food.Height = 76;
            panel_Event.Height = 76;
            panel_Cage.Height = 76;

            panel_Event.BringToFront();
            panel_Food.BringToFront();
            panel_Animals.BringToFront();

        }
        //Open Species form - Tran Viet Anh
        private void tbl_Species_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSpecies(), sender);
        }

        private void btn_tOB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTOB(), sender);
        }

        private void tbn_Origin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrigin(), sender); 
        }

        private void btnReason_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReason(), sender);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFix(), sender);
        }

        private void btnAccident_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccident(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFood(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFoodPrice(), sender);
        }

        private void btnZone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormArea(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCondition(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCage(), sender); 
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
