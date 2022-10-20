using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Metodos

        private int calcularAreaRectangulo (int basse, int altura)
        {
            int areaRectangulo = basse * altura;

            return areaRectangulo;
        }

        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int Base = Convert.ToInt32(txtBase.Text);
            int altura = Convert.ToInt32(txtAltura.Text);

            int areaRectangulo = CalcularAreaRectangulo(Base, altura);

            MessageBox.Show("El area de su rectangulo es " + areaRectangulo);
        }

        #region metodos

        private int CalcularAreaRectangulo (int Base, int altura)
        {
            int areaRectangulo = Base * altura;
            
            return areaRectangulo;
        }

        #endregion  
    }
}
