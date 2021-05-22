using MethodsSLAU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public float[,] Matrix;
        public float E;
        public Form2(Form1 form)
        {
  
        InitializeComponent();
            Matrix = new float[3, 4]
                      {
                      {0, 0, 0, 0},
                      {0, 0, 0, 0},
                      {0, 0, 0, 0},
                      };
            Matrix[0, 0] = float.Parse(form.textBox1.Text);
            Matrix[0, 1] = float.Parse(form.textBox2.Text);
            Matrix[0, 2] = float.Parse(form.textBox3.Text);
            Matrix[0, 3] = float.Parse(form.textBox4.Text);
            Matrix[1, 0] = float.Parse(form.textBox5.Text);
            Matrix[1, 1] = float.Parse(form.textBox6.Text);
            Matrix[1, 2] = float.Parse(form.textBox7.Text);
            Matrix[1, 3] = float.Parse(form.textBox8.Text);
            Matrix[2, 0] = float.Parse(form.textBox9.Text);
            Matrix[2, 1] = float.Parse(form.textBox10.Text);
            Matrix[2, 2] = float.Parse(form.textBox11.Text);
            Matrix[2, 3] = float.Parse(form.textBox12.Text);
            E = float.Parse(form.textBox13.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SLAU Matr = new SLAU(Matrix, E);

            float[] x = Matr.MethZeygAndIter('i');
            for (int i = 0; i < x.Length; i++)
            {
               label3.Text = (x[0].ToString());
               label4.Text = (x[1].ToString());
               label5.Text = (x[2].ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
