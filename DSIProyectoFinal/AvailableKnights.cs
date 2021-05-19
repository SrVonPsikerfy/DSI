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
                "Draku",
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
                             new Skill("skill2", 1, true, true), new Skill("skill6", 3, true, true), new Skill("skill4", 8, true, true)}

             ),
            new Knight(
                "Keo",
                "ms-appx:///Assets/Knights/stickman2.png",
                Knight.Rol.Defender,
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
                "Pala",
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
                "Dora",
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
                "Etod",
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
                "Dio",
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
                "Sanic",
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
             ),
             new Knight(
                "Paco",
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}

             ),
              new Knight(
                "Sanz",
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}

             ),

              new Knight(
                "Astolfo",
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}

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
