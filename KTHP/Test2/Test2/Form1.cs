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

namespace Test2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLTV;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Laydulieu();
            LayMaTheLoai();
            txtMaSach.Focus();

        }

        private void Laydulieu()
        {
            string sql = "select * from SACH";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            dgvSach.DataSource = dt;
        }

        public void LayMaTheLoai()
        {
            string sql = "select MaTheLoai, TenTheLoai from TheLoai";
            DataTable dt = new DataTable();
            dt = GetTable(sql);
            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }

        public DataTable GetTable(string sql)
        {
            conn = new SqlConnection(connstring);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int b;
            b = e.RowIndex;
            txtMaSach.Text = dgvSach.Rows[b].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[b].Cells[1].Value.ToString();
            txtSoTrang.Text = dgvSach.Rows[b].Cells[2].Value.ToString();
            cboTheLoai.Text = dgvSach.Rows[b].Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMaSach.Text == "" || txtTenSach.Text == "" || txtSoTrang.Text=="" || cboTheLoai.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin", "Thông báo");
            }
            else if (kiemtrasach(txtMaSach.Text)== true)
            {
                MessageBox.Show("Mã sách đã tồn tại", "Thông báo");
            }
            else
            {
                themMoi();
                Laydulieu();
            }
        }

        public void themMoi()
        {
            try
            {
                string sql = "insert into SACH values('" + txtMaSach.Text + "', N'" + txtTenSach.Text + "', '" + txtSoTrang.Text + "','" + cboTheLoai.SelectedValue + "')";
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
            if(kiemtrasach(txtMaSach.Text)== false)
            {
                MessageBox.Show("Mã sách không tồn tại", "Thông báo");
            }
            else if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtSoTrang.Text == "" || cboTheLoai.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin", "Thông báo");
            }
            else
            {
                suaSach();
                Laydulieu();
            }
        }

        public void suaSach()
        {
            try
            {
                string sql = "update SACH set TenSach =N'"+txtTenSach.Text+"', SoTrang = '"+txtSoTrang.Text+"', MaTheLoai = '"+cboTheLoai.SelectedValue+"' where MaSach = '"+txtMaSach.Text+"' ";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành cồng, Có lỗi nhập liệu", "Thông báo");
            }
        }

        public bool kiemtrasach(string masach)
        {
            bool kt = false;
            string sql = "select MaSach from SACH where MaSach='" + masach + "'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (kiemtrasach(txtMaSach.Text) == false)
            {
                MessageBox.Show("Mã sách không tồn tại", "Thông báo");
            }
            else
            {
                xoaSach();
                Laydulieu();
            }
        }
        public void xoaSach()
        {
            try
            {
                string sql = "delete from SACH Where MaSach = '" + txtMaSach.Text + "'";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoTrang.Clear();
            LayMaTheLoai();
            txtMaSach.Focus();
            Laydulieu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes){
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (kiemtrasachcbo(cboTheLoai.Text) == false)
            {
                MessageBox.Show("Không có dữ liệu thỏa mãn", "Thông báo");
            }
            else
            {
                search();
               // Laydulieu();
            }
        }

        public void search()
        {
            try
            {
                string sql = "select * from SACH where MaTheLoai = '" + cboTheLoai.Text + "'";
                DataTable dt = new DataTable();
                dt = GetTable(sql);
                dgvSach.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu", "Thông báo");
            }
        }

        public bool kiemtrasachcbo(string masach)
        {
            bool kt = false;
            string sql = "select MaSach from SACH where MaTheLoai='" + masach + "'";
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
    }
}
