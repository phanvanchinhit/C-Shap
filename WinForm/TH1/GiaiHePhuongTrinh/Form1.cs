using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiHePhuongTrinh
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float b = float.Parse(txtSob.Text);
            float c = float.Parse(txtSoc.Text);
            if(b== 0)
            {
                if(c== 0)
                {
                    MessageBox.Show("Phương trình có vô số nghiệm");
                }
                else
                {
                    MessageBox.Show("Phương trình vô nghiệm ");
                }
            }
            else
            {
                txtKetQua.Text = (-c/b).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
