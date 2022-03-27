
namespace FinalProject_DSA
{
    partial class Recursion
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_EnterNum = new System.Windows.Forms.Label();
            this.tb_FactorialAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Generate = new System.Windows.Forms.Button();
            this.tb_FactorialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_FibError = new System.Windows.Forms.Label();
            this.tb_FibAnswer = new System.Windows.Forms.TextBox();
            this.lbl_FibAnswer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_FibGenerate = new System.Windows.Forms.Button();
            this.bt_FibClear = new System.Windows.Forms.Button();
            this.tb_FibNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_EnterNum);
            this.groupBox1.Controls.Add(this.tb_FactorialAnswer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Clear);
            this.groupBox1.Controls.Add(this.bt_Generate);
            this.groupBox1.Controls.Add(this.tb_FactorialNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FACTORIAL";
            // 
            // lbl_EnterNum
            // 
            this.lbl_EnterNum.AutoSize = true;
            this.lbl_EnterNum.Location = new System.Drawing.Point(181, 66);
            this.lbl_EnterNum.Name = "lbl_EnterNum";
            this.lbl_EnterNum.Size = new System.Drawing.Size(0, 17);
            this.lbl_EnterNum.TabIndex = 6;
            // 
            // tb_FactorialAnswer
            // 
            this.tb_FactorialAnswer.Location = new System.Drawing.Point(185, 220);
            this.tb_FactorialAnswer.Name = "tb_FactorialAnswer";
            this.tb_FactorialAnswer.ReadOnly = true;
            this.tb_FactorialAnswer.Size = new System.Drawing.Size(195, 25);
            this.tb_FactorialAnswer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Factorial of the given number is:";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(157, 103);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(98, 33);
            this.bt_Clear.TabIndex = 3;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Generate
            // 
            this.bt_Generate.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Generate.Location = new System.Drawing.Point(297, 103);
            this.bt_Generate.Name = "bt_Generate";
            this.bt_Generate.Size = new System.Drawing.Size(98, 33);
            this.bt_Generate.TabIndex = 2;
            this.bt_Generate.Text = "Generate";
            this.bt_Generate.UseVisualStyleBackColor = true;
            this.bt_Generate.Click += new System.EventHandler(this.bt_Generate_Click);
            // 
            // tb_FactorialNumber
            // 
            this.tb_FactorialNumber.Location = new System.Drawing.Point(184, 42);
            this.tb_FactorialNumber.Name = "tb_FactorialNumber";
            this.tb_FactorialNumber.Size = new System.Drawing.Size(195, 25);
            this.tb_FactorialNumber.TabIndex = 1;
            this.tb_FactorialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FactorialNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter any number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "RECURSION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_FibError);
            this.groupBox2.Controls.Add(this.tb_FibAnswer);
            this.groupBox2.Controls.Add(this.lbl_FibAnswer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bt_FibGenerate);
            this.groupBox2.Controls.Add(this.bt_FibClear);
            this.groupBox2.Controls.Add(this.tb_FibNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(568, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 347);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FIBONACCI SEQUENCE";
            // 
            // lbl_FibError
            // 
            this.lbl_FibError.AutoSize = true;
            this.lbl_FibError.Location = new System.Drawing.Point(209, 74);
            this.lbl_FibError.Name = "lbl_FibError";
            this.lbl_FibError.Size = new System.Drawing.Size(0, 17);
            this.lbl_FibError.TabIndex = 12;
            // 
            // tb_FibAnswer
            // 
            this.tb_FibAnswer.Location = new System.Drawing.Point(209, 220);
            this.tb_FibAnswer.Name = "tb_FibAnswer";
            this.tb_FibAnswer.ReadOnly = true;
            this.tb_FibAnswer.Size = new System.Drawing.Size(195, 25);
            this.tb_FibAnswer.TabIndex = 11;
            // 
            // lbl_FibAnswer
            // 
            this.lbl_FibAnswer.AutoSize = true;
            this.lbl_FibAnswer.Location = new System.Drawing.Point(206, 184);
            this.lbl_FibAnswer.Name = "lbl_FibAnswer";
            this.lbl_FibAnswer.Size = new System.Drawing.Size(0, 17);
            this.lbl_FibAnswer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fibonacci Series:";
            // 
            // bt_FibGenerate
            // 
            this.bt_FibGenerate.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FibGenerate.Location = new System.Drawing.Point(337, 103);
            this.bt_FibGenerate.Name = "bt_FibGenerate";
            this.bt_FibGenerate.Size = new System.Drawing.Size(98, 33);
            this.bt_FibGenerate.TabIndex = 8;
            this.bt_FibGenerate.Text = "Generate";
            this.bt_FibGenerate.UseVisualStyleBackColor = true;
            this.bt_FibGenerate.Click += new System.EventHandler(this.bt_FibGenerate_Click);
            // 
            // bt_FibClear
            // 
            this.bt_FibClear.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FibClear.Location = new System.Drawing.Point(176, 103);
            this.bt_FibClear.Name = "bt_FibClear";
            this.bt_FibClear.Size = new System.Drawing.Size(98, 33);
            this.bt_FibClear.TabIndex = 7;
            this.bt_FibClear.Text = "Clear";
            this.bt_FibClear.UseVisualStyleBackColor = true;
            this.bt_FibClear.Click += new System.EventHandler(this.bt_FibClear_Click);
            // 
            // tb_FibNumber
            // 
            this.tb_FibNumber.Location = new System.Drawing.Point(212, 42);
            this.tb_FibNumber.Name = "tb_FibNumber";
            this.tb_FibNumber.Size = new System.Drawing.Size(195, 25);
            this.tb_FibNumber.TabIndex = 7;
            this.tb_FibNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FibNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter any number:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Recursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1111, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Recursion";
            this.Text = "Recursion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FactorialAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Generate;
        private System.Windows.Forms.TextBox tb_FactorialNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_EnterNum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tb_FibNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_FibAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_FibGenerate;
        private System.Windows.Forms.Button bt_FibClear;
        private System.Windows.Forms.TextBox tb_FibAnswer;
        private System.Windows.Forms.Label lbl_FibError;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

