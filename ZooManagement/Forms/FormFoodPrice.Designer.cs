namespace ZooManagement.Forms
{
    partial class FormFoodPrice
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
            this.dt_FoodPrice = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
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
            this.cbb_Food = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_AppliedDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1121, 48);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(144, 38);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_FoodPrice
            // 
            this.dt_FoodPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_FoodPrice.Location = new System.Drawing.Point(668, 101);
            this.dt_FoodPrice.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dt_FoodPrice.Name = "dt_FoodPrice";
            this.dt_FoodPrice.RowHeadersWidth = 51;
            this.dt_FoodPrice.Size = new System.Drawing.Size(597, 294);
            this.dt_FoodPrice.TabIndex = 80;
            this.dt_FoodPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_FoodPrice_CellClick);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(231, 173);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(399, 22);
            this.txt_Price.TabIndex = 78;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(231, 72);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(399, 22);
            this.txt_Id.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW FOOD PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "FOOD PRICE TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1053, 471);
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
            this.btn_Insert.Location = new System.Drawing.Point(441, 471);
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
            this.txt_Update.Location = new System.Drawing.Point(747, 471);
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
            // cbb_Food
            // 
            this.cbb_Food.FormattingEnabled = true;
            this.cbb_Food.Location = new System.Drawing.Point(231, 122);
            this.cbb_Food.Name = "cbb_Food";
            this.cbb_Food.Size = new System.Drawing.Size(162, 24);
            this.cbb_Food.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Applied_date";
            // 
            // msk_AppliedDate
            // 
            this.msk_AppliedDate.Location = new System.Drawing.Point(231, 234);
            this.msk_AppliedDate.Mask = "00/00/0000";
            this.msk_AppliedDate.Name = "msk_AppliedDate";
            this.msk_AppliedDate.Size = new System.Drawing.Size(162, 22);
            this.msk_AppliedDate.TabIndex = 83;
            this.msk_AppliedDate.ValidatingType = typeof(System.DateTime);
            // 
            // FormFoodPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 569);
            this.Controls.Add(this.msk_AppliedDate);
            this.Controls.Add(this.cbb_Food);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_FoodPrice);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Name = "FormFoodPrice";
            this.Text = "FormFoodPrice";
            this.Load += new System.EventHandler(this.FormFoodPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_FoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_FoodPrice;
        private System.Windows.Forms.TextBox txt_Price;
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
        private System.Windows.Forms.MaskedTextBox msk_AppliedDate;
        private System.Windows.Forms.ComboBox cbb_Food;
        private System.Windows.Forms.Label label3;
    }
}