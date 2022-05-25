using AbstractFactory_Pizza.Abstract_Products;
using AbstractFactory_Pizza.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzeria fabrica;

            fabrica = new PizzeriaArgentina();
            Pizza pizza = fabrica.CrearPizza();
            Helado helado = fabrica.CrearHelado();
            Empanada empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}, Helado: {helado.Descripcion}");

            fabrica = new PizzeriaItaliana();
            pizza = fabrica.CrearPizza();
            helado = fabrica.CrearHelado();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}, Helado: {helado.Descripcion}");

            Console.ReadKey();

        }
    }
}
