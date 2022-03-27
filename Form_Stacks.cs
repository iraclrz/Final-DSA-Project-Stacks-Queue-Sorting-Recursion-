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
   
    public partial class Form_Stacks : Form
    {
        private ParkingClass parking = new ParkingClass();
        public Form_Stacks()
        {
            InitializeComponent();
            parking = new ParkingClass();
        }
        class ParkingClass
        {
            private int x;
            public static string getNumberInStack = "";
            public static Stack<string> Stacks_Parking;

            public ParkingClass()
            {
                x = 1000;
                Stacks_Parking = new Stack<string>();
            }

            public string ParkingGeneratedNumber(string ParkingNumber)
            {
                x++;
                ParkingNumber = ParkingNumber + x.ToString();
                return ParkingNumber;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //FILO = First in, Last out
            string ID;
            ID = tb_AddPlateNumber.Text;
            lb_AddedPlateNumbers.Items.Insert(0, String.Format(ID));
            lb_Arrival.Items.Insert(0, String.Format(ID));
            tb_AddPlateNumber.Clear();

            tb_AddPlateNumber.Text = parking.ParkingGeneratedNumber("ISK-");
        }
        private void tb_AddPlateNumber_TextChanged(object sender, EventArgs e)
        {
            if (tb_AddPlateNumber.Text == "ISK-1010")
            {
                tb_AddPlateNumber.Clear();
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lb_AddedPlateNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item.");
            }
            else
            {
                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                        tb_DeletePlateNumber.Clear();
                        //lb_AddedPlateNumbers.Enabled = false;
                    }
                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 1)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0,item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                       foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                       {
                           lb_AddedPlateNumbers.Items.Remove(item);
                           lb_SelectedPlateNumbers.Items.Insert(0, item);
                       }          
                    }

                    tb_DeletePlateNumber.Clear();
                    //lb_AddedPlateNumbers.Enabled = false;
                    

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 2)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 3)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                            }
                        }
                    }
                    
                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 4)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                }
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 5)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                    //5
                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_AddedPlateNumbers.Items.Remove(item);
                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 6)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                    //5
                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_AddedPlateNumbers.Items.Remove(item);
                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                                        }
                                        //6
                                        lb_AddedPlateNumbers.SetSelected(0, true);
                                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_AddedPlateNumbers.Items.Remove(item);
                                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 7)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                    //5
                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_AddedPlateNumbers.Items.Remove(item);
                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                                        }
                                        //6
                                        lb_AddedPlateNumbers.SetSelected(0, true);
                                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_AddedPlateNumbers.Items.Remove(item);
                                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                                            }
                                            //7
                                            lb_AddedPlateNumbers.SetSelected(0, true);
                                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_AddedPlateNumbers.Items.Remove(item);
                                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 8)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0, item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                    //5
                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_AddedPlateNumbers.Items.Remove(item);
                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                                        }
                                        //6
                                        lb_AddedPlateNumbers.SetSelected(0, true);
                                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_AddedPlateNumbers.Items.Remove(item);
                                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                                            }
                                            //7
                                            lb_AddedPlateNumbers.SetSelected(0, true);
                                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_AddedPlateNumbers.Items.Remove(item);
                                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                                }
                                                //8
                                                lb_AddedPlateNumbers.SetSelected(0, true);
                                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                                {
                                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                    {
                                                        lb_AddedPlateNumbers.Items.Remove(item);
                                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
                else if (lb_AddedPlateNumbers.SelectedIndex == 9)
                {
                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                    {
                        lb_AddedPlateNumbers.Items.Remove(item);
                        lb_Departure.Items.Insert(0,item);
                    }
                    //1
                    lb_AddedPlateNumbers.SetSelected(0, true);
                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                    {
                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                        {
                            lb_AddedPlateNumbers.Items.Remove(item);
                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                        }
                        //2
                        lb_AddedPlateNumbers.SetSelected(0, true);
                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                        {
                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                            {
                                lb_AddedPlateNumbers.Items.Remove(item);
                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                            }
                            //3
                            lb_AddedPlateNumbers.SetSelected(0, true);
                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                            {
                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                {
                                    lb_AddedPlateNumbers.Items.Remove(item);
                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                }
                                //4
                                lb_AddedPlateNumbers.SetSelected(0, true);
                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                {
                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                    {
                                        lb_AddedPlateNumbers.Items.Remove(item);
                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                    }
                                    //5
                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                    {
                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                        {
                                            lb_AddedPlateNumbers.Items.Remove(item);
                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
                                        }
                                        //6
                                        lb_AddedPlateNumbers.SetSelected(0, true);
                                        if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                        {
                                            foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                            {
                                                lb_AddedPlateNumbers.Items.Remove(item);
                                                lb_SelectedPlateNumbers.Items.Insert(0, item);
                                            }
                                            //7
                                            lb_AddedPlateNumbers.SetSelected(0, true);
                                            if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                            {
                                                foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                {
                                                    lb_AddedPlateNumbers.Items.Remove(item);
                                                    lb_SelectedPlateNumbers.Items.Insert(0, item);
                                                }
                                                //8
                                                lb_AddedPlateNumbers.SetSelected(0, true);
                                                if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                                {
                                                    foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                    {
                                                        lb_AddedPlateNumbers.Items.Remove(item);
                                                        lb_SelectedPlateNumbers.Items.Insert(0, item);
                                                    }
                                                    //9
                                                    lb_AddedPlateNumbers.SetSelected(0, true);
                                                    if (lb_AddedPlateNumbers.SelectedIndex == 0)
                                                    {
                                                        foreach (string item in lb_AddedPlateNumbers.SelectedItems.OfType<string>().ToList())
                                                        {
                                                            lb_AddedPlateNumbers.Items.Remove(item);
                                                            lb_SelectedPlateNumbers.Items.Insert(0, item);
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

                    tb_DeletePlateNumber.Clear();
                    tb_AddPlateNumber.ReadOnly = true;

                }
            }
        }

        private void lb_AddedPlateNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lb_AddedPlateNumbers.SelectedIndex;
            if (index != -1)
            {
                tb_DeletePlateNumber.Text = lb_AddedPlateNumbers.SelectedItem.ToString();
            }
        }

        private void btnNewParking_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb_SelectedPlateNumbers.Items.Count; i++)
            {
                lb_AddedPlateNumbers.Items.Insert(0, lb_SelectedPlateNumbers.Items[i].ToString());
                lb_Arrival.Items.Insert(0, lb_SelectedPlateNumbers.Items[i].ToString());
            }
            lb_SelectedPlateNumbers.Items.Clear();
            lb_AddedPlateNumbers.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lb_Arrival.SelectedItems.Clear();

            for (int i = lb_Arrival.Items.Count - 1; i >= 0; i--)
            {
                if (lb_Arrival.Items[i].ToString().ToLower().Contains(tb_SearchArrival.Text.ToLower()))
                {
                    lb_Arrival.SetSelected(i, true);
                }
            }
            label_Arrival.Text = lb_Arrival.SelectedItems.Count.ToString() + " times";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_Departure.SelectedItems.Clear();

            for (int i = lb_Departure.Items.Count - 1; i >= 0; i--)
            {
                if (lb_Departure.Items[i].ToString().ToLower().Contains(tb_SearchDeparture.Text.ToLower()))
                {
                    lb_Departure.SetSelected(i, true);
                }
            }
            label_Departure.Text = lb_Departure.SelectedItems.Count.ToString() + " times";
        }

        private void Form_Stacks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Stacks_Load(object sender, EventArgs e)
        {

        }
    }

}
