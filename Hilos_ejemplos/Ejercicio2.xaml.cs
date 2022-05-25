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
using System.Threading;

namespace Hilos_ejemplos
{
    /// <summary>
    /// Lógica de interacción para Ejercicio2.xaml
    /// 
    /// Se activan 3 hilos uno para cada barra de progreso que en tiempos diferentes actualizan sus valores
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        delegate void delegado(int valor); //para usar con invoke dentro un hilo
        int x;
        Thread hilo;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            hilo = new Thread(new ThreadStart(Proceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(Proceso3));
            hilo.Start();
        }
        void Proceso1()
        {
            //Thread.Sleep(5000);
            for ( int i = 0; i < 101; i++)
            {
                delegado hacer = new delegado(Actualiza1);
                bar1.Dispatcher.Invoke(hacer, new object[] { i });
                Thread.Sleep(70);
                if (i == 100) { MessageBox.Show("Barra 1 finalizada"); }
            }
        }public void Actualiza1(int valor) 
        {
            bar1.Value= valor;
        }
        void Proceso2()
        {
            //Thread.Sleep(7000);
            for (int i = 0; i < 101; i++)
            {
                delegado hacer = new delegado(Actualiza2);
                bar1.Dispatcher.Invoke(hacer, new object[] { i });
                Thread.Sleep(10);
                if (i == 100)
                {
                    MessageBox.Show("Barra 2 finalizada");
                }
            }
        }
        public void Actualiza2(int valor)
        {
            bar2.Value = valor;
        }
        void Proceso3()
        {
            //Thread.Sleep(2000);
            for (int i = 0; i < 101; i++)
            {
                delegado hacer = new delegado(Actualiza3);
                bar1.Dispatcher.Invoke(hacer, new object[] { i });
                Thread.Sleep(100);
                if (i == 100)
                {
                    MessageBox.Show("Barra 3 finalizada");
                }
            }
        }
        public void Actualiza3(int valor)
        {
            bar3.Value = valor;
        }
    }
}
