
namespace FinalProject_DSA
{
    partial class Queues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_AddNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tb_DeleteNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lb_numbers = new System.Windows.Forms.ListBox();
            this.lbSelected_Items = new System.Windows.Forms.ListBox();
            this.lb_Arrival = new System.Windows.Forms.ListBox();
            this.btnNewParking = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Arrival = new System.Windows.Forms.Label();
            this.lb_Departure = new System.Windows.Forms.ListBox();
            this.tb_SearchDeparture = new System.Windows.Forms.TextBox();
            this.btnSearch_Departure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Departure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_AddNumber
            // 
            this.tb_AddNumber.Location = new System.Drawing.Point(26, 70);
            this.tb_AddNumber.Name = "tb_AddNumber";
            this.tb_AddNumber.ReadOnly = true;
            this.tb_AddNumber.Size = new System.Drawing.Size(162, 22);
            this.tb_AddNumber.TabIndex = 0;
            this.tb_AddNumber.Text = "ISK-1000";
            this.tb_AddNumber.TextChanged += new System.EventHandler(this.tb_AddNumber_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Enter Garage";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tb_DeleteNumber
            // 
            this.tb_DeleteNumber.Enabled = false;
            this.tb_DeleteNumber.Location = new System.Drawing.Point(26, 74);
            this.tb_DeleteNumber.Name = "tb_DeleteNumber";
            this.tb_DeleteNumber.ReadOnly = true;
            this.tb_DeleteNumber.Size = new System.Drawing.Size(162, 22);
            this.tb_DeleteNumber.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(26, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete License Plate";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lb_numbers
            // 
            this.lb_numbers.FormattingEnabled = true;
            this.lb_numbers.ItemHeight = 16;
            this.lb_numbers.Location = new System.Drawing.Point(384, 163);
            this.lb_numbers.Name = "lb_numbers";
            this.lb_numbers.Size = new System.Drawing.Size(214, 388);
            this.lb_numbers.TabIndex = 4;
            this.lb_numbers.SelectedIndexChanged += new System.EventHandler(this.lb_numbers_SelectedIndexChanged);
            // 
            // lbSelected_Items
            // 
            this.lbSelected_Items.FormattingEnabled = true;
            this.lbSelected_Items.ItemHeight = 16;
            this.lbSelected_Items.Location = new System.Drawing.Point(631, 163);
            this.lbSelected_Items.Name = "lbSelected_Items";
            this.lbSelected_Items.Size = new System.Drawing.Size(214, 388);
            this.lbSelected_Items.TabIndex = 5;
            // 
            // lb_Arrival
            // 
            this.lb_Arrival.FormattingEnabled = true;
            this.lb_Arrival.ItemHeight = 16;
            this.lb_Arrival.Location = new System.Drawing.Point(885, 163);
            this.lb_Arrival.Name = "lb_Arrival";
            this.lb_Arrival.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Arrival.Size = new System.Drawing.Size(197, 196);
            this.lb_Arrival.TabIndex = 6;
            // 
            // btnNewParking
            // 
            this.btnNewParking.Location = new System.Drawing.Point(29, 70);
            this.btnNewParking.Name = "btnNewParking";
            this.btnNewParking.Size = new System.Drawing.Size(113, 42);
            this.btnNewParking.TabIndex = 7;
            this.btnNewParking.Text = "New Parking";
            this.btnNewParking.UseVisualStyleBackColor = true;
            this.btnNewParking.Click += new System.EventHandler(this.btnNewParking_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(982, 405);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(100, 22);
            this.tb_Search.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(885, 393);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 47);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search Arrival";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Arrival:";
            // 
            // label_Arrival
            // 
            this.label_Arrival.AutoSize = true;
            this.label_Arrival.Location = new System.Drawing.Point(884, 502);
            this.label_Arrival.Name = "label_Arrival";
            this.label_Arrival.Size = new System.Drawing.Size(0, 17);
            this.label_Arrival.TabIndex = 11;
            // 
            // lb_Departure
            // 
            this.lb_Departure.FormattingEnabled = true;
            this.lb_Departure.ItemHeight = 16;
            this.lb_Departure.Location = new System.Drawing.Point(1128, 163);
            this.lb_Departure.Name = "lb_Departure";
            this.lb_Departure.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Departure.Size = new System.Drawing.Size(197, 196);
            this.lb_Departure.TabIndex = 12;
            // 
            // tb_SearchDeparture
            // 
            this.tb_SearchDeparture.Location = new System.Drawing.Point(1225, 403);
            this.tb_SearchDeparture.Name = "tb_SearchDeparture";
            this.tb_SearchDeparture.Size = new System.Drawing.Size(100, 22);
            this.tb_SearchDeparture.TabIndex = 13;
            // 
            // btnSearch_Departure
            // 
            this.btnSearch_Departure.Location = new System.Drawing.Point(1128, 390);
            this.btnSearch_Departure.Name = "btnSearch_Departure";
            this.btnSearch_Departure.Size = new System.Drawing.Size(91, 47);
            this.btnSearch_Departure.TabIndex = 14;
            this.btnSearch_Departure.Text = "Search Departure";
            this.btnSearch_Departure.UseVisualStyleBackColor = true;
            this.btnSearch_Departure.Click += new System.EventHandler(this.btnSearch_Departure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1125, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number of Departure:";
            // 
            // label_Departure
            // 
            this.label_Departure.AutoSize = true;
            this.label_Departure.Location = new System.Drawing.Point(1134, 502);
            this.label_Departure.Name = "label_Departure";
            this.label_Departure.Size = new System.Drawing.Size(0, 17);
            this.label_Departure.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "License plate of the arriving car:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "License plate of the departing car:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 46);
            this.label5.TabIndex = 19;
            this.label5.Text = "PARKING GARAGE SYSTEM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(594, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "* Click to let vehicles from the Temporary storage of vehicles enter the Single-l" +
    "ane Parking Garage again:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Single-lane Parking Garage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Temporary storage of vehicles:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(881, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "List of arriving vehicles:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1124, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "List of departing vehicles:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(23, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "*Click the button to generate a license plate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_AddNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 196);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arriving vehicles:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.tb_DeleteNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(28, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 218);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Departing vehicles:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(40, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Single-lane Parking Garage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(26, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "* Select a license plate from the ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewParking);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(28, 597);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 129);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // Queues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1357, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch_Departure);
            this.Controls.Add(this.tb_SearchDeparture);
            this.Controls.Add(this.lb_Departure);
            this.Controls.Add(this.label_Arrival);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_Arrival);
            this.Controls.Add(this.lbSelected_Items);
            this.Controls.Add(this.lb_numbers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Queues";
            this.Text = "Parking Garage - Queue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_AddNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tb_DeleteNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lb_numbers;
        private System.Windows.Forms.ListBox lbSelected_Items;
        private System.Windows.Forms.ListBox lb_Arrival;
        private System.Windows.Forms.Button btnNewParking;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Arrival;
        private System.Windows.Forms.ListBox lb_Departure;
        private System.Windows.Forms.TextBox tb_SearchDeparture;
        private System.Windows.Forms.Button btnSearch_Departure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Departure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

