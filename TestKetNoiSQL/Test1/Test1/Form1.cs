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

namespace Test1
{
    public partial class frm_thongtinsinhvien : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLNhanSu;Integrated Security=True";
        public frm_thongtinsinhvien()
        {
            InitializeComponent();
        }

        private void frm_thongtinsinhvien_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();

        }
        public DataTable getTable(string sql)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        private void LayDuLieuDataGridView()
        {
            //string sql = "select * from Employees";
            //DataTable dt = new DataTable();
            //dt = getTable(sql);
            //dgvEmploye.DataSource = dt;

            conn = new SqlConnection(connstring);
            //Mở kết nối        
            conn.Open();
            //Câu lệnh lấy dữ liệu     
            string sql = "select * from Employees";
            //bat dau truy van          
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            //chuyen du lieu ve dataAdapter         
            SqlDataAdapter da = new SqlDataAdapter(com);
            //tạo một kho ảo để lưu trữ dữ liệu        
            DataTable dt = new DataTable();
            da.Fill(dt);
            // đổ dữ liệu vào kho          
            da.Dispose();
            //Giải phóng DataAdapter      
            conn.Close();
            // đóng kết nối 
            dgvEmploye.DataSource = dt; 
        }

        private void LayDuLieuTenPB()
        {
            string sql = "select DepartmentID, DepartmentName from Departments";
            DataTable dt = new DataTable();
            dt = getTable(sql);
            cboTenPB.DataSource = dt;
            cboTenPB.DisplayMember = "DepartmentName";
            cboTenPB.ValueMember = "DepartmentID";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text=="" || txtFirstName.Text=="" || txtLastName.Text == "" || txtFullName.Text =="" || txtDiaChi.Text=="" || cboTenPB.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin !", "Thông báo");
            }
            else
            {
                themMoiNV();
                LayDuLieuDataGridView();
            }
        }

        private void themMoiNV()
        {
            try
            {
                string sql = "insert into Employees values('" + txtMaNV.Text + "','" + cboTenPB.Text + "',N'" + txtFirstName.Text + "',N'" + txtLastName.Text + "',N'" + txtFullName.Text + "','";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                sql += gt +"','"+dateTimePicker1.Value+"',N'"+txtDiaChi.Text+"')";
                DataTable dt = new DataTable();
                dt = getTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }
    }
}
