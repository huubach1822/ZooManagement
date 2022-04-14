namespace ZooManagement.Forms
{
    partial class FormUser
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
            this.txt_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_employee = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_addess = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(958, 470);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(169, 49);
            this.txt_Update.TabIndex = 0;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = true;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1192, 470);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(169, 49);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(722, 470);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(169, 49);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(238, 70);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(354, 23);
            this.txt_Id.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(238, 119);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(354, 23);
            this.txt_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "EMPLOYEE TABLE";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "VIEW EMPLOYEE";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // dt_employee
            // 
            this.dt_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_employee.Location = new System.Drawing.Point(722, 119);
            this.dt_employee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dt_employee.Name = "dt_employee";
            this.dt_employee.Size = new System.Drawing.Size(638, 294);
            this.dt_employee.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateOfBirth";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gender ";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Location = new System.Drawing.Point(238, 219);
            this.rdb_Male.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(73, 21);
            this.rdb_Male.TabIndex = 5;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Location = new System.Drawing.Point(406, 219);
            this.rdb_Female.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(96, 21);
            this.rdb_Female.TabIndex = 5;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_addess
            // 
            this.txt_addess.Location = new System.Drawing.Point(238, 262);
            this.txt_addess.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_addess.Name = "txt_addess";
            this.txt_addess.Size = new System.Drawing.Size(354, 23);
            this.txt_addess.TabIndex = 3;
            this.txt_addess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone Number";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(238, 305);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(354, 23);
            this.txt_PhoneNumber.TabIndex = 3;
            this.txt_PhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 352);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Password";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(238, 352);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(354, 23);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_DateOfBirth
            // 
            this.txt_DateOfBirth.Location = new System.Drawing.Point(246, 183);
            this.txt_DateOfBirth.Mask = "0000/00/00";
            this.txt_DateOfBirth.Name = "txt_DateOfBirth";
            this.txt_DateOfBirth.Size = new System.Drawing.Size(346, 23);
            this.txt_DateOfBirth.TabIndex = 6;
            this.txt_DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1264, 74);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(96, 38);
            this.btn_SEARCH.TabIndex = 7;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 554);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.txt_DateOfBirth);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.dt_employee);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_addess);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormUser";
            this.Text = "Form User";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_employee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_addess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.MaskedTextBox txt_DateOfBirth;
        private System.Windows.Forms.Button btn_SEARCH;
    }
}