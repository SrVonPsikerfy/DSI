using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class Teams
    {
        static public List<Knight> Team1 { get; set; } = new List<Knight>()
        {
            AvailableKnights.GetAvailableKnights()[0], AvailableKnights.GetAvailableKnights()[1],
            AvailableKnights.GetAvailableKnights()[2], AvailableKnights.GetAvailableKnights()[3],
            AvailableKnights.GetAvailableKnights()[4], AvailableKnights.GetAvailableKnights()[5],
            AvailableKnights.GetAvailableKnights()[6], AvailableKnights.GetAvailableKnights()[7]
        };
        static public List<Knight> Team2 { get; set; } = new List<Knight>()
        {
            AvailableKnights.GetAvailableKnights()[9], AvailableKnights.GetAvailableKnights()[8],
            AvailableKnights.GetAvailableKnights()[7], AvailableKnights.GetAvailableKnights()[6],
            AvailableKnights.GetAvailableKnights()[5], AvailableKnights.GetAvailableKnights()[4],
            AvailableKnights.GetAvailableKnights()[3], AvailableKnights.GetAvailableKnights()[2]
        };
        static public List<Knight> Team3 { get; set; } = new List<Knight>()
        {
            AvailableKnights.GetAvailableKnights()[5], AvailableKnights.GetAvailableKnights()[4],
            AvailableKnights.GetAvailableKnights()[3], AvailableKnights.GetAvailableKnights()[6],
            AvailableKnights.GetAvailableKnights()[7], AvailableKnights.GetAvailableKnights()[2],
            AvailableKnights.GetAvailableKnights()[1], AvailableKnights.GetAvailableKnights()[0]
        };

        static private IList<Knight> teamSelected;
        static public void SaveList(List<Knight> newList, int selectedTeamIndex)
        {
            switch (selectedTeamIndex)
            {
                case 0:
                    Team1 = newList;
                    break;
                case 1:
                    Team2 = newList;
                    break;
                case 2:
                    Team3 = newList;
                    break;
            }
        }
    }
}
