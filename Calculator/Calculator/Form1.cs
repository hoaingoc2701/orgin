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

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, KQ;
            if (txtA.Text != string.Empty && txtB.Text != string.Empty)
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                KQ = a + b;
                txtKQ.Text = KQ.ToString();
            }

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, KQ;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KQ = a - b;
            txtKQ.Text = KQ.ToString();
        }
    }
}
