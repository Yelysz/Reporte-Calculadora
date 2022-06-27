using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double valor1 = 0, valor2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultados.Text == "0")
                txtResultados.Text = "";

            txtResultados.Text += boton.Text;
        }


        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            valor1 = Convert.ToDouble(txtResultados.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                valor1 = Math.Pow(valor1, 2);
                txtResultados.Text = valor1.ToString();
            }
            else if (Operador == '√')
            {
                valor1 = Math.Sqrt(valor1);
                txtResultados.Text = valor1.ToString();
            }
            else if (Operador == '%')
            {
                valor1 = valor1*100;
                txtResultados.Text = valor1.ToString();
            }
            else
            {
                txtResultados.Text = "0";
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 1)
            {
                txtResultados.Text = txtResultados.Text.Substring(0, txtResultados.Text.Length - 1);
            }
            else
            {
                txtResultados.Text = "0";
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            Operador = '\0';
            txtResultados.Text = "0";
        }

        private void buttonBorrarM_Click(object sender, EventArgs e)
        {
            txtResultados.Text = "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultados.Text.Contains("."))
            {
                txtResultados.Text += ".";
            }
        }

        private void buttonPN_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtResultados.Text);
            valor1 *= -1;
            txtResultados.Text = valor1.ToString();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtResultados.Text);

            if (Operador == '+')
            {
                txtResultados.Text = (valor1 + valor2).ToString();
                valor1 = Convert.ToDouble(txtResultados.Text);
            }
            else if (Operador == '‒')
            {
                txtResultados.Text = (valor1 - valor2).ToString();
                valor1 = Convert.ToDouble(txtResultados.Text);
            }
            else if (Operador == '*')
            {
                txtResultados.Text = (valor1 * valor2).ToString();
                valor1 = Convert.ToDouble(txtResultados.Text);
            }
            else if (Operador == '÷')
            {
                if (txtResultados.Text != "0")
                {
                    txtResultados.Text = (valor1 / valor2).ToString();
                    valor1 = Convert.ToDouble(txtResultados.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }

        }



    }
}
