namespace TestDrivenDevelopment
{
    partial class Form1
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
            System.Windows.Forms.Label Sum;
            this.Side_Textbox_A = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Side_Textbox_B = new System.Windows.Forms.TextBox();
            this.Side_Textbox_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SumOfSidesBox = new System.Windows.Forms.TextBox();
            this.Angle_AB_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CA_Box = new System.Windows.Forms.TextBox();
            this.BC_Box = new System.Windows.Forms.TextBox();
            this.AB_Box = new System.Windows.Forms.TextBox();
            this.Sum_Of_Angles_Box = new System.Windows.Forms.TextBox();
            Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sum
            // 
            Sum.AutoSize = true;
            Sum.Location = new System.Drawing.Point(530, 70);
            Sum.Name = "Sum";
            Sum.Size = new System.Drawing.Size(130, 25);
            Sum.TabIndex = 10;
            Sum.Text = "Area of Sum";
            // 
            // Side_Textbox_A
            // 
            this.Side_Textbox_A.Location = new System.Drawing.Point(5, 127);
            this.Side_Textbox_A.Name = "Side_Textbox_A";
            this.Side_Textbox_A.Size = new System.Drawing.Size(131, 31);
            this.Side_Textbox_A.TabIndex = 0;
            this.Side_Textbox_A.TextChanged += new System.EventHandler(this.Side_A_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submitButton_click);
            // 
            // Side_Textbox_B
            // 
            this.Side_Textbox_B.Location = new System.Drawing.Point(162, 127);
            this.Side_Textbox_B.Name = "Side_Textbox_B";
            this.Side_Textbox_B.Size = new System.Drawing.Size(131, 31);
            this.Side_Textbox_B.TabIndex = 4;
            this.Side_Textbox_B.TextChanged += new System.EventHandler(this.Side_B_TextChanged);
            // 
            // Side_Textbox_C
            // 
            this.Side_Textbox_C.Location = new System.Drawing.Point(317, 127);
            this.Side_Textbox_C.Name = "Side_Textbox_C";
            this.Side_Textbox_C.Size = new System.Drawing.Size(131, 31);
            this.Side_Textbox_C.TabIndex = 5;
            this.Side_Textbox_C.TextChanged += new System.EventHandler(this.Side_C_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side A";
            this.label1.Click += new System.EventHandler(this.Label_A_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Side B";
            this.label2.Click += new System.EventHandler(this.Label_B_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Side C";
            this.label3.Click += new System.EventHandler(this.Label_C_Click);
            // 
            // SumOfSidesBox
            // 
            this.SumOfSidesBox.Location = new System.Drawing.Point(531, 127);
            this.SumOfSidesBox.Name = "SumOfSidesBox";
            this.SumOfSidesBox.Size = new System.Drawing.Size(110, 31);
            this.SumOfSidesBox.TabIndex = 9;
            this.SumOfSidesBox.TextChanged += new System.EventHandler(this.SumOfSides_TextChanged);
            // 
            // Angle_AB_Label
            // 
            this.Angle_AB_Label.AutoSize = true;
            this.Angle_AB_Label.Location = new System.Drawing.Point(3, 199);
            this.Angle_AB_Label.Name = "Angle_AB_Label";
            this.Angle_AB_Label.Size = new System.Drawing.Size(101, 25);
            this.Angle_AB_Label.TabIndex = 11;
            this.Angle_AB_Label.Text = "Angle AB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Angle BC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Angle CA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sum of Angles";
            // 
            // CA_Box
            // 
            this.CA_Box.Location = new System.Drawing.Point(327, 265);
            this.CA_Box.Name = "CA_Box";
            this.CA_Box.Size = new System.Drawing.Size(119, 31);
            this.CA_Box.TabIndex = 17;
            this.CA_Box.TextChanged += new System.EventHandler(this.Angle_CA_TextChanged);
            // 
            // BC_Box
            // 
            this.BC_Box.Location = new System.Drawing.Point(153, 265);
            this.BC_Box.Name = "BC_Box";
            this.BC_Box.Size = new System.Drawing.Size(131, 31);
            this.BC_Box.TabIndex = 18;
            this.BC_Box.TextChanged += new System.EventHandler(this.Angle_BC__TextChanged);
            // 
            // AB_Box
            // 
            this.AB_Box.Location = new System.Drawing.Point(-4, 265);
            this.AB_Box.Name = "AB_Box";
            this.AB_Box.Size = new System.Drawing.Size(131, 31);
            this.AB_Box.TabIndex = 20;
            this.AB_Box.TextChanged += new System.EventHandler(this.Angle_AB_TextChanged);
            // 
            // Sum_Of_Angles_Box
            // 
            this.Sum_Of_Angles_Box.Location = new System.Drawing.Point(505, 265);
            this.Sum_Of_Angles_Box.Name = "Sum_Of_Angles_Box";
            this.Sum_Of_Angles_Box.Size = new System.Drawing.Size(131, 31);
            this.Sum_Of_Angles_Box.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sum_Of_Angles_Box);
            this.Controls.Add(this.AB_Box);
            this.Controls.Add(this.BC_Box);
            this.Controls.Add(this.CA_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Angle_AB_Label);
            this.Controls.Add(Sum);
            this.Controls.Add(this.SumOfSidesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Side_Textbox_C);
            this.Controls.Add(this.Side_Textbox_B);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Side_Textbox_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Side_Textbox_A;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Side_Textbox_B;
        private System.Windows.Forms.TextBox Side_Textbox_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumOfSidesBox;
        private System.Windows.Forms.Label Angle_AB_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CA_Box;
        private System.Windows.Forms.TextBox BC_Box;
        private System.Windows.Forms.TextBox AB_Box;
        private System.Windows.Forms.TextBox Sum_Of_Angles_Box;
    }
}

