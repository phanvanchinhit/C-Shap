using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWebsite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtKq.ResetText();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.txtKq.Text = "Bạn đã chọn website\n";
            this.txtKq.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi trẻ");
            this.lstWeb.Items.Add("Thanh niên");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.Items.Add("Dân trí");
            this.lstWeb.Items.Add("Tuấn anh");
            this.lstWeb.Items.Add("Quốc đạt");
            this.lstWeb.SelectedItem = "Tuổi trẻ";
        }
    }
}
