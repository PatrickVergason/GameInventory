/*  Author: Patrick Vergason, vergason@etsu.edu
 *  Course: CSCI-2210-001 - Data Structures
 *  Assignment: Project 1 - Game Inventory
 *  Description: Project to show items, clues, and weapons, as well as randomize and make new ones.
 */

namespace GameInventory  // "is" command is a type-checker!!!!
{
    public enum DamageType { SLASHING, PIERCING, BLUDGEONING } // ENUM of Weapon's Potential Damage Types
    public enum RarityType { COMMON, UNCOMMON, RARE } // ENUM of Item's Potential Rarities
    public enum WeaponNames { Sword, Spear, Whip, Dagger, Crossbow, Pistol, Hammer } // ENUM of Weapons's Potential Names
    public enum ClueNames { Letter, Shirt, Finger, Fabric } // ENUM of Clue's Potential Names
    public class Program
    {

        /// <summary>
        /// Main method of the entire program. Always called first when ran.
        /// </summary>
        /// <param name="args">Special array of strings: arguments from system.</param>
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack(); // Instantiates new Backpack
            Random random = new Random(); // Used for Random selection

            int gameInvChoice = random.Next(0,3); // Random selection from including 0 to excluding 3; option 0, 1, or 2.

            switch (gameInvChoice) // Chooses to list all Items, list only Weapons, or list Clues.
            {
                case 0:
                    Console.WriteLine(backpack.ListItems());
                    break;
                case 1:
                    Console.WriteLine(backpack.ListWeapons());
                    break;
                case 2:
                    Console.WriteLine(backpack.ListClues());
                    break;
            }
        }
    }
}