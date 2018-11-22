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
            Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(5, 192);
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
            // Sum
            // 
            Sum.AutoSize = true;
            Sum.Location = new System.Drawing.Point(543, 70);
            Sum.Name = "Sum";
            Sum.Size = new System.Drawing.Size(55, 25);
            Sum.TabIndex = 10;
            Sum.Text = "Sum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

