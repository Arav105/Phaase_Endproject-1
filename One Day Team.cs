using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_Endproject_1
{
    public class One_Day_Team:Player, ITeam
    {
        
            public static List<Player> teamlist = new List<Player>();
            public One_Day_Team()
            {
                teamlist.Capacity = 11;

            }
            public void Add(Player player)
            {
                teamlist.Add(player);
            }
            public void Remove(int playerid)
            {
                Player player = null;

                foreach (var item in teamlist)
                {
                    if (item.PlayerId == playerid)
                    {
                        Console.WriteLine("Player Removed successfully");
                        player = item;
                    }
                }
                teamlist.Remove(player);
            }

            public Player GetPlayerById(int playerid)
            {
                Player player = null;

                foreach (var item in teamlist)
                {
                    if (item.PlayerId == playerid)
                    {
                        player = item;

                        break;
                    }
                }
                return player;

            }

            public Player GetPlayerByName(string playername)
            {
                Player player = null;

                foreach (var item in teamlist)
                {
                    if (item.PlayerName == playername)
                    {
                        player = item;

                        break;
                    }
                }
                return player;

            }
            public List<Player> GetAllPlayers()
            {
                return teamlist;
            }


        
    }
}
