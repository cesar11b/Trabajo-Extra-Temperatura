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

            string data1 = "";
            string data2 = "";
          

            CuadroT cuadroT = new CuadroT();

            if (txtingdat.Text != "")
            {





                if (rbCelcius.Checked && rbCelciusSal.Checked == true)
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

                if (rbCelcius.Checked && rbFahrenheitSal.Checked == true)
                {


                    cuadroT.CelFar(txtingdat.Text);
                    data1= rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " celcius en fahrenheit equivalen a " + cuadroT.CelFar(txtingdat.Text) + " grados respectivamente";



                }

                if (rbCelcius.Checked && rbKelvinSal.Checked == true)
                {


                    cuadroT.Celkel(txtingdat.Text);
                    data1 = rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " celcius en kelvin equivalen a " + cuadroT.Celkel(txtingdat.Text) + " grados respectivamente";



                }

                if (rbFahrenheit.Checked && rbCelciusSal.Checked == true)
                {


                    cuadroT.farcel(txtingdat.Text);
                    data1 = rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " fahrenheit en celcius equivalen a " + cuadroT.farcel(txtingdat.Text) + " grados respectivamente";



                }

                 if (rbFahrenheit.Checked && rbKelvinSal.Checked == true)
                {


                    cuadroT.farkel(txtingdat.Text);
                    data1 = rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " fahrenheit en kelvin equivalen a " + cuadroT.farkel(txtingdat.Text) + " grados respectivamente";



                }

                if (rbKelvin.Checked && rbCelciusSal.Checked == true)
                {


                    cuadroT.kelcel(txtingdat.Text);
                    data1 = rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " kelvin en celcius equivalen a " + cuadroT.kelcel(txtingdat.Text) + " grados respectivamente";



                }


                if (rbKelvin.Checked && rbFahrenheitSal.Checked == true)
                {


                    cuadroT.kelfar(txtingdat.Text);
                    data1 = rtbhistorial.Text;
                    data2 = data1;

                    rtbhistorial.Text = $"" + data2 + txtingdat.Text + " kelvin en fahrenheit equivalen a " + cuadroT.kelfar(txtingdat.Text) + " grados respectivamente";



                }
            }
        }
    }
}
