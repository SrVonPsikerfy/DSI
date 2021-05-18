﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class Teams
    {
        public static List<Knight> TeamKnights = new List<Knight>()
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
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
                new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 1, false, false)}
                
             )
          };

        static public List<Knight> Team1 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "Knight 1",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Knight 2",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Drak",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Support,
                    23,
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
                    "Ukeo",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Melee,
                    23,
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
                    "Florida",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Sniper,
                    23,
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
                    "Pocahontas",
                   "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Healer,
                    23,
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
                    "Lil",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Pocoyo",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Defender,
                    23,
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
                    
                )
        };
        static public List<Knight> Team2 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "PepsiMan",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Knight 2",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Drak",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Support,
                    23,
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
                    "Ukeo",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Melee,
                    23,
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
                    "Florida",
                   "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Sniper,
                    23,
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
                    "Pocahontas",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Healer,
                    23,
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
                    "Lil",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Pocoyo",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Defender,
                    23,
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
                    
                )
        };
        static public List<Knight> Team3 { get; set; } = new List<Knight>()
        {
            new Knight(
                    "Penicilina",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Knight 2",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Drak",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Support,
                    23,
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
                    "Ukeo",
                    "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Melee,
                    23,
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
                    "Florida",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Sniper,
                    23,
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
                    "Pocahontas",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Healer,
                    23,
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
                    "Lil",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Defender,
                    23,
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
                    "Pocoyo",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Defender,
                    23,
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
                    
                )
        };

        static private IList<Knight> teamSelected;
    }
}
