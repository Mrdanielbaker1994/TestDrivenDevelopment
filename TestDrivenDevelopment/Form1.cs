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
            try
            {
            Triangles.Angle_AB = float.Parse(AB_Box.Text);
            Triangles.Angle_BC = float.Parse(BC_Box.Text);
            Triangles.Angle_CA = float.Parse(CA_Box.Text);
            Triangles.Side_A  = float.Parse(Side_Textbox_A.Text);
            Triangles.Side_C = float.Parse(Side_Textbox_C.Text);
            Triangles.Side_C = float.Parse(Side_Textbox_C.Text);


            }
            catch
            {

            }







            Triangles.sum_of_angles = Triangles.Angle_AB + Triangles.Angle_BC + Triangles.Angle_CA;
            if(Triangles.sum_of_angles == 180)
            {
                Sum_Of_Angles_Box.Text = Triangles.sum_of_angles.ToString();

                Triangles.Area = Triangles.Side_A + Triangles.Side_B + Triangles.Side_C;
                AreaOfTriangle.Text = Triangles.Area.ToString();

            }
            else if(Triangles.sum_of_angles < 180)
            {
                if(Triangles.Angle_AB != 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA == 0)
                {
                    Triangles.Angle_CA = 180 - Triangles.Angle_AB - Triangles.Angle_BC;
                    CA_Box.Text = Triangles.Angle_CA.ToString();
                }
                else if (Triangles.Angle_AB == 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_AB = 180 - Triangles.Angle_BC - Triangles.Angle_CA;
                    AB_Box.Text = Triangles.Angle_AB.ToString();


                }
                else if (Triangles.Angle_AB != 0 && Triangles.Angle_BC == 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_BC = 180 - Triangles.Angle_AB - Triangles.Angle_CA;
                    BC_Box.Text = Triangles.Angle_BC.ToString();


                }
                else
                {
                    MessageBox.Show("You must enter at least two angles.");

                }

            }
            else
            {
                MessageBox.Show("The sum of a triangle's angles may only equal 180 degrees.");
            }


        }

        private void AreaOfTriangle_Click(object sender, EventArgs e)
        {

        }
    }
}
