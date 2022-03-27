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
    public partial class Queues : Form
    {
        private ParkingClass parking = new ParkingClass();
        public Queues()
        {
            InitializeComponent();
            parking = new ParkingClass();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String ID;

            ID = tb_AddNumber.Text;
            lb_numbers.Items.Add(String.Format(ID));
            lb_Arrival.Items.Add(String.Format(ID));

            tb_AddNumber.Clear();
            tb_AddNumber.Text = parking.ParkingGeneratedNumber("ISK-");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lb_numbers.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item.");
            }
            else
            {
                if (lb_numbers.SelectedIndex == 0)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                        tb_DeleteNumber.Clear();
                    }
                }
                else if (lb_numbers.SelectedIndex == 1)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 2)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }

                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 3)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 4)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 5)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                    lb_numbers.SetSelected(0, true);
                                    if (lb_numbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_numbers.Items.Remove(item);
                                            lbSelected_Items.Items.Add(item);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 6)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                    lb_numbers.SetSelected(0, true);
                                    if (lb_numbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_numbers.Items.Remove(item);
                                            lbSelected_Items.Items.Add(item);
                                        }
                                        lb_numbers.SetSelected(0, true);
                                        if (lb_numbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_numbers.Items.Remove(item);
                                                lbSelected_Items.Items.Add(item);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 7)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                    lb_numbers.SetSelected(0, true);
                                    if (lb_numbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_numbers.Items.Remove(item);
                                            lbSelected_Items.Items.Add(item);
                                        }
                                        lb_numbers.SetSelected(0, true);
                                        if (lb_numbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_numbers.Items.Remove(item);
                                                lbSelected_Items.Items.Add(item);
                                            }
                                            lb_numbers.SetSelected(0, true);
                                            if (lb_numbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_numbers.Items.Remove(item);
                                                    lbSelected_Items.Items.Add(item);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 8)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                    lb_numbers.SetSelected(0, true);
                                    if (lb_numbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_numbers.Items.Remove(item);
                                            lbSelected_Items.Items.Add(item);
                                        }
                                        lb_numbers.SetSelected(0, true);
                                        if (lb_numbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_numbers.Items.Remove(item);
                                                lbSelected_Items.Items.Add(item);
                                            }
                                            lb_numbers.SetSelected(0, true);
                                            if (lb_numbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_numbers.Items.Remove(item);
                                                    lbSelected_Items.Items.Add(item);
                                                }
                                                lb_numbers.SetSelected(0, true);
                                                if (lb_numbers.SelectedIndex == 0)
                                                {
                                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                    {
                                                        lb_numbers.Items.Remove(item);
                                                        lbSelected_Items.Items.Add(item);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
                else if (lb_numbers.SelectedIndex == 9)
                {
                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_numbers.Items.Remove(item);
                        lb_Departure.Items.Add(item);
                    }
                    lb_numbers.SetSelected(0, true);
                    if (lb_numbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_numbers.Items.Remove(item);
                            lbSelected_Items.Items.Add(item);
                        }
                        lb_numbers.SetSelected(0, true);
                        if (lb_numbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_numbers.Items.Remove(item);
                                lbSelected_Items.Items.Add(item);
                            }
                            lb_numbers.SetSelected(0, true);
                            if (lb_numbers.SelectedIndex == 0)
                            {

                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_numbers.Items.Remove(item);
                                    lbSelected_Items.Items.Add(item);
                                }
                                lb_numbers.SetSelected(0, true);
                                if (lb_numbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_numbers.Items.Remove(item);
                                        lbSelected_Items.Items.Add(item);
                                    }
                                    lb_numbers.SetSelected(0, true);
                                    if (lb_numbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_numbers.Items.Remove(item);
                                            lbSelected_Items.Items.Add(item);
                                        }
                                        lb_numbers.SetSelected(0, true);
                                        if (lb_numbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_numbers.Items.Remove(item);
                                                lbSelected_Items.Items.Add(item);
                                            }
                                            lb_numbers.SetSelected(0, true);
                                            if (lb_numbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_numbers.Items.Remove(item);
                                                    lbSelected_Items.Items.Add(item);
                                                }
                                                lb_numbers.SetSelected(0, true);
                                                if (lb_numbers.SelectedIndex == 0)
                                                {
                                                    foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                    {
                                                        lb_numbers.Items.Remove(item);
                                                        lbSelected_Items.Items.Add(item);
                                                    }
                                                    lb_numbers.SetSelected(0, true);
                                                    if (lb_numbers.SelectedIndex == 0)
                                                    {
                                                        foreach (string item in lb_numbers.SelectedItems.OfType<string>().ToList())
                                                        {
                                                            lb_numbers.Items.Remove(item);
                                                            lbSelected_Items.Items.Add(item);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tb_DeleteNumber.Clear();
                }
            }     
        }

        private void lb_numbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lb_numbers.SelectedIndex;
            if (index != -1)
            {
                tb_DeleteNumber.Text = lb_numbers.SelectedItem.ToString();
            }
        }

        private void btnNewParking_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSelected_Items.Items.Count; i++)
            {
                lb_numbers.Items.Add(lbSelected_Items.Items[i].ToString());
                lb_Arrival.Items.Add(lbSelected_Items.Items[i].ToString());
            }
            lbSelected_Items.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lb_Arrival.SelectedItems.Clear();

            for (int i = lb_Arrival.Items.Count - 1; i >= 0; i--)
            {
                if (lb_Arrival.Items[i].ToString().ToLower().Contains(tb_Search.Text.ToLower()))
                {
                    lb_Arrival.SetSelected(i, true);
                }
            }
            label_Arrival.Text = lb_Arrival.SelectedItems.Count.ToString() + " time/s";
        }

        private void btnSearch_Departure_Click(object sender, EventArgs e)
        {
            lb_Departure.SelectedItems.Clear();

            for (int i = lb_Departure.Items.Count - 1; i >= 0; i--)
            {
                if (lb_Departure.Items[i].ToString().ToLower().Contains(tb_SearchDeparture.Text.ToLower()))
                {
                    lb_Departure.SetSelected(i, true);
                }
            }
            label_Departure.Text = lb_Departure.SelectedItems.Count.ToString() + " time/s";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_AddNumber_TextChanged(object sender, EventArgs e)
        {
            if (tb_AddNumber.Text == "ISK-1010")
            {
                tb_AddNumber.Clear();
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
