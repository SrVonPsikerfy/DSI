using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIProyectoFinal
{
    public class Knights
    {
        public string Name { get; set; }
        public string ImageLocation { get; set; }
        public string Role { get; set; }
        public int Cost { get; set; }
        public int AtkPhy { get; set; }
        public int AtkMag { get; set; }
        public int Mana { get; set; }
        public int DefPhy { get; set; }
        public int DefMag { get; set; }
        public int Range { get; set; }
        public int Lvl { get; set; }
        public int CurrentExp { get; set; }
        public int MaxExp { get; set; }
        public int PointsAvailable { get; set; }
        public bool[] Abilities { get; set; }
        public int[] EquipedAbilites { get; set; }

        public Knights(string name, string imageLocation, string role, int cost, int atkPhy, int atkMag, int mana, int defPhy, int defMag,
            int range, int lvl, int currentExp, int maxExp, int pointsAvailable, bool[] abilities, int[] equipedAbilities)
        {
            Name = name;
            ImageLocation = imageLocation;
            Role = role;
            Cost = cost;
            AtkPhy = atkPhy;
            AtkMag = atkMag;
            Mana = mana;
            DefPhy = defPhy;
            DefMag = defMag;
            Range = range;
            Lvl = lvl;
            CurrentExp = currentExp;
            MaxExp = maxExp;
            PointsAvailable = pointsAvailable;
            Abilities = abilities;
            EquipedAbilites = equipedAbilities;
        }
    }
}
