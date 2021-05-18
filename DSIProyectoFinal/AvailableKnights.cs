using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class AvailableKnights
    {
        public static List<Knight> AvailableKnightsForTeams = new List<Knight>()
        {
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
                Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
                Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
               Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
                Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
               Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
               Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             ),
            new Knight(
                "Knight",
                "Assets/stick-man-hi-small.png",
               Knight.Rol.Defender,
                    100,
                5,
                6,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)},
                new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
             )
          };

        public static void AddAvailableKnight(Knight newKnight)
        {
            AvailableKnightsForTeams.Add(newKnight);
        }

        public static void UpdateAvailableKnights(List<Knight> newList)
        {
            AvailableKnightsForTeams = newList;
        }

        public static IList<Knight> GetAvailableKnights()
        {
            return AvailableKnightsForTeams;
        }
    }
}
