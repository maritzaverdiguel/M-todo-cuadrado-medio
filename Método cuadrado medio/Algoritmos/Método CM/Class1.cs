using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Método_cuadrado_medio.Algoritmos.Método_CM
{
    public class MetodoCM
    {

        public List<int> listaAleatorios = new List<int>();
        public MetodoCM() 
        { }



        public List<int> Aleatorios(int semilla, int tamaño, int totalDatos)
        {
            int rn1 = 0, rn = semilla;
            
            

            listaAleatorios.Add(semilla);

            for (int i = 0; i < totalDatos; i++)
            {
                rn1 = (int)Math.Pow(rn, 2);

                 
                string h = rn1.ToString();
                string medio = h.Substring(1, h.Length - 2);
                string snewrn = medio.Substring(1,tamaño);
                int newrn;
                int.TryParse(snewrn, out newrn);

                listaAleatorios.Add(newrn);

                if (newrn == rn)
                {
                    i = totalDatos + 1; break;
                }
               
                rn = newrn;

               





            }

            return listaAleatorios;


        }





    } 
}
