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
    public partial class FrmCaso7 : Form
    {
        string[] alumnos = new string[4];
        int[] notaAlumn = new int[3];
        int notaMax = 0;
        int promedio = 0;
        string promedioMensaje = "";

        public FrmCaso7()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            LoadAlumno();

            LoadNotas();
        }

        #region mis metodos

        private void LoadAlumno()
        {
            for (int i = 0; i < 4; i++)
            {
                alumnos[i] = Convert.ToString(Interaction.InputBox("Ingrese el nombre del alumno " + i.ToString()));
            }
        }

        private void LoadNotas()
        {
            foreach (string alumno in alumnos)
            {
                for (int i = 0; i < 3; i++)
                {
                    notaAlumn[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la nota " + i.ToString() + " del alumno " + alumno));

                }

                NotaMax();
                Promedio();

                MessageBox.Show("Alumno: " + alumno + ". Su nota maxima: " + notaMax.ToString() + " y su promedio es: " + promedio.ToString() + promedioMensaje);
            }
        }

        private void NotaMax()
        {
            notaMax = 0;    

            foreach(int nota in notaAlumn)
            {
                if (nota > notaMax)
                {
                    notaMax = nota;
                }
            } 
        }

        private void Promedio()
        {
            promedio = 0;

            foreach (int nota in notaAlumn)
            {
                promedio += nota;
            }

            promedio = promedio / 3;

            if (promedio < 4)
            {
                promedioMensaje = " debe ir a recuperatorio.";
            }
            else if(promedio >= 4 && promedio < 7)
            {
                promedioMensaje = " bien.";
            }
            else if(promedio >= 7)
            {
                promedioMensaje = " muy bien.";
            }
        }

        #endregion
    }
}
