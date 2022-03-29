using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavidAriel_ArbolDesiciones
{
    internal class Arbol
    {
        Nodo raiz;
        List<Nodo> lista = new List<Nodo>();
        public Arbol() { raiz = null; }
        public List<Nodo> getLista() { return lista; }
        public Nodo getRaiz() { return raiz; }
        public void insertar(string dato, int peso)
        {
            Nodo rz = getRaiz();
            insertar_en(rz, dato, peso);
        }
        public void insertar_en(Nodo rz, string dato, int num) //******* void
        {
            if (rz == null)
                raiz = new Nodo(dato, num);
            else if (num < rz.number)
            {
                if (rz.left != null) { insertar_en(rz.left, dato, num); }
                else { rz.left = new Nodo(dato, num); }
            }
            else if (num > rz.number) //*******
            {
                if (rz.right != null) { insertar_en(rz.right, dato, num); }
                else { rz.right = new Nodo(dato, num); }
            }
        }
        public List<Nodo> mostrar()
        {
            Nodo rz = getRaiz();
            lista.Clear();
            enOrden(rz); //Se pide ejeutar un recorrido enOrden --> iRd
            return lista;
        }
        public void enOrden(Nodo rz)
        {
            if (rz != null)
            {
                enOrden(rz.left);
                lista.Add(rz);
                enOrden(rz.right);
            }
        }
        public void buscarPregunta(Nodo rz, Del delegado)
        {
            bool respuesta;
            if (rz != null)
                if (rz.left == null && rz.right == null)
                {
                    delegado(rz.number, rz.element, true);
                }
                else
                {
                    respuesta = delegado(rz.number, rz.element, false);
                    if (respuesta)
                    {
                        buscarPregunta(rz.left, delegado);
                    }
                    else
                    {
                        buscarPregunta(rz.right, delegado);
                    }

                }
        }
        public void Cuestionario(Del delegado)
        {
            Nodo rz = getRaiz();
            buscarPregunta(rz, delegado);
        }
    }
}
