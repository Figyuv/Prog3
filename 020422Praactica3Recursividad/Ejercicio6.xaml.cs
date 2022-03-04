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
    /// Lógica de interacción para Ejercicio6.xaml
    /// 
    /// Y dado un número cualquiera x, 
    /// ¿qué nos muestra por pantalla la llamada a la función recursiva f(x,2)? 
    /// ¿Cuál sería un nombre más adecuadopara la función f?
    /// R.-Encuentra los factores de un numero
    /// 
    /// </summary>
    public partial class Ejercicio6 : Window
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }


        //Encuentra los factores de un numer
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            f(int.Parse(txtInA.Text), int.Parse(txtInB.Text));
        }
        void f(int a, int b)
        {
            if (a > 1)
            {
                //verifica que el numero sea divisible, si es asi,
                //divide a entre b y vuelve a llamar a la funcion
                if ((a % b) == 0)
                {
                    txtOut.Text = b.ToString();
                    f(a/b, b);
                }
                //si no es divisible, aumenta en 1 a b
                else
                {
                    f(a, b + 1);
                }
            }
        }
    }
}
