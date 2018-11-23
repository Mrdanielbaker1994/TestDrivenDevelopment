using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrivenDevelopment
{


    static public class Triangles
    {

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
