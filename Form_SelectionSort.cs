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


    public partial class SelectionSort : Form
    {
       
  
        public SelectionSort()
        {
            InitializeComponent();
        }

        private void SelectionSortForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
           
            if(tb_Input1.Text != "" && tb_Input2.Text != "" && tb_Input3.Text != "" && tb_Input4.Text != "" && tb_Input5.Text != "" && tb_Input6.Text != "" && tb_Input7.Text != "" && tb_Input8.Text != "" && tb_Input9.Text != "" && tb_Input10.Text != "")
            {
                int[] Unsortedlist = { int.Parse(tb_Input1.Text), int.Parse(tb_Input2.Text), int.Parse(tb_Input3.Text), int.Parse(tb_Input4.Text), int.Parse(tb_Input5.Text), int.Parse(tb_Input6.Text), int.Parse(tb_Input7.Text), int.Parse(tb_Input8.Text), int.Parse(tb_Input9.Text), int.Parse(tb_Input10.Text) };

                var Sortedlist = SelectionSortMethod(Unsortedlist);

                tb_Input1.Text = Convert.ToString(Sortedlist[0]);
                tb_Input2.Text = Convert.ToString(Sortedlist[1]);
                tb_Input3.Text = Convert.ToString(Sortedlist[2]);
                tb_Input4.Text = Convert.ToString(Sortedlist[3]);
                tb_Input5.Text = Convert.ToString(Sortedlist[4]);
                tb_Input6.Text = Convert.ToString(Sortedlist[5]);
                tb_Input7.Text = Convert.ToString(Sortedlist[6]);
                tb_Input8.Text = Convert.ToString(Sortedlist[7]);
                tb_Input9.Text = Convert.ToString(Sortedlist[8]);
                tb_Input10.Text = Convert.ToString(Sortedlist[9]);

            }
            else
            {
                if(MessageBox.Show("Please fill up all the boxes", "Error" ,MessageBoxButtons.RetryCancel ,MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    ClearFunction();
                }
            }
            
            
            
        }

        public static int [] SelectionSortMethod(int [] Numberlist)
        {
            int MinimumIndex = 0;
            
            for (int CurrentIndex = 0; CurrentIndex < Numberlist.Length - 1; CurrentIndex++)
            {
                MinimumIndex = CurrentIndex;
                for (int SelectedIndex = CurrentIndex + 1; SelectedIndex < Numberlist.Length; SelectedIndex++)
                {
                    if (Numberlist[SelectedIndex] < Numberlist[MinimumIndex])
                    {
                        MinimumIndex = SelectedIndex;
                    }
                }
                
                if (MinimumIndex != CurrentIndex)
                {
                    int temp = Numberlist[MinimumIndex];
                    Numberlist[MinimumIndex] = Numberlist[CurrentIndex];
                    Numberlist[CurrentIndex] = temp;
                }
            }
            return Numberlist;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFunction();
        }

        private void ClearFunction()
        {
            tb_Input1.Clear();
            tb_Input2.Clear();
            tb_Input3.Clear();
            tb_Input4.Clear();
            tb_Input5.Clear();
            tb_Input6.Clear();
            tb_Input7.Clear();
            tb_Input8.Clear();
            tb_Input9.Clear();
            tb_Input10.Clear();
            tb_Input1.Focus();
        }

        private void Input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

        

    
}
