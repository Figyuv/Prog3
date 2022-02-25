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

namespace _0223PracticaPilasColas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Stack<Vehicle> garage = new Stack<Vehicle>();
        Stack<Vehicle> street = new Stack<Vehicle>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle(txtPlaca.Text, txtColor.Text);
            garage.Push(vehicle);
            ShowGarage();
        }
        void ShowGarage()
        {
            lstGarage.Items.Clear();
            foreach(var item in garage)
            {
                lstGarage.Items.Add(item.Id + "  " + item.Color);
            }
        }
        void ShowStreet()
        {
            lstStreet.Items.Clear();
            foreach( var item in street)
            {
                lstStreet.Items.Add(item.Id + "  " + item.Color);
            }
        }

        private void btnPop_Click(object sender, RoutedEventArgs e)
        {
            string IDremove = txtPlaca.Text;
            Vehicle vehicle = FindVehicle(IDremove);
            Remove(vehicle);
            ShowStreet();
            ShowGarage();

        }
        Vehicle FindVehicle(string idRemove)
        {
            Vehicle tmp = null;
            foreach(var item in garage)
            {
                if(item.Id == idRemove)
                    tmp = item;
            }
            return tmp;
        }
        void Remove(Vehicle v1)
        {
            bool encontrado = false;
            do
            {
                if (v1.Equals(garage.Peek()))
                {
                    garage.Pop();
                    encontrado = true;
                }
                else
                {
                    street.Push(garage.Pop());
                }

            } while (!encontrado);
            //for(int i = 0; i <= street.Count; i++)
            //{
            //    garage.Push(street.Pop());
            //}
            while(street.Count > 0)
            {
                garage.Push(street.Pop());
            }
        }
    }
}
