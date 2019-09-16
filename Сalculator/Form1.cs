using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0,
               b = 0,
               c = 0;
        char sign = ' ';

        private void Button0_Click(object sender, EventArgs e)  //вывод на экран символов
        {
            scren.Text += (sender as Button).Text;
        }

        private void Button10_Click(object sender, EventArgs e) //метод присвоения переменной и определения знака
        {
           
            a = double.Parse(scren.Text);
            sign = (sender as Button).Text[0];
            scren.Clear();

        }

        private void Button16_Click(object sender, EventArgs e) //матем операции
        {
            b = double.Parse(scren.Text);

            switch (sign)
            {
                case '+':
                    c = a + b;
                    break;

                case '-':
                    if (a > b)
                    {
                        c = a - b;
                    }
                    else
                    {
                        c = a - b;
                        scren.Text = '-' + scren.Text;
                    }
                    break;

                case '*':
                    c = a * b;
                    break;

                case '/':
                    c = a / b;
                    break;

                case '^':
                    c = Math.Pow(a, b);
                    break;
            }
            scren.Text = c.ToString();
        }

        private void Button18_Click(object sender, EventArgs e) //удаление последнего элемента строки 
        {
            if (scren.Text != "")
            {
                scren.Text = scren.Text.Remove(scren.Text.Length - 1, 1);
            }
        }

        private void Button17_Click(object sender, EventArgs e) // реализация оператора смены знака 
        {
            if (scren.Text != "")
            {
                if (scren.Text[0] == '-')
                {
                    scren.Text = scren.Text.Remove(0, 1);
                }
                else
                {
                    scren.Text = '-' + scren.Text;
                }
            }
        }

        private void Scren_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e) // очистка строки
        {
            scren.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
