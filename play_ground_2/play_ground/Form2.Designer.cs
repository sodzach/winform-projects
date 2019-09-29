namespace play_ground
{
    partial class formBT6
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
            this.lvStaffList = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelShowName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStaffList
            // 
            this.lvStaffList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvStaffList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colBirthDay,
            this.colAddress,
            this.colPhoneNumber});
            this.lvStaffList.FullRowSelect = true;
            this.lvStaffList.GridLines = true;
            this.lvStaffList.HideSelection = false;
            this.lvStaffList.Location = new System.Drawing.Point(12, 218);
            this.lvStaffList.Name = "lvStaffList";
            this.lvStaffList.Size = new System.Drawing.Size(763, 220);
            this.lvStaffList.TabIndex = 0;
            this.lvStaffList.UseCompatibleStateImageBehavior = false;
            this.lvStaffList.View = System.Windows.Forms.View.Details;
            this.lvStaffList.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.DisplayIndex = 4;
            this.colID.Text = "ID";
            this.colID.Width = 20;
            // 
            // colName
            // 
            this.colName.DisplayIndex = 0;
            this.colName.Text = "Name";
            this.colName.Width = 168;
            // 
            // colBirthDay
            // 
            this.colBirthDay.DisplayIndex = 1;
            this.colBirthDay.Text = "Birth Day";
            this.colBirthDay.Width = 140;
            // 
            // colAddress
            // 
            this.colAddress.DisplayIndex = 2;
            this.colAddress.Text = "Adress";
            this.colAddress.Width = 298;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DisplayIndex = 3;
            this.colPhoneNumber.Text = "Phone Number";
            this.colPhoneNumber.Width = 596;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelShowName);
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dateTimeBirthDay);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.labelPhoneNumber);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelBirthDay);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(55, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 9;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Location = new System.Drawing.Point(55, 76);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBirthDay.TabIndex = 8;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(416, 55);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(193, 20);
            this.txtPhoneNum.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(416, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(339, 57);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Phone Number";
            this.labelPhoneNumber.Click += new System.EventHandler(this.Label4_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(365, 25);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(6, 81);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(50, 13);
            this.labelBirthDay.TabIndex = 2;
            this.labelBirthDay.Text = "Birth Day";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(337, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(322, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(220, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(118, 19);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(17, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(416, 80);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(193, 21);
            this.comboBoxName.TabIndex = 11;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxName_SelectedIndexChanged);
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.Location = new System.Drawing.Point(345, 83);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(65, 13);
            this.labelShowName.TabIndex = 12;
            this.labelShowName.Text = "Show Name";
            this.labelShowName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // formBT6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvStaffList);
            this.Name = "formBT6";
            this.Text = "Staff Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStaffList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colBirthDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}