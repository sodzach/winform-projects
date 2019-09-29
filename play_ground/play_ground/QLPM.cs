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
    public partial class QLPM : Form
    {
        //SqlConnection cnn;
        DAL database;
        public QLPM()
        {
            /*
        
            InitializeComponent();

            string strCNN = "server=192.168.126.131; database=StaffDB; Uid=SA; PWD=Qwerty@123"; // Integrated Security = True
            cnn = new SqlConnection(strCNN);

            LoadList();
            //GetName();
            */

            InitializeComponent();
            database = new DAL();
            LoadList();

        }

        public void LoadList()
        {

            /*
            SqlDataAdapter da = new SqlDataAdapter("Select * from PhieuMuon", cnn);
            DataTable dt = new DataTable(); // save returned queries
            // add data from da to dt
            da.Fill(dt);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvItems;
                lvItems = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvItems.SubItems.Add(dt.Rows[i][1].ToString());
                lvItems.SubItems.Add(dt.Rows[i][2].ToString());
                //lvItems.SubItems.Add(dt.Rows[i][3].ToString());
                //lvItems.SubItems.Add(dt.Rows[i][4].ToString());
                //lvItems.SubItems.Add(phoneNum);
            */
            DataTable dt = database.Query("Select * from PhieuMuon");

            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvItems;
                lvItems = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvItems.SubItems.Add(dt.Rows[i][1].ToString());
                lvItems.SubItems.Add(dt.Rows[i][2].ToString());

            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // check whether the user select items or not
            if (listView1.SelectedItems.Count > 0)
            {
                txtMaPhieu.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
                dateTimeNgayMuon.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                //txtID.Text = listView1.SelectedItems[0].SubItems[3].Text;
                

            }

        }

        private void QLPM_Load(object sender, EventArgs e)
        {

        }

        private void LabelID_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            /*
            string maPhieu;
            string name;
            string ngayMuon;
            //string id;
            

            maPhieu = txtMaPhieu.Text;
            name = txtTen.Text;
            ngayMuon = dateTimeNgayMuon.Value.ToShortDateString();
            */
            //id = txtID.Text;

            //bc = bangCap.SelectValue

          
            /*
            cnn.Open();

            string sql = string.Format("insert into PhieuMuon values ('{0}', '{1}', '{2}')", maPhieu, name, ngayMuon);
            SqlCommand sqlCmd = new SqlCommand(sql, cnn);
            sqlCmd.ExecuteNonQuery();
            LoadList();
            //LoadList();
            cnn.Close();
            */

            string maPhieu;
            string name;
            string ngayMuon;

            maPhieu = txtMaPhieu.Text;
            name = txtTen.Text;
            ngayMuon = dateTimeNgayMuon.Value.ToShortDateString();


            string sql = string.Format("insert into PhieuMuon values('{0}', '{1}', '{2}')", maPhieu, name, ngayMuon);
            database.executeCommand(sql);

            LoadList();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            /*
            if (listView1.SelectedItems.Count > 0)
            {

                string maPhieu;
                string name;
                string ngayMuon;
                //string id;


                maPhieu = txtMaPhieu.Text;
                name = txtTen.Text;
                ngayMuon = dateTimeNgayMuon.Value.ToShortDateString();

                cnn.Open();
                string maPM = listView1.SelectedItems[0].SubItems[0].Text;
                //MessageBox.Show(staffID);
                string sql = string.Format("update PhieuMuon set MaPhieu = '{0}', HoTen = '{1}', NgayMuon = '{2}' where MaPhieu = '{3}'", maPhieu, name, ngayMuon, maPM);
                SqlCommand sqlCmd = new SqlCommand(sql, cnn);
                sqlCmd.ExecuteNonQuery();
                LoadList();

                cnn.Close();
                
     

            }
           */
            string maPhieu;
            string name;
            string ngayMuon;
            string maPM = listView1.SelectedItems[0].SubItems[0].Text;
            maPhieu = txtMaPhieu.Text;
            name = txtTen.Text;
            ngayMuon = dateTimeNgayMuon.Value.ToShortDateString();
            string sql = string.Format("update PhieuMuon set MaPhieu = '{0}', HoTen = '{1}', NgayMuon = '{2}' where MaPhieu = '{3}'", maPhieu, name, ngayMuon, maPM);
            database.executeCommand(sql);
            LoadList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            

            string MaPhieu = listView1.SelectedItems[0].SubItems[0].Text;
            string sql = string.Format("delete from PhieuMuon where MaPhieu = '{0}'", MaPhieu);
            database.executeCommand(sql);

            LoadList();
            LoadList();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you f*cking sure?", "QLPM",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Close();
        }
    }
}
