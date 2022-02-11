using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica1
{
    class Burbuja
    {
        private string[] alumnos;
        private int[] edades;

        public class Persona
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        

        public void Cargar()
        {
            Random rnd = new Random();
            string linea;
            Console.Write("Cuantos alumnos: ");
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            alumnos = new string[cant];
            edades = new int[cant];
            for (int f = 0; f < alumnos.Length; f++)
            {
                Console.WriteLine("Nombre del alumno " + alumnos[f]);
                alumnos[f] = Console.ReadLine();
                Console.WriteLine("Edad del alumno " + (alumnos[f] + 1));
                edades[f] = int.Parse(Console.ReadLine());
            }
        }

        public void MetodoBurbuja()
        {
            int aux;
            string auxn;
            for (int a = 1; a < edades.Length; a++)
                for (int b = edades.Length - 1; b >= a; b--)
                {
                    if (edades[b - 1] > edades[b])
                    {
                        auxn = alumnos[b - 1];
                        aux = edades[b - 1];
                        alumnos[b - 1] = alumnos[b];
                        edades[b - 1] = edades[b];
                        alumnos[b] = auxn;
                        edades[b] = aux;
                    }
                }
        }
        public void Ordenar()
        {
            string auxn;
            int aux;
            for (int a = 1; a < alumnos.Length; a++)
            {
                for (int b=alumnos.Length-1; b >= a; b--)
                {
                    if (alumnos[b-1].CompareTo(alumnos[b])< 0)
                    {
                        auxn = alumnos[b - 1];
                        aux = edades[b - 1];
                        alumnos[b - 1] = alumnos[b];
                        edades[b - 1] = edades[b];
                        alumnos[b] = auxn;
                        edades[b] = aux;
                    }
                }
            }
        }

        public void Imprimir(string texto)
        {
            Console.WriteLine(texto);
            for (int f = 0; f < alumnos.Length; f++)
            {
                Console.Write(alumnos[f] + "     " + edades[f]+"\n");
            }
            Console.WriteLine("==============\nAlumno con menor edad= "+alumnos[0]);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        public void ImprimirN(string texto)
        {
            Console.WriteLine(texto);
            for (int f = 0; f < alumnos.Length; f++)
            {
                Console.Write(alumnos[f] + "     " + edades[f] + "\n");
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.MetodoBurbuja();
            pv.Imprimir("Ordenado por edad");
            pv.ImprimirN("Ordenar por nombre");
        }
    }
}
