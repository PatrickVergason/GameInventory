using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class Clue : Item
    {
        public bool Accuracy;
        public string PersonIncriminated = "";

        public Clue(string name, string description, double weight, double value, string? incriminates, bool? isAccurate) : base(name, description, weight, value) {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
    }
}
