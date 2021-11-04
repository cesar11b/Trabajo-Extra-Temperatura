using Infrastructure.Cuadro_T;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformacion_de_grados
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

        private void rbCelcius_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            string ingdat = txtingdat.Text;
            double ungrado = 1;
            double celfar = 33.8;
            double celkel = 74.15;

            double farcel = -17.2222;
            double farkel = 255.928;

            double kelcel = -272.15;
            double kelfar = -457.87;


          

            CuadroT cuadroT = new CuadroT();

            if(rbCelcius.Checked && rbCelciusSal.Checked==true)
            {

                Console.WriteLine("No se ve la necesidad para convertir grados celcius a grados celcius");

            }

            if (rbFahrenheit.Checked && rbFahrenheitSal.Checked == true)
            {

                Console.WriteLine("No se ve la necesidad para convertir grados Fahrenheit a grados Fahrenheit");

            }

            if (rbKelvin.Checked && rbKelvinSal.Checked == true)
            {

                Console.WriteLine("No se ve la necesidad para convertir grados Kelvin a grados Kelvin");

            }

            if(rbCelcius.Checked && rbFahrenheitSal.Checked == true)
            {
                

                cuadroT.CuadrosT(ungrado, celfar, txtingdat.Text);


            }
        }
    }
}
