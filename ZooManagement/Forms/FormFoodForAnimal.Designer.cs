namespace ZooManagement.Forms
{
    partial class FormFoodForAnimal
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
            this.dt_AnimalFood = new System.Windows.Forms.DataGridView();
            this.txt_AOL = new System.Windows.Forms.TextBox();
            this.txt_AOB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Update = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbb_Animal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Breakfast = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_Lunch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Dinner = new System.Windows.Forms.ComboBox();
            this.txt_AOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AnimalFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1124, 43);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(144, 38);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_AnimalFood
            // 
            this.dt_AnimalFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AnimalFood.Location = new System.Drawing.Point(671, 96);
            this.dt_AnimalFood.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dt_AnimalFood.Name = "dt_AnimalFood";
            this.dt_AnimalFood.RowHeadersWidth = 51;
            this.dt_AnimalFood.Size = new System.Drawing.Size(597, 294);
            this.dt_AnimalFood.TabIndex = 80;
            this.dt_AnimalFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_AnimalFood_CellClick);
            // 
            // txt_AOL
            // 
            this.txt_AOL.Location = new System.Drawing.Point(177, 251);
            this.txt_AOL.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_AOL.Name = "txt_AOL";
            this.txt_AOL.Size = new System.Drawing.Size(399, 22);
            this.txt_AOL.TabIndex = 78;
            this.txt_AOL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AOL_KeyPress);
            // 
            // txt_AOB
            // 
            this.txt_AOB.Location = new System.Drawing.Point(177, 163);
            this.txt_AOB.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_AOB.Name = "txt_AOB";
            this.txt_AOB.Size = new System.Drawing.Size(399, 22);
            this.txt_AOB.TabIndex = 77;
            this.txt_AOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AOB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW FOOD FOR ANIMAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "FOOD FOR ANIMAL TABLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Amount of breakfast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Animal";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1115, 500);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(262, 50);
            this.btn_Delete.TabIndex = 70;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(503, 500);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(262, 50);
            this.btn_Insert.TabIndex = 71;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(809, 500);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(262, 50);
            this.txt_Update.TabIndex = 69;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = true;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbb_Animal
            // 
            this.cbb_Animal.FormattingEnabled = true;
            this.cbb_Animal.Location = new System.Drawing.Point(177, 74);
            this.cbb_Animal.Name = "cbb_Animal";
            this.cbb_Animal.Size = new System.Drawing.Size(155, 24);
            this.cbb_Animal.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Breakfast";
            // 
            // cbb_Breakfast
            // 
            this.cbb_Breakfast.FormattingEnabled = true;
            this.cbb_Breakfast.Location = new System.Drawing.Point(177, 120);
            this.cbb_Breakfast.Name = "cbb_Breakfast";
            this.cbb_Breakfast.Size = new System.Drawing.Size(155, 24);
            this.cbb_Breakfast.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Lunch";
            // 
            // cbb_Lunch
            // 
            this.cbb_Lunch.FormattingEnabled = true;
            this.cbb_Lunch.Location = new System.Drawing.Point(177, 205);
            this.cbb_Lunch.Name = "cbb_Lunch";
            this.cbb_Lunch.Size = new System.Drawing.Size(155, 24);
            this.cbb_Lunch.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dinner";
            // 
            // cbb_Dinner
            // 
            this.cbb_Dinner.FormattingEnabled = true;
            this.cbb_Dinner.Location = new System.Drawing.Point(177, 293);
            this.cbb_Dinner.Name = "cbb_Dinner";
            this.cbb_Dinner.Size = new System.Drawing.Size(155, 24);
            this.cbb_Dinner.TabIndex = 82;
            // 
            // txt_AOD
            // 
            this.txt_AOD.Location = new System.Drawing.Point(177, 335);
            this.txt_AOD.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_AOD.Name = "txt_AOD";
            this.txt_AOD.Size = new System.Drawing.Size(399, 22);
            this.txt_AOD.TabIndex = 78;
            this.txt_AOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AOD_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Amount of lunch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Amount of dinner";
            // 
            // FormFoodForAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 636);
            this.Controls.Add(this.cbb_Dinner);
            this.Controls.Add(this.cbb_Lunch);
            this.Controls.Add(this.cbb_Breakfast);
            this.Controls.Add(this.cbb_Animal);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_AnimalFood);
            this.Controls.Add(this.txt_AOD);
            this.Controls.Add(this.txt_AOL);
            this.Controls.Add(this.txt_AOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Name = "FormFoodForAnimal";
            this.Text = "FormFoodForAnimal";
            this.Load += new System.EventHandler(this.FormFoodForAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_AnimalFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_AnimalFood;
        private System.Windows.Forms.TextBox txt_AOL;
        private System.Windows.Forms.TextBox txt_AOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbb_Dinner;
        private System.Windows.Forms.ComboBox cbb_Lunch;
        private System.Windows.Forms.ComboBox cbb_Breakfast;
        private System.Windows.Forms.ComboBox cbb_Animal;
        private System.Windows.Forms.TextBox txt_AOD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}