using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class StoreKnights
    {
        public static int Prize = 2000;

        static List<Knight> StoredKnights = new List<Knight>()
        {
            new Knight(
                    "lllll",
                    "Assets/stick-man-hi-small.png",
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
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Support,
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
                    "b",
                    "Assets/stick-man-hi-small.png",
                    Knight.Rol.Defender,
                    500,
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
                    "a",
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
