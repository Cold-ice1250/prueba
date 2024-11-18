using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_formulario_con_controles_basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double v1, v2, suma, resta, multiplica, divide;

            v1 = Convert.ToDouble (textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);


            suma = v1 + v2;
            resta = v1 - v2;
            multiplica = v1 * v2;
            divide = v1 / v2;


            textBox3.Text = suma.ToString();
            textBox4.Text = resta.ToString();
            textBox5.Text = multiplica.ToString();
            textBox6.Text = divide.ToString();
        }
    }
}
