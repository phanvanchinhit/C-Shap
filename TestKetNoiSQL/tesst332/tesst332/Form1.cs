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

namespace tesst332
{
    public partial class frm_sinhvien : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLNhanSuaa;Integrated Security=True";
        public frm_sinhvien()
        {
            InitializeComponent();
        }

        private void frm_sinhvien_Load(object sender, EventArgs e)
        {
            LayDuLieuView();
            LayTenPhongBan();
            txtMaNV.Focus();
        }
        private void LayDuLieuView()
        {
            string sql = "select * from Employees";
            DataTable dt = new DataTable();
            dt = getTable(sql);
            dgvEmploye.DataSource = dt;
        }
        public DataTable getTable( string sql)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void LayTenPhongBan()
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
            if (txtMaNV.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtFullName.Text == "" || txtDiaChi.Text == "" || cboTenPB.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin !", "Thông báo");
            }
            else
            {
                themMoiNV();
                LayDuLieuView();
            }
        }

        public void themMoiNV()
        {
            try
            {
                string sql = "insert into Employees values('" + txtMaNV.Text + "','" + cboTenPB.SelectedValue + "',N'" + txtFirstName.Text + "',N'" + txtLastName.Text + "',N'" + txtFullName.Text + "','";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                sql += gt + "','" + dateTimePicker1.Value + "',N'" + txtDiaChi.Text + "')";
                DataTable dt = new DataTable();
                dt = getTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (kiemTraNV(int.Parse(txtMaNV.Text)) == false)
            {
                MessageBox.Show("Không tồn tại nhân viên này !", "Thông báo");
            }
            else
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtFullName.Text == "" || txtDiaChi.Text == "" || cboTenPB.Text == "")
                {
                    MessageBox.Show("Bạn nhập thiếu thông tin !", "Thông báo");
                }
                else
                {
                    SuaNV();
                    LayDuLieuView();
                }
            }
        }

        public bool kiemTraNV(int manv)
        {
            bool kt = false;
            string sql = "select * from Employees where EmployeeID='" + manv + "'";
            DataTable dt = new DataTable();
            dt = getTable(sql);
            if (dt.Rows.Count == 0)
                kt = false;
            else
                kt = true;
            return kt;

        }
        public void SuaNV()
        {

            try
            {
                string sql = "update Employees set DepartmentID = '" + cboTenPB.SelectedValue + "',FirstName=N'" + txtFirstName.Text + "',LastName=N'" + txtLastName.Text + "',FullName= N'" + txtFullName.Text + "', Gender='";
                string gt;
                if (radNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nu";
                sql += gt + "' ,Birthday='" + dateTimePicker1.Value + "',Address= N'" + txtDiaChi.Text + "' where EmployeeID='" + txtMaNV.Text + "' ";
                DataTable dt = new DataTable();
                dt = getTable(sql);
            }
            catch
            {
                MessageBox.Show("Có Lỗi nhập liệu", "Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(kiemTraNV(int.Parse(txtMaNV.Text))== false)
            {
                MessageBox.Show("Không tồn tại nhân viên này", "Thông báo");
            }
            else
            {
                xoaNV();
                LayDuLieuView();
            }
        }
        public void xoaNV()
        {
            try
            {
                string sql = "Delete from Employees where EmployeeID='" + txtMaNV.Text + "'";
                DataTable dt = new DataTable();
                dt = getTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            LayTenPhongBan();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFullName.Clear();
            txtDiaChi.Clear();
            radNam.Checked = true;
            radNu.Checked = false;
            txtDiaChi.Clear();
            txtMaNV.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn Muốn thoát không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
                Application.Exit();
        }
    }
}
