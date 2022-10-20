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
    public partial class FrmCaso6 : Form
    {
        public FrmCaso6()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(txtFirstName.Text);
            string lastName = Convert.ToString(txtLastName.Text);
            DateTime birthDate = Convert.ToDateTime(dateTimeBirhtDate.Text);

            ShowData(firstName, lastName, birthDate);
        }

        private void ShowData(string firstName, string lastName)
        {
            MessageBox.Show(firstName + ", " + lastName);
        }
       
        private void ShowData(string firstName, string lastName, DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int year = today.Year - birthDate.Year;

            MessageBox.Show(firstName + ", " + lastName + " tiene " + year.ToString() + " años.");
        }
    }
}
