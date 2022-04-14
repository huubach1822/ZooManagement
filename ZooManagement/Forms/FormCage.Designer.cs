namespace ZooManagement.Forms
{
    partial class FormCage
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
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.dt_Cage = new System.Windows.Forms.DataGridView();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_cagearea = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Update = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_Species = new System.Windows.Forms.ComboBox();
            this.cbb_Area = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_Condition = new System.Windows.Forms.ComboBox();
            this.cbb_Employee = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Cage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(868, 39);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(108, 31);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_Cage
            // 
            this.dt_Cage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Cage.Location = new System.Drawing.Point(528, 82);
            this.dt_Cage.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dt_Cage.Name = "dt_Cage";
            this.dt_Cage.RowHeadersWidth = 51;
            this.dt_Cage.Size = new System.Drawing.Size(448, 239);
            this.dt_Cage.TabIndex = 80;
            this.dt_Cage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Cage_CellClick);
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(200, 175);
            this.txt_height.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(300, 20);
            this.txt_height.TabIndex = 78;
            this.txt_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_height_KeyPress);
            // 
            // txt_cagearea
            // 
            this.txt_cagearea.Location = new System.Drawing.Point(200, 137);
            this.txt_cagearea.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_cagearea.Name = "txt_cagearea";
            this.txt_cagearea.Size = new System.Drawing.Size(300, 20);
            this.txt_cagearea.TabIndex = 77;
            this.txt_cagearea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cagearea_KeyPress);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(200, 58);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(300, 20);
            this.txt_Id.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW CAGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "CAGE TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Species";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(816, 382);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(196, 41);
            this.btn_Delete.TabIndex = 70;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(358, 382);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(196, 41);
            this.btn_Insert.TabIndex = 71;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(587, 382);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(196, 41);
            this.txt_Update.TabIndex = 69;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = true;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Cage_area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Height";
            // 
            // cbb_Species
            // 
            this.cbb_Species.FormattingEnabled = true;
            this.cbb_Species.Location = new System.Drawing.Point(89, 97);
            this.cbb_Species.Name = "cbb_Species";
            this.cbb_Species.Size = new System.Drawing.Size(121, 21);
            this.cbb_Species.TabIndex = 82;
            // 
            // cbb_Area
            // 
            this.cbb_Area.FormattingEnabled = true;
            this.cbb_Area.Location = new System.Drawing.Point(358, 97);
            this.cbb_Area.Name = "cbb_Area";
            this.cbb_Area.Size = new System.Drawing.Size(121, 21);
            this.cbb_Area.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Capacity";
            // 
            // txt_capacity
            // 
            this.txt_capacity.Location = new System.Drawing.Point(200, 215);
            this.txt_capacity.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(300, 20);
            this.txt_capacity.TabIndex = 78;
            this.txt_capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_capacity_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Condition";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Employee";
            // 
            // cbb_Condition
            // 
            this.cbb_Condition.FormattingEnabled = true;
            this.cbb_Condition.Location = new System.Drawing.Point(89, 263);
            this.cbb_Condition.Name = "cbb_Condition";
            this.cbb_Condition.Size = new System.Drawing.Size(121, 21);
            this.cbb_Condition.TabIndex = 82;
            // 
            // cbb_Employee
            // 
            this.cbb_Employee.FormattingEnabled = true;
            this.cbb_Employee.Location = new System.Drawing.Point(358, 263);
            this.cbb_Employee.Name = "cbb_Employee";
            this.cbb_Employee.Size = new System.Drawing.Size(121, 21);
            this.cbb_Employee.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 313);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Note";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(200, 313);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(300, 20);
            this.txt_Note.TabIndex = 78;
            this.txt_Note.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Note_Validating);
            // 
            // FormCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 463);
            this.Controls.Add(this.cbb_Employee);
            this.Controls.Add(this.cbb_Condition);
            this.Controls.Add(this.cbb_Area);
            this.Controls.Add(this.cbb_Species);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_Cage);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_capacity);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_cagearea);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Name = "FormCage";
            this.Text = "FormCage";
            this.Load += new System.EventHandler(this.FormCage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Cage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_Cage;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_cagearea;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbb_Area;
        private System.Windows.Forms.ComboBox cbb_Species;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_Employee;
        private System.Windows.Forms.ComboBox cbb_Condition;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}