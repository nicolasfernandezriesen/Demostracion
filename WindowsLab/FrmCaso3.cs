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
    public partial class FrmCaso3 : Form
    {
        public FrmCaso3()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);

            Tabla(numero);
        }

        #region metodos

        private void Tabla(int num)
        {
            int result = 0;

            for (int i = 0; i < 13; i++)
            {
                result = num * i;

                MessageBox.Show(num.ToString() + " * " + i.ToString() + " = " + result.ToString());
            }
        }

        #endregion
    }
}
