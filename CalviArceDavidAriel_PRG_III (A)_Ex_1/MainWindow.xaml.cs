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

namespace CalviArceDavidAriel_PRG_III__A__Ex_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int indexParks;
        List<Parque> parques = new List<Parque>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPark_Click(object sender, RoutedEventArgs e)
        {
            Queue<Juego> juegoQueue = new Queue<Juego>();
            string nombre = txtAddPark.Text;
            string juego = txtNewGame.Text;
            int capacidad = int.Parse(txtCapacity.Text);
            if (juego == null)
            {
                juegoQueue.Enqueue(null);
            }
            else
            {
                
                juegoQueue.Enqueue(new Juego()
                {
                    GameName = juego,
                    maxCapacity = capacidad,
                });
                parques.Add(new Parque()
                {
                    ParkName = nombre,
                    Games = juegoQueue
                });
            }
            
            AddCmb();
        }
        void AddCmb()
        {
            cmbParks.Items.Clear();
            foreach(var parque in parques)
            {
                cmbParks.Items.Add(parque.ParkName);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int i = cmbParks.SelectedIndex;
            string newGame = txtNewGame.Text;
            int newCapacity= int.Parse(txtCapacity.Text);
            parques[i].Games.Enqueue(new Juego()
            {
                GameName = newGame,
                maxCapacity = newCapacity
            });
        }
        void ShowList()
        {
            lstShow.Items.Clear();
            foreach(var parque in parques)
            {
                lstShow.Items.Add("Nombre: "+parque.ParkName);
                if (parque.Games == null)
                {
                    lstShow.Items.Add("\tCola vacia");
                }
                else
                {
                    foreach (var juegos in parque.Games)
                    {
                        lstShow.Items.Add("\tNombre Juego: " + juegos.GameName + " Capacidad: " + juegos.maxCapacity);
                    }
                }
            }
        }
        void ShowParkGames()
        {
            lstShow.Items.Clear();
            int i = cmbParks.SelectedIndex;
            lstShow.Items.Add("Parque: " + parques[i].ParkName);
            if (parques[i].Games == null)
            {
                lstShow.Items.Add("\tCola vacia");
            }
            else
            {
                foreach (var juegos in parques[i].Games)
                {
                    lstShow.Items.Add("\tNombre Juego: " + juegos.GameName + " Capacidad: " + juegos.maxCapacity);
                }
            }
            
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ShowList();
        }

        private void btnShowGames_Click(object sender, RoutedEventArgs e)
        {
            ShowParkGames();
        }

        private void btnDequeGame_Click(object sender, RoutedEventArgs e)
        {
            int i = cmbParks.SelectedIndex;
            Juego aux = new Juego();
            aux = parques[i].Games.Dequeue();
            MessageBox.Show("Nombre del parque: "+ parques[i].ParkName+" juego retirado: "+ aux.GameName);
            
        }
    }
}
