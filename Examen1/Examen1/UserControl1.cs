using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class UserControl1: UserControl
    {
        char[] codigo;
        string colores = "ARBNVM";
        int intentos;
        public UserControl1()
        {
            InitializeComponent();
            codigo = new char[4];
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            textCodigo.Enabled = true;
            textResultado.Text = "";
            textCodigo.Text = "";
            Comparar.Enabled = true;
            generatePick();
            intentos = 8;
            textIntentos.Text = intentos.ToString();
            //trampa.Text = print();
            
        }
        public void generatePick()
        {
            var rd = new Random();
            for (var i = 0; i < codigo.Length; i++)
            {
                codigo[i] = colores[rd.Next(0, colores.Length)];
            }
        }

        private void Comparar_Click(object sender, EventArgs e)
        {
            char[] cIngresado = textCodigo.Text.ToCharArray();
            int [] comparacion=compararCodigo(cIngresado);
            if (comparacion[0] < 4)
            {
                textResultado.Text = "Aciertos totales " + comparacion[0] + " " + "Aciertos parciales " + comparacion[1];
                intentos--;
                textIntentos.Text = intentos.ToString();
            }
            else
            {
                textResultado.Text = "GANADOR";
                disabling();
            }

            if (intentos < 1)
            {
                textResultado.Text = "PERDEDOR";
                disabling();
            }


        }

        private int[] compararCodigo(char[] c)
        {
            int[] resultado = new int[2];
            int aciertosParciales = 0;
            int aciertosTotales = 0;
            for (var i = 0; i < c.Length; i++)
            {
                if (c[i] == codigo[i])
                {
                    aciertosTotales++;
                }
                else
                {
                    for (var j = 0; j < codigo.Length; j++)
                    {
                        if (c[i] == codigo[j])
                        {
                            aciertosParciales++;
                            break;
                        }
                    }
                }

            }
            resultado[0] = aciertosTotales;
            resultado[1] = aciertosParciales;
            return resultado;
        }

        private void disabling()
        {
            textCodigo.Enabled = false;
            Comparar.Enabled = false;
        }

        //public string print()
        //{
        //    string resul = "";
        //    for (var i = 0; i < codigo.Length; i++)
        //    {
        //        resul = resul + codigo[i];
        //    }
        //    return resul;
        //}
    }
}
