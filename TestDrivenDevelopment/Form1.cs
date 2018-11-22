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

        public void getValues()
        {
            try
            {
                Triangles.Angle_AB = float.Parse(AB_Box.Text);
                Triangles.Angle_BC = float.Parse(BC_Box.Text);
                Triangles.Angle_CA = float.Parse(CA_Box.Text);
                Triangles.Side_A = float.Parse(Side_Textbox_A.Text);
                Triangles.Side_C = float.Parse(Side_Textbox_C.Text);
                Triangles.Side_C = float.Parse(Side_Textbox_C.Text);


            }
            catch
            {

            }
        }
        public bool anglesInRange()
        {
            bool retValue = false;
            Triangles.sum_of_angles = Triangles.Angle_AB + Triangles.Angle_BC + Triangles.Angle_CA;
            if (Triangles.sum_of_angles == 180)
            {
                Sum_Of_Angles_Box.Text = Triangles.sum_of_angles.ToString();


                retValue = true;
            }
            else if (Triangles.sum_of_angles < 180)
            {
                if (Triangles.Angle_AB != 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA == 0)
                {
                    Triangles.Angle_CA = 180 - Triangles.Angle_AB - Triangles.Angle_BC;
                    CA_Box.Text = Triangles.Angle_CA.ToString();
                    retValue = true;

                }
                else if (Triangles.Angle_AB == 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_AB = 180 - Triangles.Angle_BC - Triangles.Angle_CA;
                    AB_Box.Text = Triangles.Angle_AB.ToString();
                    retValue = true;



                }
                else if (Triangles.Angle_AB != 0 && Triangles.Angle_BC == 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_BC = 180 - Triangles.Angle_AB - Triangles.Angle_CA;
                    BC_Box.Text = Triangles.Angle_BC.ToString();
                    retValue = true;



                }
                else
                {
                    MessageBox.Show("You must enter at least two angles.");
                    retValue = false;


                }

            }
            else
            {
                MessageBox.Show("The sum of a triangle's angles may only equal 180 degrees.");
                retValue = false;

            }
            return retValue;
        }

        public bool validateSidesProvided()
        {
            bool retValue = false;
            if (Triangles.Side_A != 0 && Triangles.Side_B != 0 && Triangles.Side_C != 0)
            {
                retValue = true;

            }
            else
            {
                retValue = false;

            }
            return retValue;
        }

        public void determineIfRightAngle()
        {
            if(Triangles.Angle_AB == 90)
            {

            }
            else if (Triangles.Angle_BC == 90)
            {

            }
            else if (Triangles.Angle_CA == 90)
            {

            }
            else
            {

            }
        }



        private void submitButton_click(object sender, EventArgs e)
        {


            getValues();
            bool angeRetValue = anglesInRange();
            bool sideRetValue = validateSidesProvided();
            determineIfRightAngle();
            







        }

   
    }
}
