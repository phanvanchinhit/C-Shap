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

namespace QuanLySanPham
{
    public partial class frm_ThongTinSanPham : Form
    {
        SqlConnection conn;
        string connstring = @"Data Source=PHANCHINH\SQLMAIN;Initial Catalog=QLBH;Persist Security Info=True;User ID=sa; Password= Anhchinh2k";

        public frm_ThongTinSanPham()
        {
            InitializeComponent();
        }

        private void frm_ThongTinSanPham_Load(object sender, EventArgs e)
        {
            LayDuLieuDataGridView();
            LayTenHang();
            txtMa.Focus();

        }
        private void LayDuLieuDataGridView()
        {
            string sql = "select * from SanPham";
            DataTable dt = new DataTable();
            dt = getTable(sql);
            dataGridView1.DataSource = dt;

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
        private void LayTenHang()
        {
            string sql = "select MaHang,TenHang from HangSX";
            DataTable dt = new DataTable();
            dt = getTable(sql);
            cboTenHang.DataSource = dt;
            cboTenHang.DisplayMember = "TenHang";
            cboTenHang.ValueMember = "MaHang";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtMau.Text == "" || txtSoLuong.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {
                themMoiSanPham();
                LayDuLieuDataGridView();
            }
        }

        private void themMoiSanPham()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string strInsert = "insert into SanPham values('" + txtMa.Text + "',N'";
                strInsert += txtTen.Text + "',N'" + txtMau.Text + "'," + txtSoLuong.Text + ",'";
                strInsert += txtGiaBan.Text + "',N" + cboTenHang.SelectedValue + ")";
                SqlCommand cmd = new SqlCommand(strInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi nhập liệu!", "Thông báo");
            }
        }
    }       
}
