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
    /// Lógica de interacción para Ejercicio1.xaml
    /// 
    /// Calcular el capital total al cabo de una cantidad de tiempo determinada
    /// con un interes determinado
    /// 
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            //Definicion de las variables para hacer el calculo
            double cap = double.Parse(txtCapital.Text);
            double intst = double.Parse(txtIntst.Text);
            int years = int.Parse(txtTime.Text);

            intst = intst / 100;

            Capital(cap,intst,years);
        }
        void Capital(double cap, double intst, int years)
        {
            //Validacion, si years llega a 0 significa que cumplio la cantidad de tiempo que especificamos
            if (years == 0)
            {
                txtOut.Text = cap.ToString();
            }
            //calculo de ganancias de acuerdo al tiempo
            else
            {
                cap = cap + cap * intst;
                years--;
                Capital(cap,intst,years);
            }
        }
    }
}
