/*
* FILE :UnitTest1.cs
* PROJECT : Assignment 2 - Software Quality
* PROGRAMMER :Daniel Baker
* FIRST VERSION :2018-11-21
* DESCRIPTION : This file contains the methods necessary to
* to these the Triangles class (Program.cs) This file makes use of
* the Assert.AreEqual method to ensure that the return values of the
* methods meets the expected return value.
*/
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /*
        Test Method: Solved_1()
        DESCRIPTION: Tested to see if the program saves
        and displays the values for side A, B and C of the 
        triangle.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_1()
        {
            // Arrange
            float valueEquals1 = 1;
           
                Triangles.Side_A = 1;
                Triangles.Side_B = 1;
                Triangles.Side_C = 1;
                Triangles.Angle_AB = 1;
                Triangles.Angle_BC = 1;
                Triangles.Angle_CA = 1;


            // Act
            try
            {
                Assert.AreEqual(Triangles.Side_A, 1);
                Assert.AreEqual(Triangles.Side_B, valueEquals1);
                Assert.AreEqual(Triangles.Side_C, valueEquals1);
                Assert.AreEqual(Triangles.Angle_AB, valueEquals1);
                Assert.AreEqual(Triangles.Angle_BC, valueEquals1);
                Assert.AreEqual(Triangles.Angle_CA, valueEquals1);

            }
            catch
            {
                throw new InvalidOperationException();



            }



        }
        /*
        Test Method: Solved_2()
        DESCRIPTION: Tested to find and display the 
        summation of side A, B and C  in a textbox by 
        pressing the submit button.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_2()
        {
            // Arrange
            float sideA = 1;
            float sideB = 1;
            float sideC = 1;
            float expectedResult = 3;

            // Act
            try
            {
                TriangleCalculator test = new TriangleCalculator();
                float returnValue = test.sumOfSides(sideA, sideB, sideC);
                Assert.AreEqual(returnValue, expectedResult);


            }
            catch
            {
                throw new InvalidOperationException();



            }
        }
        /*
        Test Method: Solved_3()
        DESCRIPTION: Tests to see if the programs finds the sum 
        of all the angles when the submit button is hit.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_3()
        {
            // Arrange
            float A = 60;
            float B = 60;
            float C = 60;
            float expectedResult = 180;


            // Act
            try
            {
                TriangleCalculator test = new TriangleCalculator();
                float retValue = test.calculateSumTest(A, B, C);
                Assert.AreEqual(retValue, expectedResult);

            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
        /*
        Test Method: Solved_4()
        DESCRIPTION: Check to see that the program
        does not allow the sum of  angle
        AB, BC and CA, to equal a value other than 180
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_4()
        {
            // Arrange
                Triangles.sum_of_angles = 300;
                TriangleCalculator test = new TriangleCalculator();
                bool retValue = test.anglesInRange();

            // Act
            try
            {
                Assert.AreEqual(retValue, false);
            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
        /*
        Test Method: Solved_5()
        DESCRIPTION: Test to see when entering 2 of the 3 required angles, 
        the program  automatically calculate the value of the missing angle.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_5()
        {
            // Arrange
            TriangleCalculator test = new TriangleCalculator();
            string retValue = test.validateSidesProvided();

            // Act
            try
            {
                Assert.AreEqual(retValue, "notProvided");
            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
        /*
        Test Method: Solved_6()
        DESCRIPTION: Tests to see if the program is able to determine 
        if the triangle contains a right angle.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_6()
        {
            // Arrange
            TriangleCalculator test = new TriangleCalculator();
            string sideA = "irrelevantToThisTest";
            string retValue = test.determineIfRightAngle(sideA);

            // Act
            try
            {
                Assert.AreEqual(retValue, "rightAngleTrianglesOnly");
            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
        /*
        Test Method: Solved_7()
        DESCRIPTION: Test to see if the program is able
        to calculate the hypotenuse of the triangle.
              This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_7()
        {
            // Arrange
            TriangleCalculator test = new TriangleCalculator();
            float retValue = test.calculateSides("SideA", "SideA");
            float expected = 5;


            // Act
            try
            {
            Triangles.Side_B = 3;
            Triangles.Side_C = 4;
                Assert.AreEqual(retValue, expected);
            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
        /*
        Test Method: Solved_8()
        DESCRIPTION: Test to see if the program
        is able to calculate the area of the triable.
        This method made use of the Assert.AreEqual
        which checks to see if our known value equals
        an expected value. If it does not, we know the
        method does not behave as expected.
        PARAMETERS : VOID		
        RETURNS : VOID
        Author: Daniel Baker
        */
        [TestMethod]
        public void Solved_8()
        {
            // Arrange
            TriangleCalculator test = new TriangleCalculator();
            float retValue = test.calculateSides("SideA", "SideA");
            float expected = Triangles.areaOfTriangle;


            // Act
            try
            {
                Triangles.Side_B = 3;
                Triangles.Side_C = 4;
                Assert.AreEqual(6, expected);
            }
            catch
            {
                throw new InvalidOperationException();

            }
        }
    }
}
