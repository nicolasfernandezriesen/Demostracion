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
    public partial class FrmCaso11 : Form
    {
        struct Provincia
        {
            public string name;
            public decimal[] temp;
        }

        Provincia[] provincias; 
        public FrmCaso11()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            provincias = new Provincia[4];

            LoadProvincia();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal avg;
            foreach (Provincia provincia in provincias)
            {
                avg = AvgTemp(provincia.temp);
                MessageBox.Show("Nombre de la Provincia: " + provincia.name + ". Promedio de la temperatura: " + avg.ToString());
            }
        }

        private void btnMediaMayor_Click(object sender, EventArgs e)
        {
            Provincia provincia = AvgProncia();

            MessageBox.Show("Provincia con mayor temperatura media trimestral: " + provincia.name);
        }
        #region Method

        private void LoadProvincia()
        {
            for (int i = 0; i < 4; i++)
            {
                provincias[i].name = Interaction.InputBox("Ingrese el Nombre de la Provincia.", "Nombre de la Pronvincia");
                provincias[i].temp = new decimal[3];
                MessageBox.Show("Ingrese las las tres temperaturas medias mensuales.");
                for (int j = 0; j < 3; j++)
                {
                    provincias[i].temp[j] = Convert.ToDecimal(Interaction.InputBox((j+1) + " Temp", (j+1) + " Temp"));
                }
            }
        }

        private void Show()
        {
            foreach (var provincia in provincias)
            {
                MessageBox.Show("Nombre de la Provincia: " + provincia.name + Show(provincia.temp));
            }
        }

        private string Show(decimal[] temps)
        {
            string aux = "";

            foreach (decimal temp in temps)
            {
                aux =aux + temp + "C - ";
            }

            return aux;
        }

        private decimal AvgTemp(decimal[] temps)
        {
            decimal aux = 0;
            int i = 0;

            foreach (decimal temp in temps)
            {
                aux = aux + temp;
                i++;
            }

            aux = aux / i;

            return aux;
        }

        private Provincia AvgProncia()
        {
            Provincia aux = provincias[0];
            decimal avg = 0;

            foreach (Provincia provincia in provincias)
            {
                if (avg < AvgTemp(provincia.temp))
                {
                    avg = AvgTemp(provincia.temp);
                    aux = provincia;
                }
            }

            return aux;
        }

        #endregion

    }
}
