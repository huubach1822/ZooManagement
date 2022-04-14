namespace ZooManagement.Forms
{
    partial class FormAnimals
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
            this.txt_vnName = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.dt_Animals = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_ScieneName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.cbb_Species = new System.Windows.Forms.ComboBox();
            this.cbb_typeOfBirth = new System.Windows.Forms.ComboBox();
            this.cb_redList = new System.Windows.Forms.CheckBox();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_fmale = new System.Windows.Forms.RadioButton();
            this.cbb_Origin = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_EngName = new System.Windows.Forms.TextBox();
            this.mskDateOfJoin = new System.Windows.Forms.MaskedTextBox();
            this.mskDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vnName
            // 
            this.txt_vnName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_vnName.ForeColor = System.Drawing.Color.MediumPurple;
            this.txt_vnName.Location = new System.Drawing.Point(115, 73);
            this.txt_vnName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_vnName.Name = "txt_vnName";
            this.txt_vnName.Size = new System.Drawing.Size(299, 25);
            this.txt_vnName.TabIndex = 58;
            this.txt_vnName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_vnName_Validating);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Id.ForeColor = System.Drawing.Color.MediumPurple;
            this.txt_Id.Location = new System.Drawing.Point(115, 23);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(123, 25);
            this.txt_Id.TabIndex = 60;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "ANIMALS TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(26, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Species";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Vietnamese_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID";
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SEARCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_SEARCH.Location = new System.Drawing.Point(906, 49);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(108, 38);
            this.btn_SEARCH.TabIndex = 66;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = false;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_Animals
            // 
            this.dt_Animals.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_Animals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dt_Animals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Animals.GridColor = System.Drawing.Color.MediumPurple;
            this.dt_Animals.Location = new System.Drawing.Point(545, 141);
            this.dt_Animals.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dt_Animals.Name = "dt_Animals";
            this.dt_Animals.RowHeadersWidth = 51;
            this.dt_Animals.Size = new System.Drawing.Size(937, 294);
            this.dt_Animals.TabIndex = 65;
            this.dt_Animals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Animals_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(541, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "VIEW ANIMALS";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1080, 479);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(169, 33);
            this.btn_Delete.TabIndex = 62;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(640, 479);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(159, 33);
            this.btn_Insert.TabIndex = 63;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(855, 479);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(159, 33);
            this.txt_Update.TabIndex = 61;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = false;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(26, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Red_list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(26, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Sciene Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(26, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "TypeOfBirth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MediumPurple;
            this.label10.Location = new System.Drawing.Point(26, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(26, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MediumPurple;
            this.label12.Location = new System.Drawing.Point(30, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Date_of_joint";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.MediumPurple;
            this.label13.Location = new System.Drawing.Point(30, 395);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Origin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.MediumPurple;
            this.label14.Location = new System.Drawing.Point(29, 431);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Feature";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.MediumPurple;
            this.label15.Location = new System.Drawing.Point(242, 395);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "Date_of_birth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.MediumPurple;
            this.label16.Location = new System.Drawing.Point(242, 431);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 56;
            this.label16.Text = "Picture";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.MediumPurple;
            this.label17.Location = new System.Drawing.Point(242, 356);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 20);
            this.label17.TabIndex = 56;
            this.label17.Text = "Age";
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_quantity.ForeColor = System.Drawing.Color.MediumPurple;
            this.txt_quantity.Location = new System.Drawing.Point(115, 169);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(123, 25);
            this.txt_quantity.TabIndex = 59;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quantity_Validating);
            // 
            // txt_ScieneName
            // 
            this.txt_ScieneName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_ScieneName.ForeColor = System.Drawing.Color.MediumPurple;
            this.txt_ScieneName.Location = new System.Drawing.Point(113, 241);
            this.txt_ScieneName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_ScieneName.Name = "txt_ScieneName";
            this.txt_ScieneName.Size = new System.Drawing.Size(123, 25);
            this.txt_ScieneName.TabIndex = 59;
            this.txt_ScieneName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ScieneName_Validating);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAge.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtAge.Location = new System.Drawing.Point(334, 352);
            this.txtAge.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(117, 25);
            this.txtAge.TabIndex = 59;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            // 
            // txtFeature
            // 
            this.txtFeature.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFeature.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtFeature.Location = new System.Drawing.Point(113, 431);
            this.txtFeature.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(117, 25);
            this.txtFeature.TabIndex = 59;
            this.txtFeature.Validating += new System.ComponentModel.CancelEventHandler(this.txtFeature_Validating);
            // 
            // cbb_Species
            // 
            this.cbb_Species.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbb_Species.ForeColor = System.Drawing.Color.MediumPurple;
            this.cbb_Species.FormattingEnabled = true;
            this.cbb_Species.Location = new System.Drawing.Point(115, 124);
            this.cbb_Species.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbb_Species.Name = "cbb_Species";
            this.cbb_Species.Size = new System.Drawing.Size(122, 28);
            this.cbb_Species.TabIndex = 68;
            // 
            // cbb_typeOfBirth
            // 
            this.cbb_typeOfBirth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbb_typeOfBirth.ForeColor = System.Drawing.Color.MediumPurple;
            this.cbb_typeOfBirth.FormattingEnabled = true;
            this.cbb_typeOfBirth.Location = new System.Drawing.Point(115, 279);
            this.cbb_typeOfBirth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbb_typeOfBirth.Name = "cbb_typeOfBirth";
            this.cbb_typeOfBirth.Size = new System.Drawing.Size(122, 28);
            this.cbb_typeOfBirth.TabIndex = 68;
            // 
            // cb_redList
            // 
            this.cb_redList.AutoSize = true;
            this.cb_redList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_redList.ForeColor = System.Drawing.Color.MediumPurple;
            this.cb_redList.Location = new System.Drawing.Point(115, 209);
            this.cb_redList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cb_redList.Name = "cb_redList";
            this.cb_redList.Size = new System.Drawing.Size(18, 17);
            this.cb_redList.TabIndex = 69;
            this.cb_redList.UseVisualStyleBackColor = false;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.ForeColor = System.Drawing.Color.MediumPurple;
            this.rdo_male.Location = new System.Drawing.Point(113, 319);
            this.rdo_male.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(59, 24);
            this.rdo_male.TabIndex = 70;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // rdo_fmale
            // 
            this.rdo_fmale.AutoSize = true;
            this.rdo_fmale.ForeColor = System.Drawing.Color.MediumPurple;
            this.rdo_fmale.Location = new System.Drawing.Point(246, 324);
            this.rdo_fmale.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdo_fmale.Name = "rdo_fmale";
            this.rdo_fmale.Size = new System.Drawing.Size(74, 24);
            this.rdo_fmale.TabIndex = 70;
            this.rdo_fmale.TabStop = true;
            this.rdo_fmale.Text = "Female";
            this.rdo_fmale.UseVisualStyleBackColor = true;
            // 
            // cbb_Origin
            // 
            this.cbb_Origin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbb_Origin.ForeColor = System.Drawing.Color.MediumPurple;
            this.cbb_Origin.FormattingEnabled = true;
            this.cbb_Origin.Location = new System.Drawing.Point(113, 397);
            this.cbb_Origin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbb_Origin.Name = "cbb_Origin";
            this.cbb_Origin.Size = new System.Drawing.Size(114, 28);
            this.cbb_Origin.TabIndex = 68;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.MediumPurple;
            this.label18.Location = new System.Drawing.Point(247, 241);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 56;
            this.label18.Text = "English Name";
            // 
            // txt_EngName
            // 
            this.txt_EngName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_EngName.ForeColor = System.Drawing.Color.MediumPurple;
            this.txt_EngName.Location = new System.Drawing.Point(325, 240);
            this.txt_EngName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_EngName.Name = "txt_EngName";
            this.txt_EngName.Size = new System.Drawing.Size(123, 25);
            this.txt_EngName.TabIndex = 59;
            this.txt_EngName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_EngName_Validating);
            // 
            // mskDateOfJoin
            // 
            this.mskDateOfJoin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskDateOfJoin.ForeColor = System.Drawing.Color.MediumPurple;
            this.mskDateOfJoin.Location = new System.Drawing.Point(115, 352);
            this.mskDateOfJoin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mskDateOfJoin.Mask = "00/00/0000";
            this.mskDateOfJoin.Name = "mskDateOfJoin";
            this.mskDateOfJoin.Size = new System.Drawing.Size(113, 25);
            this.mskDateOfJoin.TabIndex = 71;
            this.mskDateOfJoin.ValidatingType = typeof(System.DateTime);
            this.mskDateOfJoin.Validating += new System.ComponentModel.CancelEventHandler(this.mskDateOfJoin_Validating);
            // 
            // mskDateOfBirth
            // 
            this.mskDateOfBirth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskDateOfBirth.ForeColor = System.Drawing.Color.MediumPurple;
            this.mskDateOfBirth.Location = new System.Drawing.Point(336, 393);
            this.mskDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mskDateOfBirth.Mask = "00/00/0000";
            this.mskDateOfBirth.Name = "mskDateOfBirth";
            this.mskDateOfBirth.Size = new System.Drawing.Size(113, 25);
            this.mskDateOfBirth.TabIndex = 71;
            this.mskDateOfBirth.ValidatingType = typeof(System.DateTime);
            this.mskDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.mskDateOfBirth_Validating);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(336, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 28);
            this.button1.TabIndex = 72;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1503, 141);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1739, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskDateOfBirth);
            this.Controls.Add(this.mskDateOfJoin);
            this.Controls.Add(this.rdo_fmale);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.cb_redList);
            this.Controls.Add(this.cbb_Origin);
            this.Controls.Add(this.cbb_typeOfBirth);
            this.Controls.Add(this.cbb_Species);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_Animals);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Controls.Add(this.txtFeature);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txt_EngName);
            this.Controls.Add(this.txt_ScieneName);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_vnName);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormAnimals";
            this.Text = "FormAnimals";
            this.Load += new System.EventHandler(this.FormAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_vnName;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_Animals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_ScieneName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFeature;
        private System.Windows.Forms.ComboBox cbb_Species;
        private System.Windows.Forms.ComboBox cbb_typeOfBirth;
        private System.Windows.Forms.CheckBox cb_redList;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.RadioButton rdo_fmale;
        private System.Windows.Forms.ComboBox cbb_Origin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_EngName;
        private System.Windows.Forms.MaskedTextBox mskDateOfJoin;
        private System.Windows.Forms.MaskedTextBox mskDateOfBirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}