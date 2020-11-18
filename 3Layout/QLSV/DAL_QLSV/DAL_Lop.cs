using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLSV
{
    class DAL_Lop
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLSV;Persist Security Info=True;User ID=sa ;Password=Anhchinh2k"); }
        //trả về 1 bảng lưu trữ       
        public DataTable getTable(string strsql)
        {             SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Thực thi câu lệnh    
        public void ExcuteNonQuery(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand com = new SqlCommand(strsql, conn);
            com.ExecuteNonQuery();
            com.Dispose();
            com.Clone();
        }   
    }

}
