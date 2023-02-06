namespace GameInventory
{
    internal static class ItemFactoryHelpers
    {


        /// <summary>
        /// Makes a new Weapon object. This is just a random weapon found.
        /// </summary>
        /// <param name="rarity">Selected from the RarityType enum, tells the weapon its rarity.</param>
        /// <returns>Returns the new weapon, as a Weapon object.</returns>
        public static Weapon MakeRandomWeapon(RarityType rarity)
        {
            Weapon weapon = new Weapon("", "", 0, 0, null, null);
            Random random = new Random();

            int wepName = random.Next(0, 7);

            switch (wepName)
            {
                case 0:
                    weapon.Name = WeaponNames.Sword.ToString();
                    weapon.Description = "A hefty, yet dull sword. Maybe it still has a use.";
                    weapon.Weight = 14.7d;
                    weapon.Value = 30.3d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 5;
                    break;
                case 1:
                    weapon.Name = WeaponNames.Spear.ToString();
                    weapon.Description = "Pokey pokey!";
                    weapon.Weight = 11.3d;
                    weapon.Value = 22.1d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 22;
                    break;
                case 2:
                    weapon.Name = WeaponNames.Whip.ToString();
                    weapon.Description = "These spikes are pretty... spiky.";
                    weapon.Weight = 14.6d;
                    weapon.Value = 70.2d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 12;
                    break;
                case 3:
                    weapon.Name = WeaponNames.Dagger.ToString();
                    weapon.Description = "So you're going for the stealthy approach, eh?";
                    weapon.Weight = 4.1d;
                    weapon.Value = 10.4d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 26;
                    break;
                case 4:
                    weapon.Name = WeaponNames.Pistol.ToString();
                    weapon.Description = "A deadly weapon with encased bullets inside.";
                    weapon.Weight = 3.8d;
                    weapon.Value = 40.2d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 60;
                    break;
                case 5:
                    weapon.Name = WeaponNames.Crossbow.ToString();
                    weapon.Description = "I hope you brought bolts!";
                    weapon.Weight = 8.0d;
                    weapon.Value = 54.0d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 45;
                    break;
                case 6:
                default:
                    weapon.Name = WeaponNames.Hammer.ToString();
                    weapon.Description = "Thonk!";
                    weapon.Weight = 3.0d;
                    weapon.Value = 15.0d;
                    weapon.damageType = DamageType.BLUDGEONING;
                    weapon.Damage = 6;
                    break;
            }
            return weapon;
        }
    }
}