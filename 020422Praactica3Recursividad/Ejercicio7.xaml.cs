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
    /// Lógica de interacción para Ejercicio7.xaml
    /// 
    /// Para todos los valores mayores a 100 devuelve x-10
    /// y para los menores o iguales a 100 devuelve 91
    /// 
    /// </summary>
    public partial class Ejercicio7 : Window
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            txtOut.Text = f(int.Parse(txtInA.Text.ToString())).ToString();
        }

        int f(int x)
        {
            if(x>100)
                return (x-10);
            else
                return (f(f(x+11)));
        }
    }
}
