namespace ZooManagement.Forms
{
    partial class FormAccident
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
            this.dt_Accident = new System.Windows.Forms.DataGridView();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dt_Accident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1118, 28);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(144, 38);
            this.btn_SEARCH.TabIndex = 94;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_Accident
            // 
            this.dt_Accident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Accident.Location = new System.Drawing.Point(665, 81);
            this.dt_Accident.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dt_Accident.Name = "dt_Accident";
            this.dt_Accident.RowHeadersWidth = 51;
            this.dt_Accident.Size = new System.Drawing.Size(597, 294);
            this.dt_Accident.TabIndex = 93;
            this.dt_Accident.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Accident_CellClick);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(228, 153);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(399, 22);
            this.txt_Note.TabIndex = 91;
            this.txt_Note.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Note_Validating);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(228, 101);
            this.txt_name.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(399, 22);
            this.txt_name.TabIndex = 90;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(228, 52);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(399, 22);
            this.txt_Id.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "VIEW ACCIDENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "ACCIDENT TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 87;
            this.label8.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "ID";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1072, 448);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(262, 50);
            this.btn_Delete.TabIndex = 83;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Location = new System.Drawing.Point(460, 448);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(262, 50);
            this.btn_Insert.TabIndex = 84;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Update.Location = new System.Drawing.Point(766, 448);
            this.txt_Update.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(262, 50);
            this.txt_Update.TabIndex = 82;
            this.txt_Update.Text = "UPDATE";
            this.txt_Update.UseVisualStyleBackColor = true;
            this.txt_Update.Click += new System.EventHandler(this.txt_Update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAccident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 573);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_Accident);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Name = "FormAccident";
            this.Text = "FormAccident";
            this.Load += new System.EventHandler(this.FormAccident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Accident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_Accident;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_name;
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
    }
}