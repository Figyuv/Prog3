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

namespace _0218ListasPilasColas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Ejemplo de listas dentro de otra lista. Inserta equipos y jugadores
    /// Los equipos estan en una lista de equipos
    /// Los jugadores estan en una lista dentro de cada equipo
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Equipo> teamList = new List<Equipo>();
        public MainWindow()
        {
            InitializeComponent();

            //Equipo 1 lista inicial
            List<Jugador> playerListTmp = new List<Jugador>()
            {new Jugador("Mauricio",10), new Jugador("Victoria",8)};

            teamList.Add(new Equipo("Tupiza Futbol Club",15,"Futbol","Juvenil",playerListTmp));

            //Equipo 2 sin jugadores
            teamList.Add(new Equipo("Punata Futbol Cub", 20, "Futbol", "Juvenil"));
            List<Jugador> newPlayerList = new List<Jugador>();
            newPlayerList.Add(new Jugador("Aries", 10));
            newPlayerList.Add(new Jugador("Leo", 30));

            teamList[1].newPlayers(newPlayerList);

        }
        public void ShowList()
        {
            foreach(Equipo team in teamList)
            {
                lstOut.Items.Add(team.TeamName.ToUpper() + "\t" + team.TeamSport + "\t" + team.TeamCategory + "\tCantidad max: " + team.TeamMax);
                foreach (Jugador player in team.PlayersList)
                {
                    lstOut.Items.Add(player.PlayerName+ "\t" + player.PlayerNumber);
                }
                lstOut.Items.Add("-------------------------------------------------------");
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ShowList();
        }
    }
}
