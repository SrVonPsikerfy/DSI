using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class StoreKnights
    {
        public static int Prize = 37500;

        static List<Knight> StoredKnights = new List<Knight>()
        {
            new Knight(
                    "Carmen",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Defender,
                    200,    //Shop cost
                    5,      //Cost
                    6,      //AtkPhy
                    7,      //AtkMag
                    8,      //Mana
                    9,      //DefPhy
                    10,     //DefMag
                    1,      //Range
                    87,     //lvl
                    210,    //CurrentExp
                    420,    //MaxExp
                    15,     //PointsAvailable
                    new Skill[3]{ new Skill("skill1", 1, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false)}
                    
                ),
            new Knight(
                    "Mernand",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Support,
                    100,
                    3,
                    4,
                    8,
                    15,
                    14,
                    20,
                    2,
                    35,
                    210,
                    420,
                    10,
                    new Skill[3]{ new Skill("skill1", 6, false, false), new Skill("skill2", 3, false, false), new Skill("skill3", 10, false, false)}
                    
                ),
            new Knight(
                    "Marta",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Sniper,
                    300,
                    2,
                    15,
                    5,
                    8,
                    70,
                    14,
                    4,
                    27,
                    210,
                    420,
                    14,
                    new Skill[3]{ new Skill("skill1", 7, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 6, false, false)}
                    
                ),
            new Knight(
                    "Bernard",
                    "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Melee,
                    600,
                    1,
                    20,
                    10,
                    14,
                    11,
                    15,
                    2,
                    34,
                    210,
                    420,
                    15,
                    new Skill[4]{ new Skill("skill1", 4, false, false), new Skill("skill2", 3, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 11, false, false) }
                    
                ),
            new Knight(
                    "Marcos",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Sniper,
                    250,
                    4,
                    50,
                    54,
                    4,
                    20,
                    15,
                    4,
                    23,
                    210,
                    420,
                    19,
                    new Skill[3]{ new Skill("skill1", 12, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 6, false, false)}
                    
                ),
            new Knight(
                    "Ana",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Support,
                    50,
                    5,
                    30,
                    25,
                    32,
                    40,
                    22,
                    2,
                    20,
                    210,
                    420,
                    7,
                    new Skill[3]{ new Skill("skill1", 4, false, false), new Skill("skill2", 9, false, false), new Skill("skill3", 13, false, false)}
                    
                ),
            new Knight(
                    "Martis",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Defender,
                    400,
                    3,
                    53,
                    32,
                    15,
                    4,
                    32,
                    2,
                    46,
                    210,
                    420,
                    22,
                    new Skill[5]{ new Skill("skill1", 3, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 2, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}
                    
                ),
            new Knight(
                    "Evardo",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Support,
                    240,
                    2,
                    47,
                    24,
                    14,
                    62,
                    24,
                    3,
                    34,
                    210,
                    420,
                    13,
                    new Skill[5]{ new Skill("skill1", 2, false, false), new Skill("skill2", 4, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Lori",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Melee,
                    150,
                    4,
                    24,
                    15,
                    65,
                    23,
                    14,
                    6,
                    2,
                    210,
                    420,
                    18,
                    new Skill[5]{ new Skill("skill1", 5, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 6, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 3, false, false)}

                ),
            new Knight(
                    "Anton",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Melee,
                    180,
                    3,
                    32,
                    16,
                    15,
                    62,
                    78,
                    3,
                    2,
                    210,
                    420,
                    15,
                    new Skill[5]{ new Skill("skill1", 1, false, false), new Skill("skill2", 6, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 11, false, false)}

                ),
            new Knight(
                    "Maria",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Sniper,
                    500,
                    5,
                    28,
                    15,
                    18,
                    26,
                    7,
                    4,
                    26,
                    210,
                    420,
                    9,
                    new Skill[5]{ new Skill("skill1", 5, false, false), new Skill("skill2", 7, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Cristin",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Healer,
                    700,
                    4,
                    27,
                    54,
                    24,
                    47,
                    65,
                    2,
                    45,
                    210,
                    420,
                    10,
                    new Skill[5]{ new Skill("skill1", 5, false, false), new Skill("skill2", 3, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 8, false, false), new Skill("skill5", 13, false, false)}

                ),
            new Knight(
                    "Leorio",
                    "ms-appx:///Assets/Knights/stickman1.png",
                    Knight.Rol.Sniper,
                    300,
                    5,
                    23,
                    27,
                    32,
                    44,
                    12,
                    3,
                    22,
                    210,
                    420,
                    8,
                    new Skill[5]{ new Skill("skill1", 3, false, false), new Skill("skill2", 1, false, false), new Skill("skill3", 6, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 11, false, false)}

                ),
            new Knight(
                    "Bippet",
                    "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Melee,
                    430,
                    2,
                    23,
                    21,
                    19,
                    32,
                    22,
                    3,
                    16,
                    210,
                    420,
                    7,
                    new Skill[5]{ new Skill("skill1", 4, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 11, false, false)}

                ),
            new Knight(
                    "Arter",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Defender,
                    140,
                    3,
                    22,
                    15,
                    17,
                    25,
                    24,
                    3,
                    26,
                    210,
                    420,
                    16,
                    new Skill[5]{ new Skill("skill1", 3, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Carla",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Healer,
                    420,
                    2,
                    24,
                    27,
                    15,
                    28,
                    23,
                    2,
                    53,
                    210,
                    420,
                    11,
                    new Skill[4]{ new Skill("skill1", 1, false, false), new Skill("skill2", 6, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 9, false, false)}

                ),
            new Knight(
                    "Sara",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Melee,
                    355,
                    2,
                    25,
                    34,
                    42,
                    14,
                    22,
                    3,
                    43,
                    210,
                    420,
                    9,
                    new Skill[5]{ new Skill("skill1", 6, false, false), new Skill("skill2", 2, false, false), new Skill("skill3", 3, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Lana",
                    "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Melee,
                    152,
                    3,
                    34,
                    22,
                    11,
                    5,
                    7,
                    2,
                    15,
                    210,
                    420,
                    6,
                    new Skill[5]{ new Skill("skill1", 4, false, false), new Skill("skill2", 6, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 11, false, false)}

                ),
            new Knight(
                    "Terete",
                    "ms-appx:///Assets/Knights/stickman2.png",
                    Knight.Rol.Sniper,
                    250,
                    2,
                    16,
                    24,
                    15,
                    26,
                    25,
                    3,
                    35,
                    210,
                    420,
                    8,
                    new Skill[5]{ new Skill("skill1", 4, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 2, false, false), new Skill("skill4", 10, false, false), new Skill("skill5", 11, false, false)}

                ),
            new Knight(
                    "Terresa",
                    "ms-appx:///Assets/Knights/stickman4.png",
                    Knight.Rol.Melee,
                    600,
                    2,
                    25,
                    14,
                    24,
                    26,
                    46,
                    3,
                    16,
                    210,
                    420,
                    28,
                    new Skill[5]{ new Skill("skill1", 1, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 6, false, false), new Skill("skill4", 8, false, false), new Skill("skill5", 13, false, false)}

                ),
            new Knight(
                    "Alberto",
                    "ms-appx:///Assets/Knights/stickman5.png",
                    Knight.Rol.Melee,
                    140,
                    2,
                    34,
                    31,
                    25,
                    6,
                    13,
                    3,
                    25,
                    210,
                    420,
                    8,
                    new Skill[5]{ new Skill("skill1", 3, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Tarta",
                    "ms-appx:///Assets/Knights/stickman3.png",
                    Knight.Rol.Healer,
                    170,
                    2,
                    25,
                    23,
                    55,
                    25,
                    17,
                    3,
                    22,
                    210,
                    420,
                    11,
                    new Skill[5]{ new Skill("skill1", 4, false, false), new Skill("skill2", 5, false, false), new Skill("skill3", 8, false, false), new Skill("skill4", 9, false, false), new Skill("skill5", 12, false, false)}

                ),
            new Knight(
                    "Larian",
                    "ms-appx:///Assets/Knights/stickman6.png",
                    Knight.Rol.Defender,
                    170,
                    2,
                    24,
                    49,
                    17,
                    25,
                    28,
                    5,
                    28,
                    210,
                    420,
                    11,
                    new Skill[4]{ new Skill("skill1", 2, false, false), new Skill("skill2", 4, false, false), new Skill("skill3", 7, false, false), new Skill("skill4", 6, false, false)}

                ),

          };

        public static void UpdateStoreKnights(List<Knight> newList)
        {
            StoredKnights = newList;
        }

        public static IList<Knight> GetStoreKnights()
        {
            return StoredKnights;
        }
    }
}
