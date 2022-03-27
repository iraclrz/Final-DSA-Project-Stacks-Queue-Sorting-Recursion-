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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Stacks_Click(object sender, EventArgs e)
        {
            Form stacks = new Form_Stacks();
            stacks.Show();
        }

        private void btn_Recursion_Click(object sender, EventArgs e)
        {
            Recursion r = new Recursion();
            r.Show();
        }

        private void btn_Queues_Click(object sender, EventArgs e)
        {
            Queues q = new Queues();
            q.Show();
        }

        private void btn_Sorting_Click(object sender, EventArgs e)
        {
            SelectionSort s = new SelectionSort();
            s.Show();
        }
    }
}
