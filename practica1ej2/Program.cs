using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica1
{
    class Burbuja
    {
        private int[] vector;



        public void Cargar()
        {
            Random rnd = new Random();
            string linea;
            Console.Write("Longitud del vector= 10");
            linea = Console.ReadLine();
            int cant=10;
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                vector[f] = rnd.Next(1, cant);
            }
        }

        public void MetodoBurbuja()
        {
            int aux;
            int vec =10;
            int arrl = 0;
            
            for (int i=0;i<vector.Length;i++)
            {
                for(int j = 1; j < vector.Length; j++)
                {
                    if (vector[j]<=vec )
                    {
                        vec = vector[j];
                        arrl = j;
                    }
                }
                aux = vector[i];
                vector[i] = vec;
                vector[arrl] = aux;
            }
        }

        public void Imprimir(string texto)
        {
            Console.WriteLine(texto);
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "     ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.Imprimir("Desordenado");
            pv.MetodoBurbuja();
            pv.Imprimir("Ordenado");
        }
    }
}