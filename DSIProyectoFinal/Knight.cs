using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI;
using Windows.UI.Xaml.Media;


namespace DSIProyectoFinal
{
    public class Knight
    {
        public enum Rol { Defender, Melee, Sniper, Support, Healer }

        private static string[] roleLocation { get; set; } = new string[5]
        {
            "ms-appx:///Assets/defender_class_icon.png",
            "ms-appx:///Assets/melee_class_icon.png",
            "ms-appx:///Assets/sniper_class_icon.png",
            "ms-appx:///Assets/support_class_icon.png",
            "ms-appx:///Assets/healer_class_icon.png"
        };

        public string Name { get; set; }
        public string ImageLocation { get; set; }

        public Rol Role { get; set; }
        public string RoleLocation { get; set; }


        public int ShopCost { get; set; }
        public Visibility Bought { get; set; }

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
        public Skill[] Abilities { get; set; }
        public List<Skill> EquipedAbilities { get; set; }

        public SolidColorBrush BackgroundColor { get; set; }

        public Knight(string name, string imageLocation, Rol role, int shopCost, int cost, int atkPhy, int atkMag, int mana, int defPhy, int defMag,
            int range, int lvl, int currentExp, int maxExp, int pointsAvailable, Skill[] abilities, Visibility visibility = Visibility.Collapsed)
        {
            Name = name;
            ImageLocation = imageLocation;
            Role = role;
            RoleLocation = roleLocation[(int)Role];

            ShopCost = shopCost;
            Bought = visibility;

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

            EquipedAbilities = new List<Skill>(3);
            foreach (Skill skill in Abilities)
            {
                if (skill.IsActive)
                {
                    EquipedAbilities.Add(skill);
                }
                //NO METER MAS DE 3
                if (EquipedAbilities.Count >= 3) break;
            }

            //escoger color segun la clase para la pantalla de juego
            ColorSelect();
        }

        private void ColorSelect()
        {
            switch (Role)
            {
                case Rol.Defender:
                    BackgroundColor = new SolidColorBrush(ColorHelper.FromArgb(255, 0, 255, 255));
                    break;

                case Rol.Healer:
                    BackgroundColor = new SolidColorBrush(ColorHelper.FromArgb(255, 255, 0, 255));
                    break;

                case Rol.Support:
                    BackgroundColor = new SolidColorBrush(ColorHelper.FromArgb(255, 255, 255, 0));
                    break;

                case Rol.Melee:
                    BackgroundColor = new SolidColorBrush(ColorHelper.FromArgb(255, 255, 255, 255));
                    break;

                case Rol.Sniper:
                    BackgroundColor = new SolidColorBrush(ColorHelper.FromArgb(255, 0, 255, 255));
                    break;
            }
        }

        public Knight(Knight knight_)
        {
            Name = knight_.Name;
            ImageLocation = knight_.ImageLocation;
            Role = knight_.Role;
            RoleLocation = roleLocation[(int)Role];

            ShopCost = knight_.ShopCost;
            Bought = knight_.Bought;

            Cost = knight_.Cost;
            AtkPhy = knight_.AtkPhy;
            AtkMag = knight_.AtkMag;
            Mana = knight_.Mana;
            DefPhy = knight_.DefPhy;
            DefMag = knight_.DefMag;
            Range = knight_.Range;
            Lvl = knight_.Lvl;
            CurrentExp = knight_.CurrentExp;
            MaxExp = knight_.MaxExp;

            PointsAvailable = knight_.PointsAvailable;
            Abilities = knight_.Abilities;
            EquipedAbilities = knight_.EquipedAbilities;
            BackgroundColor = knight_.BackgroundColor;
        }
    }

    public class Skill
    {
        public string Name { get; set; }
        public int SkillId { get; set; }
        public string ImageSource { get; set; }
        public bool IsActive { get; set; }
        public bool IsUnlocked { get; set; }
        public int PointsNeeded { get; set; }
        public Visibility CostVisibility { get; set; }

        public Skill(Skill skill_)
        {
            Name = skill_.Name;
            SkillId = skill_.SkillId;

            IsActive = skill_.IsActive;
            IsUnlocked = skill_.IsUnlocked;
            PointsNeeded = skill_.PointsNeeded;
            CostVisibility = skill_.CostVisibility;
        }

        public Skill(string name, int skillId, bool isActive, bool isUnlocked, int pointsNeeded = 3)
        {
            Name = name;
            SkillId = skillId;

            IsActive = isActive;
            IsUnlocked = isUnlocked;
            if (IsActive) ImageSource = "ms-appx:///Assets/skills/skill" + skillId.ToString() + "_icon_active.png";
            else if (isUnlocked) ImageSource = "ms-appx:///Assets/skills/skill" + skillId.ToString() + "_icon_unlocked.png";
            else ImageSource = "ms-appx:///Assets/skills/skill" + skillId.ToString() + "_icon.png";
            
            PointsNeeded = pointsNeeded;
            if (isUnlocked) CostVisibility = Visibility.Collapsed;
            else CostVisibility = Visibility.Visible;
        }

        public void UnlockAbility()
        {
            ImageSource = "ms-appx:///Assets/skills/skill" + SkillId.ToString() + "_icon_unlocked.png";
            IsUnlocked = true;
        }

        public void EquipAbility()
        {
            ImageSource = "ms-appx:///Assets/skills/skill" + SkillId.ToString() + "_icon_active.png";
            IsActive = true;
        }

        public void UnequipAbility()
        {
            ImageSource = "ms-appx:///Assets/skills/skill" + SkillId.ToString() + "_icon_unlocked.png";
            IsActive = false;
        }
    }
}
