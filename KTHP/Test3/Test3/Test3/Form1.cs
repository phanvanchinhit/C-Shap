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

namespace Test3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QuanLyThuVienSach;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            laydulieudgv();
            laydulieutheloai();
            txtMaSach.Focus();
        }
        public DataTable GetTable(string sql)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void laydulieudgv()
        {
            string sql = "select * from SACH";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            dgvSach.DataSource = dt;
        }
        public void laydulieutheloai()
        {
            string sql = "select MaTheLoai, TenTheLoai from THELOAI";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }

        public bool ktMa(string ma)
        {
            bool kt = false;
            string sql = "select MaSach from SACH Where MaSach= '" + ma + "'";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            if(dt.Rows.Count == 0)
            {
                kt = false;
            }
            else
            {
                kt = true;
            }
            return kt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ktMa(txtMaSach.Text) == true)
            {
                MessageBox.Show("Mã sách đã tồn tại", "Thông báo");
            }
            else if(txtMaSach.Text == "" || txtTenSach.Text ==""|| txtSoTrang.Text ==""||cboTheLoai.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thồng tin", "Thông báo");
            }
            else
            {
                addSach();
                laydulieudgv();
            }
        }

        public void addSach()
        {
            try
            {
                string sql = "insert into SACH values ('"+txtMaSach.Text+"',N'"+txtTenSach.Text+"','"+txtSoTrang.Text+"','"+cboTheLoai.SelectedValue+"')";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }
        public void EditSach()
        {
            try
            {
                string sql = "update SACH set TenSach =N'" + txtTenSach.Text + "',SoTrang = '" + txtSoTrang.Text + "',MaTheLoai= '" + cboTheLoai.SelectedValue + "' where MaSach = '"+txtMaSach.Text+"'";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ktMa(txtMaSach.Text) == false)
            {
                MessageBox.Show("Mã sách Không tồn tại", "Thông báo");
            }
            else if ( txtTenSach.Text == "" || txtSoTrang.Text == "" || cboTheLoai.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thồng tin", "Thông báo");
            }
            else
            {
                EditSach();
                laydulieudgv();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t;
            t = e.RowIndex;
            txtMaSach.Text = dgvSach.Rows[t].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[t].Cells[1].Value.ToString();
            txtSoTrang.Text = dgvSach.Rows[t].Cells[2].Value.ToString();
            cboTheLoai.Text = dgvSach.Rows[t].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ktMa(txtMaSach.Text) == false)
            {
                MessageBox.Show("Mã sách không tồn tại", "Thông báo");
            }
            else
            {
                deleteSach();
                laydulieudgv();
            }
        }
        public void deleteSach()
        {
            string sql = "delete from SACH where MaSach ='" + txtMaSach.Text + "'";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ktSach(cboTheLoai.Text) == false)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
            else
            {
                string sql = "select * from SACH where MaTheLoai = '" + cboTheLoai.Text + "'";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
                dgvSach.DataSource = dt;
            }
        }
        public bool ktSach(string ma)
        {
            bool kt = false;
            string sql = "select MaSach from SACH Where MaTheLoai= '" + ma + "'";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            if (dt.Rows.Count == 0)
            {
                kt = false;
            }
            else
            {
                kt = true;
            }
            return kt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoTrang.Clear();
            laydulieutheloai();
            laydulieudgv();
            txtMaSach.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn thật sựu muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
