using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);
            decimal promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            decimal mayorNota = Math.Max(Math.Max(nota1, nota2), Math.Max(nota3, nota4));

            string mensaje = "";

            if (promedio >= 9)
            {
                mensaje = "Excelente.";
                MensajeNota(mayorNota, promedio, mensaje);
            } 
            else if (promedio < 9 && promedio >= 7)
            {
                mensaje = "Muy bien.";
                MensajeNota(mayorNota, promedio, mensaje);
            }
            else if (promedio < 7 && promedio >= 4)
            {
                mensaje = "Regular.";
                MensajeNota(mayorNota, promedio, mensaje);
            }
            else
            {
                mensaje = "En proceso de aprendizaje.";
                MensajeNota(mayorNota, promedio, mensaje);
            }
        }

        private void MensajeNota(decimal notaMayor, decimal promedio, string mensaje)
        {
            MessageBox.Show("Tu mayor nota ingresada es " + notaMayor + " , tu promedio es " + promedio + " " + mensaje);

        }
    }
}
