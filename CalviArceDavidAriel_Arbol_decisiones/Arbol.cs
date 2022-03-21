using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalviArceDavidAriel_Arbol_decisiones
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
            else if (num < rz.numero)
            {
                if (rz.izquierdo != null) { insertar_en(rz.izquierdo, dato, num); }
                else { rz.izquierdo = new Nodo(dato, num); }
            }
            else if (num > rz.numero) //*******
            {
                if (rz.derecho != null) { insertar_en(rz.derecho, dato, num); }
                else { rz.derecho = new Nodo(dato, num); }
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
                enOrden(rz.izquierdo);
                lista.Add(rz);
                enOrden(rz.derecho);
            }
        }
        public void buscarPregunta(Nodo rz, Del delegado)
        {
            bool respuesta;
            if (rz != null)
                if (rz.izquierdo == null && rz.derecho == null)
                {
                    delegado(rz.numero, rz.elemento, true);
                }
                else
                {
                    respuesta = delegado(rz.numero, rz.elemento, false);
                    if (respuesta)
                    {
                        buscarPregunta(rz.izquierdo, delegado);
                    }
                    else
                    {
                        buscarPregunta(rz.derecho, delegado);
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
