using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory {
    public class Weapon : Clue
    {
        public int Damage { get; set; } // How much damage does the Weapon do?
        public DamageType damageType { get; set; } // What type of damage does the Weapon do?

        /// <summary>
        /// Makes a Weapon object with values based on the Item class.
        /// </summary>
        /// <param name="name">Name of the weapon</param>
        /// <param name="description">What does the weapon do?</param>
        /// <param name="weight">How much does it weigh?</param>
        /// <param name="value">How much does it cost? or How much does it sell for?</param>
        /// <param name="incriminates">Does this clue push blame on another? If so, who?</param>
        /// <param name="isAccurate">Checks if the clue is accurate or not, to see if the player is right</param>
        public Weapon(string name, string description, double weight, double value, string? incriminates, bool? isAccurate) : base(name, description, weight, value, incriminates, isAccurate)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
            PersonIncriminated = incriminates;
            Accuracy = isAccurate;
        }
        

        /// <summary>
        /// Takes an existing weapon, adds damage type and Damage dealt into it, then outputs everything as a string.
        /// </summary>
        /// <param name="weapon">Existing weapon, based upon the Item class, adding weapon information</param>
        /// <returns>Returns the weapon object's fields, as a string.</returns>
        public string ToString(Weapon weapon)
        {
            string strWeapon = $"Item Name: {weapon.Name.ToString()}\n" +
                               $"Description: {weapon.Description.ToString()}\n" +
                               $"Weight: {weapon.Weight.ToString()} pounds\n" +
                               $"Value: ${weapon.Value.ToString()}\n" +
                               $"Damage Type: {weapon.damageType.ToString()}\n" +
                               $"Damage Dealt: {weapon.Damage.ToString()} kicks in the stomach\n";
            return strWeapon;
        }
    }
}
