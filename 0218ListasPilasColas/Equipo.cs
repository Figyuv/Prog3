using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0218ListasPilasColas
{
    internal class Equipo
    {
        public string TeamName { get; set; }
        public int TeamMax { get; set; }
        public string TeamSport { get; set; }
        public string TeamCategory { get; set; }

        List<Jugador> playersList;
        public List<Jugador> PlayersList { get { return playersList; } }

        public Equipo(string name, int teamMax, string teamSport, string teamCategory)
        {
            TeamName = name;
            TeamMax = teamMax;
            TeamSport = teamSport;
            TeamCategory = teamCategory;
            playersList = new List<Jugador>();
        }

        public Equipo(string name, int teamMax, string teamSport, string teamCategory, List<Jugador> playersList)
        {
            TeamName = name;
            TeamMax = teamMax;
            TeamSport = teamSport;
            TeamCategory = teamCategory;
            this.playersList = playersList;
        }

        public void newPlayers(List<Jugador> playerList)
        {
            playersList = playerList;
        }
    }
}
