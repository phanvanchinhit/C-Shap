using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH_CHUONG4
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }


        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.Visible = chkHienThi.Checked;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtTen.Text + ", " + txtThongBao.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtThongBao.Text = "";
            lblHienThi.Text = String.Empty;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radDen_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Black;
        }

        private void radDo_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Red;
        }

        private void radVang_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Yellow;
        }

        private void radXanh_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Blue;
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
