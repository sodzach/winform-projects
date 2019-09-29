using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace play_ground
{
    class DAL
    {
        SqlConnection cnn;
        public DAL()
        {
            string strCNN = "server=192.168.126.131; database=StaffDB; Uid=SA; PWD=Qwerty@123"; // Integrated Security = True
            cnn = new SqlConnection(strCNN);
        }
        public DataTable Query(string strSql) // thuc hien truy van
        {
            SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void executeCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
