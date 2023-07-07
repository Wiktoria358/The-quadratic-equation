using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rownanie_kwadratowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double delta;
            double x1, x2;
            double number;
            if (double.TryParse(textBox1.Text, out number))
                a = number; else a = 0;
            if (double.TryParse(textBox2.Text, out number))
                b = number; else b = 0;
            if (double.TryParse(textBox3.Text, out number))
                c = number; else c = 0;
            delta = (b * b) - 4 * a * c;
            if(delta < 0)
            {
                textBox4.Text = delta.ToString();
                textBox5.Text = "Brak rozwiazan";
                textBox6.Text = "Brak rozwiazan";
            }
            if(delta == 0)
            {
                x1 = (-b) / (2 * a);
                textBox4.Text = delta.ToString();
                textBox5.Text = x1.ToString();
            }
            if(delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                textBox4.Text = delta.ToString();
                textBox5.Text = x1.ToString();
                textBox6.Text = x2.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
