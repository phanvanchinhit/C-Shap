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
namespace KetNoi
{
    public partial class fmEmployee : Form
    {
        SqlConnection conn;
        string connstr = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa";

        public fmEmployee()
        {
            InitializeComponent();
        }

        private void fmEmployee_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            LayDuLieuTenPB();
            radNam.Checked = true;
            radNu.Checked = false;
            txtMaNV.Focus(); 
        }

        private void LayDuLieuDataGridView()
        {
            conn = new SqlConnection(connstr);             
            conn.Open();
            string sql = "select * from Employees";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            dgvEmploye.DataSource = dt;
        }

        private void LayDuLieuTenPB()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            string sql = "select DepartmentID,DepartmentName from Departments";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            cboTenPB.DataSource = dt;
            cboTenPB.DisplayMember = "DepartmentName";         
            cboTenPB.ValueMember = "DepartmentID";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtFristName.Text == "" || txtLastName.Text == "" || txtFullName.Text == "" || txtDiaChi.Text == "" || cboTenPB.Text == "")
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo");
            else {
                themMoiNhanVien();
                LayDuLieuDataGridView();
            }
        }
        private void themMoiNhanVien()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                string strInsert = "insert into Employees values('" + txtMaNV.Text + "','" + cboTenPB.SelectedValue + "',N'";
                strInsert += txtFristName.Text + "',N'" + txtLastName.Text + "',N'" + txtFullName.Text + "','";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                strInsert += gt + "','" + dateTimePicker1.Value + "',N'" + txtDiaChi.Text + "')";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu!", "Thông báo");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (KiemTraMaNV(int.Parse(txtMaNV.Text)) == false)
            {
                MessageBox.Show("Không có nhân viên này!", "Thông báo");
            }
            else
            {
                if (txtFristName.Text == "" || txtLastName.Text == ""
               || txtFullName.Text == "" || txtDiaChi.Text == "" || cboTenPB.Text ==
               "")
                    MessageBox.Show("Bạn nhập thiếu thông tin!",
                   "Thông báo");
                else
                {
                    SuaNhanVien();
                    LayDuLieuDataGridView();
                }
            }

        }
        private bool KiemTraMaNV(int manv)
        {
            bool ktra = false;
            //Tạo chuỗi kết nối
            conn = new SqlConnection(connstr);
            //Mở kết nối
            conn.Open();
            //Câu lệnh lấy dữ liệu
            string sql = "select * from Employees where EmployeeID = '"+manv+"'";
             SqlCommand com = new SqlCommand(sql, conn); 
                com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
             DataTable dt = new DataTable();
            da.Fill(dt); 
            da.Dispose(); 
            conn.Close(); 
            if (dt.Rows.Count == 0)
                ktra = false;
            else
                ktra = true;
            return ktra;
        }

        private void SuaNhanVien()
        {
            try
            {
                conn = new SqlConnection(connstr);
                conn.Open();

                string strUpdate = "Update Employees set DepartmentID = '" + cboTenPB.SelectedValue + "',FirstName = N'";
            strUpdate += txtFristName.Text + "',LastName=N'" +txtLastName.Text + "',FullName=N'" + txtFullName.Text + "',Gender='";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                strUpdate += gt + "',Birthday='" +
               dateTimePicker1.Value + "',Addres=N'" + txtDiaChi.Text + "' where EmployeeID = '"+txtMaNV.Text+"'";
                 SqlCommand cmd = new SqlCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu!", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (KiemTraMaNV(int.Parse(txtMaNV.Text)) == false)
            {
                MessageBox.Show("Không có nhân viên này!", "Thông báo");
            }
            else
            {
                XoaNhanVien();
                LayDuLieuDataGridView();
            }
        }

    }

}
