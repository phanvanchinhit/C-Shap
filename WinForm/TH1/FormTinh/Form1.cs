using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtso1.Text);
            float b = float.Parse(txtSo2.Text);
            txtKq.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtso1.Text);
            float b = float.Parse(txtSo2.Text);
            txtKq.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtso1.Text);
            float b = float.Parse(txtSo2.Text);
            txtKq.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtso1.Text);
            float b = float.Parse(txtSo2.Text);
            txtKq.Text = (a / b).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.txtso1.Clear();
            this.txtSo2.Clear();
            this.txtKq.Clear();
            this.txtso1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
