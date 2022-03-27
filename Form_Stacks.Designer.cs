
namespace FinalProject_DSA
{
    partial class Form_Stacks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AddPlateNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DeletePlateNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewParking = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_SelectedPlateNumbers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_AddedPlateNumbers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Departure = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_SearchDeparture = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Arrival = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_SearchArrival = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Departure = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Arrival = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARKING GARAGE SYSTEM\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click to enter car plate number:\r\n";
            // 
            // tb_AddPlateNumber
            // 
            this.tb_AddPlateNumber.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddPlateNumber.Location = new System.Drawing.Point(42, 38);
            this.tb_AddPlateNumber.Name = "tb_AddPlateNumber";
            this.tb_AddPlateNumber.ReadOnly = true;
            this.tb_AddPlateNumber.Size = new System.Drawing.Size(122, 33);
            this.tb_AddPlateNumber.TabIndex = 2;
            this.tb_AddPlateNumber.Text = "ISK-1000";
            this.tb_AddPlateNumber.TextChanged += new System.EventHandler(this.tb_AddPlateNumber_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdd.Location = new System.Drawing.Point(57, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Enter Garage";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_AddPlateNumber);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 128);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_DeletePlateNumber);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 136);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Plate numbers of Departing Car:\r\n";
            // 
            // tb_DeletePlateNumber
            // 
            this.tb_DeletePlateNumber.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DeletePlateNumber.Location = new System.Drawing.Point(42, 39);
            this.tb_DeletePlateNumber.Name = "tb_DeletePlateNumber";
            this.tb_DeletePlateNumber.Size = new System.Drawing.Size(122, 33);
            this.tb_DeletePlateNumber.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.Location = new System.Drawing.Point(57, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Liscens Plate";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnNewParking);
            this.panel3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 81);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Click to let cars enter again";
            // 
            // btnNewParking
            // 
            this.btnNewParking.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNewParking.Location = new System.Drawing.Point(41, 41);
            this.btnNewParking.Name = "btnNewParking";
            this.btnNewParking.Size = new System.Drawing.Size(123, 31);
            this.btnNewParking.TabIndex = 3;
            this.btnNewParking.Text = "New Parking ";
            this.btnNewParking.UseVisualStyleBackColor = false;
            this.btnNewParking.Click += new System.EventHandler(this.btnNewParking_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lb_SelectedPlateNumbers);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lb_AddedPlateNumbers);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(238, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 356);
            this.panel4.TabIndex = 6;
            // 
            // lb_SelectedPlateNumbers
            // 
            this.lb_SelectedPlateNumbers.BackColor = System.Drawing.Color.DimGray;
            this.lb_SelectedPlateNumbers.FormattingEnabled = true;
            this.lb_SelectedPlateNumbers.ItemHeight = 25;
            this.lb_SelectedPlateNumbers.Location = new System.Drawing.Point(148, 67);
            this.lb_SelectedPlateNumbers.Name = "lb_SelectedPlateNumbers";
            this.lb_SelectedPlateNumbers.Size = new System.Drawing.Size(110, 254);
            this.lb_SelectedPlateNumbers.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(139, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 50);
            this.label6.TabIndex = 3;
            this.label6.Text = "Temporary Storage \r\nof Cars:";
            // 
            // lb_AddedPlateNumbers
            // 
            this.lb_AddedPlateNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lb_AddedPlateNumbers.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_AddedPlateNumbers.FormattingEnabled = true;
            this.lb_AddedPlateNumbers.ItemHeight = 25;
            this.lb_AddedPlateNumbers.Location = new System.Drawing.Point(18, 67);
            this.lb_AddedPlateNumbers.Name = "lb_AddedPlateNumbers";
            this.lb_AddedPlateNumbers.Size = new System.Drawing.Size(110, 254);
            this.lb_AddedPlateNumbers.TabIndex = 2;
            this.lb_AddedPlateNumbers.SelectedIndexChanged += new System.EventHandler(this.lb_AddedPlateNumbers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Single-Lane\r\nParking Garage:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label_Departure);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.tb_SearchDeparture);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label_Arrival);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.tb_SearchArrival);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.lb_Departure);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lb_Arrival);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(521, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 356);
            this.panel5.TabIndex = 7;
            // 
            // label_Departure
            // 
            this.label_Departure.AutoSize = true;
            this.label_Departure.BackColor = System.Drawing.Color.LightGray;
            this.label_Departure.Location = new System.Drawing.Point(171, 300);
            this.label_Departure.Name = "label_Departure";
            this.label_Departure.Size = new System.Drawing.Size(20, 25);
            this.label_Departure.TabIndex = 12;
            this.label_Departure.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Number of Departure:";
            // 
            // tb_SearchDeparture
            // 
            this.tb_SearchDeparture.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_SearchDeparture.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_SearchDeparture.Location = new System.Drawing.Point(160, 190);
            this.tb_SearchDeparture.Name = "tb_SearchDeparture";
            this.tb_SearchDeparture.Size = new System.Drawing.Size(139, 33);
            this.tb_SearchDeparture.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(160, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Search Departure:";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Arrival
            // 
            this.label_Arrival.AutoSize = true;
            this.label_Arrival.BackColor = System.Drawing.Color.LightGray;
            this.label_Arrival.Location = new System.Drawing.Point(23, 300);
            this.label_Arrival.Name = "label_Arrival";
            this.label_Arrival.Size = new System.Drawing.Size(20, 25);
            this.label_Arrival.TabIndex = 8;
            this.label_Arrival.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Number of Arrival:";
            // 
            // tb_SearchArrival
            // 
            this.tb_SearchArrival.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_SearchArrival.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_SearchArrival.Location = new System.Drawing.Point(17, 190);
            this.tb_SearchArrival.Name = "tb_SearchArrival";
            this.tb_SearchArrival.Size = new System.Drawing.Size(118, 33);
            this.tb_SearchArrival.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(17, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search Arrival";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Departure
            // 
            this.lb_Departure.BackColor = System.Drawing.Color.DimGray;
            this.lb_Departure.FormattingEnabled = true;
            this.lb_Departure.ItemHeight = 25;
            this.lb_Departure.Location = new System.Drawing.Point(167, 42);
            this.lb_Departure.Name = "lb_Departure";
            this.lb_Departure.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Departure.Size = new System.Drawing.Size(120, 129);
            this.lb_Departure.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(155, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "List of Departing Cars:";
            // 
            // lb_Arrival
            // 
            this.lb_Arrival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lb_Arrival.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Arrival.FormattingEnabled = true;
            this.lb_Arrival.ItemHeight = 25;
            this.lb_Arrival.Location = new System.Drawing.Point(17, 42);
            this.lb_Arrival.Name = "lb_Arrival";
            this.lb_Arrival.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Arrival.Size = new System.Drawing.Size(118, 129);
            this.lb_Arrival.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "List of Arriving Cars:";
            // 
            // Form_Stacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(3)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(851, 484);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Stacks";
            this.Text = "Stacks Form -Parking Garage-";
            this.Load += new System.EventHandler(this.Form_Stacks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_AddPlateNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DeletePlateNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewParking;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lb_SelectedPlateNumbers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_AddedPlateNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lb_Departure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_Arrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Departure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_SearchDeparture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Arrival;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_SearchArrival;
        private System.Windows.Forms.Button button1;
    }
}

