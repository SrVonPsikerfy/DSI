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
                "Elsa",
                "ms-appx:///Assets/Knights/stickman1.png",
                Knight.Rol.Healer,
                    100,
                100,
                100,
                100,
                20,
                100,
                100,
                1,
                69,
                210,
                420,
                21,
                new Skill[6]{ new Skill("skill1", 1, false, false), new Skill("skill6", 6, false, false), new Skill("skill8", 8, false, false),
                             new Skill("skill2", 2, true, true), new Skill("skill7", 7, true, true), new Skill("skill8", 8, true, true)}

             ),
            new Knight(
                "Capunta",
                "ms-appx:///Assets/Knights/stickman2.png",
                Knight.Rol.Support,
                    100,
                60,
                6,
                7,
                14,
                9,
                10,
                1,
                69,
                210,
                420,
                19,
                new Skill[3]{ new Skill("skill10", 10, true, true), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false)}
                
             ),
            new Knight(
                "Elva",
                "ms-appx:///Assets/Knights/stickman3.png",
               Knight.Rol.Sniper,
                    100,
                70,
                6,
                7,
                8,
                28,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, true, true)}
                
             ),
            new Knight(
                "Calao",
                "ms-appx:///Assets/Knights/stickman4.png",
                Knight.Rol.Melee,
                    100,
                5,
                6,
                200,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false)}
                
             ),
            new Knight(
                "Paca",
                "ms-appx:///Assets/Knights/stickman5.png",
               Knight.Rol.Healer,
                    100,
                5,
                900,
                7,
                8,
                9,
                10,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill9", 9, false, false), new Skill("skill3", 3, false, false)}
                
             ),
            new Knight(
                "Garte",
                "ms-appx:///Assets/Knights/stickman2.png",
               Knight.Rol.Melee,
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
                new Skill[3]{ new Skill("skill11", 11, false, false), new Skill("skill4", 4, false, false), new Skill("skill5", 5, false, false)}
                
             ),
            new Knight(
                "Jones",
                "ms-appx:///Assets/Knights/stickman6.png",
               Knight.Rol.Healer,
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false)}
                
             ),
             new Knight(
                "Jonazo",
                "ms-appx:///Assets/Knights/stickman6.png",
               Knight.Rol.Defender,
                    100,
                400,
                6,
                7,
                8,
                9,
                400,
                1,
                69,
                210,
                420,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false)}

             ),
              new Knight(
                "Dracu",
                "ms-appx:///Assets/Knights/stickman6.png",
               Knight.Rol.Healer,
                    100,
                600,
                600,
                7,
                8,
                9,
                10,
                1,
                69,
                100,
                200,
                21,
                new Skill[3]{ new Skill("skill3", 3, false, false), new Skill("skill2", 2, false, false), new Skill("skill5", 5, false, false)}

             ),

              new Knight(
                "Keo",
                "ms-appx:///Assets/Knights/stickman6.png",
               Knight.Rol.Healer,
                    100,
                600,
                999,
                7,
                8,
                9,
                99,
                1,
                99,
                420,
                690,
                21,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill9", 9, false, false)}

             ),
              new Knight(
                "Lerida",
                "ms-appx:///Assets/Knights/stickman4.png",
               Knight.Rol.Melee,
                    120,
                250,
                654,
                34,
                22,
                11,
                87,
                1,
                24,
                420,
                690,
                15,
                new Skill[3]{ new Skill("skill2", 2, false, false), new Skill("skill6", 6, false, false), new Skill("skill8", 8, false, false)}

             ),
              new Knight(
                "Aharta",
                "ms-appx:///Assets/Knights/stickman2.png",
               Knight.Rol.Defender,
                    46,
                15,
                25,
                327,
                15,
                23,
                53,
                2,
                32,
                420,
                690,
                12,
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill7", 7, false, false), new Skill("skill2", 2, false, false)}

             ),
              new Knight(
                "Carta",
                "ms-appx:///Assets/Knights/stickman5.png",
               Knight.Rol.Melee,
                    154,
                234,
                53,
                25,
                15,
                23,
                65,
                23,
                42,
                420,
                690,
                11,
                new Skill[3]{ new Skill("skill5", 5, false, false), new Skill("skill7", 7, false, false), new Skill("skill9", 9, false, false)}

             ),
              new Knight(
                "Larita",
                "ms-appx:///Assets/Knights/stickman3.png",
               Knight.Rol.Support,
                    23,
                412,
                23,
                4,
                238,
                231,
                2,
                3,
                23,
                420,
                690,
                17,
                new Skill[3]{ new Skill("skill3", 3, false, false), new Skill("skill4", 4, false, false), new Skill("skill7", 7, false, false)}

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
