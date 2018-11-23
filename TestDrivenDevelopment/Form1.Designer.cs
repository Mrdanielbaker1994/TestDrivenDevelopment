namespace TestDrivenDevelopment
{
    partial class TriangleCalculator
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
            System.Windows.Forms.Label Area_of_Triangle;
            this.Side_Textbox_A = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Side_Textbox_B = new System.Windows.Forms.TextBox();
            this.Side_Textbox_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AreaOfTriangleBox = new System.Windows.Forms.TextBox();
            this.Angle_AB_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CA_Box = new System.Windows.Forms.TextBox();
            this.BC_Box = new System.Windows.Forms.TextBox();
            this.AB_Box = new System.Windows.Forms.TextBox();
            this.Sum_Of_Angles_Box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            Area_of_Triangle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Area_of_Triangle
            // 
            Area_of_Triangle.AutoSize = true;
            Area_of_Triangle.Location = new System.Drawing.Point(565, 72);
            Area_of_Triangle.Name = "Area_of_Triangle";
            Area_of_Triangle.Size = new System.Drawing.Size(165, 25);
            Area_of_Triangle.TabIndex = 10;
            Area_of_Triangle.Text = "Area of Triangle";
            // 
            // Side_Textbox_A
            // 
            this.Side_Textbox_A.Location = new System.Drawing.Point(70, 129);
            this.Side_Textbox_A.Name = "Side_Textbox_A";
            this.Side_Textbox_A.Size = new System.Drawing.Size(131, 31);
            this.Side_Textbox_A.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submitButton_click);
            // 
            // Side_Textbox_B
            // 
            this.Side_Textbox_B.Location = new System.Drawing.Point(227, 129);
            this.Side_Textbox_B.Name = "Side_Textbox_B";
            this.Side_Textbox_B.Size = new System.Drawing.Size(131, 31);
            this.Side_Textbox_B.TabIndex = 4;
            // 
            // Side_Textbox_C
            // 
            this.Side_Textbox_C.Location = new System.Drawing.Point(382, 129);
            this.Side_Textbox_C.Name = "Side_Textbox_C";
            this.Side_Textbox_C.Size = new System.Drawing.Size(129, 31);
            this.Side_Textbox_C.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Side B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Side C";
            // 
            // AreaOfTriangleBox
            // 
            this.AreaOfTriangleBox.Location = new System.Drawing.Point(570, 129);
            this.AreaOfTriangleBox.Name = "AreaOfTriangleBox";
            this.AreaOfTriangleBox.Size = new System.Drawing.Size(136, 31);
            this.AreaOfTriangleBox.TabIndex = 9;
            // 
            // Angle_AB_Label
            // 
            this.Angle_AB_Label.AutoSize = true;
            this.Angle_AB_Label.Location = new System.Drawing.Point(56, 201);
            this.Angle_AB_Label.Name = "Angle_AB_Label";
            this.Angle_AB_Label.Size = new System.Drawing.Size(101, 25);
            this.Angle_AB_Label.TabIndex = 11;
            this.Angle_AB_Label.Text = "Angle AB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Angle BC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Angle CA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sum of Angles";
            // 
            // CA_Box
            // 
            this.CA_Box.Location = new System.Drawing.Point(392, 267);
            this.CA_Box.Name = "CA_Box";
            this.CA_Box.Size = new System.Drawing.Size(119, 31);
            this.CA_Box.TabIndex = 17;
            // 
            // BC_Box
            // 
            this.BC_Box.Location = new System.Drawing.Point(218, 267);
            this.BC_Box.Name = "BC_Box";
            this.BC_Box.Size = new System.Drawing.Size(131, 31);
            this.BC_Box.TabIndex = 18;
            // 
            // AB_Box
            // 
            this.AB_Box.Location = new System.Drawing.Point(61, 267);
            this.AB_Box.Name = "AB_Box";
            this.AB_Box.Size = new System.Drawing.Size(131, 31);
            this.AB_Box.TabIndex = 20;
            // 
            // Sum_Of_Angles_Box
            // 
            this.Sum_Of_Angles_Box.Location = new System.Drawing.Point(570, 267);
            this.Sum_Of_Angles_Box.Name = "Sum_Of_Angles_Box";
            this.Sum_Of_Angles_Box.Size = new System.Drawing.Size(131, 31);
            this.Sum_Of_Angles_Box.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 53);
            this.button2.TabIndex = 22;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearValues_Click);
            // 
            // TriangleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sum_Of_Angles_Box);
            this.Controls.Add(this.AB_Box);
            this.Controls.Add(this.BC_Box);
            this.Controls.Add(this.CA_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Angle_AB_Label);
            this.Controls.Add(Area_of_Triangle);
            this.Controls.Add(this.AreaOfTriangleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Side_Textbox_C);
            this.Controls.Add(this.Side_Textbox_B);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Side_Textbox_A);
            this.Name = "TriangleCalculator";
            this.Text = "Triangle Calculator";
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
        private System.Windows.Forms.TextBox AreaOfTriangleBox;
        private System.Windows.Forms.Label Angle_AB_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CA_Box;
        private System.Windows.Forms.TextBox BC_Box;
        private System.Windows.Forms.TextBox AB_Box;
        private System.Windows.Forms.TextBox Sum_Of_Angles_Box;
        private System.Windows.Forms.Button button2;
    }
}

