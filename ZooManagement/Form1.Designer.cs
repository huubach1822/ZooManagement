namespace ZooManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel_Cage = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnZone = new System.Windows.Forms.Button();
            this.btnCages = new System.Windows.Forms.Button();
            this.panel_Event = new System.Windows.Forms.Panel();
            this.btnReason = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAccident = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.panel_Food = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.panel_Animals = new System.Windows.Forms.Panel();
            this.tbn_Origin = new System.Windows.Forms.Button();
            this.btn_tOB = new System.Windows.Forms.Button();
            this.tbl_Species = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btn_minimunsize = new System.Windows.Forms.Button();
            this.btn_maximumsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel_Cage.SuspendLayout();
            this.panel_Event.SuspendLayout();
            this.panel_Food.SuspendLayout();
            this.panel_Animals.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panel_Cage);
            this.panelMenu.Controls.Add(this.panel_Animals);
            this.panelMenu.Controls.Add(this.panel_Event);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panel_Food);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 934);
            this.panelMenu.TabIndex = 0;
            // 
            // panel_Cage
            // 
            this.panel_Cage.Controls.Add(this.button4);
            this.panel_Cage.Controls.Add(this.button3);
            this.panel_Cage.Controls.Add(this.btnZone);
            this.panel_Cage.Controls.Add(this.btnCages);
            this.panel_Cage.Location = new System.Drawing.Point(6, 504);
            this.panel_Cage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Cage.Name = "panel_Cage";
            this.panel_Cage.Size = new System.Drawing.Size(317, 101);
            this.panel_Cage.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::ZooManagement.Properties.Resources.pet_cage;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 180);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(317, 90);
            this.button4.TabIndex = 6;
            this.button4.Text = "Condition";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::ZooManagement.Properties.Resources.pet_cage;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(317, 90);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cage";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnZone
            // 
            this.btnZone.FlatAppearance.BorderSize = 0;
            this.btnZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZone.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnZone.Image = global::ZooManagement.Properties.Resources.location_pointer;
            this.btnZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZone.Location = new System.Drawing.Point(-6, 278);
            this.btnZone.Margin = new System.Windows.Forms.Padding(4);
            this.btnZone.Name = "btnZone";
            this.btnZone.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnZone.Size = new System.Drawing.Size(313, 90);
            this.btnZone.TabIndex = 5;
            this.btnZone.Text = "Area";
            this.btnZone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZone.UseVisualStyleBackColor = true;
            this.btnZone.UseWaitCursor = true;
            this.btnZone.Click += new System.EventHandler(this.btnZone_Click);
            // 
            // btnCages
            // 
            this.btnCages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCages.FlatAppearance.BorderSize = 0;
            this.btnCages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCages.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCages.Image = global::ZooManagement.Properties.Resources.pet_cage;
            this.btnCages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCages.Location = new System.Drawing.Point(0, 0);
            this.btnCages.Margin = new System.Windows.Forms.Padding(4);
            this.btnCages.Name = "btnCages";
            this.btnCages.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCages.Size = new System.Drawing.Size(317, 90);
            this.btnCages.TabIndex = 4;
            this.btnCages.Text = "Cage For Animal";
            this.btnCages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCages.UseVisualStyleBackColor = true;
            this.btnCages.UseWaitCursor = true;
            this.btnCages.Click += new System.EventHandler(this.btnCages_Click);
            // 
            // panel_Event
            // 
            this.panel_Event.Controls.Add(this.btnReason);
            this.panel_Event.Controls.Add(this.btnFix);
            this.panel_Event.Controls.Add(this.btnAccident);
            this.panel_Event.Controls.Add(this.btnEvent);
            this.panel_Event.Location = new System.Drawing.Point(3, 397);
            this.panel_Event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Event.Name = "panel_Event";
            this.panel_Event.Size = new System.Drawing.Size(296, 94);
            this.panel_Event.TabIndex = 9;
            // 
            // btnReason
            // 
            this.btnReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReason.FlatAppearance.BorderSize = 0;
            this.btnReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReason.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReason.Image = global::ZooManagement.Properties.Resources.calendar;
            this.btnReason.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReason.Location = new System.Drawing.Point(0, 270);
            this.btnReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnReason.Name = "btnReason";
            this.btnReason.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnReason.Size = new System.Drawing.Size(296, 90);
            this.btnReason.TabIndex = 6;
            this.btnReason.Text = "Reason";
            this.btnReason.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReason.UseVisualStyleBackColor = true;
            this.btnReason.UseWaitCursor = true;
            this.btnReason.Click += new System.EventHandler(this.btnReason_Click);
            // 
            // btnFix
            // 
            this.btnFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFix.Image = global::ZooManagement.Properties.Resources.calendar;
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.Location = new System.Drawing.Point(0, 180);
            this.btnFix.Margin = new System.Windows.Forms.Padding(4);
            this.btnFix.Name = "btnFix";
            this.btnFix.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnFix.Size = new System.Drawing.Size(296, 90);
            this.btnFix.TabIndex = 5;
            this.btnFix.Text = "Fix";
            this.btnFix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.UseWaitCursor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAccident
            // 
            this.btnAccident.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccident.FlatAppearance.BorderSize = 0;
            this.btnAccident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccident.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccident.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccident.Image = global::ZooManagement.Properties.Resources.calendar;
            this.btnAccident.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccident.Location = new System.Drawing.Point(0, 90);
            this.btnAccident.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccident.Name = "btnAccident";
            this.btnAccident.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAccident.Size = new System.Drawing.Size(296, 90);
            this.btnAccident.TabIndex = 4;
            this.btnAccident.Text = "Accident";
            this.btnAccident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccident.UseVisualStyleBackColor = true;
            this.btnAccident.UseWaitCursor = true;
            this.btnAccident.Click += new System.EventHandler(this.btnAccident_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEvent.Image = global::ZooManagement.Properties.Resources.calendar;
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.Location = new System.Drawing.Point(0, 0);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(296, 90);
            this.btnEvent.TabIndex = 3;
            this.btnEvent.Text = "Events";
            this.btnEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.UseWaitCursor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // panel_Food
            // 
            this.panel_Food.Controls.Add(this.button2);
            this.panel_Food.Controls.Add(this.button1);
            this.panel_Food.Controls.Add(this.btnFood);
            this.panel_Food.Location = new System.Drawing.Point(3, 295);
            this.panel_Food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Food.Name = "panel_Food";
            this.panel_Food.Size = new System.Drawing.Size(299, 98);
            this.panel_Food.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::ZooManagement.Properties.Resources.pet_food;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(299, 90);
            this.button2.TabIndex = 4;
            this.button2.Text = "Food";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::ZooManagement.Properties.Resources.pet_food;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(299, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "Food Price";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFood.Image = global::ZooManagement.Properties.Resources.pet_food;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 0);
            this.btnFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnFood.Size = new System.Drawing.Size(299, 90);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Food For Animal";
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.UseWaitCursor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // panel_Animals
            // 
            this.panel_Animals.Controls.Add(this.tbn_Origin);
            this.panel_Animals.Controls.Add(this.btn_tOB);
            this.panel_Animals.Controls.Add(this.tbl_Species);
            this.panel_Animals.Controls.Add(this.btnAnimal);
            this.panel_Animals.Location = new System.Drawing.Point(0, 196);
            this.panel_Animals.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Animals.Name = "panel_Animals";
            this.panel_Animals.Size = new System.Drawing.Size(323, 101);
            this.panel_Animals.TabIndex = 8;
            // 
            // tbn_Origin
            // 
            this.tbn_Origin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbn_Origin.FlatAppearance.BorderSize = 0;
            this.tbn_Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_Origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_Origin.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbn_Origin.Image = global::ZooManagement.Properties.Resources.koala;
            this.tbn_Origin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbn_Origin.Location = new System.Drawing.Point(0, 270);
            this.tbn_Origin.Margin = new System.Windows.Forms.Padding(4);
            this.tbn_Origin.Name = "tbn_Origin";
            this.tbn_Origin.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tbn_Origin.Size = new System.Drawing.Size(323, 90);
            this.tbn_Origin.TabIndex = 4;
            this.tbn_Origin.Text = "Origin";
            this.tbn_Origin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbn_Origin.UseVisualStyleBackColor = true;
            this.tbn_Origin.UseWaitCursor = true;
            this.tbn_Origin.Click += new System.EventHandler(this.tbn_Origin_Click);
            // 
            // btn_tOB
            // 
            this.btn_tOB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tOB.FlatAppearance.BorderSize = 0;
            this.btn_tOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tOB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_tOB.Image = global::ZooManagement.Properties.Resources.koala;
            this.btn_tOB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tOB.Location = new System.Drawing.Point(0, 180);
            this.btn_tOB.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tOB.Name = "btn_tOB";
            this.btn_tOB.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_tOB.Size = new System.Drawing.Size(323, 90);
            this.btn_tOB.TabIndex = 3;
            this.btn_tOB.Text = "Type of Birth";
            this.btn_tOB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tOB.UseVisualStyleBackColor = true;
            this.btn_tOB.UseWaitCursor = true;
            this.btn_tOB.Click += new System.EventHandler(this.btn_tOB_Click);
            // 
            // tbl_Species
            // 
            this.tbl_Species.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbl_Species.FlatAppearance.BorderSize = 0;
            this.tbl_Species.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbl_Species.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_Species.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbl_Species.Image = global::ZooManagement.Properties.Resources.koala;
            this.tbl_Species.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbl_Species.Location = new System.Drawing.Point(0, 90);
            this.tbl_Species.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_Species.Name = "tbl_Species";
            this.tbl_Species.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.tbl_Species.Size = new System.Drawing.Size(323, 90);
            this.tbl_Species.TabIndex = 2;
            this.tbl_Species.Text = "Species";
            this.tbl_Species.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbl_Species.UseVisualStyleBackColor = true;
            this.tbl_Species.UseWaitCursor = true;
            this.tbl_Species.Click += new System.EventHandler(this.tbl_Species_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnimal.FlatAppearance.BorderSize = 0;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnimal.Image = global::ZooManagement.Properties.Resources.koala;
            this.btnAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimal.Location = new System.Drawing.Point(0, 0);
            this.btnAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAnimal.Size = new System.Drawing.Size(323, 90);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Animals";
            this.btnAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.UseWaitCursor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.Image = global::ZooManagement.Properties.Resources.man__2___1_;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 98);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(293, 90);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.UseWaitCursor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 98);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZOO MANAGEMENT";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.btn_minimunsize);
            this.panelTitle.Controls.Add(this.btn_maximumsize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(293, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1631, 98);
            this.panelTitle.TabIndex = 6;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btn_minimunsize
            // 
            this.btn_minimunsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimunsize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimunsize.FlatAppearance.BorderSize = 0;
            this.btn_minimunsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimunsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimunsize.ForeColor = System.Drawing.Color.Lime;
            this.btn_minimunsize.Location = new System.Drawing.Point(1491, 4);
            this.btn_minimunsize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimunsize.Name = "btn_minimunsize";
            this.btn_minimunsize.Size = new System.Drawing.Size(40, 37);
            this.btn_minimunsize.TabIndex = 7;
            this.btn_minimunsize.Text = "O";
            this.btn_minimunsize.UseVisualStyleBackColor = false;
            this.btn_minimunsize.Click += new System.EventHandler(this.btn_minimunsize_Click);
            // 
            // btn_maximumsize
            // 
            this.btn_maximumsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximumsize.FlatAppearance.BorderSize = 0;
            this.btn_maximumsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximumsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximumsize.ForeColor = System.Drawing.Color.Gold;
            this.btn_maximumsize.Location = new System.Drawing.Point(1539, 4);
            this.btn_maximumsize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maximumsize.Name = "btn_maximumsize";
            this.btn_maximumsize.Size = new System.Drawing.Size(40, 37);
            this.btn_maximumsize.TabIndex = 7;
            this.btn_maximumsize.Text = "O";
            this.btn_maximumsize.UseVisualStyleBackColor = true;
            this.btn_maximumsize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1587, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::ZooManagement.Properties.Resources.logout__1_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(100, 98);
            this.btnCloseChildForm.TabIndex = 6;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(768, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(293, 98);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1631, 836);
            this.panelDesktopPanel.TabIndex = 1;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ZooManagement.Properties.Resources.zoo;
            this.pictureBox1.Location = new System.Drawing.Point(475, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(964, 731);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 934);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel_Cage.ResumeLayout(false);
            this.panel_Event.ResumeLayout(false);
            this.panel_Food.ResumeLayout(false);
            this.panel_Animals.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnZone;
        private System.Windows.Forms.Button btnCages;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_minimunsize;
        private System.Windows.Forms.Button btn_maximumsize;
        private System.Windows.Forms.Panel panel_Animals;
        private System.Windows.Forms.Button btn_tOB;
        private System.Windows.Forms.Button tbl_Species;
        private System.Windows.Forms.Button tbn_Origin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Event;
        private System.Windows.Forms.Button btnReason;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAccident;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel_Food;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Cage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

