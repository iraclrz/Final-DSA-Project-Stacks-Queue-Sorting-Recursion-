using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DSA
{
    public partial class Recursion : Form
    {
        public Recursion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Generate_Click(object sender, EventArgs e)
        {
            int i, factorial = 1, num;
            num = Convert.ToInt32(tb_FactorialNumber.Text);
            for (i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            tb_FactorialAnswer.Text = factorial.ToString();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tb_FactorialNumber.Clear();
            tb_FactorialAnswer.Clear();
        }

        private void tb_FactorialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled =! char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(lbl_EnterNum, "Please enter a valid numeric value");
                lbl_EnterNum.Text = "Please enter a valid numeric value";
            }
            else
            {
                errorProvider1.SetError(lbl_EnterNum, "");
                lbl_EnterNum.Text = "";
            }
        }

        private void bt_FibGenerate_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 1, n3, i, num1;
            num1 = Convert.ToInt32(tb_FibNumber.Text);
            tb_FibAnswer.Text = n1 + " " + n2 + " ";
            for (i = 2; i < num1; i++)
            {
                n3 = n1 + n2;
                tb_FibAnswer.Text = tb_FibAnswer.Text + n3 + " ";
                n1 = n2;
                n2 = n3;
            }
        }

        private void bt_FibClear_Click(object sender, EventArgs e)
        {
            tb_FibNumber.Clear();
            tb_FibAnswer.Clear();
        }

        private void tb_FibNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider2.SetError(lbl_FibError, "Please enter a valid numeric value");
                lbl_FibError.Text = "Please enter a valid numeric value";
            }
            else
            {
                errorProvider2.SetError(lbl_FibError, "");
                lbl_FibError.Text = "";
            }
        }
    }
}
