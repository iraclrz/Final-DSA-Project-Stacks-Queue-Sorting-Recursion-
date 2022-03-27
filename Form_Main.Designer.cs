
namespace FinalProject_DSA
{
    partial class Form_Main
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
            this.btn_Stacks = new System.Windows.Forms.Button();
            this.btn_Queues = new System.Windows.Forms.Button();
            this.btn_Sorting = new System.Windows.Forms.Button();
            this.btn_Recursion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Stacks
            // 
            this.btn_Stacks.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Stacks.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stacks.ForeColor = System.Drawing.Color.Snow;
            this.btn_Stacks.Location = new System.Drawing.Point(164, 144);
            this.btn_Stacks.Name = "btn_Stacks";
            this.btn_Stacks.Size = new System.Drawing.Size(197, 43);
            this.btn_Stacks.TabIndex = 0;
            this.btn_Stacks.Text = "STACKS";
            this.btn_Stacks.UseVisualStyleBackColor = false;
            this.btn_Stacks.Click += new System.EventHandler(this.btn_Stacks_Click);
            // 
            // btn_Queues
            // 
            this.btn_Queues.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Queues.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Queues.Location = new System.Drawing.Point(164, 198);
            this.btn_Queues.Name = "btn_Queues";
            this.btn_Queues.Size = new System.Drawing.Size(197, 43);
            this.btn_Queues.TabIndex = 1;
            this.btn_Queues.Text = "QUEUES";
            this.btn_Queues.UseVisualStyleBackColor = false;
            this.btn_Queues.Click += new System.EventHandler(this.btn_Queues_Click);
            // 
            // btn_Sorting
            // 
            this.btn_Sorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(142)))));
            this.btn_Sorting.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sorting.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Sorting.Location = new System.Drawing.Point(164, 252);
            this.btn_Sorting.Name = "btn_Sorting";
            this.btn_Sorting.Size = new System.Drawing.Size(197, 43);
            this.btn_Sorting.TabIndex = 2;
            this.btn_Sorting.Text = "SORTING";
            this.btn_Sorting.UseVisualStyleBackColor = false;
            this.btn_Sorting.Click += new System.EventHandler(this.btn_Sorting_Click);
            // 
            // btn_Recursion
            // 
            this.btn_Recursion.BackColor = System.Drawing.Color.Plum;
            this.btn_Recursion.Font = new System.Drawing.Font("Tahoma", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recursion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Recursion.Location = new System.Drawing.Point(164, 305);
            this.btn_Recursion.Name = "btn_Recursion";
            this.btn_Recursion.Size = new System.Drawing.Size(197, 43);
            this.btn_Recursion.TabIndex = 3;
            this.btn_Recursion.Text = "RECURSION";
            this.btn_Recursion.UseVisualStyleBackColor = false;
            this.btn_Recursion.Click += new System.EventHandler(this.btn_Recursion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = " You can choose a method here! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "- Lim, Mendoza, Morales - ";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(545, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Recursion);
            this.Controls.Add(this.btn_Sorting);
            this.Controls.Add(this.btn_Queues);
            this.Controls.Add(this.btn_Stacks);
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Main Methods Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Stacks;
        private System.Windows.Forms.Button btn_Queues;
        private System.Windows.Forms.Button btn_Sorting;
        private System.Windows.Forms.Button btn_Recursion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

