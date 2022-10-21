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
    public partial class FrmCaso9 : Form
    {
        string[] operators = new string[4];
        decimal[] salary = new decimal[3];
        decimal total = 0;
        decimal salaryMax=0;
        string operatorName;

        public FrmCaso9()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadOperators();

            foreach (string name in operators)
            {
                LoadSalary(name);
                ShowSalary(name);
            }

            MessageBox.Show("Total de sueldos pagados: " + total.ToString() + "Operador con mayor ingresos acumulados: " + operatorName);
        }

        #region My Methods

        private void LoadOperators()
        {
            for (int i = 0; i < 4; i++)
            {
                operators[i] = Interaction.InputBox("Ingrese el nombre del operador " + (i + 1) + ": ");
            }
        }

        private void LoadSalary(string name)
        {
            decimal aux = 0;

            for (int i = 0; i < 3; i++)
            {
                salary[i] = Convert.ToDecimal(Interaction.InputBox("Ingrese el salario numero " + (i+1) + " del operador " + name));
                aux = aux + salary[i];
                total = total + salary[i];
            }
            if(aux > salaryMax)
            {
                salaryMax = aux;
                operatorName = name;
            }
        }

        private void ShowSalary(string name)
        {
            decimal aux = 0;

            foreach (decimal num in salary)
            {
                aux = aux + num;
            }

            MessageBox.Show("Operador " + name + " salario total a pagarle: " + aux.ToString());
        }

        #endregion
    }
}
