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
    public partial class FrmCaso8 : Form
    {
        Decimal[] precios = new Decimal[8];
        decimal suma = 0;

        public FrmCaso8()
        {
            InitializeComponent();
        }

        private void btnLoadPrec_Click(object sender, EventArgs e)
        {
            int aux = 1;

            for (int i = 0; i < 8; i++)
            {
                precios[i] = Convert.ToDecimal(Interaction.InputBox("Ingrese el precio del producto " + aux));
                aux++;
            }

            Suma();
            MessageBox.Show("La suma de los precios de sus productos da: " + suma.ToString());
        }

        private void Suma()
        {
            suma = 0;   

            foreach (decimal precio in precios)
            {
                suma += precio;
            }
        }

    }
}
