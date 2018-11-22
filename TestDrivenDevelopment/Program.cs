using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrivenDevelopment
{


    static public class Triangles
    {

        static public float Area { get; set; }
        static public float Side_A { get; set; }
        static public float Side_B { get; set; }
        static public float Side_C { get; set; }
        static public float Angle_AB { get; set; }
        static public float Angle_BC { get; set; }
        static public float Angle_CA { get; set; }
        static public float sum_of_angles { get; set; }



        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
