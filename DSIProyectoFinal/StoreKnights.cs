using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class StoreKnights
    {
        static List<Tuple<Knight, bool>> StoredKnights = new List<Tuple<Knight, bool>>()
        {
            new Tuple<Knight, bool>(
                new Knight(
                    "VAMOSSSS",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true),
             new Tuple<Knight, bool>(
                new Knight(
                    "Knight",
                    "Assets/stick-man-hi-small.png",
                    "Rol",
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
                ), true)
          };

        public static void UpdateKnights(List<Tuple<Knight, bool>> newList)
        {
            StoredKnights = newList;
        }

        public static IList<Tuple<Knight, bool>> GetStoreKnights()
        {
            return StoredKnights;
        }
    }
}
