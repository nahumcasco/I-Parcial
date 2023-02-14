using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace IParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        List<Coche> listaCoches = new List<Coche>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio;
            if (PrecioTextBox.Text == string.Empty)
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(PrecioTextBox.Text);
            }

            int km = KilometrosTextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            miCoche = new Coche();

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;

            listaCoches.Add(miCoche);

            CochesDataGridView.DataSource = null;
            CochesDataGridView.DataSource = listaCoches;
            LimpiarControles();
            MarcaTextBox.Focus();
            //MessageBox.Show("Objeto Coche -> Marca:" + miCoche.Marca + " Modelo: " + miCoche.Modelo);
        }

        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Text = string.Empty;
            PrecioTextBox.Text = "";
            KilometrosTextBox.Clear();
        }

        private void Ejercicio9_Activated(object sender, EventArgs e)
        {
            MarcaTextBox.Focus();
        }
    }
}
