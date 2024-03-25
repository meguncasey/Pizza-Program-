using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_to_celsius_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCelsius_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double C;
            double F;
            F = double.Parse(txtFahrenheit.Text);
            C = 5.0 / 9.0 * (F - 32);
            lblCelsius.Text = C.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCelsius.Text = "";
            txtFahrenheit.Text = "";
            txtFahrenheit.Focus(); 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
