﻿using System;
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
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
                    new bool[3]{ true, false, true},
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
                    new bool[3]{ true, false, true},
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
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
                    new bool[3]{ true, false, true},
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
                    new bool[3]{ true, false, true},
                    new int[8]{ 1, 2, 3, 4, 5, 6, 7, 8 }
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
