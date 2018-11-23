using System;
using System.Windows.Forms;

namespace TestDrivenDevelopment
{
    public partial class TriangleCalculator : Form
    {
        /*
         * 
        FUNCTION: TriangleCalculator()
        DESCRIPTION: This method is used to call
        InitializeCoponent() which is a method used to 
        support the forms Deisgner file.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        public TriangleCalculator()
        {

            InitializeComponent();
            ClearValues();
        }

        /*
        FUNCTION: getValues()
        DESCRIPTION: This method is used to attempt to
        grab the values from the form's text boxes. Since 
        not all text boxes have to have values, a try catch is used
        to ensure that there are not an crashes from try to cast an 
        emtpy string to a float.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        public void getValues()
        {
            try
            {
                Triangles.Angle_AB = float.Parse(AB_Box.Text);
                Triangles.Angle_BC = float.Parse(BC_Box.Text);
                Triangles.Angle_CA = float.Parse(CA_Box.Text);
                Triangles.Side_A = float.Parse(Side_Textbox_A.Text);
                Triangles.Side_B = float.Parse(Side_Textbox_B.Text);
                Triangles.Side_C = float.Parse(Side_Textbox_C.Text);


            }
            catch
            {

            }
        }

        /*
        FUNCTION: calculateSum()
        DESCRIPTION: This method is used to find the sum of
        the angles. It should equal 180, therefore this method is only
        called when it is determined that the triangle's angles equal 180 
        and ensure it is a right angle triangle. It is called if the method
        anglesInRnage() returns a bool of true.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        public void calculateSum()
        {
            Triangles.sum_of_angles = Triangles.Angle_AB + Triangles.Angle_BC + Triangles.Angle_CA;
            Sum_Of_Angles_Box.Text = Triangles.sum_of_angles.ToString();
        }


        /*
        FUNCTION: anglesInRange()
        DESCRIPTION: This method is used to determine
        if the sum of all angles equals 180 degrees and 
        also ensuring that t least one of the angles is 90 degrees
        so that we are working with a right angle triangle. Upon
        success this method returns true.
        PARAMETERS : VOID		
        RETURNS : bool
        Author: Daniel Baker
        */
        public bool anglesInRange()
        {
            bool retValue = false;
            Triangles.sum_of_angles = Triangles.Angle_AB + Triangles.Angle_BC + Triangles.Angle_CA;
            if (Triangles.sum_of_angles == 180 && Triangles.Angle_AB != 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA != 0)
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

                    calculateSum();
                   

                    retValue = true;

                }
                else if (Triangles.Angle_AB == 0 && Triangles.Angle_BC != 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_AB = 180 - Triangles.Angle_BC - Triangles.Angle_CA;
                    AB_Box.Text = Triangles.Angle_AB.ToString();
                    retValue = true;
                    calculateSum();



                }
                else if (Triangles.Angle_AB != 0 && Triangles.Angle_BC == 0 && Triangles.Angle_CA != 0)
                {
                    Triangles.Angle_BC = 180 - Triangles.Angle_AB - Triangles.Angle_CA;
                    BC_Box.Text = Triangles.Angle_BC.ToString();
                    retValue = true;

                    calculateSum();


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


        /*
        FUNCTION: validateSidesProvided()
        DESCRIPTION: This method is used to determine
        if at least 2 of the 3 sides is provided, which is required.
        If only 1 side is provided, the method returns a string "notProvided"
        which is used to stop further methods from executing. If all sides are
        provided a string is passed to determineIfRightAngle(). Or, if one side
        is not provided, the missing side is provided. This is because we have to isolate
        for this side, so it is important to know which sides is not provided.
        PARAMETERS : VOID		
        RETURNS : string
        Author: Daniel Baker
        */
        public string validateSidesProvided()
        {
            string retValue;
            if (Triangles.Side_A != 0 && Triangles.Side_B != 0 && Triangles.Side_C == 0)
            {
                retValue = "SideC";

            }
            else if (Triangles.Side_A == 0 && Triangles.Side_B != 0 && Triangles.Side_C != 0)
            {
                retValue = "SideA";

            }
            else if (Triangles.Side_A != 0 && Triangles.Side_B == 0 && Triangles.Side_C != 0)
            {
                retValue = "SideB";

            }
            else if (Triangles.Side_A != 0 && Triangles.Side_B != 0 && Triangles.Side_C != 0)
            {
                retValue = "allProvided";

            }       
            else
            {
            MessageBox.Show("Please provide at least 2 sides of the triangle.");
                retValue = "notProvided";
            }
            



            return retValue;
        }

        /*
        FUNCTION: This method is simply used to determine if
        the triangle is a right angle triangle. It must be a 
        right angle triangle.
        DESCRIPTION:
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        public void determineIfRightAngle(string emtpySide)
        {
            if (Triangles.Angle_BC == 90)
            {
                calculateSides("SideA", emtpySide);

            }
            else if (Triangles.Angle_CA == 90)
            {
                calculateSides("SideB", emtpySide);

            }
            else if(Triangles.Angle_AB == 90)
            {
                calculateSides("SideC", emtpySide);
            }
            else
            {
                MessageBox.Show("This calculator only works for right angle triangles.");
            }
        }

        void calculateSides(string hypotenuse , string emptySide)
        {
            
            if(emptySide == hypotenuse)
            {
                if(hypotenuse == "SideA")
                {
                    Triangles.areaOfTriangle = Triangles.Side_C * Triangles.Side_B * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                    float temp = (float)Math.Sqrt((float)Math.Pow(Triangles.Side_C, 2) + (float)Math.Pow(Triangles.Side_B, 2));
                    Triangles.Side_A = (float)(temp);
                    Side_Textbox_A.Text = Triangles.Side_A.ToString();

                }
                else if (hypotenuse == "SideB")
                {
                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();


                    float temp = (float)Math.Sqrt((float)Math.Pow(Triangles.Side_A, 2) + (float)Math.Pow(Triangles.Side_C, 2));
                    Triangles.Side_B = (float)(temp);
                    Side_Textbox_B.Text = Triangles.Side_B.ToString();


                }
                else if (hypotenuse == "SideC")
                {
                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_B * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();



                    float temp = (float)Math.Sqrt((float)Math.Pow(Triangles.Side_A, 2) + (float)Math.Pow(Triangles.Side_B, 2));
                    Triangles.Side_C = (temp);
                    Side_Textbox_C.Text = Triangles.Side_C.ToString();

                }

            }
            else if(emptySide == "SideA")
            {
                

                if(hypotenuse == "SideB")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_B, 2) - (float)Math.Pow(Triangles.Side_C, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_A = (isolateSide);
                    Side_Textbox_A.Text = Triangles.Side_A.ToString();

                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();



                }
                else if (hypotenuse == "SideC")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_C, 2) - (float)Math.Pow(Triangles.Side_B, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_A = (isolateSide);
                    Side_Textbox_A.Text = Triangles.Side_A.ToString();


                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_B * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();


                }






            }
            else if (emptySide == "SideB")
            {
                

                if (hypotenuse == "SideA")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_A, 2) - (float)Math.Pow(Triangles.Side_C, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_B = (isolateSide);
                    Side_Textbox_B.Text = Triangles.Side_B.ToString();


                    Triangles.areaOfTriangle = Triangles.Side_B * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }
                else if (hypotenuse == "SideC")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_C, 2) - (float)Math.Pow(Triangles.Side_A, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_B = (isolateSide);
                    Side_Textbox_B.Text = Triangles.Side_B.ToString();

                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }


            }
            else if (emptySide == "SideC")
            {

                if (hypotenuse == "SideA")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_A, 2) - (float)Math.Pow(Triangles.Side_B, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_C = (isolateSide);
                    Side_Textbox_C.Text = Triangles.Side_C.ToString();


                    Triangles.areaOfTriangle = Triangles.Side_B * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();


                }
                else if (hypotenuse == "SideB")
                {
                    float isolateSide = (float)Math.Sqrt(Math.Pow(Triangles.Side_B, 2) - (float)Math.Pow(Triangles.Side_A, 2));
                    float temp = (float)Math.Sqrt(isolateSide);
                    Triangles.Side_C = (isolateSide);
                    Side_Textbox_C.Text = Triangles.Side_C.ToString();


                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }

            }
            else
            {
                //all sides provided so simply find the hypoteneuse and use B*H*0.5
                if(hypotenuse == "SideA")
                {
                    Triangles.areaOfTriangle = Triangles.Side_B * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }
                else if (hypotenuse == "SideB")
                {
                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_C * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }
                else if (hypotenuse == "SideC")
                {
                    Triangles.areaOfTriangle = Triangles.Side_A * Triangles.Side_B * (float)0.5;
                    AreaOfTriangleBox.Text = Triangles.areaOfTriangle.ToString();

                }
            }







        }



        /*
        FUNCTION: submitButton_click()
        DESCRIPTION: This method handles the submit button
        click event. It is used to handle the flow of the program. First
        it gets the values from all the text boxes. It then calls anglesInRange()
        method. If it returns bool, then the program does not continue, since a 
        triangle must sum up to 180. This method is used as the puppet master, or
        in other words, control the flow of the program.fghjkl;'Lkjhgfd./;",fgdsaZXcv bnm,./";[po09875432qwasxcbn
        PARAMETERS : object sender, EventArgs e		
        RETURNS : VOID
        Author: Daniel Baker
        */
        private void submitButton_click(object sender, EventArgs e)
        {


            getValues();
            bool angleRetValue = anglesInRange();
            if (angleRetValue == true)
            {
                string sideRetValue = validateSidesProvided();
                if (sideRetValue != "notProvided")
                {
                    determineIfRightAngle(sideRetValue);

                }
                else
                {
                    ClearValues();
                }



            }
            else
            {
                ClearValues();
            }


            







        }
        public void ClearValues()
        {
            Triangles.Angle_AB = 0;
            Triangles.Angle_BC = 0;
            Triangles.Angle_CA = 0;
            Triangles.Side_A = 0;
            Triangles.Side_B = 0;
            Triangles.Side_C = 0;
            Triangles.areaOfTriangle = 0;
            Convert.ToInt32(AB_Box.Text = "0");
            Convert.ToInt32(BC_Box.Text = "0");
            Convert.ToInt32(CA_Box.Text = "0");
            Convert.ToInt32(Side_Textbox_A.Text = "0");
            Convert.ToInt32(Side_Textbox_B.Text = "0");
            Convert.ToInt32(Side_Textbox_C.Text = "0");
            Convert.ToInt32(Sum_Of_Angles_Box.Text = "0");
            Convert.ToInt32(AreaOfTriangleBox.Text = "0");

        }

        private void ClearValues_Click(object sender, EventArgs e)
        {
            ClearValues();



        }
    }
}
