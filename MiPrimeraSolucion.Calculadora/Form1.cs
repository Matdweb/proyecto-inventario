using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraSolucion.Calculadora
{
    public partial class Form1 : Form
    {
        int numeroUno = 0;
        int numeroDos = 0;
        int resultado = 0;
        string operacion = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "1";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "2";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numeroUno = int.Parse(cajaDeResultados.Text);
            cajaDeResultados.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numeroUno = int.Parse(cajaDeResultados.Text);
            cajaDeResultados.Text = "";
        }

        private void Sumar()
        {
            numeroDos = int.Parse(cajaDeResultados.Text);
            resultado = numeroUno + numeroDos;
            cajaDeResultados.Text = resultado.ToString();
        }

        private void Restar()
        {
            numeroDos = int.Parse(cajaDeResultados.Text);
            resultado = numeroUno - numeroDos;
            cajaDeResultados.Text = resultado.ToString();
        }

        private void Multiplicar()
        {
            numeroDos = int.Parse(cajaDeResultados.Text);
            resultado = numeroUno * numeroDos;
            cajaDeResultados.Text = resultado.ToString();
        }

        private void Dividir()
        {
            numeroDos = int.Parse(cajaDeResultados.Text);
            resultado = numeroUno / numeroDos;
            cajaDeResultados.Text = resultado.ToString();
        }

        private void botonTres_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "3";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "3";
            }
        }

        private void botonCuatro_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "4";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "4";
            }
        }

        private void botonCinco_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "5";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "5";
            }
        }

        private void botonSeis_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "6";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "6";
            }
        }

        private void botonSiete_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "7";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "7";
            }
        }

        private void botonOcho_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "8";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "8";
            }
        }

        private void botonNueve_Click(object sender, EventArgs e)
        {
            if (cajaDeResultados.Text == "0")
            {
                cajaDeResultados.Text = "9";
            }
            else
            {
                cajaDeResultados.Text = cajaDeResultados.Text + "9";
            }
        }

        private void botonCero_Click(object sender, EventArgs e)
        {
                cajaDeResultados.Text = cajaDeResultados.Text + "0";
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numeroUno = int.Parse(cajaDeResultados.Text);
            cajaDeResultados.Text = "";
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numeroUno = int.Parse(cajaDeResultados.Text);
            cajaDeResultados.Text = "";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    Sumar();
                    break;
                case "-":
                    Restar();
                    break;
                case "*":
                    Multiplicar();
                    break;
                case "/":
                    Dividir();
                    break;
            }
        }
    }
}
