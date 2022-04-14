namespace ZooManagement.Forms
{
    partial class FormEvent
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
            this.dt_Event = new System.Windows.Forms.DataGridView();
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Accident = new System.Windows.Forms.ComboBox();
            this.cbb_Animal = new System.Windows.Forms.ComboBox();
            this.cbb_Reason = new System.Windows.Forms.ComboBox();
            this.cbb_Fix = new System.Windows.Forms.ComboBox();
            this.mskStartDay = new System.Windows.Forms.MaskedTextBox();
            this.mskEndDay = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.Location = new System.Drawing.Point(1124, 29);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(144, 38);
            this.btn_SEARCH.TabIndex = 81;
            this.btn_SEARCH.Text = "SEARCH";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // dt_Event
            // 
            this.dt_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Event.Location = new System.Drawing.Point(671, 82);
            this.dt_Event.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.dt_Event.Name = "dt_Event";
            this.dt_Event.RowHeadersWidth = 51;
            this.dt_Event.Size = new System.Drawing.Size(597, 294);
            this.dt_Event.TabIndex = 80;
            this.dt_Event.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Event_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "VIEW EVENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "EVENT TABLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Start Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Accident";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1089, 459);
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
            this.btn_Insert.Location = new System.Drawing.Point(477, 459);
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
            this.txt_Update.Location = new System.Drawing.Point(783, 459);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Reason";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Fix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "End Day";
            // 
            // cbb_Accident
            // 
            this.cbb_Accident.FormattingEnabled = true;
            this.cbb_Accident.Location = new System.Drawing.Point(234, 51);
            this.cbb_Accident.Name = "cbb_Accident";
            this.cbb_Accident.Size = new System.Drawing.Size(163, 24);
            this.cbb_Accident.TabIndex = 82;
            // 
            // cbb_Animal
            // 
            this.cbb_Animal.FormattingEnabled = true;
            this.cbb_Animal.Location = new System.Drawing.Point(234, 103);
            this.cbb_Animal.Name = "cbb_Animal";
            this.cbb_Animal.Size = new System.Drawing.Size(163, 24);
            this.cbb_Animal.TabIndex = 82;
            // 
            // cbb_Reason
            // 
            this.cbb_Reason.FormattingEnabled = true;
            this.cbb_Reason.Location = new System.Drawing.Point(234, 203);
            this.cbb_Reason.Name = "cbb_Reason";
            this.cbb_Reason.Size = new System.Drawing.Size(163, 24);
            this.cbb_Reason.TabIndex = 82;
            // 
            // cbb_Fix
            // 
            this.cbb_Fix.FormattingEnabled = true;
            this.cbb_Fix.Location = new System.Drawing.Point(234, 153);
            this.cbb_Fix.Name = "cbb_Fix";
            this.cbb_Fix.Size = new System.Drawing.Size(163, 24);
            this.cbb_Fix.TabIndex = 82;
            // 
            // mskStartDay
            // 
            this.mskStartDay.Location = new System.Drawing.Point(234, 261);
            this.mskStartDay.Mask = "00/00/0000";
            this.mskStartDay.Name = "mskStartDay";
            this.mskStartDay.Size = new System.Drawing.Size(163, 22);
            this.mskStartDay.TabIndex = 83;
            this.mskStartDay.ValidatingType = typeof(System.DateTime);
            // 
            // mskEndDay
            // 
            this.mskEndDay.Location = new System.Drawing.Point(234, 310);
            this.mskEndDay.Mask = "00/00/0000";
            this.mskEndDay.Name = "mskEndDay";
            this.mskEndDay.Size = new System.Drawing.Size(163, 22);
            this.mskEndDay.TabIndex = 83;
            this.mskEndDay.ValidatingType = typeof(System.DateTime);
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 577);
            this.Controls.Add(this.mskEndDay);
            this.Controls.Add(this.mskStartDay);
            this.Controls.Add(this.cbb_Fix);
            this.Controls.Add(this.cbb_Reason);
            this.Controls.Add(this.cbb_Animal);
            this.Controls.Add(this.cbb_Accident);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.dt_Event);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Update);
            this.Name = "FormEvent";
            this.Text = "FormEvent";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridView dt_Event;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button txt_Update;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Fix;
        private System.Windows.Forms.ComboBox cbb_Reason;
        private System.Windows.Forms.ComboBox cbb_Animal;
        private System.Windows.Forms.ComboBox cbb_Accident;
        private System.Windows.Forms.MaskedTextBox mskEndDay;
        private System.Windows.Forms.MaskedTextBox mskStartDay;
    }
}