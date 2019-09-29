namespace play_ground
{
    partial class QLPM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.dateTimeNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.labelNgayMuon = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaPhieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelMaPhieu);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.dateTimeNgayMuon);
            this.groupBox1.Controls.Add(this.labelNgayMuon);
            this.groupBox1.Controls.Add(this.labelTen);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonEdit);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(319, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            // labelMaPhieu
            // 
            this.labelMaPhieu.AutoSize = true;
            this.labelMaPhieu.Location = new System.Drawing.Point(6, 21);
            this.labelMaPhieu.Name = "labelMaPhieu";
            this.labelMaPhieu.Size = new System.Drawing.Size(49, 13);
            this.labelMaPhieu.TabIndex = 10;
            this.labelMaPhieu.Text = "MaPhieu";
            this.labelMaPhieu.Click += new System.EventHandler(this.LabelID_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(55, 17);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhieu.TabIndex = 9;
            // 
            // dateTimeNgayMuon
            // 
            this.dateTimeNgayMuon.Location = new System.Drawing.Point(55, 76);
            this.dateTimeNgayMuon.Name = "dateTimeNgayMuon";
            this.dateTimeNgayMuon.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNgayMuon.TabIndex = 8;
            // 
            // labelNgayMuon
            // 
            this.labelNgayMuon.AutoSize = true;
            this.labelNgayMuon.Location = new System.Drawing.Point(-3, 80);
            this.labelNgayMuon.Name = "labelNgayMuon";
            this.labelNgayMuon.Size = new System.Drawing.Size(62, 13);
            this.labelNgayMuon.TabIndex = 2;
            this.labelNgayMuon.Text = "Ngay Muon";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(6, 50);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(26, 13);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Ten";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(55, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaPhieu,
            this.colTen,
            this.colNgayMuon,
            this.colStaffID});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 175);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 263);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.Text = "MaPhieu";
            // 
            // colTen
            // 
            this.colTen.Text = "Ten";
            this.colTen.Width = 333;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Text = "NgayMuon";
            this.colNgayMuon.Width = 339;
            // 
            // colStaffID
            // 
            this.colStaffID.Text = "StaffID";
            this.colStaffID.Width = 13;
            // 
            // QLPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLPM";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.QLPM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DateTimePicker dateTimeNgayMuon;
        private System.Windows.Forms.Label labelNgayMuon;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaPhieu;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colNgayMuon;
        private System.Windows.Forms.ColumnHeader colStaffID;
    }
}