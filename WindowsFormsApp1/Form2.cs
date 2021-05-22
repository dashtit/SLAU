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
    public partial class Form2 : Form //это код втрой формы
    {
        public float[,] Matrix; // создаем матрицу
        public float E; //и переменную отвечающую за точность
        public Form2(Form1 form) //контруктор формы2 здесь мы инициализируем матрицу значениями из текстбоксов формы1 которую передали в параметр конструктора
        {
  
        InitializeComponent();
            Matrix = new float[3, 4]; // матрица 3х4
                      
            Matrix[0, 0] = float.Parse(form.textBox1.Text); //в каждый элемент матрицы запихиваем значение из текстобкса
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
            SLAU Matr = new SLAU(Matrix, E); //тут создаем объект класса СЛАУ где будет считаться система и передаем туда нашу матрицу и точность

            float[] x = Matr.MethZeygAndIter('i'); // вызываем функцию которая будет считать методом итераций и передаем флаг i чтобы обозначить метод итераций
            for (int i = 0; i < x.Length; i++) // это цикл вывода полученных ответов на форму 2
            {
               label3.Text = (x[0].ToString()); // в каждйы лэйбл засовываем наш ответ
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
