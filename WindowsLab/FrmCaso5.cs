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
    public partial class FrmCaso5 : Form
    {
        public FrmCaso5()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = Convert.ToString(txtNameUser.Text);
            string genero = Convert.ToString(txtGeneroUser.Text);
            string rol = Convert.ToString(txtRolUser.Text);

            int flag = ValidarDatos(genero, rol);  

            if (flag == 1)
            {
                Mensaje("ERROR EN LA VALIDACION DE DATOS. REVISELSO.");
            }
            else
            {
                if (genero.ToLower() == "f")
                {
                    genero = "Femenino";
                }
                else
                {
                    genero = "Masculino";
                }

                string mensaje = "Usuario: " + username + " - Genero: " + genero + " - Rol: " + rol;
                Mensaje(mensaje);
            }
        }

        private int ValidarDatos(string genero, string rol)
        {
            int flag = 1;

            if (genero.ToLower() == "m" || genero.ToLower() == "f")
            {
                flag = 0;
            }

            if (rol.ToLower() == "administrador" || rol.ToLower() == "estandar" || rol.ToLower() == "invitados")
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }

            return flag;
        }

        private void Mensaje(string message)
        {
            MessageBox.Show(message);
        }
    }
}
