namespace GameInventory
{
    public class ItemFactory
    {
        /// <summary>
        /// When called, makes a random clue with random 
        /// values. This is just a random clue found.
        /// </summary>
        /// <returns>Returns the new clue, as a Clue object.</returns>
        public Clue MakeRandomClue()
        {
            
            Clue clue = new Clue("", "", 0, 0, null, null);  // Make a base clue; add reference variables
            Random random = new Random(); // Used for Random selection
            int num = random.Next(0,4); // Random selection from including 0 to excluding 4; option 0 to 3.

            switch (num) // Selects Clue's Names from random, from ClueNames ENUM.
            {
                case 0:
                    clue.Name = ClueNames.Letter.ToString();
                    clue.Description = "This is a letter with obscure writing.";
                    clue.Weight = 0.5d;
                    clue.Value = 22.6d;
                    break;
                case 1:
                    clue.Name = ClueNames.Shirt.ToString();
                    clue.Description = "This is a shirt with some blood on it, with a large hole.";
                    clue.Weight = 0.5d;
                    clue.Value = 6.0d;
                    break;
                case 2:
                    clue.Name = ClueNames.Finger.ToString();
                    clue.Description = "There's a tip of a finger with dried blood! Ewww!!!";
                    clue.Weight = 0.8d;
                    clue.Value = 0.0d;
                    break;
                case 3:
                    clue.Name = ClueNames.Fabric.ToString();
                    clue.Description = "There's a small section of fabric... maybe from a glove?";
                    clue.Weight = 0.2d;
                    clue.Value = 5.2d;
                    break;
            }
            return clue;
        }


        /// <summary>
        /// When called, makes a random clue from a random choice of Names (and therefore details).
        /// This one specifically is a clue for the murder.
        /// </summary>
        /// <param name="incriminates">
        /// Takes in a string value of the person who it incriminates
        /// </param>
        /// <param name="isAccurate">
        /// Takes in a true or false if the clue is accurate or not.
        /// </param>
        /// <returns>Returns the new clue, as a Clue object.</returns>
        public Clue MakeRandomClue(string incriminates, bool isAccurate)
        {
            Clue clue = new Clue("", "", 0, 0, incriminates, isAccurate); // Make a base clue; add reference variables
            Random random = new Random(); // Used for Random selection
            int num = random.Next(0,4); // Random selection from including 0 to excluding 4; option 0 to 3.

            switch (num) // Selects Clue's Names from random, from ClueNames ENUM.
            {
                case 0:
                    clue.Name = ClueNames.Letter.ToString();
                    clue.Description = "This is a letter with obscure writing.";
                    clue.Weight = 0.5d;
                    clue.Value = 22.6d;
                    break;
                case 1:
                    clue.Name = ClueNames.Shirt.ToString();
                    clue.Description = "This is a shirt with some blood on it, and a shredded hole!";
                    clue.Weight = 0.5d;
                    clue.Value = 6.0d;
                    break;
                case 2:
                    clue.Name = ClueNames.Finger.ToString();
                    clue.Description = "There's a tip of a finger with dried blood! Ewww!!!";
                    clue.Weight = 0.8d;
                    clue.Value = 0.0d;
                    break;
                case 3:
                    clue.Name = ClueNames.Fabric.ToString();
                    clue.Description = "There's a small section of fabric... maybe from a glove?";
                    clue.Weight = 0.2d;
                    clue.Value = 5.2d;
                    break;
            }
            return clue;
        }


        /// <summary>
        /// When called, makes a random object, Clue or Weapon, with base values.
        /// </summary>
        public void MakeRandomItem() {

            Random random = new Random(); // Used for Random selection
            int num = random.Next(0,2); // Random selection from including 0 to excluding 2; option 0 or 1.

            switch  (num)
            {
                case 0:
                    MakeRandomClue();
                case 1:
                    MakeRandomWeapon();
            }
        }


