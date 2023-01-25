using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables
            //decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            //decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            //decimal resultado = numero1 + numero2;
            decimal resultado = Convert.ToDecimal(Numero1TextBox.Text) + Convert.ToDecimal(Numero2TextBox.Text);

            string valor1 = Numero1TextBox.Text;

            ResultadoLabel.Text = Convert.ToString(resultado);

            //MessageBox.Show("La suma es: " + resultado);



        }
    }
}
