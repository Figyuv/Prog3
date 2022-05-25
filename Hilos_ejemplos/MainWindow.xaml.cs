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
using System.Threading;

namespace Hilos_ejemplos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// 
    /// el boton inicia un o mas procrsos, que se numeran correlativamente, como hilos y por tanto no bloquean la interfaz
    /// en la cual el usuario puede seguir trabajando
    /// Cada proceso demora 10 segundos y luego muestra un mensaje (que tampoco bloquea el hilo principal de la interfaz)
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void delegado(); //para usar con invoke dentro un hilo
        int x;

        public MainWindow()
        {
            InitializeComponent();
            txtLabel.Content = "";
        }

        private void ejecutarProceso()
        {
            //Hacer que tarde 10000 ms 
            Thread.Sleep(10000);
            x++;
            MessageBox.Show("Proceso " + x + " finalizado");
            delegado hacer = new delegado(limpiarEtiqueta);

            txtLabel.Dispatcher.Invoke(hacer);
        }
        void limpiarEtiqueta()
        {
            txtLabel.Content = "";
        }

        private void btnEj2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();

        }

        private void btnAmarillo_Click(object sender, RoutedEventArgs e)
        {
            txtLabel.Content = "PROCESANTO...... 10 SEGUNDOS";

            //creamos delegado
            ThreadStart delegado = new ThreadStart(ejecutarProceso);

            //crear hilo
            Thread hilo = new Thread(delegado);

            //iniciar hilo
            hilo.Start();

            //fin lineas de ejecucion con hilos 


            //txtLabel.Content = "ejecucion sin hilos";
            //ejecutarProceso();

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Add("Tutorial hilos");
        }
    }
}
