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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _020422Praactica3Recursividad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ej3= new Ejercicio3();
            ej3.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ej4 = new Ejercicio4();
            ej4.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ej5 = new Ejercicio5();
            ej5.Show();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio6 ej6 = new Ejercicio6();
            ej6.Show();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio7 ej7 = new Ejercicio7();
            ej7.Show();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio8 ej8 = new Ejercicio8();
            ej8.Show();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio9 ej9 = new Ejercicio9();
            ej9.Show();
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio10 ej10 = new Ejercicio10();
            ej10.Show();
        }
    }
}
