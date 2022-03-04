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
    /// Lógica de interacción para Ejercicio9.xaml
    /// 
    /// Un granjero ha comprado una pareja de conejos para criarlos y luego venderlos. 
    /// Si la pareja de conejos produce una nueva pareja cada mes y la nueva pareja tarda 
    /// un mes más en ser también productiva, ¿cuántos pares deconejos podrá poner a la
    /// venta el granjero al cabo de un año?
    /// 
    /// </summary>
    public partial class Ejercicio9 : Window
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Mandamos la cantidad de tiempo y el numero inicial de parejas
            int month = 12;
            int pairs = 1;
            int lastpairs = pairs - 1;
            PairRab(pairs,month, lastpairs);

        }
        void PairRab(int pairs, int months, int lastpairs)
        {
            //verificamos, si ya paso la cantidad de tiemo, imprimimos el total de pajeras que nos resulto
            if (months == 1)
            {
                txtOut.Text = "En 12 meses, habaran: "+pairs.ToString()+" pares de conejos";
            }
            //si no paso el tiempo especificado,
            //sumamos el numero de parejas actuales junto al de la anterior iteracion y reducimos el tiempo
            else
            { 
                int total = pairs + lastpairs;
                months--;
                PairRab(total, months, pairs);
            }
        }
    }
}
