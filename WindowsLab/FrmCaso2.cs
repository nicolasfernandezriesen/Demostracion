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
    public partial class FrmCaso2 : Form
    {
        public FrmCaso2()
        {
            InitializeComponent();
        }

       private void btnEdad_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);
            int flag = 0;

            flag = indenEdad(edad);

            while (flag == 1)
            {
                edad = Convert.ToInt32(Interaction.InputBox("Ingrese su edad"));
                flag = indenEdad(edad);
            }
        }

        #region metodos
        private int indenEdad(int edad)
        {
            int flag = 0;

            if(edad <= 0)
            {
                MessageBox.Show("ERROR");

                flag = 1;
            }
            else if(edad < 18)
            {
                MessageBox.Show("Usted es menor de edad");

            }
            else if (edad >= 18 && edad < 60)
            {
                MessageBox.Show("Usted es mayor de edad");
            }
            else if (edad >= 60 )
            {
                MessageBox.Show("Usted es adulto mayor");
            }

            return flag;
        }
        #endregion
    }
}
