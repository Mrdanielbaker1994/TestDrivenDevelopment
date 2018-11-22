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

        }

        private void Side_A_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_A  = float.Parse(Side_Textbox_A.Text);
            MessageBox.Show(Triangles.Side_A.ToString());
        }
        //
        private void Side_B_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_B = float.Parse(Side_Textbox_B.Text);
            MessageBox.Show(Triangles.Side_B.ToString());
        }

        private void Side_C_TextChanged(object sender, EventArgs e)
        {
            Triangles.Side_C = float.Parse(Side_Textbox_C.Text);
            MessageBox.Show(Triangles.Side_C.ToString());
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
    }
}
