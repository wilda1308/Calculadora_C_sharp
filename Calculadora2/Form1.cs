using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1: Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if(txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            txtResultado.Text += boton.Text; 
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            if(operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == 'X')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if(operador == '/')
            {
                try
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }
                catch (DivideByZeroException)
                {
                    txtResultado.Text = "Sintaxis error";
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 0)
            {
                txtResultado.Text = "0";
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            operador = ' ';
            numero1 = 0;
            numero2 = 0;
            txtResultado.Text = "0";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            string separadorDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (!txtResultado.Text.Contains(separadorDecimal))
            {
                txtResultado.Text += separadorDecimal;
            }
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if(operador == '²')
            {
                numero1 = Math.Pow(numero1,2);
                txtResultado.Text = numero1.ToString();
            }
            else if(operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

    }
}
