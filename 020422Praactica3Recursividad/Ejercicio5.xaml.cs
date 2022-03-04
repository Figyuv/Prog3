using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _020422Praactica3Recursividad
{
    /// <summary>
    /// Lógica de interacción para Ejercicio5.xaml
    /// 
    /// Sea ay benteros positivos. Suponga una función Qdefinida recursiva como sigue:
    ///             {0              a<b
    ///     Q(a,b)={
    ///             {Q(a-b,b)+1     b<=a
    ///Encontrar el valor de Q(3,2).
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            txtOut.Text = "El resultado para Q(3,2) es: "+FunctionQ(3,2).ToString();
        }
        
        int FunctionQ(int a, int b)
        {
            //evalua el caso
            if (a < b)
            {
                return 0;
            }
            else
            {
                return FunctionQ((a-b)+1, b+1);
            }
        }
    }
}