        /// <summary>
        /// Makes a new Weapon object. This is just a random weapon found.
        /// </summary>
        /// <returns>Returns the new weapon, as a Weapon object.</returns>
        public Weapon MakeRandomWeapon()
        {
            Weapon weapon = new Weapon("", "", 0, 0, null, null); // Make a base Weapon
            Random random = new Random(); // Used for Random selection
            RarityType rarity = new RarityType(); // Make a base Rarity

            int rarityChoice = random.Next(0, 3); // Random selection from including 0 to excluding 3; option 0, 1, and 2.

            switch (rarityChoice) // Randomly chooses a rarity from RarityType ENUM and sets it.
            {
                case 0:
                    rarity = RarityType.COMMON;
                    break;
                case 1:
                    rarity = RarityType.UNCOMMON;
                    break;
                case 2:
                    rarity = RarityType.RARE;
                    break;
            }

            int wepName = random.Next(0,7); // Random selection from including 0 to excluding 7; option 0 to 6.

            switch (wepName) // Randomly sets a Weapon's Name and its other values, from WeaponNames ENUM.
            {
                case 0:
                    weapon.Name = WeaponNames.Sword.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "A hefty, yet dull sword. Maybe it still has a use.";
                    weapon.Weight = 14.7d;
                    weapon.Value = 30.3d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 5;
                    break;
                case 1:
                    weapon.Name = WeaponNames.Spear.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "Pokey pokey!";
                    weapon.Weight = 11.3d;
                    weapon.Value = 22.1d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 22;
                    break;
                case 2:
                    weapon.Name = WeaponNames.Whip.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "These spikes are pretty... spiky.";
                    weapon.Weight = 14.6d;
                    weapon.Value = 70.2d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 12;
                    break;
                case 3:
                    weapon.Name = WeaponNames.Dagger.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "So you're going for the stealthy approach, eh?";
                    weapon.Weight = 4.1d;
                    weapon.Value = 10.4d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 26;
                    break;
                case 4:
                    weapon.Name = WeaponNames.Pistol.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "A deadly weapon with encased bullets inside.";
                    weapon.Weight = 3.8d;
                    weapon.Value = 40.2d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 60;
                    break;
                case 5:
                    weapon.Name = WeaponNames.Crossbow.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "I hope you brought bolts!";
                    weapon.Weight = 8.0d;
                    weapon.Value = 54.0d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 45;
                    break;
                case 6:
                    weapon.Name = WeaponNames.Hammer.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "Thonk!";
                    weapon.Weight = 3.0d;
                    weapon.Value = 15.0d;
                    weapon.damageType = DamageType.BLUDGEONING;
                    weapon.Damage = 6;
                    break;
            }
            return weapon;
        }


        /// <summary>
        /// Makes a new Weapon from a random choice of Names (and therefore details).
        /// This one specifically is a murder weapon.
        /// </summary>
        /// <param name="incriminates">Takes in a string value of the person who it incriminates</param>
        /// <param name="isAccurate">Takes in a true or false if the clue is accurate or not.</param>
        /// <returns>Returns the new weapon, as a Weapon object.</returns>
        public Weapon MakeRandomWeapon(string incriminates, bool isAccurate)
        {
            Weapon weapon = new Weapon("", "", 0, 0, null, null); // Make a base Weapon
            Random random = new Random(); // Used for Random selection
            RarityType rarity = new RarityType(); // Make a base Rarity

            int rarityChoice = random.Next(0, 3); // Random selection from including 0 to excluding 3; option 0, 1, and 2.

            switch (rarityChoice) // Randomly chooses a rarity from RarityType ENUM and sets it.
            {
                case 0:
                    rarity = RarityType.COMMON;
                    break;
                case 1:
                    rarity = RarityType.UNCOMMON;
                    break;
                case 2:
                    rarity = RarityType.RARE;
                    break;
            }

            int wepName = random.Next(0,7); // Random selection from including 0 to excluding 7; option 0 to 6.

            switch (wepName) // Randomly sets a Weapon's Name and its other values, from WeaponNames ENUM.
            {
                case 0:
                    weapon.Name = WeaponNames.Sword.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "A hefty, yet dull sword. Maybe it still has a use.";
                    weapon.Weight = 14.7d;
                    weapon.Value = 30.3d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 5;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 1:
                    weapon.Name = WeaponNames.Spear.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "Pokey pokey!";
                    weapon.Weight = 11.3d;
                    weapon.Value = 22.1d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 22;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 2:
                    weapon.Name = WeaponNames.Whip.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "These spikes are pretty... spiky.";
                    weapon.Weight = 14.6d;
                    weapon.Value = 70.2d;
                    weapon.damageType = DamageType.SLASHING;
                    weapon.Damage = 12;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 3:
                    weapon.Name = WeaponNames.Dagger.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "So you're going for the stealthy approach, eh?";
                    weapon.Weight = 4.1d;
                    weapon.Value = 10.4d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 26;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 4:
                    weapon.Name = WeaponNames.Pistol.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "A deadly weapon with encased bullets inside.";
                    weapon.Weight = 3.8d;
                    weapon.Value = 40.2d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 60;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 5:
                    weapon.Name = WeaponNames.Crossbow.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "I hope you brought bolts!";
                    weapon.Weight = 8.0d;
                    weapon.Value = 54.0d;
                    weapon.damageType = DamageType.PIERCING;
                    weapon.Damage = 45;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
                case 6:
                    weapon.Name = WeaponNames.Hammer.ToString();
                    if (rarity != RarityType.COMMON) // Checks Rarity value, based on RarityType enum, and appends to name if not COMMON.
                    {
                        weapon.Name = $"{rarity.ToString()} {weapon.Name}";
                    }
                    weapon.Description = "Thonk!";
                    weapon.Weight = 3.0d;
                    weapon.Value = 15.0d;
                    weapon.damageType = DamageType.BLUDGEONING;
                    weapon.Damage = 6;
                    weapon.PersonIncriminated = incriminates;
                    weapon.Accuracy = isAccurate;
                    break;
            }
            return weapon;
        }
    }
}
