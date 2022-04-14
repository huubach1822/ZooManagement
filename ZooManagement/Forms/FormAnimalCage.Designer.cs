namespace ZooManagement.Forms
{
    partial class FormAnimalCage
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
            this.dt_AnimalCage = new System.Windows.Forms.DataGridView();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Update = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbb_Cage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Animal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_dayin = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AnimalCage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1139, 78);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(144, 38);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_AnimalCage
            // 
            this.dt_AnimalCage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AnimalCage.Location = new System.Drawing.Point(685, 130);
            this.dt_AnimalCage.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dt_AnimalCage.Name = "dt_AnimalCage";
            this.dt_AnimalCage.RowHeadersWidth = 51;
            this.dt_AnimalCage.Size = new System.Drawing.Size(597, 294);
            this.dt_AnimalCage.TabIndex = 80;
            this.dt_AnimalCage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_AnimalCage_CellClick);
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(248, 283);
            this.txt_reason.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(399, 22);
            this.txt_reason.TabIndex = 78;
            this.txt_reason.Validating += new System.ComponentModel.CancelEventHandler(this.txt_reason_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW ANIMAL CAGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "ANIMAL CAGE TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Animal";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1069, 500);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(261, 50);
            this.btn_Delete.TabIndex = 70;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(459, 500);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(261, 50);
            this.btn_Insert.TabIndex = 71;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(764, 500);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(261, 50);
            this.txt_Update.TabIndex = 69;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = true;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbb_Cage
            // 
            this.cbb_Cage.FormattingEnabled = true;
            this.cbb_Cage.Location = new System.Drawing.Point(248, 89);
            this.cbb_Cage.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Cage.Name = "cbb_Cage";
            this.cbb_Cage.Size = new System.Drawing.Size(160, 24);
            this.cbb_Cage.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Cage";
            // 
            // cbb_Animal
            // 
            this.cbb_Animal.FormattingEnabled = true;
            this.cbb_Animal.Location = new System.Drawing.Point(248, 155);
            this.cbb_Animal.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Animal.Name = "cbb_Animal";
            this.cbb_Animal.Size = new System.Drawing.Size(160, 24);
            this.cbb_Animal.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Reason";
            // 
            // msk_dayin
            // 
            this.msk_dayin.Location = new System.Drawing.Point(248, 226);
            this.msk_dayin.Margin = new System.Windows.Forms.Padding(4);
            this.msk_dayin.Mask = "00/00/0000";
            this.msk_dayin.Name = "msk_dayin";
            this.msk_dayin.Size = new System.Drawing.Size(160, 22);
            this.msk_dayin.TabIndex = 83;
            this.msk_dayin.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Day_in";
            // 
            // FormAnimalCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 629);
            this.Controls.Add(this.msk_dayin);
            this.Controls.Add(this.cbb_Animal);
            this.Controls.Add(this.cbb_Cage);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_AnimalCage);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAnimalCage";
            this.Text = "FormAnimalCage";
            this.Load += new System.EventHandler(this.FormAnimalCage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_AnimalCage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_AnimalCage;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox msk_dayin;
        private System.Windows.Forms.ComboBox cbb_Animal;
        private System.Windows.Forms.ComboBox cbb_Cage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}