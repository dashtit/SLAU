using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form // это код первой формы 
    {
        public Form1() //конструктор для инициалиализации элементов на формах
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // пустые ивенты для элементов формы -- пустые потому что они ничего не делают 
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // здесь мы нажимаем на кнопочку и переходим ко второй форме поэтому он не пустой
        {
            string pattern = @"^-?[0-9]";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" ||
                textBox12.Text == "" || textBox13.Text == "") // огромная проверка на то что все текстобоксы заполнены числами
            {
                MessageBox.Show("Введите все значения", "Поля с числовыми значениями пусты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Regex.IsMatch(textBox1.Text, pattern) && Regex.IsMatch(textBox2.Text, pattern) && Regex.IsMatch(textBox3.Text, pattern) &&
                Regex.IsMatch(textBox4.Text, pattern) && Regex.IsMatch(textBox5.Text, pattern) && Regex.IsMatch(textBox6.Text, pattern) && Regex.IsMatch(textBox7.Text, pattern) && 
                Regex.IsMatch(textBox8.Text, pattern) && Regex.IsMatch(textBox9.Text, pattern) && Regex.IsMatch(textBox10.Text, pattern) && Regex.IsMatch(textBox11.Text, pattern) &&
                Regex.IsMatch(textBox12.Text, pattern) && Regex.IsMatch(textBox13.Text, pattern))
                {
                Form2 form2 = new Form2(this); //создаем объект второй формы и передаем в него все что мы заполнили на ЭТОЙ форме (ТЕКУШЕЙ т.е. форма1)
                form2.Show();//открываем форму2
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Поля заполнены некорректно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
