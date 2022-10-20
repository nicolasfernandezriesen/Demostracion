using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class FrmCaso4 : Form
    {
        public FrmCaso4()
        {
            InitializeComponent();
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            int Base = Convert.ToInt32(Interaction.InputBox("Ingrese la base de su rectangulo."));
            int altura = Convert.ToInt32(Interaction.InputBox("Ingrese la altura de su rectangulo"));

            double area = CalcularArea(Base, altura);

            MessageBox.Show("El area de su rectangulo es: " + area.ToString());
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            int diametro = Convert.ToInt32(Interaction.InputBox("Ingrese el diametro de su circulo"));

            double area = CalcularArea(diametro);

            MessageBox.Show("El area de su circulo es: " + area.ToString());
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            int baseSuperior = Convert.ToInt32(Interaction.InputBox("Ingrese la base superior de su trapecio"));
            int baseInferior = Convert.ToInt32(Interaction.InputBox("Ingrese la base inferior de su trapecio"));
            int altura = Convert.ToInt32(Interaction.InputBox("Ingrese la altura de su trapecio"));

            double area = CalcularArea(baseSuperior, baseInferior, altura);

            MessageBox.Show("El area de su trapecio es: " + area.ToString());
        }

        #region mis metodos

        private double CalcularArea(int Base, int altura)
        {
            double area = Base * altura;

            return area;
        }

        private double CalcularArea(int diametro)
        {
            int radio = diametro / 2;
            double area = 0;

            radio = radio * radio;
            area = 3.1416 * radio;

            return area;
        }

        private double CalcularArea(int baseSuperior, int baseInferior, int altura)
        {
            double area = 0;
            
            area = baseSuperior + baseInferior;
            area = area * altura;
            area = area / 2;

            return area;
        }


        #endregion

    }
}
