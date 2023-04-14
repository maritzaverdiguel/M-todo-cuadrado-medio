using Método_cuadrado_medio.Algoritmos.Método_CM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Método_cuadrado_medio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))

                {
                    MessageBox.Show("Uno de los valores: semilla, total de datos , tamaño es vacío");

                    return;
                }

                int semilla = Int32.Parse(textBox1.Text);
                int totalDatos = Int32.Parse(textBox2.Text);
                int tamaño = Int32.Parse(textBox3.Text);
                MetodoCM algoritmo = new MetodoCM();

                if (semilla > 0 )
                {
                    List<int> ListaValoresAleatorios = algoritmo.Aleatorios(semilla, totalDatos, tamaño);

                    llenarGridV2(totalDatos, ListaValoresAleatorios);

                        



                }
                 else
                {
                    MessageBox.Show("Una de las condiciones es incorrecta, favor de revisar");

                    
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("vuelve a intentar");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void llenarGridV2(int numeroDatos, List<int> listaInicial)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add(numeroColumna1, "ID");
            dataGridView2.Columns.Add(numeroColumna2, "Algoritmo");
            for (int i = 0; i < numeroDatos; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView2.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = (listaInicial[i]).ToString();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



