using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrivenDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void submitButton_click(object sender, EventArgs e)
        {
            Triangles.sum_of_angles = Triangles.Angle_AB + Triangles.Angle_BC + Triangles.Angle_CA;
            if(Triangles.sum_of_angles == 180)
            {
            Sum_Of_Angles_Box.Text = Triangles.sum_of_angles.ToString();

            Triangles.Area = Triangles.Side_A + Triangles.Side_B + Triangles.Side_C;
            SumOfSidesBox.Text = Triangles.Area.ToString();

            }
            else
            {
                MessageBox.Show("The sum of a triangle's angles may only equal 180 degrees.");
            }


        }


        private void Side_A_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_A  = float.Parse(Side_Textbox_A.Text);
            //MessageBox.Show(Triangles.Side_A.ToString());
        }
        
        private void Side_B_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_B = float.Parse(Side_Textbox_B.Text);
            //MessageBox.Show(Triangles.Side_B.ToString());
        }

        private void Side_C_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_C = float.Parse(Side_Textbox_C.Text);
            //MessageBox.Show(Triangles.Side_C.ToString());
        }

        private void Label_A_Click(object sender, EventArgs e)
        {

        }

        private void Label_B_Click(object sender, EventArgs e)
        {

        }

        private void Label_C_Click(object sender, EventArgs e)
        {

        }

        private void SumOfSides_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Angle_AB_TextChanged(object sender, EventArgs e)
        {
            Triangles.Angle_AB = float.Parse(AB_Box.Text);

        }
        private void Angle_BC__TextChanged(object sender, EventArgs e)
        {
            Triangles.Angle_BC = float.Parse(BC_Box.Text);

        }
        private void Angle_CA_TextChanged(object sender, EventArgs e)
        {
            Triangles.Angle_CA = float.Parse(CA_Box.Text);

        }

 
    }
}
