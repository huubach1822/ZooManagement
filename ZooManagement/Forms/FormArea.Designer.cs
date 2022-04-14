namespace ZooManagement.Forms
{
    partial class FormArea
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
            this.dt_Area = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dt_Area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(904, 35);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(108, 31);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_Area
            // 
            this.dt_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Area.Location = new System.Drawing.Point(564, 78);
            this.dt_Area.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dt_Area.Name = "dt_Area";
            this.dt_Area.RowHeadersWidth = 51;
            this.dt_Area.Size = new System.Drawing.Size(448, 239);
            this.dt_Area.TabIndex = 80;
            this.dt_Area.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Area_CellClick);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(236, 136);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(300, 20);
            this.txt_Note.TabIndex = 78;
            this.txt_Note.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Note_Validating);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(236, 94);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(300, 20);
            this.txt_name.TabIndex = 77;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(236, 54);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(300, 20);
            this.txt_Id.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW AREA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "AREA TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 58);
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
            this.btn_Delete.Location = new System.Drawing.Point(852, 378);
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
            this.btn_Insert.Location = new System.Drawing.Point(394, 378);
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
            this.txt_Update.Location = new System.Drawing.Point(623, 378);
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
            // FormArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 455);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_Area);
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
            this.Name = "FormArea";
            this.Text = "FormArea";
            this.Load += new System.EventHandler(this.FormArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_Area;
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