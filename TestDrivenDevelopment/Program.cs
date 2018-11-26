/*
* FILE :Program.cs
* PROJECT : Assignment 2 - Software Quality
* PROGRAMMER :Daniel Baker
* FIRST VERSION :2018-11-21
* DESCRIPTION : This file contains the static methods that
* are used tu support the the Test Driven Development project.
* These static methods are used so that the program can store
* the Triagnles's angles, area, and sides lengths. I elected
* to use static methods since this object does not require
* instantiation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrivenDevelopment
{


    static public class Triangles
    {
        //static methods used to support the Triangle calculations on the Form

        static public float Area { get; set; }            = 0;
        static public float Side_A { get; set; }          = 0;
        static public float Side_B { get; set; }          = 0;
        static public float Side_C { get; set; }          = 0;
        static public float Angle_AB { get; set; }        = 0;
        static public float Angle_BC { get; set; }        = 0;
        static public float Angle_CA { get; set; }        = 0;
        static public float sum_of_angles { get; set; }   = 0;
        static public float heightOfTriangle { get; set;} = 0;
        static public float areaOfTriangle { get; set; }  = 0;




        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TriangleCalculator());
        }
    }
}
