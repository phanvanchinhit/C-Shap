using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text == "pvchinh" && this.txtPass.Text == "123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / Mật khẩu !!!","Thông Báo");
                this.txtUser.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Chắc Không ?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
