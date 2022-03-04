using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _020422Praactica3Recursividad
{
    /// <summary>
    /// Lógica de interacción para Ejercicio2.xaml
    /// 
    /// Imprime sumando letra por letra
    /// 
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        Stack<string> stack = new Stack<string>();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //incluye la palabra a una pila para facilitar la impresion
            string word = txtIn.Text;
            stack.Push(word);
            Print(word, word.ToArray().Length);
        }
        void Print(string word, int aux)
        {
            if (aux==0)
            {
                ShowText();
            }
            //suma a la pila la palabra inicial restando el ultimo caracter
            else
            {
                aux--;
                stack.Push(word.Substring(0,aux));
                Print(word, aux);
            }
        }
        //imprimir cada elemento de la pila
        void ShowText()
        {
            string word="";
            foreach(var item in stack)
            {
                word = word + item.ToString()+"\n";
            }
            txtOut.Text = word;
        }
    }
}
