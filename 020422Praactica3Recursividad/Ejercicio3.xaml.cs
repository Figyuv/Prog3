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
    /// Lógica de interacción para Ejercicio3.xaml
    /// 
    /// Sumartodos los números pares positivos desde el 0 hasta n.
    /// 
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //definicion de variables a utilizar
            int num = int.Parse(txtIn.Text);
            int count = 0;
            int i = 0;
            ResultSum(num, count,i);
        }
        void ResultSum(int num,int count, int i)
        {
            if (i > num)
            {
                txtOut.Text=count.ToString();
            }
            //suma de el numero que solicitamos y todos los pares desde 0
            else
            {
                count=count  + i;
                i = i + 2;
                ResultSum(num, count,i);
            }
        }
    }
}
