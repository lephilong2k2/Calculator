using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Execute("+").ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Execute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Execute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculation(a, b);
            txtKetQua.Text = cal.Execute("/").ToString();

        }
    }
}
