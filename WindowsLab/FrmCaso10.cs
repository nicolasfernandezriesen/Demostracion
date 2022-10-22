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
    public partial class FrmCaso10 : Form
    {
        string[] nombres;
        int[] edades;
        public FrmCaso10()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            nombres = new string[5];
            edades = new int[5];

            LoadArray();
            ShowArrayAdults();
        }

        private void LoadArray()
        {
            for (int i = 0; i < 5; i++)
            { 
                nombres[i] = Interaction.InputBox("Ingrese el nombre de la persona","Nombre de la Persona");
                edades[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la edad de " + nombres[i], "Edad de la Persona"));
            }
        }

        private void ShowArrayAdults()
        {
            string adults = "";
            
            for (int i = 0; i < 5; i++)
            {
                if (edades[i] >= 18)
                {
                    adults = adults + nombres[i] + " - ";
                }
            }

            MessageBox.Show("Personas mayores de edad: " + adults);
        }
    }
}
