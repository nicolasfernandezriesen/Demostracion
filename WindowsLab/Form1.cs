﻿using System;
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
    }
}
