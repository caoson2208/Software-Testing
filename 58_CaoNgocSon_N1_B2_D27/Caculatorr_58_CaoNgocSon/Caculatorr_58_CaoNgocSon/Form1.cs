using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculatorr_58_CaoNgocSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            ketqua = c.Execute("+");
            txtKQ.Text = ketqua.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            ketqua = c.Execute("-");
            txtKQ.Text = ketqua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            ketqua = c.Execute("*");
            txtKQ.Text = ketqua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation_58_CaoNgocSon c = new Caculation_58_CaoNgocSon(a, b);
            ketqua = c.Execute("/");
            txtKQ.Text = ketqua.ToString();
        }
    }
}
