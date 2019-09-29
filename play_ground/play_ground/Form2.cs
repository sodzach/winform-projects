using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace play_ground
{
    public partial class formBT6 : Form
    {
        SqlConnection cnn;

        public formBT6()
        {

            InitializeComponent();

            string strCNN = "server=192.168.126.131; database=StaffDB; Uid=SA; PWD=Qwerty@123"; // Integrated Security = True
            cnn = new SqlConnection(strCNN);

            LoadList();
            GetName();
        }

        public void LoadList()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from StaffTable", cnn);
            DataTable dt = new DataTable(); // save returned queries
            // add data from da to dt
            da.Fill(dt);
            lvStaffList.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvItems;
                lvItems = lvStaffList.Items.Add(dt.Rows[i][0].ToString());
                lvItems.SubItems.Add(dt.Rows[i][1].ToString());
                lvItems.SubItems.Add(dt.Rows[i][2].ToString());
                lvItems.SubItems.Add(dt.Rows[i][3].ToString());
                lvItems.SubItems.Add(dt.Rows[i][4].ToString());
                //lvItems.SubItems.Add(phoneNum);

            }
        }
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // check whether the user select items or not
            if (lvStaffList.SelectedItems.Count > 0)
            {
                txtID.Text = lvStaffList.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lvStaffList.SelectedItems[0].SubItems[1].Text;
                dateTimeBirthDay.Value = DateTime.Parse(lvStaffList.SelectedItems[0].SubItems[2].Text);
                txtAddress.Text = lvStaffList.SelectedItems[0].SubItems[3].Text;
                txtPhoneNum.Text = lvStaffList.SelectedItems[0].SubItems[4].Text;
                
            }
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string id;
            string name;
            string birthDay;
            string phoneNum;
            string address;

            id = txtID.Text;
            name = txtName.Text;
            birthDay = dateTimeBirthDay.Value.ToShortDateString();
            phoneNum = txtPhoneNum.Text;
            address = txtAddress.Text;
            //bc = bangCap.SelectValue

            /*
            ListViewItem lvItems;
            lvItems = lvStaffList.Items.Add(id);
            lvItems.SubItems.Add(name);
            lvItems.SubItems.Add(birthDay);
            lvItems.SubItems.Add(phoneNum);
            lvItems.SubItems.Add(address);
            */

            cnn.Open();

            string sql = string.Format("insert into StaffTable values ('{0}', '{1}', '{2}', '{3}', '{4}')", id, name, birthDay, address, phoneNum);
            SqlCommand sqlCmd = new SqlCommand(sql, cnn);
            sqlCmd.ExecuteNonQuery();
            LoadList();
            //LoadList();
            cnn.Close();


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //lvStaffList.Items.Remove(lvStaffList.SelectedItems[0]);
            cnn.Open();
            
            string staffID = lvStaffList.SelectedItems[0].SubItems[0].Text;
            string sql = string.Format("delete from StaffTable where StaffID = '{0}'", staffID);
            SqlCommand sqlCmd = new SqlCommand(sql, cnn);
            sqlCmd.ExecuteNonQuery();
            LoadList();
            LoadList();
            cnn.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you f*cking sure?", "formBT6",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
           if(lvStaffList.SelectedItems.Count > 0)
            {
                /*
                lvStaffList.SelectedItems[0].SubItems[0].Text = txtID.Text;
                //dateTimeBirthDay.Value = DateTime.Parse(lvStaffList.SelectedItems[0].SubItems[2].Text);
                lvStaffList.SelectedItems[0].SubItems[1].Text = txtName.Text;
                lvStaffList.SelectedItems[0].SubItems[2].Text = dateTimeBirthDay.Value.ToShortDateString();
                lvStaffList.SelectedItems[0].SubItems[3].Text = txtPhoneNum.Text;
                lvStaffList.SelectedItems[0].SubItems[4].Text = txtAddress.Text;
                */

                /*
                ListViewItem lvItems;
                lvItems = lvStaffList.Items.Add(id);
                lvItems.SubItems.Add(name);
                lvItems.SubItems.Add(birthDay);
                lvItems.SubItems.Add(phoneNum);
                lvItems.SubItems.Add(address);
                */

                string id;
                string name;
                string birthDay;
                string phoneNum;
                string address;

                id = txtID.Text;
                name = txtName.Text;
                birthDay = dateTimeBirthDay.Value.ToShortDateString();
                phoneNum = txtPhoneNum.Text;
                address = txtAddress.Text;

                cnn.Open();
                string staffID = lvStaffList.SelectedItems[0].SubItems[0].Text;
                //MessageBox.Show(staffID);
                string sql = string.Format("update StaffTable set StaffID = '{0}', StaffName = '{1}', StaffBirthday = '{2}', StaffAddress = '{3}', StaffPhoneNumber = '{4}' where StaffID = '{5}'", id, name, birthDay, address, phoneNum, staffID);
                SqlCommand sqlCmd = new SqlCommand(sql, cnn);
                sqlCmd.ExecuteNonQuery();
                LoadList();
            
                cnn.Close();

            }
        }

        public void GetName() 
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from StaffTable", cnn);
            DataTable dt = new DataTable(); // save returned queries
            // add data from da to dt
            da.Fill(dt);
          
            comboBoxName.DataSource = dt;
            comboBoxName.DisplayMember = "StaffName";
            comboBoxName.ValueMember = "StaffID";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GetName();
        }
    }
}
