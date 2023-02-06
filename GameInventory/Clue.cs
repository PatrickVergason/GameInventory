using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Clue : Item
    {
        public bool? Accuracy { get; set; } // Is the clue the correct one for the Murder Scene?
        public string? PersonIncriminated { get; set; } // If true, who did the murder?


        /// <summary>
        /// Clue Constructor
        /// When called, and given parameters, creates an
        /// object called Clue, with different value types.
        /// Used from values from base Item class.
        /// </summary>
        /// 
        /// <param name="name">Name of the Item</param>
        /// <param name="description">Description of what the Item does</param>
        /// <param name="weight"> Weight, in pounds, of the Item</param>
        /// <param name="value">Value, in USD, of the Item's worth</param>
        /// <param name="incriminates">Does this clue push blame on another? If so, who?</param>
        /// <param name="isAccurate">Checks if the clue is accurate or not, to see if the player is right</param>
        public Clue(string name, string description, double weight, double value, string? incriminates, bool? isAccurate) : base(name, description, weight, value) {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
            PersonIncriminated = incriminates;
            Accuracy = isAccurate;
        }
    }
}
